using WaterWise.Controller;

namespace WaterWise.Views
{
    public partial class Login : Form
    {
        private LoginController _authControl;
        private readonly UserController _userControl;
        public Login()
        {
            InitializeComponent();
            _userControl = new UserController();
            _authControl = new LoginController();
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
            UserController controller = new UserController();
            string result = controller.Login(txtUsername.Text, txtPassword.Text);

            if (result == "Login Berhasil")
            {
                this.Hide();

                if (UserController.CurrentAdmin != null)
                {
                    // Yang login adalah Admin → buka DashboardAdmin
                    new dashboardadmin().Show();
                }
                else if (UserController.CurrentUser != null)
                {
                    // Yang login adalah User biasa → buka UserForm
                    new UserForm().Show();
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

