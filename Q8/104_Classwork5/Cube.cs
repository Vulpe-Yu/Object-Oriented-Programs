using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;

namespace _106_Quiz6
{
    class Cube:Shape3D
    {
        new private static int _amount;  //隱藏繼承
        private double _side;
        public Cube():base()
        {
            _side = 0;
            _amount++;
        }
        public Cube(double side, Sort.Material mtype) : base(mtype)
        {
            _stype = Sort.Shape.Cube;
            Side = side;
            _amount++;
        }
        new public static int Amount  //隱藏繼承
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

        public override double Volume()   //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            return _side*_side*_side;
        }

        public override string ShapeProperty()    //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            string str = string.Format("{0,8}", "Cube");
            str += '\t';
            str += string.Format("{0,8:F2}", _side);
            str += '\t';
            str += string.Format("{0,8}", "");
            str += '\t';
            str += Property();     //重構, 降低重複的程式碼
            return str;
        }
    }
}
