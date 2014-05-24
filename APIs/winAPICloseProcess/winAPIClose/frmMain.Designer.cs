namespace winAPIClose
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListView();
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(339, 366);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lstProcesses
            // 
            this.lstProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pName,
            this.pID});
            this.lstProcesses.Location = new System.Drawing.Point(12, 12);
            this.lstProcesses.MultiSelect = false;
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(289, 377);
            this.lstProcesses.TabIndex = 2;
            this.lstProcesses.UseCompatibleStateImageBehavior = false;
            this.lstProcesses.View = System.Windows.Forms.View.Details;
            this.lstProcesses.SelectedIndexChanged += new System.EventHandler(this.lstProcesses_SelectedIndexChanged);
            // 
            // pName
            // 
            this.pName.Text = "Name";
            // 
            // pID
            // 
            this.pID.Text = "PID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "kill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 401);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.btnPopulate);
            this.Name = "frmMain";
            this.Text = "Yayyyy I got placed. Hell yeah I am a good developer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListView lstProcesses;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader pID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

