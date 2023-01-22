namespace NexusLabs.BoRAT.Server
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCommandShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReqPw = new MetroFramework.Controls.MetroButton();
            this.lblStatusPwRecovery = new MetroFramework.Controls.MetroLabel();
            this.listPasswords = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatusSTCrypter = new MetroFramework.Controls.MetroLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMTest = new MetroFramework.Controls.MetroButton();
            this.rbExclamation = new MetroFramework.Controls.MetroRadioButton();
            this.rbInformation = new MetroFramework.Controls.MetroRadioButton();
            this.rbError = new MetroFramework.Controls.MetroRadioButton();
            this.txtMCaption = new MetroFramework.Controls.MetroTextBox();
            this.txtMTitle = new MetroFramework.Controls.MetroTextBox();
            this.chMsgbox = new MetroFramework.Controls.MetroCheckBox();
            this.rbManaged = new MetroFramework.Controls.MetroRadioButton();
            this.rbNative = new MetroFramework.Controls.MetroRadioButton();
            this.label16 = new MetroFramework.Controls.MetroLabel();
            this.txtEKey = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new MetroFramework.Controls.MetroLabel();
            this.btnSTIcon = new MetroFramework.Controls.MetroButton();
            this.chRName = new MetroFramework.Controls.MetroCheckBox();
            this.chHide = new MetroFramework.Controls.MetroCheckBox();
            this.pSTIcon = new System.Windows.Forms.PictureBox();
            this.chStartup = new MetroFramework.Controls.MetroCheckBox();
            this.comboEPath = new MetroFramework.Controls.MetroComboBox();
            this.label12 = new MetroFramework.Controls.MetroLabel();
            this.label13 = new MetroFramework.Controls.MetroLabel();
            this.PanelClients = new MetroFramework.Controls.MetroPanel();
            this.tpConnections_lblStatus = new MetroFramework.Controls.MetroLabel();
            this.tpConnections_listClients = new System.Windows.Forms.ListView();
            this.listClients_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClients_PublicIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClients_Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClients_OS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClients_AntiVirus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClients_DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpConnections_lbPort = new MetroFramework.Controls.MetroLabel();
            this.tpConnections_btnListen = new MetroFramework.Controls.MetroButton();
            this.tpConnections_nPort = new System.Windows.Forms.NumericUpDown();
            this.btnEncrypt = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.PanelRdp = new MetroFramework.Controls.MetroPanel();
            this.tpRV_btnStart = new MetroFramework.Controls.MetroButton();
            this.tpRV_btnStop = new MetroFramework.Controls.MetroButton();
            this.tpRV_cmbChangeView = new MetroFramework.Controls.MetroComboBox();
            this.tpRV_pbView = new System.Windows.Forms.PictureBox();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.tpShell_rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpShell_lbCommand = new MetroFramework.Controls.MetroLabel();
            this.tpShell_tbCommand = new MetroFramework.Controls.MetroTextBox();
            this.PanelCommand = new MetroFramework.Controls.MetroPanel();
            this.tpFM_listFileManager = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpFM_lbActivityLog = new MetroFramework.Controls.MetroLabel();
            this.tpFM_rtbLogs = new System.Windows.Forms.RichTextBox();
            this.PanelFileManager = new MetroFramework.Controls.MetroPanel();
            this.tcMain = new MetroFramework.Controls.MetroTabControl();
            this.tpConnections = new MetroFramework.Controls.MetroTabPage();
            this.tpRdp = new MetroFramework.Controls.MetroTabPage();
            this.tpRemoteShell = new MetroFramework.Controls.MetroTabPage();
            this.tpFileManager = new MetroFramework.Controls.MetroTabPage();
            this.tpAbout = new MetroFramework.Controls.MetroTabPage();
            this.tpAbout_lbAuthor = new MetroFramework.Controls.MetroLabel();
            this.tpAbout_lbTitle = new MetroFramework.Controls.MetroLabel();
            this.tpAbout_lbExperiments = new MetroFramework.Controls.MetroLabel();
            this.tpAbout_toggleExperiments = new MetroFramework.Controls.MetroToggle();
            this.tpExperimental = new MetroFramework.Controls.MetroTabPage();
            this.tpExperimental_gpRunOnlineEXE = new System.Windows.Forms.GroupBox();
            this.tpExperimental_tbEXEURL = new MetroFramework.Controls.MetroTextBox();
            this.tpExperimental_btnRunOnlineEXE = new MetroFramework.Controls.MetroButton();
            this.tpExperimental_gpShowImage = new System.Windows.Forms.GroupBox();
            this.tpExperimental_tbImageURL = new MetroFramework.Controls.MetroTextBox();
            this.tpExperimental_btnShowImage = new MetroFramework.Controls.MetroButton();
            this.tpExperimental_gpShowMessageBox = new System.Windows.Forms.GroupBox();
            this.tpExperimental_tbMsgBoxTitle = new MetroFramework.Controls.MetroTextBox();
            this.tpExperimental_cbMsgBoxIcons = new MetroFramework.Controls.MetroComboBox();
            this.tpExperimental_btnShowMsgBoxes = new MetroFramework.Controls.MetroButton();
            this.tpExperimental_tbMsgBoxMsg = new MetroFramework.Controls.MetroTextBox();
            this.tpExperimental_lbLog = new MetroFramework.Controls.MetroLabel();
            this.tpExperimental_btnAddToStartup = new MetroFramework.Controls.MetroButton();
            this.tpExperimental_rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpExperimental_btnSelfDestruct = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.MenuClients.SuspendLayout();
            this.MenuFileManager.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSTIcon)).BeginInit();
            this.PanelClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpConnections_nPort)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.PanelRdp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpRV_pbView)).BeginInit();
            this.PanelCommand.SuspendLayout();
            this.PanelFileManager.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpConnections.SuspendLayout();
            this.tpRdp.SuspendLayout();
            this.tpRemoteShell.SuspendLayout();
            this.tpFileManager.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.tpExperimental.SuspendLayout();
            this.tpExperimental_gpRunOnlineEXE.SuspendLayout();
            this.tpExperimental_gpShowImage.SuspendLayout();
            this.tpExperimental_gpShowMessageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuClients
            // 
            this.MenuClients.BackColor = System.Drawing.SystemColors.Control;
            this.MenuClients.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.runCommandShellToolStripMenuItem});
            this.MenuClients.Name = "MenuClients";
            this.MenuClients.Size = new System.Drawing.Size(185, 48);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // runCommandShellToolStripMenuItem
            // 
            this.runCommandShellToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.runCommandShellToolStripMenuItem.Name = "runCommandShellToolStripMenuItem";
            this.runCommandShellToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.runCommandShellToolStripMenuItem.Text = "Run Remote Shell";
            this.runCommandShellToolStripMenuItem.Click += new System.EventHandler(this.runCommandShellToolStripMenuItem_Click);
            // 
            // MenuFileManager
            // 
            this.MenuFileManager.BackColor = System.Drawing.SystemColors.Control;
            this.MenuFileManager.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFileManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivesListToolStripMenuItem,
            this.enterToolStripMenuItem,
            this.backToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.MenuFileManager.Name = "MenuFileManager";
            this.MenuFileManager.Size = new System.Drawing.Size(140, 114);
            // 
            // drivesListToolStripMenuItem
            // 
            this.drivesListToolStripMenuItem.Name = "drivesListToolStripMenuItem";
            this.drivesListToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.drivesListToolStripMenuItem.Text = "Drives List";
            this.drivesListToolStripMenuItem.Click += new System.EventHandler(this.drivesListToolStripMenuItem_Click);
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.enterToolStripMenuItem.Text = "Enter";
            this.enterToolStripMenuItem.Click += new System.EventHandler(this.enterToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // btnReqPw
            // 
            this.btnReqPw.Location = new System.Drawing.Point(0, 0);
            this.btnReqPw.Name = "btnReqPw";
            this.btnReqPw.Size = new System.Drawing.Size(75, 23);
            this.btnReqPw.TabIndex = 0;
            this.btnReqPw.UseSelectable = true;
            // 
            // lblStatusPwRecovery
            // 
            this.lblStatusPwRecovery.Location = new System.Drawing.Point(0, 0);
            this.lblStatusPwRecovery.Name = "lblStatusPwRecovery";
            this.lblStatusPwRecovery.Size = new System.Drawing.Size(100, 23);
            this.lblStatusPwRecovery.TabIndex = 0;
            // 
            // listPasswords
            // 
            this.listPasswords.HideSelection = false;
            this.listPasswords.Location = new System.Drawing.Point(0, 0);
            this.listPasswords.Name = "listPasswords";
            this.listPasswords.Size = new System.Drawing.Size(121, 97);
            this.listPasswords.TabIndex = 0;
            this.listPasswords.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Host";
            this.columnHeader11.Width = 450;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Username";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Password";
            this.columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Browser";
            this.columnHeader14.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatusSTCrypter);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.rbManaged);
            this.groupBox3.Controls.Add(this.rbNative);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtEKey);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnSTIcon);
            this.groupBox3.Controls.Add(this.chRName);
            this.groupBox3.Controls.Add(this.chHide);
            this.groupBox3.Controls.Add(this.pSTIcon);
            this.groupBox3.Controls.Add(this.chStartup);
            this.groupBox3.Controls.Add(this.comboEPath);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 261);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // lblStatusSTCrypter
            // 
            this.lblStatusSTCrypter.AutoSize = true;
            this.lblStatusSTCrypter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusSTCrypter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.lblStatusSTCrypter.Location = new System.Drawing.Point(670, 22);
            this.lblStatusSTCrypter.Name = "lblStatusSTCrypter";
            this.lblStatusSTCrypter.Size = new System.Drawing.Size(105, 19);
            this.lblStatusSTCrypter.TabIndex = 18;
            this.lblStatusSTCrypter.Text = "Crypter Status: -";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnMTest);
            this.groupBox7.Controls.Add(this.rbExclamation);
            this.groupBox7.Controls.Add(this.rbInformation);
            this.groupBox7.Controls.Add(this.rbError);
            this.groupBox7.Controls.Add(this.txtMCaption);
            this.groupBox7.Controls.Add(this.txtMTitle);
            this.groupBox7.Controls.Add(this.chMsgbox);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.groupBox7.Location = new System.Drawing.Point(316, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(348, 182);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Message Box";
            // 
            // btnMTest
            // 
            this.btnMTest.Location = new System.Drawing.Point(0, 0);
            this.btnMTest.Name = "btnMTest";
            this.btnMTest.Size = new System.Drawing.Size(75, 23);
            this.btnMTest.TabIndex = 0;
            this.btnMTest.UseSelectable = true;
            // 
            // rbExclamation
            // 
            this.rbExclamation.AutoSize = true;
            this.rbExclamation.Enabled = false;
            this.rbExclamation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.rbExclamation.Location = new System.Drawing.Point(230, 125);
            this.rbExclamation.Name = "rbExclamation";
            this.rbExclamation.Size = new System.Drawing.Size(88, 15);
            this.rbExclamation.TabIndex = 5;
            this.rbExclamation.TabStop = true;
            this.rbExclamation.Text = "Exclamation";
            this.rbExclamation.UseSelectable = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Enabled = false;
            this.rbInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.rbInformation.Location = new System.Drawing.Point(109, 125);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(86, 15);
            this.rbInformation.TabIndex = 4;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseSelectable = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Enabled = false;
            this.rbError.Location = new System.Drawing.Point(28, 125);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(48, 15);
            this.rbError.TabIndex = 3;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseSelectable = true;
            // 
            // txtMCaption
            // 
            this.txtMCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            this.txtMCaption.CustomButton.Image = null;
            this.txtMCaption.CustomButton.Location = new System.Drawing.Point(254, 2);
            this.txtMCaption.CustomButton.Name = "";
            this.txtMCaption.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.txtMCaption.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMCaption.CustomButton.TabIndex = 1;
            this.txtMCaption.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMCaption.CustomButton.UseSelectable = true;
            this.txtMCaption.CustomButton.Visible = false;
            this.txtMCaption.Enabled = false;
            this.txtMCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.txtMCaption.Lines = new string[] {
        "Microsoft .NET Framework 2.0 was not detected to be installed.This process cannot" +
            " be ran."};
            this.txtMCaption.Location = new System.Drawing.Point(24, 69);
            this.txtMCaption.MaxLength = 32767;
            this.txtMCaption.Multiline = true;
            this.txtMCaption.Name = "txtMCaption";
            this.txtMCaption.PasswordChar = '\0';
            this.txtMCaption.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMCaption.SelectedText = "";
            this.txtMCaption.SelectionLength = 0;
            this.txtMCaption.SelectionStart = 0;
            this.txtMCaption.ShortcutsEnabled = true;
            this.txtMCaption.Size = new System.Drawing.Size(300, 48);
            this.txtMCaption.TabIndex = 2;
            this.txtMCaption.Text = "Microsoft .NET Framework 2.0 was not detected to be installed.This process cannot" +
    " be ran.";
            this.txtMCaption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMCaption.UseSelectable = true;
            this.txtMCaption.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMCaption.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMTitle
            // 
            this.txtMTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            this.txtMTitle.CustomButton.Image = null;
            this.txtMTitle.CustomButton.Location = new System.Drawing.Point(280, 2);
            this.txtMTitle.CustomButton.Name = "";
            this.txtMTitle.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtMTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMTitle.CustomButton.TabIndex = 1;
            this.txtMTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMTitle.CustomButton.UseSelectable = true;
            this.txtMTitle.CustomButton.Visible = false;
            this.txtMTitle.Enabled = false;
            this.txtMTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.txtMTitle.Lines = new string[] {
        "Microsoft"};
            this.txtMTitle.Location = new System.Drawing.Point(24, 43);
            this.txtMTitle.MaxLength = 32767;
            this.txtMTitle.Name = "txtMTitle";
            this.txtMTitle.PasswordChar = '\0';
            this.txtMTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMTitle.SelectedText = "";
            this.txtMTitle.SelectionLength = 0;
            this.txtMTitle.SelectionStart = 0;
            this.txtMTitle.ShortcutsEnabled = true;
            this.txtMTitle.Size = new System.Drawing.Size(300, 22);
            this.txtMTitle.TabIndex = 1;
            this.txtMTitle.Text = "Microsoft";
            this.txtMTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMTitle.UseSelectable = true;
            this.txtMTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chMsgbox
            // 
            this.chMsgbox.Location = new System.Drawing.Point(0, 0);
            this.chMsgbox.Name = "chMsgbox";
            this.chMsgbox.Size = new System.Drawing.Size(104, 24);
            this.chMsgbox.TabIndex = 6;
            this.chMsgbox.UseSelectable = true;
            // 
            // rbManaged
            // 
            this.rbManaged.Location = new System.Drawing.Point(0, 0);
            this.rbManaged.Name = "rbManaged";
            this.rbManaged.Size = new System.Drawing.Size(104, 24);
            this.rbManaged.TabIndex = 23;
            this.rbManaged.UseSelectable = true;
            // 
            // rbNative
            // 
            this.rbNative.Location = new System.Drawing.Point(0, 0);
            this.rbNative.Name = "rbNative";
            this.rbNative.Size = new System.Drawing.Size(104, 24);
            this.rbNative.TabIndex = 24;
            this.rbNative.UseSelectable = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 25;
            // 
            // txtEKey
            // 
            // 
            // 
            // 
            this.txtEKey.CustomButton.Image = null;
            this.txtEKey.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.txtEKey.CustomButton.Name = "";
            this.txtEKey.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtEKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEKey.CustomButton.TabIndex = 1;
            this.txtEKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEKey.CustomButton.UseSelectable = true;
            this.txtEKey.CustomButton.Visible = false;
            this.txtEKey.Lines = new string[0];
            this.txtEKey.Location = new System.Drawing.Point(0, 0);
            this.txtEKey.MaxLength = 32767;
            this.txtEKey.Name = "txtEKey";
            this.txtEKey.PasswordChar = '\0';
            this.txtEKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEKey.SelectedText = "";
            this.txtEKey.SelectionLength = 0;
            this.txtEKey.SelectionStart = 0;
            this.txtEKey.ShortcutsEnabled = true;
            this.txtEKey.Size = new System.Drawing.Size(0, 22);
            this.txtEKey.TabIndex = 26;
            this.txtEKey.UseSelectable = true;
            this.txtEKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 27;
            // 
            // btnSTIcon
            // 
            this.btnSTIcon.Location = new System.Drawing.Point(0, 0);
            this.btnSTIcon.Name = "btnSTIcon";
            this.btnSTIcon.Size = new System.Drawing.Size(75, 23);
            this.btnSTIcon.TabIndex = 28;
            this.btnSTIcon.UseSelectable = true;
            // 
            // chRName
            // 
            this.chRName.Location = new System.Drawing.Point(0, 0);
            this.chRName.Name = "chRName";
            this.chRName.Size = new System.Drawing.Size(104, 24);
            this.chRName.TabIndex = 29;
            this.chRName.UseSelectable = true;
            // 
            // chHide
            // 
            this.chHide.Location = new System.Drawing.Point(0, 0);
            this.chHide.Name = "chHide";
            this.chHide.Size = new System.Drawing.Size(104, 24);
            this.chHide.TabIndex = 30;
            this.chHide.UseSelectable = true;
            // 
            // pSTIcon
            // 
            this.pSTIcon.Location = new System.Drawing.Point(0, 0);
            this.pSTIcon.Name = "pSTIcon";
            this.pSTIcon.Size = new System.Drawing.Size(100, 50);
            this.pSTIcon.TabIndex = 31;
            this.pSTIcon.TabStop = false;
            // 
            // chStartup
            // 
            this.chStartup.AutoSize = true;
            this.chStartup.Location = new System.Drawing.Point(9, 26);
            this.chStartup.Name = "chStartup";
            this.chStartup.Size = new System.Drawing.Size(101, 15);
            this.chStartup.TabIndex = 0;
            this.chStartup.Text = "Add To Startup";
            this.chStartup.UseSelectable = true;
            // 
            // comboEPath
            // 
            this.comboEPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboEPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.comboEPath.FormattingEnabled = true;
            this.comboEPath.Items.AddRange(new object[] {
            "%SYSTEM32%",
            "%APPDATA%",
            "%PROGRAMFILES%",
            "%CurrentPath%"});
            this.comboEPath.Location = new System.Drawing.Point(121, 143);
            this.comboEPath.Name = "comboEPath";
            this.comboEPath.Size = new System.Drawing.Size(177, 23);
            this.comboEPath.TabIndex = 4;
            this.comboEPath.UseSelectable = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Icon";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Execution Path";
            // 
            // PanelClients
            // 
            this.PanelClients.BackColor = System.Drawing.Color.Transparent;
            this.PanelClients.Controls.Add(this.tpConnections_lblStatus);
            this.PanelClients.Controls.Add(this.tpConnections_listClients);
            this.PanelClients.Controls.Add(this.tpConnections_lbPort);
            this.PanelClients.Controls.Add(this.tpConnections_btnListen);
            this.PanelClients.Controls.Add(this.tpConnections_nPort);
            this.PanelClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelClients.ForeColor = System.Drawing.Color.Black;
            this.PanelClients.HorizontalScrollbarBarColor = true;
            this.PanelClients.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelClients.HorizontalScrollbarSize = 8;
            this.PanelClients.Location = new System.Drawing.Point(3, 3);
            this.PanelClients.Name = "PanelClients";
            this.PanelClients.Size = new System.Drawing.Size(920, 421);
            this.PanelClients.TabIndex = 9;
            this.PanelClients.VerticalScrollbarBarColor = true;
            this.PanelClients.VerticalScrollbarHighlightOnWheel = false;
            this.PanelClients.VerticalScrollbarSize = 6;
            // 
            // tpConnections_lblStatus
            // 
            this.tpConnections_lblStatus.AutoSize = true;
            this.tpConnections_lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpConnections_lblStatus.ForeColor = System.Drawing.Color.Black;
            this.tpConnections_lblStatus.Location = new System.Drawing.Point(3, 401);
            this.tpConnections_lblStatus.Name = "tpConnections_lblStatus";
            this.tpConnections_lblStatus.Size = new System.Drawing.Size(192, 19);
            this.tpConnections_lblStatus.TabIndex = 7;
            this.tpConnections_lblStatus.Text = "Status: Idle | Connections: 0";
            // 
            // tpConnections_listClients
            // 
            this.tpConnections_listClients.BackColor = System.Drawing.SystemColors.Control;
            this.tpConnections_listClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listClients_ID,
            this.listClients_PublicIP,
            this.listClients_Username,
            this.listClients_OS,
            this.listClients_AntiVirus,
            this.listClients_DateTime});
            this.tpConnections_listClients.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConnections_listClients.ForeColor = System.Drawing.Color.Black;
            this.tpConnections_listClients.HideSelection = false;
            this.tpConnections_listClients.Location = new System.Drawing.Point(3, 56);
            this.tpConnections_listClients.Name = "tpConnections_listClients";
            this.tpConnections_listClients.Size = new System.Drawing.Size(914, 342);
            this.tpConnections_listClients.TabIndex = 6;
            this.tpConnections_listClients.UseCompatibleStateImageBehavior = false;
            this.tpConnections_listClients.View = System.Windows.Forms.View.Details;
            this.tpConnections_listClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listClients_MouseClick);
            // 
            // listClients_ID
            // 
            this.listClients_ID.Text = "ID";
            this.listClients_ID.Width = 40;
            // 
            // listClients_PublicIP
            // 
            this.listClients_PublicIP.Text = "Public IP";
            this.listClients_PublicIP.Width = 160;
            // 
            // listClients_Username
            // 
            this.listClients_Username.Text = "Username";
            this.listClients_Username.Width = 200;
            // 
            // listClients_OS
            // 
            this.listClients_OS.Text = "OS";
            this.listClients_OS.Width = 140;
            // 
            // listClients_AntiVirus
            // 
            this.listClients_AntiVirus.Text = "Anti Virus";
            this.listClients_AntiVirus.Width = 190;
            // 
            // listClients_DateTime
            // 
            this.listClients_DateTime.Text = "Date/Time";
            this.listClients_DateTime.Width = 170;
            // 
            // tpConnections_lbPort
            // 
            this.tpConnections_lbPort.AutoSize = true;
            this.tpConnections_lbPort.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpConnections_lbPort.ForeColor = System.Drawing.Color.Black;
            this.tpConnections_lbPort.Location = new System.Drawing.Point(5, 5);
            this.tpConnections_lbPort.Name = "tpConnections_lbPort";
            this.tpConnections_lbPort.Size = new System.Drawing.Size(42, 19);
            this.tpConnections_lbPort.TabIndex = 3;
            this.tpConnections_lbPort.Text = "Port:";
            // 
            // tpConnections_btnListen
            // 
            this.tpConnections_btnListen.Location = new System.Drawing.Point(136, 27);
            this.tpConnections_btnListen.Name = "tpConnections_btnListen";
            this.tpConnections_btnListen.Size = new System.Drawing.Size(85, 23);
            this.tpConnections_btnListen.TabIndex = 5;
            this.tpConnections_btnListen.Text = "Listen";
            this.tpConnections_btnListen.UseSelectable = true;
            this.tpConnections_btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // tpConnections_nPort
            // 
            this.tpConnections_nPort.BackColor = System.Drawing.SystemColors.Control;
            this.tpConnections_nPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tpConnections_nPort.ForeColor = System.Drawing.Color.Black;
            this.tpConnections_nPort.Location = new System.Drawing.Point(5, 27);
            this.tpConnections_nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tpConnections_nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tpConnections_nPort.Name = "tpConnections_nPort";
            this.tpConnections_nPort.Size = new System.Drawing.Size(125, 23);
            this.tpConnections_nPort.TabIndex = 4;
            this.tpConnections_nPort.Value = new decimal(new int[] {
            40438,
            0,
            0,
            0});
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(0, 0);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowse);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.txtFilePath);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(998, 324);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(0, 0);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.UseSelectable = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(108)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            this.txtFilePath.CustomButton.Image = null;
            this.txtFilePath.CustomButton.Location = new System.Drawing.Point(417, 2);
            this.txtFilePath.CustomButton.Name = "";
            this.txtFilePath.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilePath.CustomButton.TabIndex = 1;
            this.txtFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilePath.CustomButton.UseSelectable = true;
            this.txtFilePath.CustomButton.Visible = false;
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.txtFilePath.Lines = new string[0];
            this.txtFilePath.Location = new System.Drawing.Point(52, 21);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.SelectionLength = 0;
            this.txtFilePath.SelectionStart = 0;
            this.txtFilePath.ShortcutsEnabled = true;
            this.txtFilePath.Size = new System.Drawing.Size(435, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.UseSelectable = true;
            this.txtFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "File:";
            // 
            // PanelRdp
            // 
            this.PanelRdp.Controls.Add(this.tpRV_btnStart);
            this.PanelRdp.Controls.Add(this.tpRV_btnStop);
            this.PanelRdp.Controls.Add(this.tpRV_cmbChangeView);
            this.PanelRdp.Controls.Add(this.tpRV_pbView);
            this.PanelRdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRdp.HorizontalScrollbarBarColor = true;
            this.PanelRdp.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelRdp.HorizontalScrollbarSize = 8;
            this.PanelRdp.Location = new System.Drawing.Point(3, 3);
            this.PanelRdp.Name = "PanelRdp";
            this.PanelRdp.Size = new System.Drawing.Size(920, 421);
            this.PanelRdp.TabIndex = 12;
            this.PanelRdp.VerticalScrollbarBarColor = true;
            this.PanelRdp.VerticalScrollbarHighlightOnWheel = false;
            this.PanelRdp.VerticalScrollbarSize = 6;
            // 
            // tpRV_btnStart
            // 
            this.tpRV_btnStart.Location = new System.Drawing.Point(3, 3);
            this.tpRV_btnStart.Name = "tpRV_btnStart";
            this.tpRV_btnStart.Size = new System.Drawing.Size(90, 30);
            this.tpRV_btnStart.TabIndex = 10;
            this.tpRV_btnStart.Text = "Start";
            this.tpRV_btnStart.UseSelectable = true;
            this.tpRV_btnStart.Click += new System.EventHandler(this.btnStartRdp_Click);
            // 
            // tpRV_btnStop
            // 
            this.tpRV_btnStop.Location = new System.Drawing.Point(98, 3);
            this.tpRV_btnStop.Name = "tpRV_btnStop";
            this.tpRV_btnStop.Size = new System.Drawing.Size(90, 30);
            this.tpRV_btnStop.TabIndex = 9;
            this.tpRV_btnStop.Text = "Stop";
            this.tpRV_btnStop.UseSelectable = true;
            this.tpRV_btnStop.Click += new System.EventHandler(this.btnRdpStop_Click);
            // 
            // tpRV_cmbChangeView
            // 
            this.tpRV_cmbChangeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpRV_cmbChangeView.ForeColor = System.Drawing.Color.Black;
            this.tpRV_cmbChangeView.FormattingEnabled = true;
            this.tpRV_cmbChangeView.ItemHeight = 23;
            this.tpRV_cmbChangeView.Items.AddRange(new object[] {
            "ZoomScreen",
            "CenterImage",
            "AutoSize",
            "FullScreen"});
            this.tpRV_cmbChangeView.Location = new System.Drawing.Point(3, 38);
            this.tpRV_cmbChangeView.Name = "tpRV_cmbChangeView";
            this.tpRV_cmbChangeView.Size = new System.Drawing.Size(185, 29);
            this.tpRV_cmbChangeView.TabIndex = 6;
            this.tpRV_cmbChangeView.UseSelectable = true;
            this.tpRV_cmbChangeView.SelectedIndexChanged += new System.EventHandler(this.comboRdp_SelectedIndexChanged);
            // 
            // tpRV_pbView
            // 
            this.tpRV_pbView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpRV_pbView.Location = new System.Drawing.Point(194, 3);
            this.tpRV_pbView.Name = "tpRV_pbView";
            this.tpRV_pbView.Size = new System.Drawing.Size(723, 418);
            this.tpRV_pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tpRV_pbView.TabIndex = 6;
            this.tpRV_pbView.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(177, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "No Active Session";
            // 
            // tpShell_rtbLog
            // 
            this.tpShell_rtbLog.BackColor = System.Drawing.SystemColors.Control;
            this.tpShell_rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpShell_rtbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.tpShell_rtbLog.Location = new System.Drawing.Point(5, 3);
            this.tpShell_rtbLog.Name = "tpShell_rtbLog";
            this.tpShell_rtbLog.Size = new System.Drawing.Size(912, 361);
            this.tpShell_rtbLog.TabIndex = 4;
            this.tpShell_rtbLog.Text = "";
            // 
            // tpShell_lbCommand
            // 
            this.tpShell_lbCommand.AutoSize = true;
            this.tpShell_lbCommand.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpShell_lbCommand.ForeColor = System.Drawing.Color.Black;
            this.tpShell_lbCommand.Location = new System.Drawing.Point(3, 367);
            this.tpShell_lbCommand.Name = "tpShell_lbCommand";
            this.tpShell_lbCommand.Size = new System.Drawing.Size(82, 19);
            this.tpShell_lbCommand.TabIndex = 5;
            this.tpShell_lbCommand.Text = "Command:";
            // 
            // tpShell_tbCommand
            // 
            this.tpShell_tbCommand.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.tpShell_tbCommand.CustomButton.Image = null;
            this.tpShell_tbCommand.CustomButton.Location = new System.Drawing.Point(669, 2);
            this.tpShell_tbCommand.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpShell_tbCommand.CustomButton.Name = "";
            this.tpShell_tbCommand.CustomButton.Size = new System.Drawing.Size(13, 16);
            this.tpShell_tbCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpShell_tbCommand.CustomButton.TabIndex = 1;
            this.tpShell_tbCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpShell_tbCommand.CustomButton.UseSelectable = true;
            this.tpShell_tbCommand.CustomButton.Visible = false;
            this.tpShell_tbCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.tpShell_tbCommand.Lines = new string[0];
            this.tpShell_tbCommand.Location = new System.Drawing.Point(5, 389);
            this.tpShell_tbCommand.MaxLength = 32767;
            this.tpShell_tbCommand.Name = "tpShell_tbCommand";
            this.tpShell_tbCommand.PasswordChar = '\0';
            this.tpShell_tbCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpShell_tbCommand.SelectedText = "";
            this.tpShell_tbCommand.SelectionLength = 0;
            this.tpShell_tbCommand.SelectionStart = 0;
            this.tpShell_tbCommand.ShortcutsEnabled = true;
            this.tpShell_tbCommand.Size = new System.Drawing.Size(912, 22);
            this.tpShell_tbCommand.TabIndex = 6;
            this.tpShell_tbCommand.UseSelectable = true;
            this.tpShell_tbCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpShell_tbCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tpShell_tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // PanelCommand
            // 
            this.PanelCommand.Controls.Add(this.tpShell_tbCommand);
            this.PanelCommand.Controls.Add(this.tpShell_lbCommand);
            this.PanelCommand.Controls.Add(this.tpShell_rtbLog);
            this.PanelCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.PanelCommand.HorizontalScrollbarBarColor = true;
            this.PanelCommand.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelCommand.HorizontalScrollbarSize = 8;
            this.PanelCommand.Location = new System.Drawing.Point(3, 3);
            this.PanelCommand.Name = "PanelCommand";
            this.PanelCommand.Size = new System.Drawing.Size(920, 421);
            this.PanelCommand.TabIndex = 10;
            this.PanelCommand.VerticalScrollbarBarColor = true;
            this.PanelCommand.VerticalScrollbarHighlightOnWheel = false;
            this.PanelCommand.VerticalScrollbarSize = 6;
            // 
            // tpFM_listFileManager
            // 
            this.tpFM_listFileManager.BackColor = System.Drawing.SystemColors.Control;
            this.tpFM_listFileManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.tpFM_listFileManager.ContextMenuStrip = this.MenuFileManager;
            this.tpFM_listFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.tpFM_listFileManager.GridLines = true;
            this.tpFM_listFileManager.HideSelection = false;
            this.tpFM_listFileManager.Location = new System.Drawing.Point(3, 3);
            this.tpFM_listFileManager.Name = "tpFM_listFileManager";
            this.tpFM_listFileManager.Size = new System.Drawing.Size(914, 308);
            this.tpFM_listFileManager.TabIndex = 1;
            this.tpFM_listFileManager.UseCompatibleStateImageBehavior = false;
            this.tpFM_listFileManager.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "File Name";
            this.columnHeader6.Width = 220;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "File Size";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Creation Time";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Address";
            this.columnHeader9.Width = 495;
            // 
            // tpFM_lbActivityLog
            // 
            this.tpFM_lbActivityLog.AutoSize = true;
            this.tpFM_lbActivityLog.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpFM_lbActivityLog.ForeColor = System.Drawing.Color.Black;
            this.tpFM_lbActivityLog.Location = new System.Drawing.Point(0, 314);
            this.tpFM_lbActivityLog.Name = "tpFM_lbActivityLog";
            this.tpFM_lbActivityLog.Size = new System.Drawing.Size(133, 19);
            this.tpFM_lbActivityLog.TabIndex = 5;
            this.tpFM_lbActivityLog.Text = "Activity/Error Log:";
            // 
            // tpFM_rtbLogs
            // 
            this.tpFM_rtbLogs.BackColor = System.Drawing.SystemColors.Control;
            this.tpFM_rtbLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpFM_rtbLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.tpFM_rtbLogs.Location = new System.Drawing.Point(3, 336);
            this.tpFM_rtbLogs.Name = "tpFM_rtbLogs";
            this.tpFM_rtbLogs.Size = new System.Drawing.Size(914, 85);
            this.tpFM_rtbLogs.TabIndex = 6;
            this.tpFM_rtbLogs.Text = "";
            this.tpFM_rtbLogs.TextChanged += new System.EventHandler(this.LogsFileManager_TextChanged_1);
            // 
            // PanelFileManager
            // 
            this.PanelFileManager.Controls.Add(this.tpFM_rtbLogs);
            this.PanelFileManager.Controls.Add(this.tpFM_lbActivityLog);
            this.PanelFileManager.Controls.Add(this.tpFM_listFileManager);
            this.PanelFileManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFileManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(96)))));
            this.PanelFileManager.HorizontalScrollbarBarColor = true;
            this.PanelFileManager.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelFileManager.HorizontalScrollbarSize = 8;
            this.PanelFileManager.Location = new System.Drawing.Point(3, 3);
            this.PanelFileManager.Name = "PanelFileManager";
            this.PanelFileManager.Size = new System.Drawing.Size(920, 421);
            this.PanelFileManager.TabIndex = 11;
            this.PanelFileManager.VerticalScrollbarBarColor = true;
            this.PanelFileManager.VerticalScrollbarHighlightOnWheel = false;
            this.PanelFileManager.VerticalScrollbarSize = 6;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpConnections);
            this.tcMain.Controls.Add(this.tpRdp);
            this.tcMain.Controls.Add(this.tpRemoteShell);
            this.tcMain.Controls.Add(this.tpFileManager);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Controls.Add(this.tpExperimental);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(20, 60);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 4;
            this.tcMain.Size = new System.Drawing.Size(934, 469);
            this.tcMain.TabIndex = 7;
            this.tcMain.UseSelectable = true;
            // 
            // tpConnections
            // 
            this.tpConnections.BackColor = System.Drawing.Color.Transparent;
            this.tpConnections.Controls.Add(this.PanelClients);
            this.tpConnections.HorizontalScrollbarBarColor = true;
            this.tpConnections.HorizontalScrollbarHighlightOnWheel = false;
            this.tpConnections.HorizontalScrollbarSize = 8;
            this.tpConnections.Location = new System.Drawing.Point(4, 38);
            this.tpConnections.Name = "tpConnections";
            this.tpConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tpConnections.Size = new System.Drawing.Size(926, 427);
            this.tpConnections.TabIndex = 4;
            this.tpConnections.Text = "Connections";
            this.tpConnections.VerticalScrollbarBarColor = true;
            this.tpConnections.VerticalScrollbarHighlightOnWheel = false;
            this.tpConnections.VerticalScrollbarSize = 6;
            // 
            // tpRdp
            // 
            this.tpRdp.BackColor = System.Drawing.SystemColors.Control;
            this.tpRdp.Controls.Add(this.PanelRdp);
            this.tpRdp.HorizontalScrollbarBarColor = true;
            this.tpRdp.HorizontalScrollbarHighlightOnWheel = false;
            this.tpRdp.HorizontalScrollbarSize = 8;
            this.tpRdp.Location = new System.Drawing.Point(4, 38);
            this.tpRdp.Name = "tpRdp";
            this.tpRdp.Padding = new System.Windows.Forms.Padding(3);
            this.tpRdp.Size = new System.Drawing.Size(926, 427);
            this.tpRdp.TabIndex = 0;
            this.tpRdp.Text = "Remote View";
            this.tpRdp.VerticalScrollbarBarColor = true;
            this.tpRdp.VerticalScrollbarHighlightOnWheel = false;
            this.tpRdp.VerticalScrollbarSize = 6;
            // 
            // tpRemoteShell
            // 
            this.tpRemoteShell.BackColor = System.Drawing.SystemColors.Control;
            this.tpRemoteShell.Controls.Add(this.PanelCommand);
            this.tpRemoteShell.HorizontalScrollbarBarColor = true;
            this.tpRemoteShell.HorizontalScrollbarHighlightOnWheel = false;
            this.tpRemoteShell.HorizontalScrollbarSize = 8;
            this.tpRemoteShell.Location = new System.Drawing.Point(4, 38);
            this.tpRemoteShell.Name = "tpRemoteShell";
            this.tpRemoteShell.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemoteShell.Size = new System.Drawing.Size(926, 427);
            this.tpRemoteShell.TabIndex = 2;
            this.tpRemoteShell.Text = "Remote Shell";
            this.tpRemoteShell.VerticalScrollbarBarColor = true;
            this.tpRemoteShell.VerticalScrollbarHighlightOnWheel = false;
            this.tpRemoteShell.VerticalScrollbarSize = 6;
            // 
            // tpFileManager
            // 
            this.tpFileManager.BackColor = System.Drawing.SystemColors.Control;
            this.tpFileManager.Controls.Add(this.PanelFileManager);
            this.tpFileManager.HorizontalScrollbarBarColor = true;
            this.tpFileManager.HorizontalScrollbarHighlightOnWheel = false;
            this.tpFileManager.HorizontalScrollbarSize = 8;
            this.tpFileManager.Location = new System.Drawing.Point(4, 38);
            this.tpFileManager.Name = "tpFileManager";
            this.tpFileManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileManager.Size = new System.Drawing.Size(926, 427);
            this.tpFileManager.TabIndex = 1;
            this.tpFileManager.Text = "File Manager";
            this.tpFileManager.VerticalScrollbarBarColor = true;
            this.tpFileManager.VerticalScrollbarHighlightOnWheel = false;
            this.tpFileManager.VerticalScrollbarSize = 6;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.tpAbout_lbAuthor);
            this.tpAbout.Controls.Add(this.tpAbout_lbTitle);
            this.tpAbout.Controls.Add(this.tpAbout_lbExperiments);
            this.tpAbout.Controls.Add(this.tpAbout_toggleExperiments);
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 8;
            this.tpAbout.Location = new System.Drawing.Point(4, 38);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(926, 427);
            this.tpAbout.TabIndex = 6;
            this.tpAbout.Text = "About";
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 6;
            // 
            // tpAbout_lbAuthor
            // 
            this.tpAbout_lbAuthor.AutoSize = true;
            this.tpAbout_lbAuthor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tpAbout_lbAuthor.Location = new System.Drawing.Point(3, 25);
            this.tpAbout_lbAuthor.Name = "tpAbout_lbAuthor";
            this.tpAbout_lbAuthor.Size = new System.Drawing.Size(93, 19);
            this.tpAbout_lbAuthor.TabIndex = 5;
            this.tpAbout_lbAuthor.Text = "By NexusLabs";
            // 
            // tpAbout_lbTitle
            // 
            this.tpAbout_lbTitle.AutoSize = true;
            this.tpAbout_lbTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.tpAbout_lbTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpAbout_lbTitle.Location = new System.Drawing.Point(0, 0);
            this.tpAbout_lbTitle.Name = "tpAbout_lbTitle";
            this.tpAbout_lbTitle.Size = new System.Drawing.Size(70, 25);
            this.tpAbout_lbTitle.TabIndex = 4;
            this.tpAbout_lbTitle.Text = "BoRAT";
            // 
            // tpAbout_lbExperiments
            // 
            this.tpAbout_lbExperiments.AutoSize = true;
            this.tpAbout_lbExperiments.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tpAbout_lbExperiments.Location = new System.Drawing.Point(6, 402);
            this.tpAbout_lbExperiments.Name = "tpAbout_lbExperiments";
            this.tpAbout_lbExperiments.Size = new System.Drawing.Size(86, 19);
            this.tpAbout_lbExperiments.TabIndex = 3;
            this.tpAbout_lbExperiments.Text = "Experiments:";
            // 
            // tpAbout_toggleExperiments
            // 
            this.tpAbout_toggleExperiments.AutoSize = true;
            this.tpAbout_toggleExperiments.Location = new System.Drawing.Point(89, 403);
            this.tpAbout_toggleExperiments.Name = "tpAbout_toggleExperiments";
            this.tpAbout_toggleExperiments.Size = new System.Drawing.Size(80, 18);
            this.tpAbout_toggleExperiments.TabIndex = 2;
            this.tpAbout_toggleExperiments.Text = "Off";
            this.tpAbout_toggleExperiments.UseSelectable = true;
            this.tpAbout_toggleExperiments.CheckedChanged += new System.EventHandler(this.toggleDevMode_CheckedChanged);
            // 
            // tpExperimental
            // 
            this.tpExperimental.Controls.Add(this.tpExperimental_gpRunOnlineEXE);
            this.tpExperimental.Controls.Add(this.tpExperimental_gpShowImage);
            this.tpExperimental.Controls.Add(this.tpExperimental_gpShowMessageBox);
            this.tpExperimental.Controls.Add(this.tpExperimental_lbLog);
            this.tpExperimental.Controls.Add(this.tpExperimental_btnAddToStartup);
            this.tpExperimental.Controls.Add(this.tpExperimental_rtbLog);
            this.tpExperimental.Controls.Add(this.tpExperimental_btnSelfDestruct);
            this.tpExperimental.HorizontalScrollbarBarColor = true;
            this.tpExperimental.HorizontalScrollbarHighlightOnWheel = false;
            this.tpExperimental.HorizontalScrollbarSize = 8;
            this.tpExperimental.Location = new System.Drawing.Point(4, 38);
            this.tpExperimental.Name = "tpExperimental";
            this.tpExperimental.Size = new System.Drawing.Size(926, 427);
            this.tpExperimental.TabIndex = 5;
            this.tpExperimental.Text = "Experiments";
            this.tpExperimental.VerticalScrollbarBarColor = true;
            this.tpExperimental.VerticalScrollbarHighlightOnWheel = false;
            this.tpExperimental.VerticalScrollbarSize = 6;
            this.tpExperimental.Click += new System.EventHandler(this.tpExperimental_Click);
            // 
            // tpExperimental_gpRunOnlineEXE
            // 
            this.tpExperimental_gpRunOnlineEXE.Controls.Add(this.tpExperimental_tbEXEURL);
            this.tpExperimental_gpRunOnlineEXE.Controls.Add(this.tpExperimental_btnRunOnlineEXE);
            this.tpExperimental_gpRunOnlineEXE.Location = new System.Drawing.Point(401, 33);
            this.tpExperimental_gpRunOnlineEXE.Name = "tpExperimental_gpRunOnlineEXE";
            this.tpExperimental_gpRunOnlineEXE.Size = new System.Drawing.Size(200, 81);
            this.tpExperimental_gpRunOnlineEXE.TabIndex = 6;
            this.tpExperimental_gpRunOnlineEXE.TabStop = false;
            this.tpExperimental_gpRunOnlineEXE.Text = "Run Online EXE";
            // 
            // tpExperimental_tbEXEURL
            // 
            // 
            // 
            // 
            this.tpExperimental_tbEXEURL.CustomButton.Image = null;
            this.tpExperimental_tbEXEURL.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.tpExperimental_tbEXEURL.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpExperimental_tbEXEURL.CustomButton.Name = "";
            this.tpExperimental_tbEXEURL.CustomButton.Size = new System.Drawing.Size(16, 20);
            this.tpExperimental_tbEXEURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpExperimental_tbEXEURL.CustomButton.TabIndex = 1;
            this.tpExperimental_tbEXEURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpExperimental_tbEXEURL.CustomButton.UseSelectable = true;
            this.tpExperimental_tbEXEURL.CustomButton.Visible = false;
            this.tpExperimental_tbEXEURL.Lines = new string[] {
        "URL"};
            this.tpExperimental_tbEXEURL.Location = new System.Drawing.Point(6, 21);
            this.tpExperimental_tbEXEURL.MaxLength = 32767;
            this.tpExperimental_tbEXEURL.Name = "tpExperimental_tbEXEURL";
            this.tpExperimental_tbEXEURL.PasswordChar = '\0';
            this.tpExperimental_tbEXEURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpExperimental_tbEXEURL.SelectedText = "";
            this.tpExperimental_tbEXEURL.SelectionLength = 0;
            this.tpExperimental_tbEXEURL.SelectionStart = 0;
            this.tpExperimental_tbEXEURL.ShortcutsEnabled = true;
            this.tpExperimental_tbEXEURL.Size = new System.Drawing.Size(188, 23);
            this.tpExperimental_tbEXEURL.TabIndex = 1;
            this.tpExperimental_tbEXEURL.Text = "URL";
            this.tpExperimental_tbEXEURL.UseSelectable = true;
            this.tpExperimental_tbEXEURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpExperimental_tbEXEURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpExperimental_btnRunOnlineEXE
            // 
            this.tpExperimental_btnRunOnlineEXE.Location = new System.Drawing.Point(6, 50);
            this.tpExperimental_btnRunOnlineEXE.Name = "tpExperimental_btnRunOnlineEXE";
            this.tpExperimental_btnRunOnlineEXE.Size = new System.Drawing.Size(188, 23);
            this.tpExperimental_btnRunOnlineEXE.TabIndex = 0;
            this.tpExperimental_btnRunOnlineEXE.Text = "Run Online EXE";
            this.tpExperimental_btnRunOnlineEXE.UseSelectable = true;
            this.tpExperimental_btnRunOnlineEXE.Click += new System.EventHandler(this.tpExperimental_btnRunOnlineEXE_Click);
            // 
            // tpExperimental_gpShowImage
            // 
            this.tpExperimental_gpShowImage.Controls.Add(this.tpExperimental_tbImageURL);
            this.tpExperimental_gpShowImage.Controls.Add(this.tpExperimental_btnShowImage);
            this.tpExperimental_gpShowImage.Location = new System.Drawing.Point(195, 33);
            this.tpExperimental_gpShowImage.Name = "tpExperimental_gpShowImage";
            this.tpExperimental_gpShowImage.Size = new System.Drawing.Size(200, 81);
            this.tpExperimental_gpShowImage.TabIndex = 5;
            this.tpExperimental_gpShowImage.TabStop = false;
            this.tpExperimental_gpShowImage.Text = "Show Image";
            // 
            // tpExperimental_tbImageURL
            // 
            // 
            // 
            // 
            this.tpExperimental_tbImageURL.CustomButton.Image = null;
            this.tpExperimental_tbImageURL.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.tpExperimental_tbImageURL.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpExperimental_tbImageURL.CustomButton.Name = "";
            this.tpExperimental_tbImageURL.CustomButton.Size = new System.Drawing.Size(16, 20);
            this.tpExperimental_tbImageURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpExperimental_tbImageURL.CustomButton.TabIndex = 1;
            this.tpExperimental_tbImageURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpExperimental_tbImageURL.CustomButton.UseSelectable = true;
            this.tpExperimental_tbImageURL.CustomButton.Visible = false;
            this.tpExperimental_tbImageURL.Lines = new string[] {
        "URL"};
            this.tpExperimental_tbImageURL.Location = new System.Drawing.Point(6, 21);
            this.tpExperimental_tbImageURL.MaxLength = 32767;
            this.tpExperimental_tbImageURL.Name = "tpExperimental_tbImageURL";
            this.tpExperimental_tbImageURL.PasswordChar = '\0';
            this.tpExperimental_tbImageURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpExperimental_tbImageURL.SelectedText = "";
            this.tpExperimental_tbImageURL.SelectionLength = 0;
            this.tpExperimental_tbImageURL.SelectionStart = 0;
            this.tpExperimental_tbImageURL.ShortcutsEnabled = true;
            this.tpExperimental_tbImageURL.Size = new System.Drawing.Size(188, 23);
            this.tpExperimental_tbImageURL.TabIndex = 1;
            this.tpExperimental_tbImageURL.Text = "URL";
            this.tpExperimental_tbImageURL.UseSelectable = true;
            this.tpExperimental_tbImageURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpExperimental_tbImageURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpExperimental_btnShowImage
            // 
            this.tpExperimental_btnShowImage.Location = new System.Drawing.Point(6, 50);
            this.tpExperimental_btnShowImage.Name = "tpExperimental_btnShowImage";
            this.tpExperimental_btnShowImage.Size = new System.Drawing.Size(188, 23);
            this.tpExperimental_btnShowImage.TabIndex = 0;
            this.tpExperimental_btnShowImage.Text = "Show Image";
            this.tpExperimental_btnShowImage.UseSelectable = true;
            this.tpExperimental_btnShowImage.Click += new System.EventHandler(this.tpExperimental_btnShowImage_Click);
            // 
            // tpExperimental_gpShowMessageBox
            // 
            this.tpExperimental_gpShowMessageBox.Controls.Add(this.tpExperimental_tbMsgBoxTitle);
            this.tpExperimental_gpShowMessageBox.Controls.Add(this.tpExperimental_cbMsgBoxIcons);
            this.tpExperimental_gpShowMessageBox.Controls.Add(this.tpExperimental_btnShowMsgBoxes);
            this.tpExperimental_gpShowMessageBox.Controls.Add(this.tpExperimental_tbMsgBoxMsg);
            this.tpExperimental_gpShowMessageBox.Location = new System.Drawing.Point(0, 33);
            this.tpExperimental_gpShowMessageBox.Name = "tpExperimental_gpShowMessageBox";
            this.tpExperimental_gpShowMessageBox.Size = new System.Drawing.Size(189, 117);
            this.tpExperimental_gpShowMessageBox.TabIndex = 4;
            this.tpExperimental_gpShowMessageBox.TabStop = false;
            this.tpExperimental_gpShowMessageBox.Text = "Show Message Box";
            // 
            // tpExperimental_tbMsgBoxTitle
            // 
            // 
            // 
            // 
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Image = null;
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Name = "";
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Size = new System.Drawing.Size(16, 20);
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpExperimental_tbMsgBoxTitle.CustomButton.TabIndex = 1;
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpExperimental_tbMsgBoxTitle.CustomButton.UseSelectable = true;
            this.tpExperimental_tbMsgBoxTitle.CustomButton.Visible = false;
            this.tpExperimental_tbMsgBoxTitle.Lines = new string[] {
        "Title"};
            this.tpExperimental_tbMsgBoxTitle.Location = new System.Drawing.Point(6, 21);
            this.tpExperimental_tbMsgBoxTitle.MaxLength = 32767;
            this.tpExperimental_tbMsgBoxTitle.Name = "tpExperimental_tbMsgBoxTitle";
            this.tpExperimental_tbMsgBoxTitle.PasswordChar = '\0';
            this.tpExperimental_tbMsgBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpExperimental_tbMsgBoxTitle.SelectedText = "";
            this.tpExperimental_tbMsgBoxTitle.SelectionLength = 0;
            this.tpExperimental_tbMsgBoxTitle.SelectionStart = 0;
            this.tpExperimental_tbMsgBoxTitle.ShortcutsEnabled = true;
            this.tpExperimental_tbMsgBoxTitle.Size = new System.Drawing.Size(174, 23);
            this.tpExperimental_tbMsgBoxTitle.TabIndex = 3;
            this.tpExperimental_tbMsgBoxTitle.Text = "Title";
            this.tpExperimental_tbMsgBoxTitle.UseSelectable = true;
            this.tpExperimental_tbMsgBoxTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpExperimental_tbMsgBoxTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpExperimental_cbMsgBoxIcons
            // 
            this.tpExperimental_cbMsgBoxIcons.FormattingEnabled = true;
            this.tpExperimental_cbMsgBoxIcons.ItemHeight = 23;
            this.tpExperimental_cbMsgBoxIcons.Items.AddRange(new object[] {
            "None",
            "Information",
            "Error",
            "Question",
            "Exclamation",
            "Warning"});
            this.tpExperimental_cbMsgBoxIcons.Location = new System.Drawing.Point(6, 80);
            this.tpExperimental_cbMsgBoxIcons.Name = "tpExperimental_cbMsgBoxIcons";
            this.tpExperimental_cbMsgBoxIcons.Size = new System.Drawing.Size(121, 29);
            this.tpExperimental_cbMsgBoxIcons.TabIndex = 2;
            this.tpExperimental_cbMsgBoxIcons.UseSelectable = true;
            // 
            // tpExperimental_btnShowMsgBoxes
            // 
            this.tpExperimental_btnShowMsgBoxes.Location = new System.Drawing.Point(133, 80);
            this.tpExperimental_btnShowMsgBoxes.Name = "tpExperimental_btnShowMsgBoxes";
            this.tpExperimental_btnShowMsgBoxes.Size = new System.Drawing.Size(47, 29);
            this.tpExperimental_btnShowMsgBoxes.TabIndex = 1;
            this.tpExperimental_btnShowMsgBoxes.Text = "Show";
            this.tpExperimental_btnShowMsgBoxes.UseSelectable = true;
            this.tpExperimental_btnShowMsgBoxes.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tpExperimental_tbMsgBoxMsg
            // 
            // 
            // 
            // 
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Image = null;
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Name = "";
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Size = new System.Drawing.Size(16, 20);
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpExperimental_tbMsgBoxMsg.CustomButton.TabIndex = 1;
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tpExperimental_tbMsgBoxMsg.CustomButton.UseSelectable = true;
            this.tpExperimental_tbMsgBoxMsg.CustomButton.Visible = false;
            this.tpExperimental_tbMsgBoxMsg.Lines = new string[] {
        "Message"};
            this.tpExperimental_tbMsgBoxMsg.Location = new System.Drawing.Point(6, 50);
            this.tpExperimental_tbMsgBoxMsg.MaxLength = 32767;
            this.tpExperimental_tbMsgBoxMsg.Name = "tpExperimental_tbMsgBoxMsg";
            this.tpExperimental_tbMsgBoxMsg.PasswordChar = '\0';
            this.tpExperimental_tbMsgBoxMsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tpExperimental_tbMsgBoxMsg.SelectedText = "";
            this.tpExperimental_tbMsgBoxMsg.SelectionLength = 0;
            this.tpExperimental_tbMsgBoxMsg.SelectionStart = 0;
            this.tpExperimental_tbMsgBoxMsg.ShortcutsEnabled = true;
            this.tpExperimental_tbMsgBoxMsg.Size = new System.Drawing.Size(174, 23);
            this.tpExperimental_tbMsgBoxMsg.TabIndex = 0;
            this.tpExperimental_tbMsgBoxMsg.Text = "Message";
            this.tpExperimental_tbMsgBoxMsg.UseSelectable = true;
            this.tpExperimental_tbMsgBoxMsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tpExperimental_tbMsgBoxMsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tpExperimental_lbLog
            // 
            this.tpExperimental_lbLog.AutoSize = true;
            this.tpExperimental_lbLog.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tpExperimental_lbLog.Location = new System.Drawing.Point(3, 238);
            this.tpExperimental_lbLog.Name = "tpExperimental_lbLog";
            this.tpExperimental_lbLog.Size = new System.Drawing.Size(38, 19);
            this.tpExperimental_lbLog.TabIndex = 3;
            this.tpExperimental_lbLog.Text = "Log:";
            // 
            // tpExperimental_btnAddToStartup
            // 
            this.tpExperimental_btnAddToStartup.Location = new System.Drawing.Point(111, 3);
            this.tpExperimental_btnAddToStartup.Name = "tpExperimental_btnAddToStartup";
            this.tpExperimental_btnAddToStartup.Size = new System.Drawing.Size(105, 24);
            this.tpExperimental_btnAddToStartup.TabIndex = 2;
            this.tpExperimental_btnAddToStartup.Text = "Add to Startup";
            this.tpExperimental_btnAddToStartup.UseSelectable = true;
            this.tpExperimental_btnAddToStartup.Click += new System.EventHandler(this.btnAddToStartup_Click);
            // 
            // tpExperimental_rtbLog
            // 
            this.tpExperimental_rtbLog.Location = new System.Drawing.Point(3, 260);
            this.tpExperimental_rtbLog.Name = "tpExperimental_rtbLog";
            this.tpExperimental_rtbLog.Size = new System.Drawing.Size(920, 170);
            this.tpExperimental_rtbLog.TabIndex = 1;
            this.tpExperimental_rtbLog.Text = "";
            // 
            // tpExperimental_btnSelfDestruct
            // 
            this.tpExperimental_btnSelfDestruct.Location = new System.Drawing.Point(0, 3);
            this.tpExperimental_btnSelfDestruct.Name = "tpExperimental_btnSelfDestruct";
            this.tpExperimental_btnSelfDestruct.Size = new System.Drawing.Size(105, 24);
            this.tpExperimental_btnSelfDestruct.TabIndex = 0;
            this.tpExperimental_btnSelfDestruct.Text = "Self-Destruct";
            this.tpExperimental_btnSelfDestruct.UseSelectable = true;
            this.tpExperimental_btnSelfDestruct.Click += new System.EventHandler(this.btnSuicide_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 549);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "BoRAT - BETA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuClients.ResumeLayout(false);
            this.MenuFileManager.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSTIcon)).EndInit();
            this.PanelClients.ResumeLayout(false);
            this.PanelClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpConnections_nPort)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PanelRdp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpRV_pbView)).EndInit();
            this.PanelCommand.ResumeLayout(false);
            this.PanelCommand.PerformLayout();
            this.PanelFileManager.ResumeLayout(false);
            this.PanelFileManager.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpConnections.ResumeLayout(false);
            this.tpRdp.ResumeLayout(false);
            this.tpRemoteShell.ResumeLayout(false);
            this.tpFileManager.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.tpExperimental.ResumeLayout(false);
            this.tpExperimental.PerformLayout();
            this.tpExperimental_gpRunOnlineEXE.ResumeLayout(false);
            this.tpExperimental_gpShowImage.ResumeLayout(false);
            this.tpExperimental_gpShowMessageBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuClients;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCommandShellToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuFileManager;
        private System.Windows.Forms.ToolStripMenuItem drivesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnReqPw;
        private MetroFramework.Controls.MetroLabel lblStatusPwRecovery;
        private System.Windows.Forms.ListView listPasswords;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox comboEPath;
        private MetroFramework.Controls.MetroLabel label13;
        private MetroFramework.Controls.MetroCheckBox chHide;
        private MetroFramework.Controls.MetroCheckBox chStartup;
        private MetroFramework.Controls.MetroPanel PanelClients;
        private MetroFramework.Controls.MetroLabel tpConnections_lblStatus;
        private System.Windows.Forms.ListView tpConnections_listClients;
        private System.Windows.Forms.ColumnHeader listClients_ID;
        private System.Windows.Forms.ColumnHeader listClients_PublicIP;
        private System.Windows.Forms.ColumnHeader listClients_Username;
        private System.Windows.Forms.ColumnHeader listClients_OS;
        private System.Windows.Forms.ColumnHeader listClients_AntiVirus;
        private System.Windows.Forms.ColumnHeader listClients_DateTime;
        private MetroFramework.Controls.MetroLabel tpConnections_lbPort;
        private MetroFramework.Controls.MetroButton tpConnections_btnListen;
        private System.Windows.Forms.NumericUpDown tpConnections_nPort;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroButton btnEncrypt;
        private MetroFramework.Controls.MetroLabel lblStatusSTCrypter;
        private MetroFramework.Controls.MetroLabel label12;
        private MetroFramework.Controls.MetroButton btnSTIcon;
        private System.Windows.Forms.PictureBox pSTIcon;
        private MetroFramework.Controls.MetroCheckBox chRName;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroRadioButton rbExclamation;
        private MetroFramework.Controls.MetroRadioButton rbInformation;
        private MetroFramework.Controls.MetroRadioButton rbError;
        private MetroFramework.Controls.MetroTextBox txtMCaption;
        private MetroFramework.Controls.MetroTextBox txtMTitle;
        private MetroFramework.Controls.MetroCheckBox chMsgbox;
        private MetroFramework.Controls.MetroButton btnMTest;
        private MetroFramework.Controls.MetroTextBox txtEKey;
        private MetroFramework.Controls.MetroLabel label15;
        private MetroFramework.Controls.MetroRadioButton rbManaged;
        private MetroFramework.Controls.MetroRadioButton rbNative;
        private MetroFramework.Controls.MetroLabel label16;
        private MetroFramework.Controls.MetroPanel PanelRdp;
        private MetroFramework.Controls.MetroButton tpRV_btnStart;
        private MetroFramework.Controls.MetroButton tpRV_btnStop;
        private MetroFramework.Controls.MetroComboBox tpRV_cmbChangeView;
        private System.Windows.Forms.PictureBox tpRV_pbView;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.RichTextBox tpShell_rtbLog;
        private MetroFramework.Controls.MetroLabel tpShell_lbCommand;
        private MetroFramework.Controls.MetroTextBox tpShell_tbCommand;
        private MetroFramework.Controls.MetroPanel PanelCommand;
        private System.Windows.Forms.ListView tpFM_listFileManager;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MetroFramework.Controls.MetroLabel tpFM_lbActivityLog;
        private System.Windows.Forms.RichTextBox tpFM_rtbLogs;
        private MetroFramework.Controls.MetroPanel PanelFileManager;
        private MetroFramework.Controls.MetroTabPage tpRdp;
        private MetroFramework.Controls.MetroTabPage tpFileManager;
        private MetroFramework.Controls.MetroTabPage tpRemoteShell;
        private MetroFramework.Controls.MetroTabPage tpConnections;
        private MetroFramework.Controls.MetroTabPage tpExperimental;
        private MetroFramework.Controls.MetroButton tpExperimental_btnAddToStartup;
        private System.Windows.Forms.RichTextBox tpExperimental_rtbLog;
        private MetroFramework.Controls.MetroButton tpExperimental_btnSelfDestruct;
        private MetroFramework.Controls.MetroTabPage tpAbout;
        private MetroFramework.Controls.MetroTabControl tcMain;
        private MetroFramework.Controls.MetroLabel tpAbout_lbExperiments;
        private MetroFramework.Controls.MetroToggle tpAbout_toggleExperiments;
        private MetroFramework.Controls.MetroLabel tpExperimental_lbLog;
        private System.Windows.Forms.GroupBox tpExperimental_gpShowMessageBox;
        private MetroFramework.Controls.MetroTextBox tpExperimental_tbMsgBoxMsg;
        private MetroFramework.Controls.MetroComboBox tpExperimental_cbMsgBoxIcons;
        private MetroFramework.Controls.MetroButton tpExperimental_btnShowMsgBoxes;
        private MetroFramework.Controls.MetroTextBox tpExperimental_tbMsgBoxTitle;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.GroupBox tpExperimental_gpShowImage;
        private MetroFramework.Controls.MetroTextBox tpExperimental_tbImageURL;
        private MetroFramework.Controls.MetroButton tpExperimental_btnShowImage;
        private System.Windows.Forms.GroupBox tpExperimental_gpRunOnlineEXE;
        private MetroFramework.Controls.MetroTextBox tpExperimental_tbEXEURL;
        private MetroFramework.Controls.MetroButton tpExperimental_btnRunOnlineEXE;
        private MetroFramework.Controls.MetroLabel tpAbout_lbAuthor;
        private MetroFramework.Controls.MetroLabel tpAbout_lbTitle;
    }
}
