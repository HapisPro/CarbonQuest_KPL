using CarbonQuest.GUI.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarbonQuest.GUI.Views
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        // TODO: Implement API for get the question and answer

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // TODO: Implement API for calculating
            MessageBox.Show("Skor kamu: 100");
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }
    }
}
