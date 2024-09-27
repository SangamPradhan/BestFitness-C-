using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Fitness
{
    public partial class GymLoginForm : Form
    {
        public GymLoginForm()
        {
            InitializeComponent();
        }


        private void btn_loginG_Click(object sender, EventArgs e)
        {
            string username = tbx_user_name.Text;
            string password = tbx_password.Text;

           

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!");

                // Open the next form
                Landing fm = new Landing();
                fm.Show();

                // Close the current login form
                this.Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Invalid username or password. Please try again."/*, MessageBoxButtons.OK, MessageBoxIcon.Error*/);
            }
        }

        private void btn_resetG_Click(object sender, EventArgs e)
        {
            tbx_user_name.Clear();
            tbx_password.Clear();
        }

      
    }
    
}
