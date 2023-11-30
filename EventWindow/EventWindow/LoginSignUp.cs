using EventLib;

namespace EventWindow
{
    public partial class LoginSignUp : Form
    {
        public LoginSignUp()
        {
            InitializeComponent();

            btLogin.Click += DoLogin;
            btSignUp.Click += DoSignUp;
            btShowPass.Click += DoShowHidePassword;
            // Remove it
            tbUsername.Text = "admin";
            tbPassword.Text = "123456789";
        }

        private async void DoLogin(object? sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (username == null || password == null)
            {
                MessageBox.Show("Please input username and password");
            }
            string endpoint = $"/api/login?username={username}&password={password}";
            Disable();
            User? response = await Program.RestClient.PostAsync<User?>(endpoint);
            Enable();
            if (response != null)
            {
                Program.CurrentUser = response;
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password...");
            }
        }
        private async void DoSignUp(object? sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (username == null || password == null)
            {
                MessageBox.Show("Please input username and password");
            }
            string endpoint = $"/api/sign_up?username={username}&password={password}";
            Disable();
            User? response = await Program.RestClient.PostAsync<User?>(endpoint);
            Enable();
            if (response != null)
            {
                Program.CurrentUser = response; MessageBox.Show(Program.CurrentUser.Name);
                Homepage homepage = new Homepage();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This username had been taken");
            }
        }
        private void DoShowHidePassword(object? sender, EventArgs e)
        {
            if(btShowPass.Text == "Show")
            {
                tbPassword.PasswordChar = '\0';
                btShowPass.Text = "Hide";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                btShowPass.Text = "Show";
            }
        }
        void Enable()
        {
            btLogin.Enabled = true;
            btSignUp.Enabled = true;
            tbUsername.Enabled = true;
            tbPassword.Enabled = true;
        }
        void Disable()
        {
            btLogin.Enabled = false;
            btSignUp.Enabled = false;
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
        }
    }
}
