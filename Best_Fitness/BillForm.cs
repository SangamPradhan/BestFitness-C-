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
    public partial class BillForm : Form
    {
        public string name { get; set; }
        public string planB { get; set; }
        public string hrsB { get; set; }
        public string saunaB { get; set; }
        public int total { get; set; }
        public string swimmingB { get; set; }
        public string dateB { get; set; }

        public BillForm()
        {
            InitializeComponent();
        }



        private void BillForm_Load_1(object sender, EventArgs e)
        {
            MemberName.Text = name;
            //MembershipPlan.Text = planB;
            PrivateCoachingHours.Text = hrsB;
            SaunaOption.Text = saunaB;
            SwimmingOption.Text = swimmingB;
            JoinDate.Text = dateB;
            TotalCost.Text = Convert.ToString(total);


            int membership_plan = 0;
            int count = 0;

            switch (MembershipPlan.Text)
            {
                case "1":
                    membership_plan = 1000;

                    break;
                case "2":
                    membership_plan = 2000;
                    break;
                case "3":
                    membership_plan = 3000;
                    break;

            }

            int pvt_coc_hr = int.Parse(PrivateCoachingHours.Text);

            int bill = membership_plan + (pvt_coc_hr * 500);


            bill += 1500 * int.Parse(SaunaOption.Text);
            bill += 500 * int.Parse(SwimmingOption.Text);

            TotalCost.Text = Convert.ToString(bill);

            int pp = int.Parse(planB);
            switch (pp)
            {
                case 1:
                    MembershipPlan.Text = "Beginner";
                    break;
                case 2:
                    MembershipPlan.Text = "Intermediate";
                    break;
                case 3:
                    MembershipPlan.Text = "Elite";
                    break;

            }

            //Print the bill
            // MessageBox.Show("The bill of " + MemberName.Text + " is RS: " + count);    

        }

        private void TotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
