using System;
using System.Windows.Forms;
using CarbonQuest.GUI.Controllers;

namespace CarbonQuest.GUI.Views
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

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

        private void btnSignup_Click(object sender, EventArgs e)
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
                // TODO: Ganti dengan API call signup yang async jika perlu
                bool signupSuccess = true; // simulasikan signup berhasil

                if (signupSuccess)
                {
                    MessageBox.Show("Signup berhasil. Silakan login.");
                    Navigator.Instance.Navigate(AppRoute.Login);
                    this.Close();
                }
                else
                {
                    lblError.Text = "Signup gagal.";
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
