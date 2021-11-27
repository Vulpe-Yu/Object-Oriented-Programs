using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    static class Item
    {
        public enum Shape
        { Unknown = 0, Ball = 1, Cube = 2, Cylinder = 3, Pyramid = 4 };
        public enum Material
        { Unknown = 0, Al = 1, Fe = 2, Pb = 3 };
    }
    abstract class Shape3D
    {
        public Item.Shape s;
        public Item.Material m;
        public Shape3D() //建構子。
        {
        }
        public Shape3D(Item.Material input) //建構子。
        {
            m = input;
        }
        public double Density()
        {
            double density = 0;
            switch (m)
            {
                case Item.Material.Al:
                    density = 2.7;
                    break;
                case Item.Material.Fe:
                    density = 7.87;
                    break;
                case Item.Material.Pb:
                    density = 11.3;
                    break;
                default:
                    break;
            }
            return density;
        }
        public abstract double Volume();
        public double Weight()
        {
            return Density() * Volume();
        }
        public abstract string Message();
        public string Output()
        {
            string output = Message();
            output += '\t';
            output += string.Format("{0,8:F2}", Density());
            output += '\t';
            output += string.Format("{0,8:F2}", Volume());
            output += '\t';
            output += string.Format("{0,8:F2}", Weight());
            return output;
        }
        public string NormalOutput()
        {
            string output = Output();
            output += Environment.NewLine;
            return output;
        }
    }
}
