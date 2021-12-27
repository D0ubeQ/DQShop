using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Model;

namespace Dashboard
{
    public partial class LoginFisrt : Form
    {
        private UserInfoManager userInfoManager;
        public LoginFisrt()
        {
            InitializeComponent();
            userInfoManager = new UserInfoManager();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserInfo user = userInfoManager.GetByUserName(txtUsername.Text.Trim());
            string msg = "";
            Int16 choose = 0;
            if (useRaBtn.Checked)
            {
                msg = useRaBtn.Text;
            }
            else if (MerRaBtn.Checked)
            {
                msg = MerRaBtn.Text;
                choose = 1;
            }
            if (user == null)
            {
                MessageBox.Show("用户名不存在");
                return;
            }
            if (user.UserPass.Trim() != txtUserpass.Text.Trim())
            {
                MessageBox.Show("密码错误");
                return;
            }
            if (user.UserType.Trim() != choose.ToString())
            {
                MessageBox.Show("请重新选择你的身份");
                return;
            }
            MessageBox.Show( msg, "你好，欢迎登录");
        }
    }
    }
}
