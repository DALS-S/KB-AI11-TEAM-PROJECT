namespace MeakKitProject
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
            this.button1_CreateAccount = new System.Windows.Forms.Button();
            this.button2_Login = new System.Windows.Forms.Button();
            this.button3_MyPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_CreateAccount
            // 
            this.button1_CreateAccount.Location = new System.Drawing.Point(421, 51);
            this.button1_CreateAccount.Name = "button1_CreateAccount";
            this.button1_CreateAccount.Size = new System.Drawing.Size(75, 23);
            this.button1_CreateAccount.TabIndex = 0;
            this.button1_CreateAccount.Text = "회원가입";
            this.button1_CreateAccount.UseVisualStyleBackColor = true;
            this.button1_CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // button2_Login
            // 
            this.button2_Login.Location = new System.Drawing.Point(521, 51);
            this.button2_Login.Name = "button2_Login";
            this.button2_Login.Size = new System.Drawing.Size(64, 23);
            this.button2_Login.TabIndex = 1;
            this.button2_Login.Text = "로그인";
            this.button2_Login.UseVisualStyleBackColor = true;
            this.button2_Login.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // button3_MyPage
            // 
            this.button3_MyPage.Location = new System.Drawing.Point(610, 51);
            this.button3_MyPage.Name = "button3_MyPage";
            this.button3_MyPage.Size = new System.Drawing.Size(75, 23);
            this.button3_MyPage.TabIndex = 2;
            this.button3_MyPage.Text = "마이페이지";
            this.button3_MyPage.UseVisualStyleBackColor = true;
            this.button3_MyPage.Click += new System.EventHandler(this.MyPageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3_MyPage);
            this.Controls.Add(this.button2_Login);
            this.Controls.Add(this.button1_CreateAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_CreateAccount;
        private System.Windows.Forms.Button button2_Login;
        private System.Windows.Forms.Button button3_MyPage;
    }
}

