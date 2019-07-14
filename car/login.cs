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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MydatabaseDataContext lg = new MydatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lenovo\Documents\Visual Studio 2012\Projects\car\car\login.mdf;Integrated Security=True");
            Login l = new Login();
            var query = from login in lg.Logins
                        where login.Id == int.Parse(textBox1.Text) && login.Password == textBox2.Text && login.Position == comboBox1.SelectedItem.ToString()
                        select login;
            Employee_list el = new Employee_list();
            var query2 = from Employee_list in lg.Employee_lists
                         where Employee_list.Id == int.Parse(textBox1.Text) && Employee_list.Password == textBox2.Text && Employee_list.Position == comboBox1.SelectedItem.ToString()
                         select Employee_list;
            if (query.Any())
            {
                if (comboBox1.Text == "Super Admin")
                {
                    SuperAdmin obj = new SuperAdmin();
                    this.Hide();
                    obj.Show();
                }

                else if (comboBox1.Text == "Admin")
                {
                    AdminPanel obj = new AdminPanel();
                    //obj.button2.Hide();
                    this.Hide();
                    obj.Show();
                }
               
              
             }

            else if (query2.Any())
            {
                SalesReport obj = new SalesReport();
                obj.sadminbutton.Hide();
                this.Hide();
                obj.Show();
            }


            else
            {
                MessageBox.Show("Sorry! Your id or password or position is incorrect.Try again");
            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
