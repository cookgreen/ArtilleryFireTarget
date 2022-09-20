using System.Drawing.Drawing2D;

namespace ArtilleryFire
{
    public partial class frmMain : Form
    {
        private Bitmap? target;
        private Bitmap? cannonBall;
        private Bitmap? cannonMozzle;
        private Bitmap? cannonBarrel;
        private Bitmap? cannonPlatformWheel;
        private Point cannonPlatformWheelRotationCenterOffset = new Point(550, 504);
        private float currentBarrelRotationAngle;
        private List<BalisticMovement> be;
        private int newW, newH = 0;
        private Queue<Tuple<int, List<BalisticMovement>>> ballisticTimeLine;
        private int time = 0;

        public frmMain()
        {
            InitializeComponent();

            be = new List<BalisticMovement>();
            ballisticTimeLine = new Queue<Tuple<int, List<BalisticMovement>>>();

            canvas.MouseWheel += Canvas_MouseWheel;

            timer1.Interval = 100;
            timer1.Start();
        }

        private void Canvas_MouseWheel(object? sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                currentBarrelRotationAngle -= 2;
            }
            else
            {
                currentBarrelRotationAngle += 2;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            target = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Images\\target.png"));
            cannonBall = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Images\\cannon_ball.png"));
            cannonBarrel = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Images\\cannon_barrel.png"));
            cannonMozzle = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Images\\cannon_fire_mozzle.png"));
            cannonPlatformWheel = new Bitmap(Path.Combine(Environment.CurrentDirectory, "Images\\canon_platform_wheel.png"));
            btnFire.Enabled = true;
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (cannonBall == null)
            {
                return;
            }

            BalisticMovement movement = new BalisticMovement(
                cannonBall, 
                int.Parse(txtSpeed.Text), 
                9.8f, 
                currentBarrelRotationAngle * -1, 
                new Point(
                    10 + 100, 
                    500), 
                0.05f);
            be.Add(movement);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (target != null)
            {
                g.DrawImage(target, 800, 400, target.Width * 0.2f, target.Height * 0.2f);
            }

            if (ballisticTimeLine.Count > 0)
            {
                if (time == ballisticTimeLine.Peek().Item1)
                {
                    var currentFrame = ballisticTimeLine.Dequeue();
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
                be[i].Draw(e.Graphics);
                e.Graphics.Flush();
            }

            if (cannonBarrel != null)
            {
                Bitmap cannonBarrelRotated = RotateImg(cannonBarrel, currentBarrelRotationAngle, out newW, out newH);
                g.DrawImage(cannonBarrelRotated, 15, 400, cannonBarrel.Width * 0.3f, cannonBarrel.Height * 0.3f);
            }

            if (cannonPlatformWheel != null)
            {
                g.DrawImage(cannonPlatformWheel, 0, 400, cannonPlatformWheel.Width * 0.3f, cannonPlatformWheel.Height * 0.3f);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        public Bitmap RotateImg(Image b, float angle, out int W, out int H)
        {
            angle = angle % 360;
            
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
             
            int w = b.Width;
            int h = b.Height;
            W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            
            Bitmap dsImage = new Bitmap(W, H);
            Graphics g = Graphics.FromImage(dsImage);
            g.InterpolationMode = InterpolationMode.Bicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
             
            Point Offset = new Point((W - w) / 2, (H - h) / 2);
             
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(angle);
            
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);
            
            g.ResetTransform();
            g.Save();
            g.Dispose();
            return dsImage;
        }
    }
}