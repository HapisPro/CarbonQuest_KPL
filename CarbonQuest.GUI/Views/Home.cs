using CarbonQuest.GUI.Controllers;
using CarbonQuest.GUI.Models;
namespace CarbonQuest.GUI;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();

        // Inisialisasi kolom pada list leaderboard
        InitializeListViewColumns();

        // Memuat data leaderboard dari server
        LoadLeaderboard();

        // Menampilkan sapaan untuk user yang login
        lblSubtitle.Text = $"Halo, {AppState.Instance.LoggedInUsername}!";
    }

    // Menyiapkan struktur kolom pada ListView leaderboard
    private void InitializeListViewColumns()
    {
        listViewLeaderboard.Columns.Clear();

        listViewLeaderboard.Columns.Add("No", 70);
        listViewLeaderboard.Columns.Add("Username", 200);
        listViewLeaderboard.Columns.Add("Score", 100);

        // Menyesuaikan lebar kolom secara otomatis
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
            // Menampilkan pesan jika terjadi kesalahan saat mengambil data
            MessageBox.Show("Terjadi kesalahan saat memuat leaderboard: " + ex.Message);
        }
    }

    private void DisplayLeaderboard(List<LeaderboardEntry> leaderboard)
    {
        listViewLeaderboard.Items.Clear();

        int nomor = 1;
        foreach (var entry in leaderboard)
        {
            // Buat item untuk setiap entri leaderboard
            var listViewItem = new ListViewItem(nomor.ToString());
            listViewItem.SubItems.Add(entry.Username);
            listViewItem.SubItems.Add(entry.Score.ToString());

            listViewLeaderboard.Items.Add(listViewItem);

            nomor++;
        }
    }

    // Event handler untuk tombol logout
    private async void btnLogout_Click(object sender, EventArgs e)
    {
        try
        {
            // Lakukan logout melalui API
            await APIClient.LogoutAsync();

            // Reset status login
            AppState.Instance.LoggedInUsername = null;

            // Navigasi kembali ke halaman login
            Navigator.Instance.Navigate(AppRoute.Login);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Terjadi kesalahan saat logout: " + ex.Message);
        }
    }

    // Navigasi ke halaman daftar artikel
    private void btnArtikel_Click(object sender, EventArgs e)
    {
        Navigator.Instance.Navigate(AppRoute.DaftarArtikel);
        this.Close();
    }

    // Navigasi ke halaman kalkulator
    private void btnCalculator_Click(object sender, EventArgs e)
    {
        Navigator.Instance.Navigate(AppRoute.Kalkulator);
        this.Close();
    }
}
