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
    public partial class Employeepro : Form
    {
        public Employeepro()
        {
            InitializeComponent();
        }

        private void Employeepro_Load(object sender, EventArgs e)
        {
            MydatabaseDataContext emp = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = emp.Employee_lists;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext emp = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Employee_list em = new Employee_list();
            em.Name = textBox1.Text;
            em.Address = richTextBox1.Text;
            em.Email = textBox2.Text;
            em.Phone_No_ = int.Parse(textBox3.Text);
            em.Position = textBox4.Text;
            em.Password = textBox5.Text; 
            emp.Employee_lists.InsertOnSubmit(em);
            emp.SubmitChanges();
            dataGridView1.DataSource = emp.Employee_lists;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext emp = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int empl = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = emp.Employee_lists.Where(w => w.Id == empl).FirstOrDefault();
            emp.Employee_lists.DeleteOnSubmit(query);
            emp.SubmitChanges();
            dataGridView1.DataSource = emp.Employee_lists;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext emp = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int empl = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = emp.Employee_lists.Where(w => w.Id == empl).FirstOrDefault();
            query.Name = textBox1.Text;
            query.Address = richTextBox1.Text;
            query.Email = textBox2.Text;
            query.Phone_No_ = int.Parse(textBox3.Text);
            query.Position = textBox4.Text;
            query.Password = textBox5.Text;
            emp.SubmitChanges();
            dataGridView1.DataSource = emp.Employee_lists;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
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

        private void backadminbutton_Click(object sender, EventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            this.Hide();
            obj.Show();
        }
    }
}
