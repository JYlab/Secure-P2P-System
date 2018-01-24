namespace Secure_P2P_project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FileSend = new System.Windows.Forms.Button();
            this.FileFind = new System.Windows.Forms.Button();
            this.shieldIMG = new System.Windows.Forms.PictureBox();
            this.configIMG = new System.Windows.Forms.PictureBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ConnectCheck = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Scanner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shieldIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileSend
            // 
            this.FileSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileSend.BackgroundImage")));
            this.FileSend.FlatAppearance.BorderSize = 0;
            this.FileSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileSend.Location = new System.Drawing.Point(67, 13);
            this.FileSend.Name = "FileSend";
            this.FileSend.Size = new System.Drawing.Size(34, 36);
            this.FileSend.TabIndex = 4;
            this.FileSend.UseVisualStyleBackColor = true;
            this.FileSend.Click += new System.EventHandler(this.FileSend_Click);
            this.FileSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileSend_MouseDown_1);
            this.FileSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileSend_MouseUp);
            // 
            // FileFind
            // 
            this.FileFind.BackColor = System.Drawing.SystemColors.Window;
            this.FileFind.BackgroundImage = global::Secure_P2P_project.Properties.Resources.FindFile;
            this.FileFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FileFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FileFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FileFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileFind.Location = new System.Drawing.Point(25, 15);
            this.FileFind.Name = "FileFind";
            this.FileFind.Size = new System.Drawing.Size(40, 33);
            this.FileFind.TabIndex = 3;
            this.FileFind.UseVisualStyleBackColor = false;
            this.FileFind.Click += new System.EventHandler(this.FileFind_Click);
            // 
            // shieldIMG
            // 
            this.shieldIMG.BackgroundImage = global::Secure_P2P_project.Properties.Resources.shiled0;
            this.shieldIMG.Location = new System.Drawing.Point(107, 16);
            this.shieldIMG.Name = "shieldIMG";
            this.shieldIMG.Size = new System.Drawing.Size(32, 33);
            this.shieldIMG.TabIndex = 2;
            this.shieldIMG.TabStop = false;
            this.shieldIMG.Click += new System.EventHandler(this.shieldIMG_Click);
            this.shieldIMG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.shieldIMG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // configIMG
            // 
            this.configIMG.BackColor = System.Drawing.SystemColors.Window;
            this.configIMG.BackgroundImage = global::Secure_P2P_project.Properties.Resources._0;
            this.configIMG.Location = new System.Drawing.Point(145, 16);
            this.configIMG.Name = "configIMG";
            this.configIMG.Size = new System.Drawing.Size(32, 33);
            this.configIMG.TabIndex = 1;
            this.configIMG.TabStop = false;
            this.configIMG.Click += new System.EventHandler(this.configIMG_Click);
            this.configIMG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.configIMG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.configIMG_MouseUp);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConnectBtn.Location = new System.Drawing.Point(285, 22);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ConnectCheck
            // 
            this.ConnectCheck.AutoSize = true;
            this.ConnectCheck.Location = new System.Drawing.Point(563, 27);
            this.ConnectCheck.Name = "ConnectCheck";
            this.ConnectCheck.Size = new System.Drawing.Size(68, 12);
            this.ConnectCheck.TabIndex = 6;
            this.ConnectCheck.Text = "Disconnect";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Scanner,
            this.Result,
            this.Malware});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(285, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(346, 268);
            this.dataGridView1.TabIndex = 7;
            // 
            // Scanner
            // 
            this.Scanner.HeaderText = "Scanner";
            this.Scanner.Name = "Scanner";
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // Malware
            // 
            this.Malware.HeaderText = "Malware";
            this.Malware.Name = "Malware";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(245, 268);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(643, 340);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConnectCheck);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.FileSend);
            this.Controls.Add(this.FileFind);
            this.Controls.Add(this.shieldIMG);
            this.Controls.Add(this.configIMG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shieldIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox configIMG;
        private System.Windows.Forms.PictureBox shieldIMG;
        private System.Windows.Forms.Button FileFind;
        private System.Windows.Forms.Button FileSend;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ConnectCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scanner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malware;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

