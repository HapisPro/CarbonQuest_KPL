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

            // Logika untuk show password
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

        // Method proses login secara asynchronous untuk tidak memblokir UI.
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
                    // Simpan username ke state global agar bisa diakses di seluruh aplikasi.
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
            // Menangani kemungkinan error saat pemanggilan API (misal: network error, server down).
            catch (Exception ex)
            {
                lblError.Text = "Terjadi kesalahan: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}
