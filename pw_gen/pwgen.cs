using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace pw_gen
{
    public partial class pwgen : Form
    {
        private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890#+*^!._-[]{}/$";
        private string pw_content = "";
        private readonly Random random = new Random();
        public readonly maxlen Maxlen = new maxlen();
        public readonly progress Progress = new progress();
        private bool finished = false;

        public pwgen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Maxlen.ShowDialog();
            Progress.max = Maxlen.max;
            Progress.Show();
            Progress.TopMost = true;
            Focus();
            SizeChanged += Pwgen_SizeChanged;
            pw.Size = Size;
            pw.Enabled = true;
            Focus();
            pw.ScrollBars = ScrollBars.Vertical; // Enable vertical scrolling
            pw.MouseMove += Pwgen_MouseMove;
            pw.WordWrap = true;
            pw.KeyUp += Pw_KeyPress;
        }

        private void Pw_KeyPress(object sender, KeyEventArgs e)
        {
            pw.Text = pw_content;
        }

        private void Pwgen_MouseMove(object sender, MouseEventArgs e)
        {
            Progress.total = pw_content.Length;
            Progress.update();
            if (pw_content.Length >= Maxlen.max) {
                if (!finished)
                {
                    finished = true;
                    pw.ReadOnly = true;
                    MessageBox.Show("Password generation Finished!");
                    Progress.Hide();
                }
                return;
            }
            short charPosSeed = (short)(e.X + e.Y);
            long unixMills = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long charPosBase = charPosSeed * unixMills * (long)Math.Floor((decimal) (Process.GetCurrentProcess().TotalProcessorTime.Ticks / 100000));
            StringBuilder passwordBuilder = new StringBuilder();

            for (short i = 0; i < Maxlen.CPM; i++)
            {
                double randomShort = random.NextDouble();
                short charPos = (short)Math.Floor((randomShort * charPosBase) % Characters.Length);
                passwordBuilder.Append(Characters[charPos % Characters.Length]);
            }

            // Append the new password to the existing content without a newline
            pw.AppendText(passwordBuilder.ToString());
            pw_content += passwordBuilder.ToString();
            Text = pw.Text.Length.ToString() + " - Password Generator";
            Progress.total = pw_content.Length;
            Progress.update();
        }

        private void Pwgen_SizeChanged(object sender, EventArgs e)
        {
            pw.Size = Size;
        }
    }
}
