using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Mid
{
    public partial class Form1 : Form
    {
        ArrayList arr = new ArrayList();
        List<IRollable> roll = new System.Collections.Generic.List<IRollable>();
        private Item.Material input;
        private delegate bool SortMethod(Shape3D S1, Shape3D S2);
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "鋁";
            comboBox2.SelectedItem = "球";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            comboBox3.SelectedItem = "形狀";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "鋁":
                    textBox1.Text = "2.7";
                    input = Item.Material.Al;
                    break;
                case "鐵":
                    textBox1.Text = "7.87";
                    input = Item.Material.Fe;
                    break;
                case "鉛":
                    textBox1.Text = "11.3";
                    input = Item.Material.Pb;
                    break;
                default:
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "球":
                    label4.Text = "半徑";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    break;
                case "立方體":
                    label4.Text = "邊長";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    break;
                case "圓柱體":
                    label4.Text = "半徑";
                    label5.Visible = true;
                    textBox3.Visible = true;
                    break;
                case "金字塔":
                    label4.Text = "邊長";
                    label5.Visible = true;
                    textBox3.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void addNum(TextBox box)
        {
            box.Text = (int.Parse(box.Text) + 1).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addNum(textBox4);
            switch (comboBox2.SelectedItem.ToString())
            {
                case "球":
                    arr.Add(new Ball(double.Parse(textBox2.Text), input));
                    roll.Add(new Ball(double.Parse(textBox2.Text), input));
                    addNum(textBox5);
                    break;
                case "立方體":
                    arr.Add(new Cube(double.Parse(textBox2.Text), input));
                    addNum(textBox6);
                    break;
                case "圓柱體":
                    arr.Add(new Cylinder(double.Parse(textBox2.Text), double.Parse(textBox3.Text), input));
                    roll.Add(new Cylinder(double.Parse(textBox2.Text), double.Parse(textBox3.Text), input));
                    addNum(textBox7);
                    break;
                case "金字塔":
                    arr.Add(new Pyramid(double.Parse(textBox2.Text), double.Parse(textBox3.Text), input));
                    addNum(textBox8);
                    break;
                default:
                    break;
            }
            if (arr[arr.Count - 1] is Shape3D)
            {
                Shape3D shape;
                shape = (Shape3D)arr[arr.Count - 1];
                textBox9.AppendText(shape.NormalOutput());
            }
        }
        private bool ShapeUp(Shape3D S1, Shape3D S2)
        {
            if (S1.s > S2.s)
                return true;
            else return false;
        }
        private bool ShapeDown(Shape3D S1, Shape3D S2)
        {
            if (S1.s < S2.s)
                return true;
            else return false;
        }
        private bool MaterialUp(Shape3D S1, Shape3D S2)
        {
            if (S1.m > S2.m)
                return true;
            else return false;
        }
        private bool MaterialDown(Shape3D S1, Shape3D S2)
        {
            if (S1.m < S2.m)
                return true;
            else return false;
        }
        private bool VolumeUp(Shape3D S1, Shape3D S2)
        {
            if (S1.Volume() > S2.Volume())
                return true;
            else return false;
        }
        private bool VolumeDown(Shape3D S1, Shape3D S2)
        {
            if (S1.Volume() < S2.Volume())
                return true;
            else return false;
        }
        private bool WeightUp(Shape3D S1, Shape3D S2)
        {
            if (S1.Weight() > S2.Weight())
                return true;
            else return false;
        }
        private bool WeightDown(Shape3D S1, Shape3D S2)
        {
            if (S1.Weight() < S2.Weight())
                return true;
            else return false;
        }
        private void Sorting(SortMethod method)
        {
            for (int i = 0; i < arr.Count; i++)
                for (int j = 0; j < arr.Count - 1; j++)
                    if (method((Shape3D)arr[j], (Shape3D)arr[j + 1]))
                    {
                        object temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "形狀":
                    if (radioButton1.Checked)
                        Sorting(ShapeUp);
                    else Sorting(ShapeDown);
                    break;
                case "材質":
                    if (radioButton1.Checked)
                        Sorting(MaterialUp);
                    else Sorting(MaterialDown);
                    break;
                case "體積":
                    if (radioButton1.Checked)
                        Sorting(VolumeUp);
                    else Sorting(VolumeDown);
                    break;
                case "重量":
                    if (radioButton1.Checked)
                        Sorting(WeightUp);
                    else Sorting(WeightDown);
                    break;
                default:
                    break;
            }
            string message = "";
            foreach (Shape3D shape in arr)
            {
                message += shape.NormalOutput();
            }
            textBox10.Text = message;
        }
        private int Compare(IRollable a, IRollable b) //傳入型別。
        {
            if (a.RollLength() > b.RollLength())
                return 1;
            else return -1;
        }  
        private void button3_Click(object sender, EventArgs e)
        {
            roll.Sort(Compare);
            string message = "";
            foreach (IRollable rollable in roll)
            {
                message += rollable.RollingOutput();
            }
            textBox11.Text = message;
        }
    }
}
