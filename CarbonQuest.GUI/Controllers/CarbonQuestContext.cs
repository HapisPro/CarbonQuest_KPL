using System;
using System.Windows.Forms;

namespace CarbonQuest.GUI.Controllers
{
    public class CarbonQuestContext : ApplicationContext
    {
        private Form? _currentForm;

        public CarbonQuestContext()
        {
            Navigator.Instance.SetAppContext(this);
            Navigator.Instance.Navigate(AppRoute.Login);
        }

        public void SetCurrentForm(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.FormClosed -= CurrentForm_FormClosed;
                _currentForm.Close();
            }

            _currentForm = form;
            _currentForm.FormClosed += CurrentForm_FormClosed;
            _currentForm.Show();
        }

        private void CurrentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ExitThread(); // Keluar dari aplikasi jika semua form sudah ditutup
        }
    }
}
