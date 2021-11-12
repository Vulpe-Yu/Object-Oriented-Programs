using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Item
    {
        protected static int _amount;
        protected double _density;

        public Item()
        {
            _amount++;
        }

        public static int Amount
        {
            get { return _amount; }
        }

        public double Density
        {
            get { return _density; }
            set
            {
                if (value < 0)
                    _density = 0;
                else
                    _density = value;
            }
        }

        public double Weight()
        {
            return _density * Volume();
        }

        public virtual double Volume()
        {
            return 0;
        }

        public virtual string ShapeProperty()
        {
            return "";
        }

        public string Property()
        {
            string str = "";
            str += '\t';
            str += string.Format("{0,8:F2}", _density);
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }
    }
}
