using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Fitness
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }



        private void normalMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Member nm = new New_Member();
            nm.Show();
        }

        private void lbl_extraoption_Click(object sender, EventArgs e)
        {

        }



        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Search_Member nm = new Search_Member();
           nm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close this application. Confirm?","Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back","Welcome", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure want to Log Out?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                GymLoginForm nm = new GymLoginForm();
                nm.Show();
                this.Close();
            }
        }

        private void editMembersDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_members nm = new edit_members();
            nm.Show();
        }


    }


}
