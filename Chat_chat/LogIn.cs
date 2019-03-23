using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_CODie
{
    public partial class LogIn : Form
    {
       
        UserManagement u = new UserManagement();
        MessageForm m = new MessageForm();
        UsersClass user = new UsersClass();

        public int CurrentUserID;

        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
         
            u.MdiParent = this.ParentForm;
            this.Hide();
            u.Show();

        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MessagesClass ms = new MessagesClass();

            if (txt_UserName.Text=="")
            {
                MessageBox.Show("please enter UserName");
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("please enter UserName");
                return;
            }

            dt = user.Search(txt_UserName.Text, txt_Password.Text);
            if (dt!=null)
            {
                m.CurrentUserID = (int)dt.Rows[0]["id"];
                u.CurrentUserID = (int)dt.Rows[0]["id"];

                user.LogIn((int)dt.Rows[0]["id"]);///update online Status
                m.MdiParent = this.ParentForm;
                this.Hide();
                m.Show();
            }

            else
            {
                MessageBox.Show("UserName or Password is incorrect");
                return;
            }
               

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            MessageForm ms = new MessageForm();
            ms.timer1.Stop();
        }
    }
}
