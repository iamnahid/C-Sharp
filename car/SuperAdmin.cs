using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesandDeals obj = new SalesandDeals();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VehicleInventory obj = new VehicleInventory();
            obj.backadminbutton.Hide();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acontrol obj = new Acontrol();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employeepro obj = new Employeepro();
            obj.backadminbutton.Hide();
            this.Hide();
            obj.Show();
        }

        private void SuperAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
