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
    public partial class Acontrol : Form
    {
        public Acontrol()
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
            MydatabaseDataContext admin = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
             Login lg= new Login();
            lg.Password = textBox1.Text;
            lg.Position = textBox2.Text;
            admin.Logins.InsertOnSubmit(lg);
            admin.SubmitChanges();
            dataGridView1.DataSource = admin.Logins;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext admin = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int lg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = admin.Logins.Where(w => w.Id == lg).FirstOrDefault();
            admin.Logins.DeleteOnSubmit(query);
            admin.SubmitChanges();
            dataGridView1.DataSource = admin.Logins;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext admin = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            int lg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var query = admin.Logins.Where(w => w.Id == lg).FirstOrDefault();
            query.Password= textBox1.Text;
            query.Position = textBox2.Text;
            admin.SubmitChanges();
            dataGridView1.DataSource = admin.Logins;
        }

        private void Acontrol_Load(object sender, EventArgs e)
        {
            MydatabaseDataContext admin = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            dataGridView1.DataSource = admin.Logins;
        }
    }
}
