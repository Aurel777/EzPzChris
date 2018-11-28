namespace EzpzChris.Forms
{
    using EzpzChris.UserControls;

    partial class NewShow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewShow));
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonAddAndExit = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelMainCaption = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelEpisodeNumber = new System.Windows.Forms.Label();
            this.LabelSeasonNumber = new System.Windows.Forms.Label();
            this.EraseTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LinkLabelImdbPage = new System.Windows.Forms.LinkLabel();
            this.TextBoxSeasonNumber = new NumericTextBox();
            this.TextBoxEpisodeNumber = new NumericTextBox();
            this.LineTop = new LineSeparator();
            this.LineBottom = new LineSeparator();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ButtonCancel);
            this.PanelBottom.Controls.Add(this.ButtonAdd);
            this.PanelBottom.Controls.Add(this.ButtonAddAndExit);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 271);
            this.PanelBottom.MaximumSize = new System.Drawing.Size(4096, 70);
            this.PanelBottom.MinimumSize = new System.Drawing.Size(0, 70);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(514, 70);
            this.PanelBottom.TabIndex = 20;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.ButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(214)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(184, 19);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 30);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(164)))), ((int)(((byte)(210)))));
            this.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(214)))));
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(250)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(294, 19);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(90, 30);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonAddAndExit
            // 
            this.ButtonAddAndExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddAndExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(164)))), ((int)(((byte)(210)))));
            this.ButtonAddAndExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(211)))), ((int)(((byte)(214)))));
            this.ButtonAddAndExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(144)))), ((int)(((byte)(190)))));
            this.ButtonAddAndExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(204)))), ((int)(((byte)(250)))));
            this.ButtonAddAndExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddAndExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddAndExit.ForeColor = System.Drawing.Color.White;
            this.ButtonAddAndExit.Location = new System.Drawing.Point(404, 19);
            this.ButtonAddAndExit.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonAddAndExit.Name = "ButtonAddAndExit";
            this.ButtonAddAndExit.Size = new System.Drawing.Size(90, 30);
            this.ButtonAddAndExit.TabIndex = 6;
            this.ButtonAddAndExit.Text = "Add and exit";
            this.ButtonAddAndExit.UseVisualStyleBackColor = false;
            this.ButtonAddAndExit.Click += new System.EventHandler(this.ButtonAddAndExit_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.LabelMainCaption);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelTop.MaximumSize = new System.Drawing.Size(4096, 60);
            this.PanelTop.MinimumSize = new System.Drawing.Size(500, 60);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(514, 60);
            this.PanelTop.TabIndex = 13;
            // 
            // LabelMainCaption
            // 
            this.LabelMainCaption.AutoSize = true;
            this.LabelMainCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMainCaption.Location = new System.Drawing.Point(21, 23);
            this.LabelMainCaption.Name = "LabelMainCaption";
            this.LabelMainCaption.Size = new System.Drawing.Size(110, 19);
            this.LabelMainCaption.TabIndex = 0;
            this.LabelMainCaption.Text = "Add a new show";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(40, 97);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 16);
            this.LblTitle.TabIndex = 7;
            this.LblTitle.Text = "Title";
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(184, 94);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(310, 21);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // LabelEpisodeNumber
            // 
            this.LabelEpisodeNumber.AutoSize = true;
            this.LabelEpisodeNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEpisodeNumber.Location = new System.Drawing.Point(40, 183);
            this.LabelEpisodeNumber.Name = "LabelEpisodeNumber";
            this.LabelEpisodeNumber.Size = new System.Drawing.Size(93, 16);
            this.LabelEpisodeNumber.TabIndex = 10;
            this.LabelEpisodeNumber.Text = "Episode number";
            // 
            // LabelSeasonNumber
            // 
            this.LabelSeasonNumber.AutoSize = true;
            this.LabelSeasonNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeasonNumber.Location = new System.Drawing.Point(40, 140);
            this.LabelSeasonNumber.Name = "LabelSeasonNumber";
            this.LabelSeasonNumber.Size = new System.Drawing.Size(89, 16);
            this.LabelSeasonNumber.TabIndex = 12;
            this.LabelSeasonNumber.Text = "Season number";
            // 
            // EraseTimer
            // 
            this.EraseTimer.Interval = 3000;
            this.EraseTimer.Tick += new System.EventHandler(this.EraseTimer_Tick);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.ForeColor = System.Drawing.Color.Red;
            this.LabelInfo.Location = new System.Drawing.Point(22, 232);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(0, 16);
            this.LabelInfo.TabIndex = 15;
            // 
            // LinkLabelImdbPage
            // 
            this.LinkLabelImdbPage.AutoSize = true;
            this.LinkLabelImdbPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelImdbPage.Location = new System.Drawing.Point(181, 221);
            this.LinkLabelImdbPage.Name = "LinkLabelImdbPage";
            this.LinkLabelImdbPage.Size = new System.Drawing.Size(98, 16);
            this.LinkLabelImdbPage.TabIndex = 7;
            this.LinkLabelImdbPage.TabStop = true;
            this.LinkLabelImdbPage.Text = "Open IMDB page";
            this.LinkLabelImdbPage.Visible = false;
            this.LinkLabelImdbPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelImdbPage_LinkClicked);
            // 
            // TextBoxSeasonNumber
            // 
            this.TextBoxSeasonNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSeasonNumber.Location = new System.Drawing.Point(184, 137);
            this.TextBoxSeasonNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSeasonNumber.Name = "TextBoxSeasonNumber";
            this.TextBoxSeasonNumber.Size = new System.Drawing.Size(79, 21);
            this.TextBoxSeasonNumber.TabIndex = 2;
            // 
            // TextBoxEpisodeNumber
            // 
            this.TextBoxEpisodeNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEpisodeNumber.Location = new System.Drawing.Point(184, 180);
            this.TextBoxEpisodeNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEpisodeNumber.Name = "TextBoxEpisodeNumber";
            this.TextBoxEpisodeNumber.Size = new System.Drawing.Size(79, 21);
            this.TextBoxEpisodeNumber.TabIndex = 3;
            // 
            // LineTop
            // 
            this.LineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(134)))), ((int)(((byte)(190)))));
            this.LineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineTop.Location = new System.Drawing.Point(0, 60);
            this.LineTop.Name = "LineTop";
            this.LineTop.Size = new System.Drawing.Size(514, 1);
            this.LineTop.TabIndex = 21;
            // 
            // LineBottom
            // 
            this.LineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(134)))), ((int)(((byte)(190)))));
            this.LineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineBottom.Location = new System.Drawing.Point(0, 270);
            this.LineBottom.Name = "LineBottom";
            this.LineBottom.Size = new System.Drawing.Size(514, 1);
            this.LineBottom.TabIndex = 22;
            // 
            // NewShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.LineBottom);
            this.Controls.Add(this.LineTop);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.LabelSeasonNumber);
            this.Controls.Add(this.TextBoxSeasonNumber);
            this.Controls.Add(this.LabelEpisodeNumber);
            this.Controls.Add(this.TextBoxEpisodeNumber);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LinkLabelImdbPage);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 380);
            this.Name = "NewShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EzPz Chris";
            this.PanelBottom.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.NumericTextBox TextBoxEpisodeNumber;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LabelEpisodeNumber;
        private System.Windows.Forms.Label LabelSeasonNumber;
        private UserControls.NumericTextBox TextBoxSeasonNumber;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelMainCaption;
        private System.Windows.Forms.Timer EraseTimer;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.LinkLabel LinkLabelImdbPage;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonAddAndExit;
        private UserControls.LineSeparator LineTop;
        private UserControls.LineSeparator LineBottom;
    }
}