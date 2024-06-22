namespace ClientProfiles
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
            this.btnGetProfiles = new System.Windows.Forms.Button();
            this.txtProfiles = new System.Windows.Forms.TextBox();
            this.btnGetAligners = new System.Windows.Forms.Button();
            this.txtAligners = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnGetProfiles
            // 
            this.btnGetProfiles.Location = new System.Drawing.Point(79, 64);
            this.btnGetProfiles.Name = "btnGetProfiles";
            this.btnGetProfiles.Size = new System.Drawing.Size(75, 23);
            this.btnGetProfiles.TabIndex = 2;
            this.btnGetProfiles.Text = "Get Profiles";
            this.btnGetProfiles.UseVisualStyleBackColor = true;
            this.btnGetProfiles.Click += new System.EventHandler(this.btnGetProfiles_Click);
            // 
            // txtProfiles
            // 
            this.txtProfiles.Location = new System.Drawing.Point(175, 19);
            this.txtProfiles.Multiline = true;
            this.txtProfiles.Name = "txtProfiles";
            this.txtProfiles.Size = new System.Drawing.Size(457, 68);
            this.txtProfiles.TabIndex = 3;
            // 
            // btnGetAligners
            // 
            this.btnGetAligners.Location = new System.Drawing.Point(79, 183);
            this.btnGetAligners.Name = "btnGetAligners";
            this.btnGetAligners.Size = new System.Drawing.Size(75, 23);
            this.btnGetAligners.TabIndex = 4;
            this.btnGetAligners.Text = "Get Aligners";
            this.btnGetAligners.UseVisualStyleBackColor = true;
            this.btnGetAligners.Click += new System.EventHandler(this.btnGetAligners_Click);
            // 
            // txtAligners
            // 
            this.txtAligners.Location = new System.Drawing.Point(175, 138);
            this.txtAligners.Multiline = true;
            this.txtAligners.Name = "txtAligners";
            this.txtAligners.Size = new System.Drawing.Size(457, 68);
            this.txtAligners.TabIndex = 5;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(45, 258);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 7;
            this.btnBrowser.Text = "Start browse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(37, 307);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(938, 316);
            this.webBrowser1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 638);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtAligners);
            this.Controls.Add(this.btnGetAligners);
            this.Controls.Add(this.txtProfiles);
            this.Controls.Add(this.btnGetProfiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetProfiles;
        private System.Windows.Forms.TextBox txtProfiles;
        private System.Windows.Forms.Button btnGetAligners;
        private System.Windows.Forms.TextBox txtAligners;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

