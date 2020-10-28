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
    public partial class ViewAdd : Form
    {
        public ViewAdd()
        {
            InitializeComponent();
        }

        int index = 0;
        List<string> lstWords = new List<string>();
        private void ViewAdd_Load(object sender, EventArgs e)
        {
            ShowLanguage();
        }

        private void ShowLanguage()
        {
            var wordList = WordList.LoadList(Program.LastSelectedList);
            if (wordList != null && wordList.Languages != null && wordList.Languages.Count() > 0)
            {
                if (wordList.Languages.Count() > index)
                {
                    lblLanguageName.Text = wordList.Languages[index];
                }
                else
                {
                    wordList.Add(lstWords.ToArray());
                    wordList.Save();

                    lstWords = new List<string>();
                    lbWords.Items.Clear();

                    if (MessageBox.Show("Do you want to enter more words ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        index = 0;
                        ShowLanguage();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWord.Text))
            {
                lstWords.Add(txtWord.Text);
                lbWords.Items.Add(txtWord.Text);
                txtWord.Text = "";
                txtWord.Focus();

                index++;
                ShowLanguage();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lstWords.Count > 0)
            {
                var wordList = WordList.LoadList(Program.LastSelectedList);
                wordList.Add(lstWords.ToArray());
                wordList.Save();
            }

            Close();
        }
    }
}
