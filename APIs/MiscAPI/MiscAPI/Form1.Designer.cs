namespace MiscAPI
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
            this.btnTaskMgr = new System.Windows.Forms.Button();
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnMuteUnmute = new System.Windows.Forms.Button();
            this.btnIncrVol = new System.Windows.Forms.Button();
            this.btnDecrVol = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHibernate = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaskMgr
            // 
            this.btnTaskMgr.Location = new System.Drawing.Point(28, 37);
            this.btnTaskMgr.Name = "btnTaskMgr";
            this.btnTaskMgr.Size = new System.Drawing.Size(112, 51);
            this.btnTaskMgr.TabIndex = 0;
            this.btnTaskMgr.Text = "Start task mgr";
            this.btnTaskMgr.UseVisualStyleBackColor = true;
            this.btnTaskMgr.Click += new System.EventHandler(this.btnTaskMgr_Click);
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(187, 37);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(112, 51);
            this.btnCmd.TabIndex = 1;
            this.btnCmd.Text = "Open command prompt";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(352, 37);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 51);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Open calculator";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(28, 116);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(112, 51);
            this.btnNotepad.TabIndex = 3;
            this.btnNotepad.Text = "Open notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(187, 116);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(112, 51);
            this.btnInternet.TabIndex = 4;
            this.btnInternet.Text = "Browse the internet";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnMuteUnmute
            // 
            this.btnMuteUnmute.Location = new System.Drawing.Point(352, 116);
            this.btnMuteUnmute.Name = "btnMuteUnmute";
            this.btnMuteUnmute.Size = new System.Drawing.Size(112, 51);
            this.btnMuteUnmute.TabIndex = 5;
            this.btnMuteUnmute.Text = "Mute/Unmute volume";
            this.btnMuteUnmute.UseVisualStyleBackColor = true;
            this.btnMuteUnmute.Click += new System.EventHandler(this.btnMuteUnmute_Click);
            // 
            // btnIncrVol
            // 
            this.btnIncrVol.Location = new System.Drawing.Point(28, 191);
            this.btnIncrVol.Name = "btnIncrVol";
            this.btnIncrVol.Size = new System.Drawing.Size(112, 51);
            this.btnIncrVol.TabIndex = 6;
            this.btnIncrVol.Text = "Increase volume";
            this.btnIncrVol.UseVisualStyleBackColor = true;
            this.btnIncrVol.Click += new System.EventHandler(this.btnIncrVol_Click);
            // 
            // btnDecrVol
            // 
            this.btnDecrVol.Location = new System.Drawing.Point(187, 191);
            this.btnDecrVol.Name = "btnDecrVol";
            this.btnDecrVol.Size = new System.Drawing.Size(112, 51);
            this.btnDecrVol.TabIndex = 7;
            this.btnDecrVol.Text = "Decrease volume";
            this.btnDecrVol.UseVisualStyleBackColor = true;
            this.btnDecrVol.Click += new System.EventHandler(this.btnDecrVol_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(352, 191);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(112, 51);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(28, 277);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(112, 51);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnHibernate
            // 
            this.btnHibernate.Location = new System.Drawing.Point(187, 277);
            this.btnHibernate.Name = "btnHibernate";
            this.btnHibernate.Size = new System.Drawing.Size(112, 51);
            this.btnHibernate.TabIndex = 10;
            this.btnHibernate.Text = "hibernate";
            this.btnHibernate.UseVisualStyleBackColor = true;
            this.btnHibernate.Click += new System.EventHandler(this.btnHibernate_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(352, 277);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(112, 51);
            this.btnSleep.TabIndex = 11;
            this.btnSleep.Text = "sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 395);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnHibernate);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnDecrVol);
            this.Controls.Add(this.btnIncrVol);
            this.Controls.Add(this.btnMuteUnmute);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.btnNotepad);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.btnTaskMgr);
            this.Name = "frmMain";
            this.Text = "14";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskMgr;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnMuteUnmute;
        private System.Windows.Forms.Button btnIncrVol;
        private System.Windows.Forms.Button btnDecrVol;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnHibernate;
        private System.Windows.Forms.Button btnSleep;
    }
}

