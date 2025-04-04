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
    public partial class DeleteBtn : Form
    {
        Functions Con;
        public DeleteBtn()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTbl";
            DataTable dt = Con.GetData(Query);
            DepCb.DataSource = dt;
            DepCb.DisplayMember = "DepName";
            DepCb.ValueMember = "DepId";
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // This method runs when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This method runs when textBox1 content changes
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This method runs when textBox2 content changes
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This method runs when label3 is clicked
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // This method runs when label4 is clicked
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    //string DOB = DOBTb.Value.Date.ToString();
                    //string JDate = JDateTb.Value.Date.ToString();
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string JDate = JDateTb.Value.ToString("yyyy-MM-dd");

                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "insert into EmployeeTbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added Successfully!!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void JDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    //string DOB = DOBTb.Value.Date.ToString();
                    //string JDate = JDateTb.Value.Date.ToString();
                    string DOB = DOBTb.Value.ToString("yyyy-MM-dd");
                    string JDate = JDateTb.Value.ToString("yyyy-MM-dd");

                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update  EmployeeTbl set EmpName  = '{0}',EmpGen = '{1}',EmpDep ={2},EmpDOB = '{3}',EmpJDate = '{4}',EmpSal = {5} where EmpId = {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated Successfully!!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {


                    string Query = "Delete from EmployeeTbl  where EmpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
