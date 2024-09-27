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
    public partial class Athelete : Form
    {
        public Athelete()
        {
            InitializeComponent();
        }

        private void Athelete_Load(object sender, EventArgs e)
        {

        }

        private void cbx_plan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveA_Click(object sender, EventArgs e)
        {
            string Name = tb_nameA.Text;
            string Address = tb_addressA.Text;
            int phone = int.Parse(tb_phoneA.Text);
            string Gender = "";
            Boolean ischecked = rbtn_maleA.Checked;

            if (ischecked)
            {
                Gender = rbtn_maleA.Text;
            }
            else
            {
                Gender = rbtn_femaleA.Text;
            }
            string Membership_Plan = cbx_planA.Text;
            string Date_of_Join = dateTimePickerA.Text;

            string Sauna = cbx_saunaA.Text;
            int PrivateCoaching = int.Parse(tb_privatecoachingA.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into new_member(Name,Address,phone,Gender,Membership_Plan,Date_of_Join,Sauna,PrivateCoaching) values ('" + Name + "','" + Address + "'," + phone + ",'" + Gender + "','" + Membership_Plan + "','" + Date_of_Join + "','" + Sauna + "'," + PrivateCoaching + ")";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved.");

            tb_nameA.Clear();
            tb_addressA.Clear();
            tb_phoneA.Clear();
            tb_privatecoachingA.Clear();
            cbx_planA.ResetText();
            cbx_saunaA.ResetText();
            dateTimePickerA.ResetText();
        }

        private void btn_resetA_Click(object sender, EventArgs e)
        {
            tb_nameA.Clear();
            tb_addressA.Clear();
            
            tb_phoneA.Clear();
            tb_privatecoachingA.Clear();
            cbx_planA.ResetText();
            cbx_saunaA.ResetText();
            dateTimePickerA.ResetText();
        }
    }
}
