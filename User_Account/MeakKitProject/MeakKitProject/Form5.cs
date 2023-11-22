using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MeakKitProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(textBox1_ID.Text.Trim()=="")
                MessageBox.Show("ID를 입력하세요.");
            else if(textBox2_PW.Text.Trim()=="")
                MessageBox.Show("비밀번호를 입력하세요.");
            else
            {
                try
                {
                    string contents = "";
                    UserInformation user = new UserInformation();
                    user.ID = textBox1_ID.Text;
                    user.Password=textBox2_PW.Text;
                    user.CurrentState = "로그인";
                    UserDataManager.Save(textBox1_ID.Text, textBox2_PW.Text, "로그인", out contents);
                    writeLog(contents);
                    Close();
                }
                catch (Exception) { }
            }            
        }

        public void writeLog(string contents)
        {
            string log =
                $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]";
            log += contents;
            UserDataManager.CurrentStateLog(log);            
        }

        private void IDFoundButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void PWFoundButton_Click(object sender, EventArgs e)
        {

        }
    }
}
