using CarbonQuest.GUI.Controllers;
using System;
using System.Windows.Forms;

namespace CarbonQuest.GUI.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            formPassword.UseSystemPasswordChar = true;
            cbxShowPw.CheckedChanged += (s, e) => formPassword.UseSystemPasswordChar = !cbxShowPw.Checked;

            lblNavSingup.Click += (s, e) => {
                Navigator.Instance.Navigate(AppRoute.Signup);
                this.Close();
            };

            lblNavSingup.Cursor = Cursors.Hand;
            lblError.Visible = false;
            btnLogin.Click += btnLogin_Click;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(formUsername.Text) || string.IsNullOrWhiteSpace(formPassword.Text))
            {
                lblError.Text = "Username dan password wajib diisi.";
                lblError.Visible = true;
                return;
            }

            try
            {
                bool loginSuccess = await APIClient.LoginAsync(formUsername.Text, formPassword.Text);

                if (loginSuccess)
                {
                    AppState.Instance.LoggedInUsername = formUsername.Text;

                    Navigator.Instance.Navigate(AppRoute.Home);
                    this.Close();
                }
                else
                {
                    lblError.Text = "Login gagal, coba lagi.";
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Terjadi kesalahan: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}
