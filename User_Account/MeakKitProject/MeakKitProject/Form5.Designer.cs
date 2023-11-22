namespace MeakKitProject
{
    partial class Form5
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
            this.PwLAbel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.textBox2_PW = new System.Windows.Forms.TextBox();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.Button2_Search_ID = new System.Windows.Forms.Button();
            this.Button3_Search_PW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PwLAbel
            // 
            this.PwLAbel.AutoSize = true;
            this.PwLAbel.Location = new System.Drawing.Point(55, 129);
            this.PwLAbel.Name = "PwLAbel";
            this.PwLAbel.Size = new System.Drawing.Size(53, 12);
            this.PwLAbel.TabIndex = 7;
            this.PwLAbel.Text = "비밀번호";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(55, 77);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 12);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "아이디";
            // 
            // textBox2_PW
            // 
            this.textBox2_PW.Location = new System.Drawing.Point(120, 120);
            this.textBox2_PW.Name = "textBox2_PW";
            this.textBox2_PW.Size = new System.Drawing.Size(205, 21);
            this.textBox2_PW.TabIndex = 5;
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(120, 74);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(205, 21);
            this.textBox1_ID.TabIndex = 4;
            // 
            // Button2_Search_ID
            // 
            this.Button2_Search_ID.Location = new System.Drawing.Point(130, 187);
            this.Button2_Search_ID.Name = "Button2_Search_ID";
            this.Button2_Search_ID.Size = new System.Drawing.Size(75, 23);
            this.Button2_Search_ID.TabIndex = 8;
            this.Button2_Search_ID.Text = "아이디찾기";
            this.Button2_Search_ID.UseVisualStyleBackColor = true;
            this.Button2_Search_ID.Click += new System.EventHandler(this.IDFoundButton_Click);
            // 
            // Button3_Search_PW
            // 
            this.Button3_Search_PW.Location = new System.Drawing.Point(231, 187);
            this.Button3_Search_PW.Name = "Button3_Search_PW";
            this.Button3_Search_PW.Size = new System.Drawing.Size(94, 23);
            this.Button3_Search_PW.TabIndex = 9;
            this.Button3_Search_PW.Text = "비밀번호 찾기";
            this.Button3_Search_PW.UseVisualStyleBackColor = true;
            this.Button3_Search_PW.Click += new System.EventHandler(this.PWFoundButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "로그인 페이지";
            // 
            // Button1_Login
            // 
            this.Button1_Login.Location = new System.Drawing.Point(348, 74);
            this.Button1_Login.Name = "Button1_Login";
            this.Button1_Login.Size = new System.Drawing.Size(83, 62);
            this.Button1_Login.TabIndex = 11;
            this.Button1_Login.Text = "로그인";
            this.Button1_Login.UseVisualStyleBackColor = true;
            this.Button1_Login.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button3_Search_PW);
            this.Controls.Add(this.Button2_Search_ID);
            this.Controls.Add(this.PwLAbel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.textBox2_PW);
            this.Controls.Add(this.textBox1_ID);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PwLAbel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox textBox2_PW;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.Button Button2_Search_ID;
        private System.Windows.Forms.Button Button3_Search_PW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button1_Login;
    }
}