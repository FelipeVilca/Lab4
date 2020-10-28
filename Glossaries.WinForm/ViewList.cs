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
    public partial class ViewList : Form
    {
        public ViewList()
        {
            InitializeComponent();
        }

        private void ViewList_Load(object sender, EventArgs e)
        {
            lbMain.Items.Clear();
            var list = WordList.GetLists();
            if (list != null && list.Count() > 0)
            {
                foreach (var item in list)
                {
                    lbMain.Items.Add(item);
                }
            }
        }
    }
}
