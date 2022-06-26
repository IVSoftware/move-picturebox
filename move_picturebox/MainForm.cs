using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picturebox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MoveTimer.Tick += (sender, e) =>
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            };
        }
        Timer MoveTimer = new Timer { Interval = 25 };
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if(e.KeyData == Keys.A)
            {
                MoveTimer.Enabled = true;
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            MoveTimer.Enabled = false; // No need to check which key
        }
    }
}
