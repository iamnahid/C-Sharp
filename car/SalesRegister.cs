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
    public partial class SalesRegister : Form
    {
        public SalesRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Sales_Register st = new Sales_Register();
            st.Date = Convert.ToDateTime(textBox1.Text);
            st.Type_of_Vehicle = textBox2.Text;
            st.Model = textBox3.Text;
            st.Sales_Unit = int.Parse(textBox4.Text);
            st.Sales_Amount = textBox5.Text;
            sr.Sales_Registers.InsertOnSubmit(st);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Registers;
        }

        private void SalesRegister_Load(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = sr.Sales_Registers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Sales_Register st = new Sales_Register();
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Sales_Registers.Where(w => w.Serial_Number == s ).FirstOrDefault();
            sr.Sales_Registers.DeleteOnSubmit(query);
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Registers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext sr = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = sr.Sales_Registers.Where(x => x.Serial_Number == s).FirstOrDefault();
            query.Date = Convert.ToDateTime(textBox1.Text);
            query.Type_of_Vehicle = textBox2.Text;
            query.Model = textBox3.Text;
            query.Sales_Unit = int.Parse(textBox4.Text);
            query.Sales_Amount = textBox5.Text;
            sr.SubmitChanges();
            dataGridView1.DataSource = sr.Sales_Registers;
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

        private void adminbutton_Click(object sender, EventArgs e)
        {
            Asalesanddeals obj = new Asalesanddeals();
            this.Hide();
            obj.Show();
        }

    }
}
