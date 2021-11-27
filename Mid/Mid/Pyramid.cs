using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    class Pyramid:Shape3D
    {
        public double side;
        public double height;
        public Pyramid() : base() //建構子。
        {
        }
        public Pyramid(double ref1, double ref2, Item.Material input) : base(input) //建構子。
        {
            side = ref1;
            height = ref2;
            m = input;
            s = Item.Shape.Pyramid;
        }
        public override double Volume()
        {
            double volume;
            volume = side * side * height / 3;
            return volume;
        }
        public override string Message()
        {
            string message = "";
            message += string.Format("{0,8}", "Pyramid");
            message += '\t';
            message += string.Format("{0,8:F2}", side);
            message += '\t';
            message += string.Format("{0,8:F2}", height);
            return message;
        }
    }
}
