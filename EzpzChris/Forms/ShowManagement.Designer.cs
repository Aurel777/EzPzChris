﻿namespace EzpzChris.Forms
{
    partial class ShowManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowManagement));
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.ButtonCancel);
            this.PanelBottom.Controls.Add(this.ButtonOK);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 474);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelBottom.MinimumSize = new System.Drawing.Size(0, 80);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(825, 80);
            this.PanelBottom.TabIndex = 11;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(599, 25);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0, 25, 23, 25);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 30);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(164)))), ((int)(((byte)(210)))));
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.ForeColor = System.Drawing.Color.White;
            this.ButtonOK.Location = new System.Drawing.Point(712, 25);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(0, 25, 23, 25);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(90, 30);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.LabelTitle);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelTop.MaximumSize = new System.Drawing.Size(0, 74);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(825, 74);
            this.PanelTop.TabIndex = 12;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(26, 29);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(179, 19);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Manage shows to monoitor";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(30, 420);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 30);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(139, 420);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 30);
            this.ButtonEdit.TabIndex = 15;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(153)))), ((int)(((byte)(159)))));
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(191)))), ((int)(((byte)(194)))));
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(246, 420);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 30);
            this.ButtonDelete.TabIndex = 16;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ShowManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowManagement";
            this.Text = "EzPz Chris";
            this.PanelBottom.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
    }
}