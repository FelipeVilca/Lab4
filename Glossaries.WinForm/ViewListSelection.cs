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
    public partial class ViewListSelection : Form
    {
        public ViewListSelection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbLists.Items.Count > 0 && cmbLists.SelectedItem != null)
            {
                Program.LastSelectedList = cmbLists.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ViewListSelection_Load(object sender, EventArgs e)
        {
            cmbLists.Items.Clear();
            var list = WordList.GetLists();
            if (list != null && list.Count() > 0)
            {
                foreach (var item in list)
                {
                    cmbLists.Items.Add(item);
                }
            }
        }
    }
}
