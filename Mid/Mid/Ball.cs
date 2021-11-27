using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    class Ball:Shape3D, IRollable
    {
        public double radius;
        public Ball():base() //建構子。
        {
        }
        public Ball(double ref1, Item.Material input) :base(input) //建構子。
        {
            radius = ref1;
            m = input;
            s = Item.Shape.Ball;
        }
        public override double Volume()
        {
            double volume;
            volume = 4 * Math.PI * radius * radius * radius / 3;
            return volume;
        }
        public override string Message()
        {
            string message = "";
            message += string.Format("{0,8}", "Ball");
            message += '\t';
            message += string.Format("{0,8:F2}", radius);
            message += '\t';
            message += string.Format("{0,8}", " ");
            return message;
        }
        public double RollLength()
        {
            return radius * radius;
        }
        public string RollingOutput()
        {
            string output = Output();
            output += '\t';
            output += string.Format("{0,8:F2}", RollLength());
            output += Environment.NewLine;
            return output;
        }
    }
}
