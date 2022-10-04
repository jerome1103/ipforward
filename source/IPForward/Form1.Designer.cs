namespace IPForward
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portproxy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guide_labe_title = new System.Windows.Forms.Label();
            this.guide_labe_sub = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.startgame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loopbackAdapter_button = new System.Windows.Forms.Button();
            this.NIC_labe_title = new System.Windows.Forms.Label();
            this.NIC_labe_sub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portproxy
            // 
            this.portproxy.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.portproxy.Location = new System.Drawing.Point(27, 144);
            this.portproxy.Name = "portproxy";
            this.portproxy.Size = new System.Drawing.Size(300, 30);
            this.portproxy.TabIndex = 1;
            this.portproxy.Text = "端口映射";
            this.portproxy.UseVisualStyleBackColor = true;
            this.portproxy.Click += new System.EventHandler(this.portproxy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author by Jerome";
            // 
            // guide_labe_title
            // 
            this.guide_labe_title.AutoSize = true;
            this.guide_labe_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guide_labe_title.Location = new System.Drawing.Point(23, 86);
            this.guide_labe_title.Name = "guide_labe_title";
            this.guide_labe_title.Size = new System.Drawing.Size(90, 21);
            this.guide_labe_title.TabIndex = 4;
            this.guide_labe_title.Text = "導向狀態：";
            // 
            // guide_labe_sub
            // 
            this.guide_labe_sub.AutoSize = true;
            this.guide_labe_sub.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guide_labe_sub.Location = new System.Drawing.Point(103, 85);
            this.guide_labe_sub.Name = "guide_labe_sub";
            this.guide_labe_sub.Size = new System.Drawing.Size(24, 21);
            this.guide_labe_sub.TabIndex = 5;
            this.guide_labe_sub.Text = "--";
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(386, 69);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 22);
            this.username.TabIndex = 6;
            // 
            // password
            // 
            this.password.Enabled = false;
            this.password.Location = new System.Drawing.Point(386, 97);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 22);
            this.password.TabIndex = 7;
            // 
            // login
            // 
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(386, 125);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(181, 23);
            this.login.TabIndex = 8;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(386, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "註冊";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // startgame
            // 
            this.startgame.Location = new System.Drawing.Point(386, 40);
            this.startgame.Name = "startgame";
            this.startgame.Size = new System.Drawing.Size(181, 23);
            this.startgame.TabIndex = 10;
            this.startgame.Text = "啟動遊戲";
            this.startgame.UseVisualStyleBackColor = true;
            this.startgame.Click += new System.EventHandler(this.startgame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "請使用系統管理員身分執行";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "版本:1.2.0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loopbackAdapter_button
            // 
            this.loopbackAdapter_button.Enabled = false;
            this.loopbackAdapter_button.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loopbackAdapter_button.Location = new System.Drawing.Point(27, 37);
            this.loopbackAdapter_button.Name = "loopbackAdapter_button";
            this.loopbackAdapter_button.Size = new System.Drawing.Size(300, 30);
            this.loopbackAdapter_button.TabIndex = 13;
            this.loopbackAdapter_button.Text = "環迴網卡";
            this.loopbackAdapter_button.UseVisualStyleBackColor = true;
            this.loopbackAdapter_button.Click += new System.EventHandler(this.loopbackAdapter_button_Click);
            // 
            // NIC_labe_title
            // 
            this.NIC_labe_title.AutoSize = true;
            this.NIC_labe_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NIC_labe_title.Location = new System.Drawing.Point(23, 6);
            this.NIC_labe_title.Name = "NIC_labe_title";
            this.NIC_labe_title.Size = new System.Drawing.Size(90, 21);
            this.NIC_labe_title.TabIndex = 14;
            this.NIC_labe_title.Text = "網卡狀態：";
            // 
            // NIC_labe_sub
            // 
            this.NIC_labe_sub.AutoSize = true;
            this.NIC_labe_sub.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NIC_labe_sub.Location = new System.Drawing.Point(103, 6);
            this.NIC_labe_sub.Name = "NIC_labe_sub";
            this.NIC_labe_sub.Size = new System.Drawing.Size(24, 21);
            this.NIC_labe_sub.TabIndex = 15;
            this.NIC_labe_sub.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(365, 211);
            this.Controls.Add(this.NIC_labe_sub);
            this.Controls.Add(this.NIC_labe_title);
            this.Controls.Add(this.loopbackAdapter_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startgame);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.guide_labe_sub);
            this.Controls.Add(this.guide_labe_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.portproxy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IPForward";
            this.Load += new System.EventHandler(this.first_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button portproxy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guide_labe_title;
        private System.Windows.Forms.Label guide_labe_sub;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button startgame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loopbackAdapter_button;
        private System.Windows.Forms.Label NIC_labe_title;
        private System.Windows.Forms.Label NIC_labe_sub;
    }
}

