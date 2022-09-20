using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtilleryFire
{
    public class BalisticMovement
    {
        private double speed;
        private double gravity;
        private double angle;
        private double shecheng;
        private double height;
        private PointF initPos;
        private double time;
        private Bitmap sprite;
        private float scale;

        public BalisticMovement(Bitmap sprite, double speed, double gravity, double angle, PointF initPos, float scale)
        {
            this.speed = speed;
            this.gravity = gravity;
            this.angle = angle;
            this.initPos = initPos;
            shecheng = (speed * speed / gravity) * (Math.Sin(2 * angle));
            height = speed * speed * Math.Sin(angle) * Math.Sin(angle) / (2 * gravity);
            time = 0;
            this.sprite = sprite;
            this.scale = scale;
        }

        private PointF GetNextPos()
        {
            double offsetX = speed * time * Math.Cos(angle * Math.PI / 180);
            double offsetY = speed * time * Math.Sin(angle * Math.PI / 180) - 0.5d * gravity * time * time;
            return new PointF((float)(initPos.X + offsetX), (float)(initPos.Y - offsetY));
        }

        private PointF GetNextPos(PointF position)
        {
            double offsetX = speed * Math.Cos(angle * Math.PI / 180);
            double offsetY = speed * Math.Sin(angle * Math.PI / 180) - gravity * time - 0.5d * gravity;
            return new PointF((float)(position.X + offsetX), (float)(position.Y - offsetY));
        }

        internal void Draw(Graphics graphics)
        {
            initPos = GetNextPos(initPos);
            graphics.DrawImage(sprite, initPos.X, initPos.Y, sprite.Width * scale, sprite.Height * scale);

            time++;
        }
    }
}
