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
    public partial class UserManagement : Form
    {
        UsersClass user = new UsersClass();
        public int CurrentUserID;
        public UserManagement()
        {
            InitializeComponent();
        }
       
        
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            MessageForm m = new MessageForm();
            DataTable dt = new DataTable();
            dt = user.Search(txt_username.Text);

            if (txt_name.Text == "")
            {
                MessageBox.Show("please enter name!");
                return;
            }
            if (txt_family.Text == "")
            {
                MessageBox.Show("please enter family!");
                return;
            }
            if (cmb_position.SelectedIndex == -1&& cmb_position.Text=="")
            {
                MessageBox.Show("please select position!");
                return;
            }
            if (txt_username.Text == "")
            {
                MessageBox.Show("please enter username!");
                return;
            }


            if (txt_password.Text == "")
            {
                MessageBox.Show("please enter password!");
                return;
            }
            if (txt_repeatpassword.Text == "")
            {
                MessageBox.Show("please enter repeatpassword!");
                return;
            }
            if (txt_password.Text!=txt_repeatpassword.Text)
            {
                MessageBox.Show("please enter same password!");
                return;
            }
            if (dt != null)
            {
                MessageBox.Show("there is a user with  this username, so please change username");
                return;
            }
            else
            {
                user.Add(txt_name.Text, txt_family.Text, cmb_position.SelectedItem.ToString(), txt_username.Text,txt_password.Text);
                txt_name.Text = "";
                txt_family.Text = "";
                cmb_position.SelectedIndex = -1;
                txt_username.Text = "";
                txt_password.Text = "";
                txt_repeatpassword.Text = "";
                btn_refresh_Click(btn_refresh, EventArgs.Empty);
                return;
            }
            
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            grid_users.DataSource =user.Search();
            grid_users.ReadOnly = true;
            grid_users.ClearSelection();
            
           

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            if ((grid_users.Rows.Count == 0) || (grid_users.CurrentRow.Index == -1))
            {
                MessageBox.Show("did not select row");
                return;
            }
            //eeeeeeeee
            int cr = grid_users.CurrentRow.Index;
            if (cr >= 0)
            {
                 
                int id = (int)grid_users[0, cr].Value;
                int id2 = id;
                dt = user.Search(id);
               
                  
               
                if (dt.Rows.Count > 0 && txt_name.Text == "" && txt_family.Text == "" && cmb_position.SelectedIndex == -1 && cmb_position.Text == ""
                 && txt_username.Text == "" && txt_password.Text == "" && txt_repeatpassword.Text == "")
                {
                    txt_name.Text = dt.Rows[0]["name"].ToString();
                    txt_family.Text = dt.Rows[0]["family"].ToString();
                    cmb_position.Text = dt.Rows[0]["position"].ToString();
                    txt_username.Text = dt.Rows[0]["UserName"].ToString();
                    txt_password.Text = dt.Rows[0]["Password"].ToString();
                    txt_repeatpassword.Text = dt.Rows[0]["Password"].ToString();
                    return;

                }

                else if (txt_name.Text != "" && txt_family.Text != "" && cmb_position.SelectedIndex != -1 && cmb_position.Text != ""
                   && txt_username.Text != "" && txt_password.Text != "" && txt_repeatpassword.Text != "" && txt_password.Text == txt_repeatpassword.Text)
                {
                    DataTable dt2 = new DataTable();
                    dt2 = user.Search(txt_username.Text);
                    if (dt2 != null &&  id!=(int) dt2.Rows[0]["id"])
                    {
                        MessageBox.Show("there is a user with  this username, so please change username");
                        return;
                    }
                    else
                    {
                        user.Edit(id, txt_name.Text, txt_family.Text, cmb_position.SelectedItem.ToString(),
                                                txt_username.Text, txt_password.Text);

                        txt_name.Text = "";
                        txt_family.Text = "";
                        cmb_position.SelectedIndex = -1;
                        txt_username.Text = "";
                        txt_password.Text = "";
                        txt_repeatpassword.Text = "";
                        btn_refresh_Click(btn_refresh, EventArgs.Empty);
                        return;
                    }
                    

                }

            }
            if (txt_name.Text == "")
            {
                MessageBox.Show("please enter name!");
                return;
            }
            if (txt_family.Text == "")
            {
                MessageBox.Show("please enter family!");
                return;
            }
            if (cmb_position.SelectedIndex == -1 && cmb_position.Text == "")
            {
                MessageBox.Show("please select position!");
                return;
            }
            if (txt_username.Text == "")
            {
                MessageBox.Show("please enter username!");
                return;
            }


            if (txt_password.Text == "")
            {
                MessageBox.Show("please enter password!");
                return;
            }
            if (txt_repeatpassword.Text == "")
            {
                MessageBox.Show("please enter repeatpassword!");
                return;
            }
            if (txt_password.Text != txt_repeatpassword.Text)
            {
                MessageBox.Show("please enter same password!");
                return;
            }


            else
            {
                MessageBox.Show("this row was deleted please refresh table button");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if ((grid_users.Rows.Count == 0) || (grid_users.CurrentRow.Index == -1))
            {
                MessageBox.Show("did not select row");
                return;
            }
            int cr = grid_users.CurrentRow.Index;
            if (cr >= 0)
            {

                int id = (int)grid_users[0, cr].Value;
                dt = user.Search(id);
                if (dt.Rows.Count > 0)
                {
                   

                        DialogResult dr;
                        dr = MessageBox.Show("are you sure?", "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                        user.Delete(id);
                        txt_name.Text = "";
                        txt_family.Text = "";
                        cmb_position.SelectedIndex = -1;
                        txt_password.Text = "";
                        txt_username.Text = "";
                        txt_repeatpassword.Text = "";

                        btn_refresh_Click(btn_refresh, EventArgs.Empty);
                     
                        }
                        if (dr == DialogResult.No)
                        {

                            grid_users.Focus();
                        }
                   
                  
                    return;
                }//end count
                
            }//end cr
            else
            {
                MessageBox.Show("there is not this row");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            grid_users.DataSource = user.Search();
            
            grid_users.ReadOnly = true;
        }

        private void btn_messageform_Click(object sender, EventArgs e)
        {
            MessageForm m = new MessageForm();
            this.Hide();
            //m.MdiParent = LogIn.ActiveForm;
            m.Show();
        }

        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
        }
    }
}
