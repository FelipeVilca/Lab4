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
    public partial class ViewRemove : Form
    {
        public ViewRemove()
        {
            InitializeComponent();
        }

        private void ViewRemove_Load(object sender, EventArgs e)
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

        private void cmbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLists.SelectedItem != null)
            {
                BindLanguages(Convert.ToString(cmbLists.SelectedItem));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbLists.SelectedItem != null && cmbLanguage.SelectedItem != null)
            {
                var list = WordList.LoadList(Convert.ToString(cmbLists.SelectedItem));
                if (list != null && lbWords.SelectedItem != null)
                {
                    var word = Convert.ToString(lbWords.SelectedItem);

                    list.Remove(cmbLanguage.SelectedIndex, word);

                    list.Save();

                    btnShowWords_Click(sender, e);
                }
            }
        }
    }
}
