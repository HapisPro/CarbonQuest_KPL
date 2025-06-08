using CarbonQuest.GUI.Controllers;
using CarbonQuest.GUI.Models;
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
            LoadQuestions();
        }

        // Method async untuk mengambil pertanyaan dari API
        private async void LoadQuestions()
        {
            try
            {
                var questions = await APIClient.GetCalculatorQuestionsAsync();
                DisplayQuestions(questions);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat pertanyaan: " + ex.Message);
            }
        }

        // Menampilkan daftar pertanyaan dan pilihan jawaban ke dalam FlowLayoutPanel
        private void DisplayQuestions(List<CarbonQuestion> questions)
        {
            flowLayoutPanelQuestion.Controls.Clear();

            foreach (var question in questions)
            {
                // Buat GroupBox untuk setiap pertanyaan
                var groupBox = new GroupBox
                {
                    Text = question.Question,
                    Width = flowLayoutPanelQuestion.Width - 30,
                    Tag = question.Id
                };

                // Tambahkan RadioButton untuk setiap jawaban pilihan
                int top = 20;
                foreach (var choice in question.Choices)
                {
                    var radio = new RadioButton
                    {
                        Text = choice.Answer,
                        Top = top,
                        Left = 10,
                        AutoSize = true,
                        Tag = choice.Answer
                    };
                    groupBox.Controls.Add(radio);
                    top += 25;
                }

                flowLayoutPanelQuestion.Controls.Add(groupBox);
            }
        }

        // Event handler ketika tombol Simpan diklik
        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            // Daftar jawaban yang dipilih
            var selectedAnswers = new List<string>();

            // Iterasi semua groupBox dan ambil radio button yang terpilih
            foreach (GroupBox group in flowLayoutPanelQuestion.Controls)
            {
                foreach (RadioButton rb in group.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        selectedAnswers.Add(rb.Tag.ToString());
                        break;
                    }
                }
            }

            // Validasi: cek jika tidak ada jawaban yang dipilih
            if (selectedAnswers.Count == 0)
            {
                MessageBox.Show("Silakan pilih jawaban terlebih dahulu.");
                return;
            }

            try
            {
                // Kirim jawaban ke API dan dapatkan total skor
                int? totalScore = await APIClient.SubmitCalculatorAnswersAsync(selectedAnswers);

                if (totalScore.HasValue)
                {
                    MessageBox.Show($"Jawaban berhasil disimpan!\nSkor kamu: {totalScore}.");
                    Navigator.Instance.Navigate(AppRoute.Home);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Jawaban tidak lengkap. Silahkan coba lagi.");
                }
            }
            // Tangani error pengiriman jawaban
            catch (Exception ex)
            {
                
                MessageBox.Show("Terjadi kesalahan saat mengirim jawaban: " + ex.Message);
            }
        }

        // Event handler untuk tombol Batal
        private void btnBatal_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }
    }
}
