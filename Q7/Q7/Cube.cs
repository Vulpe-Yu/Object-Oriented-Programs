using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Cube : Item
    {
        new private static int _amount;
        private double _side;

        public Cube()
        {
            _side = 0;
            _density = 0;
            _amount++;
        }

        public Cube(double side, double density)
        {
            Side = side;
            Density = density;
            _amount++;
        }

        new public static int Amount
        {
            get { return _amount; }
        }

        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                    _side = 0;
                else
                    _side = value;
            }
        }

        public override double Volume()
        {
            return _side * _side * _side;
        }

        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Cube");
            str += '\t';
            str += string.Format("{0,8:F2}", _side);
            str += '\t';
            str += string.Format("{0,8}", "");
            str += Property();
            return str;
        }
    }
}
