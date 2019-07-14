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
    public partial class VehicleInventory : Form
    {
        public VehicleInventory()
        {
            InitializeComponent();
        }

        private void VehicleInventory_Load(object sender, EventArgs e)
        {
            MydatabaseDataContext str = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = str.Stock_Registers;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Stock_Register s = new Stock_Register();
            s.Date = Convert.ToDateTime(textBox1.Text);
            s.Type_of_Car = textBox2.Text;
            s.Model = textBox3.Text;
            s.Total_Num = int.Parse(textBox4.Text);
            s.Sales_Number = int.Parse(textBox5.Text);
            s.Current_Stock = int.Parse(textBox6.Text);
            sr.Stock_Registers.InsertOnSubmit(s);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Stock_Registers;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Stock_Registers.Where(x => x.Serial_Number == s).FirstOrDefault();
            sr.Stock_Registers.DeleteOnSubmit(query);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Stock_Registers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Stock_Registers.Where(x => x.Serial_Number == s).FirstOrDefault();
            query.Date = Convert.ToDateTime(textBox1.Text);
            query.Type_of_Car = textBox2.Text;
            query.Model = textBox3.Text;
            query.Total_Num = int.Parse(textBox4.Text);
            query.Sales_Number = int.Parse(textBox5.Text);
            query.Current_Stock = int.Parse(textBox6.Text);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Stock_Registers;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void backadminbutton_Click(object sender, EventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            this.Hide();
            obj.Show();
        }
    }
}
