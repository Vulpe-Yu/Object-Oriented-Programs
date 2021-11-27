using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    class Cube:Shape3D
    {
        public double side;
        public Cube() : base() //建構子。
        {
        }
        public Cube(double ref1, Item.Material input) : base(input) //建構子。
        {
            side = ref1;
            m = input;
            s = Item.Shape.Cube;
        }
        public override double Volume()
        {
            double volume;
            volume = side * side * side;
            return volume;
        }
        public override string Message()
        {
            string message = "";
            message += string.Format("{0,8}", "Cube");
            message += '\t';
            message += string.Format("{0,8:F2}", side);
            message += '\t';
            message += string.Format("{0,8}", " ");
            return message;
        }
    }
}