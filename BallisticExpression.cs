using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticSimulator
{
    public class BallisticExpression
    {
        double speed;
        double gravity;
        double angle;
        double shecheng;
        double height;
        Point initPos;
        double time;
        public BallisticExpression(double speed, double gravity, double angle, Point initPos)
        {
            this.speed = speed;
            this.gravity = gravity;
            this.angle = angle;
            this.initPos = initPos;
            shecheng = (speed * speed / gravity) * (Math.Sin(2 * angle));
            height = speed * speed * Math.Sin(angle) * Math.Sin(angle) / (2 * gravity);
            time = 0;
        }

        public PointF GetNextPos()
        {
            double offsetX = speed * time * Math.Cos(angle * Math.PI / 180);
            double offsetY = speed * time * Math.Sin(angle * Math.PI / 180) - 0.5d * gravity * time * time;
            return new PointF((float)(initPos.X + offsetX), (float)(initPos.Y - offsetY));
        }

        public void Update()
        {
            time++;
        }
    }
}
