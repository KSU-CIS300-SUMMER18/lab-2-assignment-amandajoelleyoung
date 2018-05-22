using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When "Open..." button is selected, this method will run
        ///  and open the OpenFileDialog section/window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                MessageBox.Show("Unable to open " + filename);
            }
        }

        /// <summary>
        /// When "Save as..." is selected, this method will run, open the saveFileDialog
        /// to input where it is saved and named as what, then will save the current
        /// file being worked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                MessageBox.Show("Unable to save " + filename);
            }
        }

    }
}
