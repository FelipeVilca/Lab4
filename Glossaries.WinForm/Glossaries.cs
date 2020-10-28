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
    public partial class MainGlossaries : Form
    {
        public MainGlossaries()
        {
            InitializeComponent();
        }

        private void MainGlossaries_Load(object sender, EventArgs e)
        {

        }

        private void btnShowLists_Click(object sender, EventArgs e)
        {
            ViewList viewList = new ViewList();
            viewList.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ViewNew viewNew = new ViewNew();
            if(viewNew.ShowDialog() == DialogResult.OK)
            {
                ViewAdd viewAdd = new ViewAdd();
                viewAdd.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ViewListSelection viewListSelection = new ViewListSelection();
            if (viewListSelection.ShowDialog() == DialogResult.OK)
            {
                ViewAdd viewAdd = new ViewAdd();
                viewAdd.ShowDialog();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ViewRemove viewRemove = new ViewRemove();
            viewRemove.ShowDialog();
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            ViewWords viewWords = new ViewWords();
            viewWords.ShowDialog();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            ViewCount viewCount = new ViewCount();
            viewCount.ShowDialog();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            ViewListSelection viewListSelection = new ViewListSelection();
            if (viewListSelection.ShowDialog() == DialogResult.OK)
            {
                ViewPractice viewPractice = new ViewPractice();
                viewPractice.ShowDialog();
            }
            
        }
    }
}
