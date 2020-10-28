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
    public partial class ViewNew : Form
    {
        List<string> languages = new List<string>();
        public ViewNew()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewNew_Load(object sender, EventArgs e)
        {

        }

        private void btnAddInList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLanguage.Text))
            {
                var languageName = txtLanguage.Text;
                languageName = languageName.Trim();
                languageName = languageName.Replace(" ", "");
                languages.Add(languageName);
                lbLanguages.Items.Add(languageName);
                txtLanguage.Text = "";
                txtLanguage.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && lbLanguages.Items.Count > 0)
            {
                var listName = txtName.Text;
                listName = listName.Trim();
                listName = listName.Replace(" ", "");

                var wordList = new WordList(listName, languages.ToArray());
                wordList.Save();

                Program.LastSelectedList = listName;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
