using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz7;

namespace _106_Quiz6
{
    class Ball:Shape3D
    {
        new private static int _amount; //隱藏繼承
        private double _radius;
        private static double _pi=3.1415926;  //可以使用 readonly 來修飾
        public Ball():base()
        {
            _radius = 0;
            _amount++;
        }

        public Ball(double radius, Sort.Material mtype) :base(mtype)
        {
            _stype = Sort.Shape.Ball;
            Radius = radius;
            _amount++;
        }
        new public static int Amount   //隱藏繼承
        {
            get { return _amount; }
        }
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    _radius = 0;
                else
                    _radius = value;
            }
        }

        public override double Volume()     //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            return 4.0/3*_pi*_radius*_radius*_radius;
        }

        public override string ShapeProperty()     //改寫父類別的方法, 給其他類別使用故宣告為 public
        {
            string str = string.Format("{0,8}", "Ball");
            str += '\t';
            str += string.Format("{0,8:F2}", _radius);
            str += '\t';
            str += string.Format("{0,8}", "");
            str += '\t';
            str += Property();    //重構, 降低重複的程式碼
            return str;
        }
    }
}
