using System;
using System.Windows.Forms;
using CarbonQuest.GUI.Controllers;
using CarbonQuest.Lib.Utils;

namespace CarbonQuest.GUI.Views
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

            // Logika untuk show password
            formPassword.UseSystemPasswordChar = true;
            cbxShowPw.CheckedChanged += (s, e) => formPassword.UseSystemPasswordChar = !cbxShowPw.Checked;

            lblNavLogin.Click += (s, e) => {
                Navigator.Instance.Navigate(AppRoute.Login);
                this.Close();
            };

            lblNavLogin.Cursor = Cursors.Hand;
            lblError.Visible = false;
            btnSignup.Click += btnSignup_Click;
        }

        // Method proses signup secara asynchronous untuk tidak memblokir UI.
        private async void btnSignup_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(formUsername.Text) || string.IsNullOrWhiteSpace(formPassword.Text))
            {
                lblError.Text = "Username dan password wajib diisi.";
                lblError.Visible = true;
                return;
            }

            // Secure coding untuk handle password
            if (!Validator.ValidatePassword(formPassword.Text))
            {
                lblError.Text = "Password harus minimal 8 karakter, mengandung huruf besar dan simbol.";
                lblError.Visible = true;
                return;
            }


            try
            {
                bool signupSuccess = await APIClient.SignupAsync(formUsername.Text, formPassword.Text);

                if (signupSuccess)
                {
                    MessageBox.Show("Signup berhasil. Silakan login.");
                    Navigator.Instance.Navigate(AppRoute.Login);
                    this.Close();
                }
            }
            // Menangkap error dari sisi server (misal: username sudah ada) atau masalah koneksi.
            catch (Exception ex)
            {
                lblError.Text = "Terjadi kesalahan: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}
