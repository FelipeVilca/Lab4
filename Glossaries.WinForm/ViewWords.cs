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
    public partial class ViewWords : Form
    {
        public ViewWords()
        {
            InitializeComponent();
        }


        private void ViewWords_Load(object sender, EventArgs e)
        {
            cmbLists.Items.Clear();
            var list = WordList.GetLists();
            if (list != null && list.Count() > 0)
            {
                foreach (var item in list)
                {
                    cmbLists.Items.Add(item);
                }

                cmbLists.SelectedIndex = 0;
            }
        }

        private void BindLanguages(string listName)
        {
            cmbLanguage.Items.Clear();
            var list = WordList.LoadList(listName);
            if (list != null && list.Languages != null && list.Languages.Count() > 0)
            {
                foreach (var language in list.Languages)
                {
                    cmbLanguage.Items.Add(language);
                }

                cmbLanguage.SelectedIndex = 0;
            }
        }

        private void cmbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLists.SelectedItem != null)
            {
                BindLanguages(Convert.ToString(cmbLists.SelectedItem));
            }
        }

        private void btnShowWords_Click(object sender, EventArgs e)
        {
            lbWords.Items.Clear();
            if (cmbLists.SelectedItem != null && cmbLanguage.SelectedItem != null)
            {
                var list = WordList.LoadList(Convert.ToString(cmbLists.SelectedItem));
                if (list != null)
                {
                    list.List(cmbLanguage.SelectedIndex, (translations) =>
                    {
                        if (translations != null && translations.Count() > 0)
                        {
                            foreach (var translation in translations)
                            {
                                lbWords.Items.Add(translation);
                            }
                        }
                    });
                }
            }
        }
    }
}
