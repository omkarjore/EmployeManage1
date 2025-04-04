using EmployeManage1;
namespace EmployeManage1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Employees Obj = new Employees();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
