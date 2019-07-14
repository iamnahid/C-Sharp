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
    public partial class SalesandDeals : Form
    {
        public SalesandDeals()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SuperAdmin obj = new SuperAdmin();
            this.Hide();
            obj.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PriceList obj = new PriceList();
            obj.adminbackbutton.Hide();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesReport obj = new SalesReport();
            obj.adminbackbutton.Hide();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesRegister obj = new SalesRegister();
            obj.adminbutton.Hide();
            this.Hide();
            obj.Show();
        }
    }
}
