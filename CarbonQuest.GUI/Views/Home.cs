using CarbonQuest.GUI.Controllers;
using CarbonQuest.GUI.Models;
namespace CarbonQuest.GUI;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
        InitializeListViewColumns();
        LoadLeaderboard();
        lblSubtitle.Text = $"Halo, {AppState.Instance.LoggedInUsername}!";
    }

    private void InitializeListViewColumns()
    {
        listViewLeaderboard.Columns.Clear();

        listViewLeaderboard.Columns.Add("No", 70);
        listViewLeaderboard.Columns.Add("Username", 200);
        listViewLeaderboard.Columns.Add("Score", 100);

        listViewLeaderboard.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }

    private async void LoadLeaderboard()
    {
        try
        {
            List<LeaderboardEntry> leaderboard = await APIClient.GetLeaderboardAsync();
            DisplayLeaderboard(leaderboard); 
        }
        catch (Exception ex)
        {
            MessageBox.Show("Terjadi kesalahan saat memuat leaderboard: " + ex.Message);
        }
    }

    private void DisplayLeaderboard(List<LeaderboardEntry> leaderboard)
    {
        listViewLeaderboard.Items.Clear();

        int nomor = 1;
        foreach (var entry in leaderboard)
        {
            var listViewItem = new ListViewItem(nomor.ToString());
            listViewItem.SubItems.Add(entry.Username);
            listViewItem.SubItems.Add(entry.Score.ToString());

            listViewLeaderboard.Items.Add(listViewItem);

            nomor++; 
        }
    }

    private async void btnLogout_Click(object sender, EventArgs e)
    {
        try
        {
            await APIClient.LogoutAsync();

            AppState.Instance.LoggedInUsername = null;

            Navigator.Instance.Navigate(AppRoute.Login);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Terjadi kesalahan saat logout: " + ex.Message);
        }
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
}
