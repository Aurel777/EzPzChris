namespace EzpzChris.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.MaskedTextBoxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LblShowsToMonitor = new System.Windows.Forms.Label();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(116, 84);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(233, 20);
            this.TextBoxUserName.TabIndex = 0;
            // 
            // MaskedTextBoxtPassword
            // 
            this.MaskedTextBoxtPassword.Location = new System.Drawing.Point(116, 129);
            this.MaskedTextBoxtPassword.Name = "MaskedTextBoxtPassword";
            this.MaskedTextBoxtPassword.PasswordChar = '*';
            this.MaskedTextBoxtPassword.Size = new System.Drawing.Size(233, 20);
            this.MaskedTextBoxtPassword.TabIndex = 1;
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Location = new System.Drawing.Point(14, 87);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(55, 13);
            this.LabelUserName.TabIndex = 3;
            this.LabelUserName.Tag = "";
            this.LabelUserName.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(16, 132);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Tag = "";
            this.LabelPassword.Text = "Password";
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(116, 172);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(101, 17);
            this.CheckBoxShowPassword.TabIndex = 4;
            this.CheckBoxShowPassword.Text = "Show password";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBottom.Controls.Add(this.ButtonConnect);
            this.PanelBottom.Controls.Add(this.ButtonCancel);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 229);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(377, 60);
            this.PanelBottom.TabIndex = 15;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(164)))), ((int)(((byte)(210)))));
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(268, 15);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(90, 30);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(155, 15);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0, 10, 130, 10);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 30);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTop.Controls.Add(this.LblShowsToMonitor);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(377, 60);
            this.PanelTop.TabIndex = 16;
            // 
            // LblShowsToMonitor
            // 
            this.LblShowsToMonitor.AutoSize = true;
            this.LblShowsToMonitor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShowsToMonitor.Location = new System.Drawing.Point(12, 19);
            this.LblShowsToMonitor.Name = "LblShowsToMonitor";
            this.LblShowsToMonitor.Size = new System.Drawing.Size(178, 19);
            this.LblShowsToMonitor.TabIndex = 0;
            this.LblShowsToMonitor.Text = "Enter your EZTV credentials";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 289);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.MaskedTextBoxtPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EzPz Chris Login";
            this.PanelBottom.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxtPassword;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LblShowsToMonitor;
    }
}

