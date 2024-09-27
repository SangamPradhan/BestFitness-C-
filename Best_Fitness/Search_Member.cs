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
    public partial class Search_Member : Form
    {
        //public object tb_sauns;

        public object tb_saunaS { get; private set; }

      //  public int bill { get; set; } = 0;

        public Search_Member()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {

            string phone = tb_phone.Text;

            string ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select * from new_member where phone = " + phone + " ";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader(); 
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();

        }



        private void btn_bill_Click(object sender, EventArgs e)
        {


            BillForm billForm = new BillForm();
            billForm.name = tb_nameS.Text;
            billForm.planB = tb_planS.Text;
            billForm.hrsB = tb_hours.Text;
            billForm.saunaB = tb_saunas.Text;
            billForm.swimmingB = tb_swimmingS.Text;
            billForm.dateB = tb_dateS.Text;
           // billForm.total = count;

            //billForm.total = bill;
            billForm.ShowDialog();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            tb_nameS.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tb_planS.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tb_hours.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            tb_saunas.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            tb_swimmingS.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            tb_dateS.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string phone = tb_phone.Text;
                string ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "DELETE FROM new_member WHERE phone = " + phone + "";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Member deleted successfully!");

                    }
                    else
                    {
                        MessageBox.Show("No member found with the provided phone number.");
                    }
                }
            }
            tb_nameS.Clear();
            tb_planS.Clear();
            tb_saunas.Clear();
            tb_hours.Clear();
            tb_phone.Clear();
            tb_dateS.Clear();
            tb_swimmingS.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SANGAM07;database=gym; Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string Query = "select * from new_member ";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable da = new DataTable();
            da.Load(reader);
            dataGridView1.DataSource = da;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nameS.Clear();
            tb_phone.Clear();
            tb_hours.Clear();
            tb_planS.Clear();
            tb_saunas.Clear();
            tb_dateS.Clear();
            tb_swimmingS.Clear();

        }



        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter 'Digits' to search.");
            }
        }

        private void Search_Member_Load(object sender, EventArgs e)
        {

        }
    }
}

