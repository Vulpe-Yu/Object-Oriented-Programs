using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Pyramid //金字塔。
    {
        public double density;
        public double height; //高度。
        public double length; //邊長。

        public double Volume() //計算體積。
        {
            double volume;
            volume = length * length * height / 3;
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
            string result = string.Format("{0,8}", "Pyramid");
            result += "\t";
            result += string.Format("{0,8:F2}", length);
            result += "\t";
            result += string.Format("{0,8:F2}", height);
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
