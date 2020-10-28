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
    public partial class ViewCount : Form
    {
        public ViewCount()
        {
            InitializeComponent();
        }

        private void ViewCount_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLists.SelectedItem != null)
            {
                var value = cmbLists.SelectedItem.ToString();

                var list = WordList.LoadList(value);

                lbCount.Text = "Words Count: " + list.Count();
            }
        }
    }
}
