using Employee;

namespace EmployeManage1
{
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            DepList.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added Successfully!!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }
        int Key = 0;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTbl set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Updated!!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }


        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            DeleteBtn Obj = new DeleteBtn();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTbl where  DepId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            salaries Obj = new salaries();
            Obj.Show();

            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
