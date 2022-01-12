namespace _3dImageDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_url = new System.Windows.Forms.TextBox();
            this.Btn_download = new System.Windows.Forms.Button();
            this.Txt_output = new System.Windows.Forms.RichTextBox();
            this.Chk_subfolder = new System.Windows.Forms.CheckBox();
            this.Chk_AutoOpen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_count = new System.Windows.Forms.Label();
            this.Chk_skipUnknown = new System.Windows.Forms.CheckBox();
            this.Btn_outputFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_url
            // 
            this.Txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_url.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_url.Location = new System.Drawing.Point(12, 12);
            this.Txt_url.Name = "Txt_url";
            this.Txt_url.Size = new System.Drawing.Size(633, 29);
            this.Txt_url.TabIndex = 0;
            this.Txt_url.Text = "https://www.myminifactory.com/object/3d-print-spider-robot-197580";
            // 
            // Btn_download
            // 
            this.Btn_download.Location = new System.Drawing.Point(12, 47);
            this.Btn_download.Name = "Btn_download";
            this.Btn_download.Size = new System.Drawing.Size(139, 63);
            this.Btn_download.TabIndex = 1;
            this.Btn_download.Text = "Download Image";
            this.Btn_download.UseVisualStyleBackColor = true;
            this.Btn_download.Click += new System.EventHandler(this.Btn_download_Click);
            // 
            // Txt_output
            // 
            this.Txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_output.Location = new System.Drawing.Point(12, 116);
            this.Txt_output.Name = "Txt_output";
            this.Txt_output.ReadOnly = true;
            this.Txt_output.Size = new System.Drawing.Size(633, 305);
            this.Txt_output.TabIndex = 2;
            this.Txt_output.Text = "";
            // 
            // Chk_subfolder
            // 
            this.Chk_subfolder.AutoSize = true;
            this.Chk_subfolder.Location = new System.Drawing.Point(157, 91);
            this.Chk_subfolder.Name = "Chk_subfolder";
            this.Chk_subfolder.Size = new System.Drawing.Size(212, 19);
            this.Chk_subfolder.TabIndex = 3;
            this.Chk_subfolder.Text = "Group them into \'Image\' sub folder";
            this.Chk_subfolder.UseVisualStyleBackColor = true;
            // 
            // Chk_AutoOpen
            // 
            this.Chk_AutoOpen.AutoSize = true;
            this.Chk_AutoOpen.Checked = true;
            this.Chk_AutoOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_AutoOpen.Location = new System.Drawing.Point(157, 47);
            this.Chk_AutoOpen.Name = "Chk_AutoOpen";
            this.Chk_AutoOpen.Size = new System.Drawing.Size(211, 19);
            this.Chk_AutoOpen.TabIndex = 4;
            this.Chk_AutoOpen.Text = "Auto open folder upon completion";
            this.Chk_AutoOpen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Downloading: ";
            // 
            // Label_count
            // 
            this.Label_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_count.AutoSize = true;
            this.Label_count.Location = new System.Drawing.Point(93, 424);
            this.Label_count.Name = "Label_count";
            this.Label_count.Size = new System.Drawing.Size(13, 15);
            this.Label_count.TabIndex = 6;
            this.Label_count.Text = "0";
            // 
            // Chk_skipUnknown
            // 
            this.Chk_skipUnknown.AutoSize = true;
            this.Chk_skipUnknown.Checked = true;
            this.Chk_skipUnknown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_skipUnknown.Location = new System.Drawing.Point(157, 70);
            this.Chk_skipUnknown.Name = "Chk_skipUnknown";
            this.Chk_skipUnknown.Size = new System.Drawing.Size(145, 19);
            this.Chk_skipUnknown.TabIndex = 7;
            this.Chk_skipUnknown.Text = "Skip non extension file";
            this.Chk_skipUnknown.UseVisualStyleBackColor = true;
            // 
            // Btn_outputFolder
            // 
            this.Btn_outputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_outputFolder.Location = new System.Drawing.Point(506, 85);
            this.Btn_outputFolder.Name = "Btn_outputFolder";
            this.Btn_outputFolder.Size = new System.Drawing.Size(139, 28);
            this.Btn_outputFolder.TabIndex = 8;
            this.Btn_outputFolder.Text = "Open Folder";
            this.Btn_outputFolder.UseVisualStyleBackColor = true;
            this.Btn_outputFolder.Click += new System.EventHandler(this.Btn_outputFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 448);
            this.Controls.Add(this.Btn_outputFolder);
            this.Controls.Add(this.Chk_skipUnknown);
            this.Controls.Add(this.Label_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chk_AutoOpen);
            this.Controls.Add(this.Chk_subfolder);
            this.Controls.Add(this.Txt_output);
            this.Controls.Add(this.Btn_download);
            this.Controls.Add(this.Txt_url);
            this.Name = "Form1";
            this.Text = "JJ 3D Image Helper V1.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_url;
        private System.Windows.Forms.Button Btn_download;
        private System.Windows.Forms.RichTextBox Txt_output;
        private System.Windows.Forms.CheckBox Chk_subfolder;
        private System.Windows.Forms.CheckBox Chk_AutoOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_count;
        private System.Windows.Forms.CheckBox Chk_skipUnknown;
        private System.Windows.Forms.Button Btn_outputFolder;
    }
}
