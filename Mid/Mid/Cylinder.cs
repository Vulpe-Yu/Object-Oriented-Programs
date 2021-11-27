using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    class Cylinder:Shape3D, IRollable
    {
        public double radius;
        public double height;
        public Cylinder() : base() //建構子。
        {
        }
        public Cylinder(double ref1, double ref2, Item.Material input) : base(input) //建構子。
        {
            radius = ref1;
            height = ref2;
            m = input;
            s = Item.Shape.Cylinder;
        }
        public override double Volume()
        {
            double volume;
            volume = Math.PI * radius * radius * height;
            return volume;
        }
        public override string Message()
        {
            string message = "";
            message += string.Format("{0,8}", "Cylinder");
            message += '\t';
            message += string.Format("{0,8:F2}", radius);
            message += '\t';
            message += string.Format("{0,8:F2}", height);
            return message;
        }
        public double RollLength()
        {
            return radius * height;
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
