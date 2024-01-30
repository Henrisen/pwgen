using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw_gen
{
    public partial class maxlen : Form
    {
        public int max = 15;
        public int CPM = 5;
        public maxlen()
        {
            InitializeComponent();
        }

        private void maxlen_Load(object sender, EventArgs e)
        {
            FormClosed += Maxlen_FormClosed;
        }

        private void Maxlen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            max = (int)len.Value;
            CPM = (int)cpm.Value;
            Hide();
        }
    }
}
