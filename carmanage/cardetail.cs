using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carmanage
{
    public partial class cardetail : Form
    {
        public string carplate;

        public cardetail()
        {
            InitializeComponent();
        }

        private void cardetail_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hti0ppaxriDataSet.cars”中。您可以根据需要移动或删除它。
            this.carsTableAdapter.Fill(this.hti0ppaxriDataSet.cars);
            Console.WriteLine(carplate);
        }

        private void carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hti0ppaxriDataSet);

        }
    }
}
