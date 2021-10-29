using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_Material.Items.Add(new MyItem("鋁", "2.7"));
            comboBox_Material.Items.Add(new MyItem("鐵", "7.87"));
            comboBox_Material.Items.Add(new MyItem("鉛", "11.3")); //材料選項。
            comboBox_Shape.Items.Add("球");
            comboBox_Shape.Items.Add("立方體");
            comboBox_Shape.Items.Add("圓柱體");
            comboBox_Shape.Items.Add("金字塔"); //形狀選項。
            textBox_sum.Text = "0";
            textBox_Ball.Text = "0";
            textBox_Cube.Text = "0";
            textBox_Cylinder.Text = "0";
            textBox_Pyramid.Text = "0"; //初始個數為0。
        }

        private void ComboBox_Material_SelectedIndexChanged(object sender, EventArgs e) //選擇材料改變。
        {
            textBox_Density.Text = ((MyItem)comboBox_Material.SelectedItem).RealValue;
        }

        private void ComboBox_Shape_SelectedIndexChanged(object sender, EventArgs e) //選擇形狀改變。
        {
            switch (comboBox_Shape.SelectedItem.ToString())
            {
                case "球":
                    label_ref1.Text = "半徑";
                    label_ref2.Visible = false;
                    textBox_ref2.Visible = false;
                    break;
                case "立方體":
                    label_ref1.Text = "邊長";
                    label_ref2.Visible = false;
                    textBox_ref2.Visible = false;
                    break;
                case "圓柱體":
                    label_ref1.Text = "半徑";
                    label_ref2.Text = "高度";
                    label_ref2.Visible = true;
                    textBox_ref2.Visible = true;
                    break;
                case "金字塔":
                    label_ref1.Text = "邊長";
                    label_ref2.Text = "高度";
                    label_ref2.Visible = true;
                    textBox_ref2.Visible = true;
                    break;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_output.Clear();
            textBox_sum.Text = "0";
            textBox_Ball.Text = "0";
            textBox_Cube.Text = "0";
            textBox_Cylinder.Text = "0";
            textBox_Pyramid.Text = "0"; //初始個數為0。
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            textBox_sum.Text = (int.Parse(textBox_sum.Text) + 1).ToString();
            switch (comboBox_Shape.SelectedItem.ToString())
            {
                case "球":
                    textBox_Ball.Text = (int.Parse(textBox_Ball.Text) + 1).ToString();
                    Ball ball = new Ball();
                    ball.density = double.Parse(textBox_Density.Text);
                    ball.radius = double.Parse(textBox_ref1.Text);
                    textBox_output.AppendText(ball.Output());
                    break;
                case "立方體":
                    textBox_Cube.Text = (int.Parse(textBox_Cube.Text) + 1).ToString();
                    Cube cube = new Cube();
                    cube.density = double.Parse(textBox_Density.Text);
                    cube.length = double.Parse(textBox_ref1.Text);
                    textBox_output.AppendText(cube.Output());
                    break;
                case "圓柱體":
                    textBox_Cylinder.Text = (int.Parse(textBox_Cylinder.Text) + 1).ToString();
                    Cylinder cylinder = new Cylinder();
                    cylinder.density = double.Parse(textBox_Density.Text);
                    cylinder.radius = double.Parse(textBox_ref1.Text);
                    cylinder.length = double.Parse(textBox_ref2.Text);
                    textBox_output.AppendText(cylinder.Output());
                    break;
                case "金字塔":
                    textBox_Pyramid.Text = (int.Parse(textBox_Pyramid.Text) + 1).ToString();
                    Pyramid pyramid = new Pyramid();
                    pyramid.density = double.Parse(textBox_Density.Text);
                    pyramid.height = double.Parse(textBox_ref2.Text);
                    pyramid.length = double.Parse(textBox_ref1.Text);
                    textBox_output.AppendText(pyramid.Output());
                    break;
            }
        }
    }

    struct MyItem //材料選項，get/set形式。
    {
        public MyItem(string displayName, string realValue)
        {
            DisplayName = displayName;
            RealValue = realValue;
        }
        public string DisplayName { get; set; }
        public string RealValue { get; set; }
        // must have this override method to display the right string.
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
