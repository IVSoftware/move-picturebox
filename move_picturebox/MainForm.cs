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
                switch (_currentKey)
                {
                    case Keys.Up:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                        break;
                    case Keys.Down:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        break;
                    case Keys.A:        // Same as left
                    case Keys.Left:
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                        break;
                    case Keys.Right:
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                        break;
                }
            };
        }
        Timer MoveTimer = new Timer { Interval = 25 };
        Keys _currentKey;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyData)
            {
                case Keys.A:
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    _currentKey = e.KeyData;
                    MoveTimer.Enabled = true; 
                    break;
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            MoveTimer.Enabled = false; // No need to check which key
        }
    }
}
