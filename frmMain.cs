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
        public enum SimulatorMode
        {
            Fixed,
            Randomize
        }
        int time;
        Timer timer;
        SimulatorMode mode;
        Random rand;
        List<BallisticExpression> be;
        Queue<Tuple<int, List<BallisticExpression>>> ballisticTimeLine;
        public frmMain()
        {
            InitializeComponent();

            time = 0;
            be = new List<BallisticExpression>();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            mode = SimulatorMode.Fixed;
            rand = new Random();
            ballisticTimeLine = new Queue<Tuple<int, List<BallisticExpression>>>();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            Tuple<int, List<BallisticExpression>> currentFrame = null;
            if (ballisticTimeLine.Count > 0)
            {
                if (time == ballisticTimeLine.Peek().Item1)
                {
                    currentFrame = ballisticTimeLine.Dequeue();
                    be.AddRange(currentFrame.Item2);
                }
                time++;
            }
            else
            {
                time = 0;
            }
            
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
                if (mode == SimulatorMode.Fixed)
                {
                    double angle = double.Parse(txtAngle.Text);
                    double gravity = double.Parse(txtGravity.Text);
                    double speed = double.Parse(txtSpeed.Text);
                    
                    Tuple<int, List<BallisticExpression>> frame = new Tuple<int, List<BallisticExpression>>(
                        0, new List<BallisticExpression>());
                    frame.Item2.Add(new BallisticExpression(speed, gravity, angle, new Point(e.X, e.Y)));
                    ballisticTimeLine.Enqueue(frame);
                }
                else if (mode == SimulatorMode.Randomize)
                {
                    int amount = int.Parse(txtAmount.Text);
                    if (amount <= 0)
                    {
                        return;
                    }
                    double angleDown = double.Parse(txtRandomizeAngleDown.Text);
                    double angleUp = double.Parse(txtRandomizeAngleUp.Text);
                    double speed = double.Parse(txtRandomizeSpeed.Text);
                    double gravity = double.Parse(txtRandomizeGravity.Text);
                    double duration = double.Parse(txtDura.Text);
                    int interval = int.Parse(txtInterval.Text);

                    for (int i = 0; i < duration; i++)
                    {
                        Tuple<int, List<BallisticExpression>> frame = new Tuple<int, List<BallisticExpression>>(
                            i * interval , new List<BallisticExpression>());
                        for (int j = 0; j < amount; j++)
                        {
                            int randAngle = rand.Next((int)angleDown, (int)angleUp);
                            frame.Item2.Add(new BallisticExpression(speed, gravity, randAngle, new Point(e.X, e.Y)));
                        }
                        ballisticTimeLine.Enqueue(frame);
                    }
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lbMouseX.Text = e.X.ToString();
            lbMouseY.Text = e.Y.ToString();
        }

        private void rbRandomize_CheckedChanged(object sender, EventArgs e)
        {
            mode = SimulatorMode.Randomize;
            txtRandomizeAngleDown.Enabled = true;
            txtRandomizeAngleUp.Enabled = true;
            txtAmount.Enabled = true;
            txtRandomizeGravity.Enabled = true;
            txtRandomizeSpeed.Enabled = true;
            txtDura.Enabled = true;
            txtInterval.Enabled = true;

            txtAngle.Enabled = false;
            txtGravity.Enabled = false;
            txtSpeed.Enabled = false;
        }

        private void rbFixedValue_CheckedChanged(object sender, EventArgs e)
        {
            mode = SimulatorMode.Fixed;
            txtRandomizeAngleDown.Enabled = false;
            txtRandomizeAngleUp.Enabled = false;
            txtAmount.Enabled = false;
            txtRandomizeGravity.Enabled = false;
            txtRandomizeSpeed.Enabled = false;
            txtDura.Enabled = false;
            txtInterval.Enabled = false;

            txtAngle.Enabled = true;
            txtGravity.Enabled = true;
            txtSpeed.Enabled = true;
        }
    }
}
