namespace EzpzChris.Forms
{
    using EzpzChris.UserControls;

    partial class Processing
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
            this.waitControl2 = new WaitControl();
            this.SuspendLayout();
            // 
            // waitControl2
            // 
            this.waitControl2.InlineCircleRectangle = new System.Drawing.Rectangle(8, 8, 184, 184);
            this.waitControl2.InlineCircleWidth = 4;
            this.waitControl2.InnerCircleRectangle = new System.Drawing.Rectangle(16, 16, 168, 168);
            this.waitControl2.Location = new System.Drawing.Point(0, 0);
            this.waitControl2.Name = "waitControl2";
            this.waitControl2.OutlineCircleRectangle = new System.Drawing.Rectangle(24, 24, 152, 152);
            this.waitControl2.OutlineCircleWidth = 4;
            this.waitControl2.Size = new System.Drawing.Size(200, 200);
            this.waitControl2.TabIndex = 0;
            // 
            // Processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.waitControl2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Processing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);

        }

        #endregion
        
        private UserControls.WaitControl waitControl2;
    }
}