using WaterWise.Controller;

namespace WaterWise
{
    public partial class Login : Form
    {
        private LoginAuthControl _authControl;
        private readonly UserController _userControl;
        public Login()
        {
            InitializeComponent();
            _userControl = new UserController();
                _authControl = new LoginAuthControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string usernameinp = txtUsername.Text;
            string passwordinp = txtPassword.Text;
            txtPassword.Text = "";
            txtUsername.Text = "";

            bool loginResult = _authControl.Login(usernameinp, passwordinp);

            if (!loginResult)
            {
                MessageBox.Show("Login Gagal! Periksa username dan password Anda.");
                return;
            }

            string result = _userControl.Login(usernameinp, passwordinp);
            if (result == "Login Berhasil")
            {
                if (UserController.CurrentUser.role == "admin")
                {
                    AdminForm dashboard = new AdminForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    UserForm dashboard = new UserForm();
                    dashboard.Show();
                    this.Hide();
                    //    }
                    //if (usernameinp == UserController.CurrentUser.username && passwordinp == UserController.currentuser.password)
                    //{
                    //    MessageBox.Show("Login Berhasil!");
                    //    AdminForm dashboard = new AdminForm();
                    //    dashboard.Show();
                    //    this.Hide();

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Login Gagal! Periksa username dan password Anda.");
                    //}
                }
            }
        }
    }
}
