namespace NexusLabs.BoRAT.Checker
{
    partial class frmCheck
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
            this.iconWarning = new FontAwesome.Sharp.IconPictureBox();
            this.lbBoRATStatus = new MetroFramework.Controls.MetroLabel();
            this.lbRiskLabel = new MetroFramework.Controls.MetroLabel();
            this.btnCheck = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // iconWarning
            // 
            this.iconWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconWarning.ForeColor = System.Drawing.Color.Black;
            this.iconWarning.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconWarning.IconColor = System.Drawing.Color.Black;
            this.iconWarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWarning.IconSize = 96;
            this.iconWarning.Location = new System.Drawing.Point(23, 63);
            this.iconWarning.Name = "iconWarning";
            this.iconWarning.Size = new System.Drawing.Size(96, 96);
            this.iconWarning.TabIndex = 0;
            this.iconWarning.TabStop = false;
            // 
            // lbBoRATStatus
            // 
            this.lbBoRATStatus.AutoSize = true;
            this.lbBoRATStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbBoRATStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbBoRATStatus.Location = new System.Drawing.Point(125, 63);
            this.lbBoRATStatus.Name = "lbBoRATStatus";
            this.lbBoRATStatus.Size = new System.Drawing.Size(112, 25);
            this.lbBoRATStatus.TabIndex = 1;
            this.lbBoRATStatus.Text = "No scan yet";
            // 
            // lbRiskLabel
            // 
            this.lbRiskLabel.AutoSize = true;
            this.lbRiskLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbRiskLabel.Location = new System.Drawing.Point(125, 88);
            this.lbRiskLabel.Name = "lbRiskLabel";
            this.lbRiskLabel.Size = new System.Drawing.Size(167, 38);
            this.lbRiskLabel.TabIndex = 2;
            this.lbRiskLabel.Text = "Click check below to start.\r\nWe\'ll check for BoRAT.";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(125, 129);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(198, 30);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseSelectable = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 184);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbRiskLabel);
            this.Controls.Add(this.lbBoRATStatus);
            this.Controls.Add(this.iconWarning);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheck";
            this.ShowIcon = false;
            this.Text = "BoRAT Checker";
            this.Load += new System.EventHandler(this.frmCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconWarning;
        private MetroFramework.Controls.MetroLabel lbBoRATStatus;
        private MetroFramework.Controls.MetroLabel lbRiskLabel;
        private MetroFramework.Controls.MetroButton btnCheck;
    }
}

