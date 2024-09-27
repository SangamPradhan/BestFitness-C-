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
    public partial class New_Member : Form
    {
        public New_Member()
        {
            InitializeComponent();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {       
            
                if (tb_phone.Text.Length == 10)
                {
                    string Name = tb_name.Text;
                    string Address = tb_address.Text;
                    long phone;

                    if (long.TryParse(tb_phone.Text, out phone))
                    {
                        string Gender = "";
                        Boolean isMaleChecked = rbtn_male.Checked;
                        Boolean isFemaleChecked = rbtn_female.Checked;

                        if (isMaleChecked)
                        {
                            Gender = rbtn_male.Text;
                        }
                        else if (isFemaleChecked)
                        {
                            Gender = rbtn_female.Text;
                        }
                        else
                        {
                            Gender = rbtn_xakka.Text;
                        }

                        string Membership_Plan = cbx_plan.Text;
                        string Date_of_Join = dateTimePicker1.Text;

                        int CurrentWeight = int.Parse(tb_currentweight.Text);
                        int TargetWeight = int.Parse(tb_targetweight.Text);
                        int Sauna = int.Parse(cbx_sauna.Text);
                        int Swimming = int.Parse(cbx_swimming.Text);
                        int PrivateCoaching = int.Parse(tb_privatecoaching.Text);

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "insert into new_member(Name,Address,phone,Gender,Membership_Plan,Date_of_Join,CurrentWeight,TargetWeight,Sauna,PrivateCoaching,Swimming) values ('" + Name + "','" + Address + "'," + phone + ",'" + Gender + "','" + Membership_Plan + "','" + Date_of_Join + "'," + CurrentWeight + "," + TargetWeight + ",'" + Sauna + "'," + PrivateCoaching + ",'" + Swimming + "')";
                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);
                        MessageBox.Show("Data Saved.");

                        tb_name.Clear();
                        tb_address.Clear();
                        tb_currentweight.Clear();
                        tb_targetweight.Clear();
                        tb_phone.Clear();
                        tb_privatecoaching.Clear();
                        cbx_plan.ResetText();
                        cbx_sauna.ResetText();
                        dateTimePicker1.ResetText();
                        cbx_swimming.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number format. Please enter a 10-digit number.");
                    }
                }
            else 
            {
                MessageBox.Show("Invalid phone number format. Please enter a 10-digit number.");
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_address.Clear();
            tb_currentweight.Clear();
            tb_targetweight.Clear();
            tb_phone.Clear();
            tb_privatecoaching.Clear();
            cbx_plan.ResetText();
            cbx_sauna.ResetText();
            dateTimePicker1.ResetText(); 

        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter Digits only.");
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) /*&& !char.IsControl(e.KeyChar)*/)
            {
                e.Handled = true;
                MessageBox.Show("Please enter Letters only.");
            }

        }

        private void tb_currentweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sorry, but Weight are just Digits.");
            }
        }

        private void tb_targetweight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sorry, but Weight are just Digits.");
            }
        }

        private void tb_privatecoaching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Cannot enter! Coaching hours should be Digits.");
            }
        }
    }
}
