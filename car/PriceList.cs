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
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            MydatabaseDataContext pl = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = pl.Price_Lists;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext pl = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Price_List p = new Price_List();
            p.Type_of_Vehicle = textBox1.Text;
            p.Model = textBox2.Text;
            p.Price = int.Parse(textBox3.Text);
            pl.Price_Lists.InsertOnSubmit(p);
            pl.SubmitChanges();
            dataGridView1.DataSource = pl.Price_Lists;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext pl = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int psn = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = pl.Price_Lists.Where(w => w.Serial_Number == psn).FirstOrDefault();
            pl.Price_Lists.DeleteOnSubmit(query);
            pl.SubmitChanges();
            dataGridView1.DataSource = pl.Price_Lists;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext pl = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int psn = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = pl.Price_Lists.Where(x => x.Serial_Number == psn).FirstOrDefault();
            query.Type_of_Vehicle = textBox1.Text;
            query.Model = textBox2.Text;
            query.Price = int.Parse(textBox3.Text);
            pl.SubmitChanges();
            dataGridView1.DataSource = pl.Price_Lists;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesandDeals obj = new SalesandDeals();
            this.Hide();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();
        }

        private void adminbackButton_Click(object sender, EventArgs e)
        {
            //AdminPanel obj = new AdminPanel();
            //this.Hide();
           // obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Asalesanddeals obj = new Asalesanddeals();
            this.Hide();
            obj.Show();
        }
    }
}
