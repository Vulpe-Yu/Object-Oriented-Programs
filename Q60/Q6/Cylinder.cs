using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Cylinder //圓柱體。
    {
        public double density;
        public double radius; //半徑。
        public double length; //高度。

        public double Volume() //計算體積。
        {
            double volume;
            volume = Math.PI * radius * radius * length;
            return volume;
        }

        public double Weight() //計算重量。
        {
            double weight;
            weight = Volume() * density;
            return weight;
        }

        public string Output()
        {
            string result = string.Format("{0,8}", "Cylinder");
            result += "\t";
            result += string.Format("{0,8:F2}", radius);
            result += "\t";
            result += string.Format("{0,8:F2}", length);
            result += "\t";
            result += string.Format("{0,8:F2}", density);
            result += "\t";
            result += string.Format("{0,8:F2}", Volume());
            result += "\t";
            result += string.Format("{0,8:F2}", Weight());
            result += Environment.NewLine;
            return result;
        }
    }
}
