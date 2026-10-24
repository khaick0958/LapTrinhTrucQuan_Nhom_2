using QuanLyCuaHangTivi;
using TiviManagementApp.AppForms;
using TiviManagementApp.Services;

namespace TiviManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            errorMsg.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Validate_Login L = new Validate_Login(usernameTextBox.Text, passwordTextBox.Text);

            if (L.isValid())
            {
                errorMsg.Visible = false;

                FormMain form = new FormMain();

                form.FormClosed += (s, args) =>
                {
                    this.Close();
                };

                form.Show();
                this.Hide();
            }
            else
            {
                errorMsg.Visible = true;
            }
        }
    }
}
