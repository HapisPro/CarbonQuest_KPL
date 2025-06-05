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

        private void DisplayQuestions(List<CarbonQuestion> questions)
        {
            flowLayoutPanelQuestion.Controls.Clear();

            foreach (var question in questions)
            {
                var groupBox = new GroupBox
                {
                    Text = question.Question,
                    Width = flowLayoutPanelQuestion.Width - 30,
                    Tag = question.Id
                };

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

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            var selectedAnswers = new List<string>();

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

            if (selectedAnswers.Count == 0)
            {
                MessageBox.Show("Silakan pilih jawaban terlebih dahulu.");
                return;
            }

            try
            {
                int? totalScore = await APIClient.SubmitCalculatorAnswersAsync(selectedAnswers);

                if (totalScore.HasValue)
                {
                    MessageBox.Show($"Jawaban berhasil disimpan!\nSkor kamu: {totalScore}.");
                    Navigator.Instance.Navigate(AppRoute.Home);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Jawaban tidak tersimpan. Coba lagi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengirim jawaban: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Navigator.Instance.Navigate(AppRoute.Home);
            this.Close();
        }
    }
}
