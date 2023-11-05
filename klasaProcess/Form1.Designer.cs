namespace klasaProcess
{
    partial class Form1
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
            this.buttonIExplorer = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIExplorer
            // 
            this.buttonIExplorer.Location = new System.Drawing.Point(30, 34);
            this.buttonIExplorer.Name = "buttonIExplorer";
            this.buttonIExplorer.Size = new System.Drawing.Size(225, 42);
            this.buttonIExplorer.TabIndex = 0;
            this.buttonIExplorer.Text = "Pokrenite Internet Explorer";
            this.buttonIExplorer.UseVisualStyleBackColor = true;
            this.buttonIExplorer.Click += new System.EventHandler(this.buttonIExplorer_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(292, 34);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(225, 43);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "Pokrenite Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.Location = new System.Drawing.Point(292, 121);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(225, 43);
            this.buttonStartInfo.TabIndex = 3;
            this.buttonStartInfo.Text = "Start Info";
            this.buttonStartInfo.UseVisualStyleBackColor = true;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(30, 121);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(225, 43);
            this.buttonWord.TabIndex = 4;
            this.buttonWord.Text = "Pokrenite Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 227);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonStartInfo);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonIExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIExplorer;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonWord;
    }
}

