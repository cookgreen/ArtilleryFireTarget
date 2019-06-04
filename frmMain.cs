using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallisticSimulator
{
    public partial class frmMain : Form
    {
        Timer timer;
        List<BallisticExpression> be;
        public frmMain()
        {
            InitializeComponent();

            be = new List<BallisticExpression>();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            for (int i = 0; i < be.Count; i++)
            {
                PointF point = be[i].GetNextPos();
                e.Graphics.DrawEllipse(Pens.Black, point.X, point.Y, 2, 2);
                be[i].Update();
                e.Graphics.Flush();
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double angle = double.Parse(txtAngle.Text);
                double gravity = double.Parse(txtGravity.Text);
                double speed = double.Parse(txtSpeed.Text);

                be.Add(new BallisticExpression(speed, gravity, angle, new Point(e.X, e.Y)));
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lbMouseX.Text = e.X.ToString();
            lbMouseY.Text = e.Y.ToString();
        }
    }
}
