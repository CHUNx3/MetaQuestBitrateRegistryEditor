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
            this.label2 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.aswOffBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hevcBtn = new System.Windows.Forms.Button();
            this.dbrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.perfHudOffBtn = new System.Windows.Forms.Button();
            this.perfHudOnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bitrateTextBox
            // 
            this.bitrateTextBox.Location = new System.Drawing.Point(338, 44);
            this.bitrateTextBox.Name = "bitrateTextBox";
            this.bitrateTextBox.Size = new System.Drawing.Size(80, 28);
            this.bitrateTextBox.TabIndex = 0;
            this.bitrateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.bitrateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.bitrateTextBox.Leave += new System.EventHandler(this.bitrateTextBox_Leave);
            // 
            // dbmTextBox
            // 
            this.dbmTextBox.Location = new System.Drawing.Point(338, 205);
            this.dbmTextBox.Name = "dbmTextBox";
            this.dbmTextBox.Size = new System.Drawing.Size(80, 28);
            this.dbmTextBox.TabIndex = 1;
            this.dbmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.dbmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.dbmTextBox.Leave += new System.EventHandler(this.dbmTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "bitrate (Mbps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(73, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dynamic Bitrate Max (Mbps)";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.Location = new System.Drawing.Point(22, 416);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(544, 90);
            this.restoreBtn.TabIndex = 14;
            this.restoreBtn.Text = "Restore All\r\n(delete BitrateMbps, HEVC, DBR, DBRMax registry values)";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // aswOffBtn
            // 
            this.aswOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aswOffBtn.Location = new System.Drawing.Point(185, 341);
            this.aswOffBtn.Name = "aswOffBtn";
            this.aswOffBtn.Size = new System.Drawing.Size(230, 47);
            this.aswOffBtn.TabIndex = 15;
            this.aswOffBtn.Text = "ASW off";
            this.aswOffBtn.UseVisualStyleBackColor = true;
            this.aswOffBtn.Click += new System.EventHandler(this.aswOffBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "HEVC";
            // 
            // hevcBtn
            // 
            this.hevcBtn.BackColor = System.Drawing.Color.Transparent;
            this.hevcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hevcBtn.FlatAppearance.BorderSize = 0;
            this.hevcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hevcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hevcBtn.Location = new System.Drawing.Point(352, 90);
            this.hevcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.hevcBtn.Name = "hevcBtn";
            this.hevcBtn.Size = new System.Drawing.Size(74, 46);
            this.hevcBtn.TabIndex = 8;
            this.hevcBtn.UseVisualStyleBackColor = false;
            this.hevcBtn.Click += new System.EventHandler(this.hevcBtn_Click);
            // 
            // dbrBtn
            // 
            this.dbrBtn.BackColor = System.Drawing.Color.Transparent;
            this.dbrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbrBtn.FlatAppearance.BorderSize = 0;
            this.dbrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbrBtn.Location = new System.Drawing.Point(352, 139);
            this.dbrBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dbrBtn.Name = "dbrBtn";
            this.dbrBtn.Size = new System.Drawing.Size(74, 46);
            this.dbrBtn.TabIndex = 17;
            this.dbrBtn.UseVisualStyleBackColor = false;
            this.dbrBtn.Click += new System.EventHandler(this.dbrBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dynamic Bitrate";
            // 
            // perfHudOffBtn
            // 
            this.perfHudOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfHudOffBtn.Location = new System.Drawing.Point(143, 265);
            this.perfHudOffBtn.Name = "perfHudOffBtn";
            this.perfHudOffBtn.Size = new System.Drawing.Size(145, 47);
            this.perfHudOffBtn.TabIndex = 19;
            this.perfHudOffBtn.Text = "Perf HUD off";
            this.perfHudOffBtn.UseVisualStyleBackColor = true;
            this.perfHudOffBtn.Click += new System.EventHandler(this.perfHudOffBtn_Click);
            // 
            // perfHudOnBtn
            // 
            this.perfHudOnBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfHudOnBtn.Location = new System.Drawing.Point(308, 265);
            this.perfHudOnBtn.Name = "perfHudOnBtn";
            this.perfHudOnBtn.Size = new System.Drawing.Size(145, 47);
            this.perfHudOnBtn.TabIndex = 20;
            this.perfHudOnBtn.Text = "Perf HUD on";
            this.perfHudOnBtn.UseVisualStyleBackColor = true;
            this.perfHudOnBtn.Click += new System.EventHandler(this.perfHudOnBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 551);
            this.Controls.Add(this.perfHudOnBtn);
            this.Controls.Add(this.perfHudOffBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbrBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aswOffBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hevcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbmTextBox);
            this.Controls.Add(this.bitrateTextBox);
            this.Name = "Form1";
            this.Text = "Meta Quest Bitrate Registry Editor 0.2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bitrateTextBox;
        private System.Windows.Forms.TextBox dbmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hevcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Button aswOffBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dbrBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button perfHudOffBtn;
        private System.Windows.Forms.Button perfHudOnBtn;
    }
}

