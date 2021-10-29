using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Cube //立方體。
    {
        public double density;
        public double length; //邊長。

        public double Volume() //計算體積。
        {
            double volume;
            volume = length * length * length;
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
            string result = string.Format("{0,8}", "Cube");
            result += "\t";
            result += string.Format("{0,8:F2}", length);
            result += "\t";
            result += string.Format("{0,8:F2}", "null");
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
