using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeakKitProject
{
    public partial class Form6 : Form
    {
        public static bool withdrowCheck=false;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Yes_Click(object sender, EventArgs e)
        {
            string userID = UserDataManager.loginUser.ID;
            UserInformation user = new UserInformation();
            user.ID = userID;
            UserDataManager.WithdrowUser(userID);
            MessageBox.Show("저희 프로그램을 이용해주셔서 감사합니다.");
            withdrowCheck = true;
            Close();
        }
        
        private void button2_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
