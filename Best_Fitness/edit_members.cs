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
    public partial class edit_members : Form
    {
        public edit_members()
        {
            InitializeComponent();
        }

        private void tb_hourE_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            /*string phone = tb_phoneES.Text;

            string ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select * from new_member where phone = " + phone + " ";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
            con.Close();*/

            string phone = tb_phoneES.Text;
            string ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string Query;

                if (string.IsNullOrEmpty(phone))
                {
                    // Show all members if phone number is empty
                    Query = "select * from new_member";
                }
                else
                {
                    // Show member with specified phone number
                    Query = "select * from new_member where phone = '" + phone + "'";
                }

                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    var reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView2.DataSource = dt;
                }
            }

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_phoneES.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();

            tb_nameE.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            tb_planE.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            tb_hourE.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
            saunaE.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
            swimmingE.Text = dataGridView2.SelectedRows[0].Cells[10].Value.ToString();
            tb_dateE.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            tb_addressE.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            phoneE.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            genderE.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            CweightE.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            TweightE.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_nameE.Clear();
            phoneE.Clear();
            tb_hourE.Clear();
            tb_planE.Clear();
            saunaE.ResetText();
            tb_dateE.Clear();
            swimmingE.ResetText();
            tb_addressE.ResetText();
            genderE.ResetText();
            CweightE.Clear();
            TweightE.Clear();

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
           
                string Name = tb_nameE.Text;
                string Address = tb_addressE.Text;
                string Phone = phoneE.Text;
                string gender = genderE.Text;
                string Join_date = tb_dateE.Text;
                string Membership = tb_planE.Text;
                int swimming = int.Parse(swimmingE.Text);
                string Current_weight = CweightE.Text;
                string Target_weight = TweightE.Text;
                int sauna = int.Parse(saunaE.Text);
                int privat_coaching = int.Parse(tb_hourE.Text);

                if (Phone.Length != 10)
                {
                    MessageBox.Show("Please enter a valid 10-digit phone number.");
                    return;
                }

                string connectionString = "Data Source=SANGAM07; database=gym; Integrated Security=True";
                string query = "UPDATE new_member SET name = @Name, Address = @Address, Phone = @Phone, Gender = @gender,  Membership_Plan = @Membership, Date_of_Join = @Join_date, CurrentWeight = @Current_weight, TargetWeight = @Target_weight, Sauna = @sauna,  PrivateCoaching = @private_coaching, Swimming = @swimming WHERE Phone = @tb_phoneES";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@Join_date", Join_date);
                    cmd.Parameters.AddWithValue("@Membership", Membership);
                    cmd.Parameters.AddWithValue("@Current_weight", Current_weight);
                    cmd.Parameters.AddWithValue("@Target_weight", Target_weight);
                    cmd.Parameters.AddWithValue("@sauna", sauna);
                    cmd.Parameters.AddWithValue("@swimming", swimming);
                    cmd.Parameters.AddWithValue("@private_coaching", privat_coaching);
                    cmd.Parameters.AddWithValue("@tb_phoneES", Phone); // Assuming Phone_no is the primary key

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your Data have been Changed.");
                        // Clear input fields
                        tb_nameE.Clear();
                        tb_addressE.Clear();
                        CweightE.Clear();
                        TweightE.Clear();
                        phoneE.Clear();
                        tb_hourE.ResetText();
                        tb_planE.ResetText();
                        saunaE.ResetText();
                        tb_dateE.Clear();
                        genderE.ResetText();
                        swimmingE.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save data.");
                    }
                
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saunaE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
