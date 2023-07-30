namespace WorkshopDownloader
{
    partial class Main
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
            Download = new Button();
            Format = new Button();
            tb_PID = new TextBox();
            fIds = new ListBox();
            links_TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Download
            // 
            Download.Location = new Point(394, 63);
            Download.Name = "Download";
            Download.Size = new Size(100, 56);
            Download.TabIndex = 0;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = true;
            Download.Click += Download_Click;
            // 
            // Format
            // 
            Format.Location = new Point(394, 125);
            Format.Name = "Format";
            Format.Size = new Size(100, 56);
            Format.TabIndex = 1;
            Format.Text = "Format";
            Format.UseVisualStyleBackColor = true;
            Format.Click += Format_Click;
            // 
            // tb_PID
            // 
            tb_PID.Location = new Point(394, 34);
            tb_PID.Name = "tb_PID";
            tb_PID.Size = new Size(100, 23);
            tb_PID.TabIndex = 3;
            tb_PID.TextChanged += tb_PID_TextChanged;
            // 
            // fIds
            // 
            fIds.FormattingEnabled = true;
            fIds.ItemHeight = 15;
            fIds.Location = new Point(204, 34);
            fIds.Name = "fIds";
            fIds.Size = new Size(165, 289);
            fIds.TabIndex = 4;
            // 
            // links_TB
            // 
            links_TB.Location = new Point(12, 34);
            links_TB.Multiline = true;
            links_TB.Name = "links_TB";
            links_TB.Size = new Size(162, 289);
            links_TB.TabIndex = 5;
            links_TB.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "AppID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 166);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 7;
            label2.Text = "->";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 11);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 8;
            label3.Text = "Workshop Link(s)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 11);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "Formatted IDs";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(links_TB);
            Controls.Add(fIds);
            Controls.Add(tb_PID);
            Controls.Add(Format);
            Controls.Add(Download);
            Name = "Main";
            Text = "Steam workshop downloader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Download;
        private Button Format;
        private TextBox tb_PID;
        private ListBox fIds;
        private TextBox links_TB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}