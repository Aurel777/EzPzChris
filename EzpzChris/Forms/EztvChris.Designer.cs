namespace EzpzChris.Forms
{
    using EzpzChris.UserControls;

    partial class EztvChris
    {

        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                NotifyIcon?.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EztvChris));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FetchShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemManageShows = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressBarImdbTvShow = new ProgressBar();
            this.MenuStrip.SuspendLayout();
            this.NotifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.IMDBToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToolStripMenuItem,
            this.ManageShowsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ConnectToolStripMenuItem.Text = "Connect to EZTV";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // ManageShowsToolStripMenuItem
            // 
            this.ManageShowsToolStripMenuItem.Name = "ManageShowsToolStripMenuItem";
            this.ManageShowsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.ManageShowsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ManageShowsToolStripMenuItem.Text = "Manage shows";
            this.ManageShowsToolStripMenuItem.Click += new System.EventHandler(this.ManageShowsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // IMDBToolStripMenuItem
            // 
            this.IMDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FetchShowsToolStripMenuItem,
            this.UpdateShowsToolStripMenuItem});
            this.IMDBToolStripMenuItem.Name = "IMDBToolStripMenuItem";
            this.IMDBToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.IMDBToolStripMenuItem.Text = "IMDB";
            // 
            // FetchShowsToolStripMenuItem
            // 
            this.FetchShowsToolStripMenuItem.Name = "FetchShowsToolStripMenuItem";
            this.FetchShowsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FetchShowsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.FetchShowsToolStripMenuItem.Text = "Fetch shows";
            this.FetchShowsToolStripMenuItem.Click += new System.EventHandler(this.FetchShowsToolStripMenuItem_Click);
            // 
            // UpdateShowsToolStripMenuItem
            // 
            this.UpdateShowsToolStripMenuItem.Name = "UpdateShowsToolStripMenuItem";
            this.UpdateShowsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdateShowsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.UpdateShowsToolStripMenuItem.Text = "Update shows";
            this.UpdateShowsToolStripMenuItem.Click += new System.EventHandler(this.UpdateShowsToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.OptionsToolStripMenuItem.Text = "Options";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(380, 290);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(0, 13);
            this.LabelCount.TabIndex = 8;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(505, 290);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(0, 13);
            this.LabelTotal.TabIndex = 9;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyIconContextMenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // NotifyIconContextMenuStrip
            // 
            this.NotifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemManageShows,
            this.ToolStripMenuItemSettings,
            this.ToolStripMenuItemExit});
            this.NotifyIconContextMenuStrip.Name = "NotifyIconContextMenuStrip";
            this.NotifyIconContextMenuStrip.Size = new System.Drawing.Size(154, 70);
            // 
            // ToolStripMenuItemManageShows
            // 
            this.ToolStripMenuItemManageShows.Name = "ToolStripMenuItemManageShows";
            this.ToolStripMenuItemManageShows.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemManageShows.Text = "Manage shows";
            this.ToolStripMenuItemManageShows.Click += new System.EventHandler(this.ToolStripMenuItemManageShows_Click);
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemSettings.Text = "Settings";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemExit.Text = "Exit";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ProgressBarImdbTvShow
            // 
            this.ProgressBarImdbTvShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarImdbTvShow.Location = new System.Drawing.Point(12, 306);
            this.ProgressBarImdbTvShow.Name = "ProgressBarImdbTvShow";
            this.ProgressBarImdbTvShow.ProgressBarBorderColor = System.Drawing.Color.Black;
            this.ProgressBarImdbTvShow.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(135)))), ((int)(((byte)(180)))));
            this.ProgressBarImdbTvShow.Size = new System.Drawing.Size(776, 23);
            this.ProgressBarImdbTvShow.TabIndex = 10;
            this.ProgressBarImdbTvShow.Text = "0 / 100 (0%)";
            this.ProgressBarImdbTvShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProgressBarImdbTvShow.UseVisualStyleBackColor = false;
            this.ProgressBarImdbTvShow.Value = 0D;
            this.ProgressBarImdbTvShow.Visible = false;
            // 
            // EztvChris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBarImdbTvShow);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.LabelTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "EztvChris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EzPz Chris";
            this.Load += new System.EventHandler(this.EztvChris_Load);
            this.Resize += new System.EventHandler(this.EztvChris_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.NotifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelTotal;

        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IMDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FetchShowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateShowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageShowsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemManageShows;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private UserControls.ProgressBar ProgressBarImdbTvShow;
    }
}