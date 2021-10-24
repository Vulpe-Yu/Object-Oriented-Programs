using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4; //using namespace

namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            Triangle A = new Triangle();
            string StrDisplay = ""; //輸出字串，預設空字串。
            A.CreatePoints();
            A.ptArr[0].xCoord = double.Parse(textBox_PointX1.Text);
            A.ptArr[0].yCoord = double.Parse(textBox_PointY1.Text);
            A.ptArr[1].xCoord = double.Parse(textBox_PointX2.Text);
            A.ptArr[1].yCoord = double.Parse(textBox_PointY2.Text);
            A.ptArr[2].xCoord = double.Parse(textBox_PointX3.Text);
            A.ptArr[2].yCoord = double.Parse(textBox_PointY3.Text);
            if (A.isValid() == true)
            {
                if (checkBox_Area.Checked) //勾選此方塊。
                {
                    StrDisplay += ("面積 = " + A.Area().ToString() + Environment.NewLine); //空字串基礎上加入輸出內容。
                    //Environment.NewLine換行。
                }
                if (checkBox_Length.Checked)
                {
                    StrDisplay += ("周長 = " + A.Perimeter().ToString() + Environment.NewLine);
                }
                if (checkBox_Angle.Checked)
                {
                    switch (A.ShapeType())
                    {
                        case 1:
                            StrDisplay += ("直角三角形" + Environment.NewLine + Environment.NewLine);
                            break;
                        case 2:
                            StrDisplay += ("銳角三角形" + Environment.NewLine + Environment.NewLine);
                            break;
                        case 3:
                            StrDisplay += ("鈍角三角形" + Environment.NewLine + Environment.NewLine);
                            break;
                    }
                }
            }
            else
            {
                StrDisplay += ("此三點無法形成三角形。" + Environment.NewLine + Environment.NewLine);
            }
            textBox_Result.AppendText(StrDisplay); //輸出結果。
            //或textBox_Result.Text = StrDisplay;
        }
    }
}
