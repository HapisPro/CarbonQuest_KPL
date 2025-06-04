using CarbonQuest.GUI.Controllers;

namespace CarbonQuest.GUI;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        // TODO: Call logout async
        Navigator.Instance.Navigate(AppRoute.Login);
        this.Close();
    }

    private void btnArtikel_Click(object sender, EventArgs e)
    {
        Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
        this.Close();
    }

    private void btnCalculator_Click(object sender, EventArgs e)
    {
        Navigator.Instance.Navigate(AppRoute.Kalkulator);
        this.Close();
    }

    private void pnlLeaderboard_Paint(object sender, PaintEventArgs e)
    {
        // TODO: Get leaderboard from API
    }
}
