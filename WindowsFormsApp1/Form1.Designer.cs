namespace WindowsFormsApp1
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
            this.bitrateTextBox = new System.Windows.Forms.TextBox();
            this.dbmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hevcOffBtn = new System.Windows.Forms.Button();
            this.hevcOnBtn = new System.Windows.Forms.Button();
            this.dbrOffBtn = new System.Windows.Forms.Button();
            this.dbrOnBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bitrateTextBox
            // 
            this.bitrateTextBox.Location = new System.Drawing.Point(318, 46);
            this.bitrateTextBox.Name = "bitrateTextBox";
            this.bitrateTextBox.Size = new System.Drawing.Size(100, 28);
            this.bitrateTextBox.TabIndex = 0;
            this.bitrateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.bitrateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.bitrateTextBox.Leave += new System.EventHandler(this.bitrateTextBox_Leave);
            // 
            // dbmTextBox
            // 
            this.dbmTextBox.Location = new System.Drawing.Point(318, 317);
            this.dbmTextBox.Name = "dbmTextBox";
            this.dbmTextBox.Size = new System.Drawing.Size(100, 28);
            this.dbmTextBox.TabIndex = 1;
            this.dbmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.dbmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.dbmTextBox.Leave += new System.EventHandler(this.dbmTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "bitrate (Mbps)";
            // 
            // hevcOffBtn
            // 
            this.hevcOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hevcOffBtn.Location = new System.Drawing.Point(188, 100);
            this.hevcOffBtn.Name = "hevcOffBtn";
            this.hevcOffBtn.Size = new System.Drawing.Size(109, 47);
            this.hevcOffBtn.TabIndex = 8;
            this.hevcOffBtn.Text = "HEVC off";
            this.hevcOffBtn.UseVisualStyleBackColor = true;
            this.hevcOffBtn.Click += new System.EventHandler(this.hevcOffBtn_Click);
            // 
            // hevcOnBtn
            // 
            this.hevcOnBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hevcOnBtn.Location = new System.Drawing.Point(313, 100);
            this.hevcOnBtn.Name = "hevcOnBtn";
            this.hevcOnBtn.Size = new System.Drawing.Size(109, 47);
            this.hevcOnBtn.TabIndex = 10;
            this.hevcOnBtn.Text = "HEVC on";
            this.hevcOnBtn.UseVisualStyleBackColor = true;
            this.hevcOnBtn.Click += new System.EventHandler(this.hevcOnBtn_Click);
            // 
            // dbrOffBtn
            // 
            this.dbrOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbrOffBtn.Location = new System.Drawing.Point(188, 166);
            this.dbrOffBtn.Name = "dbrOffBtn";
            this.dbrOffBtn.Size = new System.Drawing.Size(196, 47);
            this.dbrOffBtn.TabIndex = 11;
            this.dbrOffBtn.Text = "Dynamic Bitrate off";
            this.dbrOffBtn.UseVisualStyleBackColor = true;
            this.dbrOffBtn.Click += new System.EventHandler(this.dbrOffBtn_Click);
            // 
            // dbrOnBtn
            // 
            this.dbrOnBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbrOnBtn.Location = new System.Drawing.Point(188, 230);
            this.dbrOnBtn.Name = "dbrOnBtn";
            this.dbrOnBtn.Size = new System.Drawing.Size(196, 47);
            this.dbrOnBtn.TabIndex = 12;
            this.dbrOnBtn.Text = "Dynamic Bitrate on";
            this.dbrOnBtn.UseVisualStyleBackColor = true;
            this.dbrOnBtn.Click += new System.EventHandler(this.dbrOnBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dynamic Bitrate Max (Mbps)";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.Location = new System.Drawing.Point(27, 377);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(544, 90);
            this.restoreBtn.TabIndex = 14;
            this.restoreBtn.Text = "Restore All\r\n(delete BitrateMbps, HEVC, DBR, DBRMax registry keys)";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 523);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbrOnBtn);
            this.Controls.Add(this.dbrOffBtn);
            this.Controls.Add(this.hevcOnBtn);
            this.Controls.Add(this.hevcOffBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbmTextBox);
            this.Controls.Add(this.bitrateTextBox);
            this.Name = "Form1";
            this.Text = "Meta Quest Bitrate Registry Editor 0.1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bitrateTextBox;
        private System.Windows.Forms.TextBox dbmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hevcOffBtn;
        private System.Windows.Forms.Button hevcOnBtn;
        private System.Windows.Forms.Button dbrOffBtn;
        private System.Windows.Forms.Button dbrOnBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreBtn;
    }
}

