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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.goButton = new System.Windows.Forms.Button();
            this.txtAddressBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetProfiles
            // 
            this.btnGetProfiles.Location = new System.Drawing.Point(12, 120);
            this.btnGetProfiles.Name = "btnGetProfiles";
            this.btnGetProfiles.Size = new System.Drawing.Size(75, 23);
            this.btnGetProfiles.TabIndex = 2;
            this.btnGetProfiles.Text = "Get Profiles";
            this.btnGetProfiles.UseVisualStyleBackColor = true;
            this.btnGetProfiles.Click += new System.EventHandler(this.btnGetProfiles_Click);
            // 
            // txtProfiles
            // 
            this.txtProfiles.Location = new System.Drawing.Point(12, 46);
            this.txtProfiles.Multiline = true;
            this.txtProfiles.Name = "txtProfiles";
            this.txtProfiles.Size = new System.Drawing.Size(457, 68);
            this.txtProfiles.TabIndex = 3;
            // 
            // btnGetAligners
            // 
            this.btnGetAligners.Location = new System.Drawing.Point(622, 120);
            this.btnGetAligners.Name = "btnGetAligners";
            this.btnGetAligners.Size = new System.Drawing.Size(75, 23);
            this.btnGetAligners.TabIndex = 4;
            this.btnGetAligners.Text = "Get Aligners";
            this.btnGetAligners.UseVisualStyleBackColor = true;
            this.btnGetAligners.Click += new System.EventHandler(this.btnGetAligners_Click);
            // 
            // txtAligners
            // 
            this.txtAligners.Location = new System.Drawing.Point(622, 46);
            this.txtAligners.Multiline = true;
            this.txtAligners.Name = "txtAligners";
            this.txtAligners.Size = new System.Drawing.Size(457, 68);
            this.txtAligners.TabIndex = 5;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 196);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1364, 583);
            this.webView21.TabIndex = 9;
            this.webView21.ZoomFactor = 1D;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1301, 790);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 11;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // txtAddressBar
            // 
            this.txtAddressBar.Location = new System.Drawing.Point(12, 12);
            this.txtAddressBar.Name = "txtAddressBar";
            this.txtAddressBar.Size = new System.Drawing.Size(398, 20);
            this.txtAddressBar.TabIndex = 10;
            this.txtAddressBar.Text = "https://localhost:7147/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 825);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.txtAddressBar);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.txtAligners);
            this.Controls.Add(this.btnGetAligners);
            this.Controls.Add(this.txtProfiles);
            this.Controls.Add(this.btnGetProfiles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetProfiles;
        private System.Windows.Forms.TextBox txtProfiles;
        private System.Windows.Forms.Button btnGetAligners;
        private System.Windows.Forms.TextBox txtAligners;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox txtAddressBar;
    }
}

