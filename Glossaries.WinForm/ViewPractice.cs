using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glossaries.WinForm
{
    public partial class ViewPractice : Form
    {
        public ViewPractice()
        {
            InitializeComponent();
        }

        Random random = new Random();
        List<PracticeResults> results = new List<PracticeResults>();
        WordList wordList;

        private void ViewPractice_Load(object sender, EventArgs e)
        {
            LoadWord();
        }

        String expectedAnswer;
        int Correct = 0;
        int Wrong = 0;
        PracticeResults resultObj;
        private void LoadWord()
        {
            wordList = WordList.LoadList(Program.LastSelectedList);
            if (wordList != null)
            {
                var word = wordList.GetWordToPractice();

                if (word == null)
                {
                    MessageBox.Show("List is empty, no word found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var indexFrom = random.Next(0, word.Translations.Count() - 1);
                var indexTo = random.Next(0, word.Translations.Count() - 1);
                while (indexTo == indexFrom)
                {
                    indexTo = random.Next(0, word.Translations.Count() - 1);
                }

                //Check if word is removed
                if (string.IsNullOrWhiteSpace(word.Translations[indexFrom]) || string.IsNullOrWhiteSpace(word.Translations[indexTo]))
                {
                    LoadWord();
                    return;
                }

                lbWord.Text = word.Translations[indexFrom];
                lbFrom.Text = wordList.Languages[indexFrom];
                lbTo.Text = wordList.Languages[indexTo];
                expectedAnswer = word.Translations[indexTo].ToLower();

                resultObj = (new PracticeResults()
                {
                    Answer = "",
                    ExpectedAnswer = word.Translations[indexTo],
                    TranslationFrom = wordList.Languages[indexFrom],
                    TranslationTo = wordList.Languages[indexTo],
                    Word = word.Translations[indexFrom],
                });
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var input = txtWord.Text;

            if (!string.IsNullOrEmpty(input))
            {
                if (input.ToLower() == expectedAnswer)
                {
                    Correct++;
                }
                else
                {
                    Wrong++;
                }

                lbCorrect.Text = Correct.ToString();
                lbWrong.Text = Wrong.ToString();

                resultObj.Answer = txtWord.Text;

                txtWord.Text = "";
                txtWord.Focus();

                ShowDetails();
                LoadWord();
            }
        }

        private void ShowDetails()
        {
            var message = "";
            message = message + ("Word: " + resultObj.Word);
            message = message + (", From: " + resultObj.TranslationFrom);
            message = message + (", To: " + resultObj.TranslationTo);
            message = message + (", Answer: " + resultObj.Answer);
            message = message + (", Expected: " + resultObj.ExpectedAnswer);
            message = message + (", Is Correct: " + (resultObj.IsCorrect ? "Yes" : "No"));

            lbResults.Items.Add(message);
        }
    }
}
