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
    public partial class DaftarArtikel : Form
    {
        public DaftarArtikel()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }

        // TODO: Create container, then generate the card (button) artcile from API by looping
        private void btnArticle1_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.ArtikelDetail, Tuple.Create("Judul", "isi dari artikelnya"));
            this.Close();
        }
    }
}
