using System.Windows.Forms;

namespace DirectoryCompressor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnSelectDirectories;
        private Button btnCompress;
        private ListBox lstDirectories;

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
            this.btnSelectDirectories = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.lstDirectories = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.removeFolderChkBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDirectories
            // 
            this.btnSelectDirectories.Location = new System.Drawing.Point(5, 12);
            this.btnSelectDirectories.Name = "btnSelectDirectories";
            this.btnSelectDirectories.Size = new System.Drawing.Size(150, 23);
            this.btnSelectDirectories.TabIndex = 0;
            this.btnSelectDirectories.Text = "Selecionar Diretórios";
            this.btnSelectDirectories.UseVisualStyleBackColor = true;
            this.btnSelectDirectories.Click += new System.EventHandler(this.BtnSelectDirectories_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(168, 12);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(150, 23);
            this.btnCompress.TabIndex = 1;
            this.btnCompress.Text = "Comprimir";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            // 
            // lstDirectories
            // 
            this.lstDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDirectories.FormattingEnabled = true;
            this.lstDirectories.Location = new System.Drawing.Point(6, 41);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(927, 381);
            this.lstDirectories.TabIndex = 2;
            this.lstDirectories.DragDrop += new System.Windows.Forms.DragEventHandler(this.LstDirectories_DragDrop);
            this.lstDirectories.DragEnter += new System.Windows.Forms.DragEventHandler(this.LstDirectories_DragEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(783, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // removeFolderChkBox
            // 
            this.removeFolderChkBox.AutoSize = true;
            this.removeFolderChkBox.Location = new System.Drawing.Point(330, 15);
            this.removeFolderChkBox.Name = "removeFolderChkBox";
            this.removeFolderChkBox.Size = new System.Drawing.Size(184, 17);
            this.removeFolderChkBox.TabIndex = 5;
            this.removeFolderChkBox.Text = "Remover folder após compressão";
            this.removeFolderChkBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 476);
            this.Controls.Add(this.removeFolderChkBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDirectories);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnSelectDirectories);
            this.Name = "MainForm";
            this.Text = "Compressor de Diretórios";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CheckBox removeFolderChkBox;
    }
}

