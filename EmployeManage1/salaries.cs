using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee;

namespace EmployeManage1
{
    public partial class salaries : Form
    {
        Functions Con;
        public salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTbl";
            DataTable dt = Con.GetData(Query);
            EmpCb.DataSource = dt;
            EmpCb.DisplayMember = "EmpName";
            EmpCb.ValueMember = "EmpId";
        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "Select * from EmployeeTbl where EmpId = {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            // DO NOT USE THIS CODE 

            // DataTable dt = Con.GetData(Query);
            //EmpCb.DataSource = dt;
            //MessageBox.Show("" + DSal);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "Rs" + (d * DSal);

            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days cannot be more than 31");
                DaysTb.Text = "";
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs" + (d * DSal);
            }

            // EmpCb.DisplayMember = "EmpName";
            // EmpCb.ValueMember = "EmpId";
        }
        private void ShowSalaries()
        {
            try
            {
                {
                    string Query = "Select * from SalaryTbl";
                    SalaryList.DataSource = Con.GetData(Query);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {

                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);

                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "insert into SalaryTbl values({0},{1},'{2}','{3}','{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid!!!!");
                    DaysTb.Text = "";

                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();

        }
    }
}
