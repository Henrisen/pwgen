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
    public partial class progress : Form
    {
        public int max;
        public int total;
        public progress()
        {
            InitializeComponent();
        }

        private void progress_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = max;
        }

        public void update()
        {
            progressBar.Value = total;
            progressBar.Maximum = max;
            progressBar.Update();
        }
    }
}
