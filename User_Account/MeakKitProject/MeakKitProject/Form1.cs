using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace MeakKitProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2_Login.Text = "로그인";
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (button2_Login.Text.Equals("로그인"))
            {
                Hide();
                Form5 frm = new Form5();
                frm.ShowDialog();

                if (UserDataManager.loginUser != null)
                {
                    if (UserDataManager.isAdmin == false)
                        (sender as Button).Text = "로그아웃";
                }
                Show();
            }
            else
            {
                string ID = UserDataManager.loginUser.ID;
                string PW = UserDataManager.loginUser.Password;

                UserDataManager.loginUser = null;
                (sender as Button).Text = "로그인";
                LoginLogoutButtonCheck(ID, PW, "로그아웃");
            }
        }

        public void LoginLogoutButtonCheck(string id, string pw, string txt)
        {
            UserDataManager.Save(id, pw, txt);
        }

        private void MyPageButton_Click(object sender, EventArgs e)
        {

            if (button2_Login.Text.Equals("로그아웃"))
            {
                Hide();
                Form4 frm = new Form4();
                frm.ShowDialog();
                if (Form6.withdrowCheck == true)
                    button2_Login.Text = "로그인";
            }
            else
                MessageBox.Show("로그인을 해주세요.");
            Show();
        }
    }
}
