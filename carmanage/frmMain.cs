using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace carmanage
{
    public partial class mainFrm : Form
    {
        MySqlDataReader cartest;
        MySqlDataReader carforce;
        MySqlDataReader carcom;
        
        public mainFrm()
        {
            InitializeComponent();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            //

            this.Text = "车保宝-" + Program.orgname;

            
            MySqlParameter my = new MySqlParameter("@oid", Program.orgid);
           
            MySqlParameter[] myo = { my};

          //读取记录

            carforce = MySqlHelper.ExecuteReader(Properties.Settings.Default.localhost, @"SELECT   cars.carplate, testrec.exdate, forceins.enddate, comins.amount, comins.enddate
FROM      cars INNER JOIN
                owners ON cars.owners_idowners = owners.idowners INNER JOIN
                orgs ON owners.orgs_idorgs = orgs.idorgs INNER JOIN
                testrec ON cars.idcars = testrec.cars_idcars LEFT OUTER JOIN
                comins ON cars.idcars = comins.cars_idcars LEFT OUTER JOIN
                forceins ON cars.idcars = forceins.cars_idcars
WHERE   (orgs.idorgs = @oid)", myo);


            while (carforce.Read())
            {
                Object[] values = new Object[ carforce.FieldCount];
                carforce.GetValues(values);
                string[] row = new string[8];
                int i = 0;
                foreach (Object v in values)
                {
                    row[i] = v.ToString();
                    if (i == 1|| i==3 || i==6)
                    {
                        if(v!=null)
                        {
                        DateTime tt = ((DateTime)v);
                        DateTime today = DateTime.Today;
                        TimeSpan ts = tt - today;
                        row[i + 1] = ts.Days.ToString(); 
                        }
                        i++;
                    }
                    i++;
                }

                testgrid.Rows.Add(row);
            }



        }

            private void mainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.OpenForms[0].Show();
            
           
        }


    }
}