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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Sales_Report s = new Sales_Report();
            s.Date = Convert.ToDateTime(textBox1.Text);
            s.Type_of_Vehicle = textBox2.Text;
            s.Model = textBox3.Text;
            s.Custoer_Name = textBox4.Text;
            s.Customer_Address = richTextBox1.Text;
            s.Customer_Phone_Number = int.Parse(textBox5.Text);
            s.Sales_Vlue = int.Parse(textBox6.Text);
            s.Money_Receipt_Number = textBox7.Text;
            s.Delivery_Number = textBox8.Text;
            s.Body_Number = textBox9.Text;
            s.Engine_Number = textBox10.Text;
            s.Employee_Id = int.Parse(textBox11.Text);
            sr.Sales_Reports.InsertOnSubmit(s);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Reports;
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {

            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = sr.Sales_Reports;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Sales_Reports.Where(x => x.Serial_Number == s).FirstOrDefault();
            sr.Sales_Reports.DeleteOnSubmit(query);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Reports;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Sales_Reports.Where(x => x.Serial_Number == s).FirstOrDefault();
            query.Type_of_Vehicle = textBox2.Text;
            query.Model = textBox3.Text;
            query.Custoer_Name = textBox4.Text;
            query.Customer_Address = richTextBox1.Text;
            query.Customer_Phone_Number = int.Parse(textBox5.Text);
            query.Sales_Vlue = int.Parse(textBox6.Text);
            query.Money_Receipt_Number = textBox7.Text;
            query.Delivery_Number = textBox8.Text;
            query.Body_Number = textBox9.Text;
            query.Engine_Number = textBox10.Text;
            query.Employee_Id = int.Parse(textBox11.Text);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Reports;
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

        private void adminbackbutton_Click(object sender, EventArgs e)
        {
            Asalesanddeals obj = new Asalesanddeals();
            this.Hide();
            obj.Show();
        }
    }
}
