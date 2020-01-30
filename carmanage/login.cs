using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace carmanage
{

    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ur = txtUsername.Text;
            string pwd = txtPassword.Text;
            MySqlParameter my = new MySqlParameter("@usr",ur);
            MySqlParameter my1 = new MySqlParameter("@pwd", pwd);
            MySqlParameter[] myo = { my, my1 };
            
            MySqlDataReader o =  MySqlHelper.ExecuteReader(Properties.Settings.Default.localhost, @"SELECT   sysusers.* ,people.*,orgs.* FROM sysusers INNER JOIN
                people ON sysusers.people_idpeople = people.idpeople INNER JOIN
                orgs ON people.orgs_idorgs = orgs.idorgs
                WHERE(sysusers.username = @usr) AND(sysusers.password =@pwd)",myo);


                if (o.HasRows) {
                    Object[] values = new Object[o.FieldCount];
                     o.Read();
                    o.GetValues(values);
                    Console.WriteLine("yes");
                    Program.username = o.GetString("username");
                    Program.orgid = o.GetInt32("idorgs");
                    Program.orgname = o.GetString("name");
                    this.Hide();
                    new mainFrm().Show();
                }
                else
                {
                    o.Close();
                            
                 o = MySqlHelper.ExecuteReader(Properties.Settings.Default.localhost, @"SELECT   sysusers.* from sysusers
                WHERE(sysusers.username = @usr) AND(sysusers.password =@pwd)", myo);
                if (o.HasRows) {
                        Object[] values = new Object[o.FieldCount];
                        o.Read();
                        o.GetValues(values);
                        Console.WriteLine("yes");
                        Program.username = o.GetString("username");
                        Program.orgid = 0; //SYS ORG ID=0
                        Program.orgname = "系统";
                        this.Hide();
                        new admin().Show();
                    }
                }       
            
           // }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
