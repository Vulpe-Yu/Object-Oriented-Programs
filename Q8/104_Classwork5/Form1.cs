using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz6;
using _106_Quiz7;
using System.Collections;

namespace _106_Quiz6
{
    public partial class Form1 : Form
    {
        private ArrayList shapeArr = new ArrayList();
        private Sort.Material _mtype;
        private delegate bool Compare(Shape3D a, Shape3D b);

        public Form1()
        {
            InitializeComponent();
            cBoxMaterial.SelectedItem = "鋁";
            cboxShape.SelectedItem = "球";
            comboBox1.SelectedItem = "形狀";
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            switch (cBoxMaterial.SelectedItem.ToString())
            {
                case "鋁":
                    _mtype = Sort.Material.Al;
                    break;
                case "鐵":
                    _mtype = Sort.Material.Fe;
                    break;
                case "鉛":
                    _mtype = Sort.Material.Pb;
                    break;
                default:
                    break;
            }
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    shapeArr.Add(new Ball(Double.Parse(txtPara1.Text), _mtype));
                    break;
                case "立方體":
                    shapeArr.Add(new Cube(Double.Parse(txtPara1.Text), _mtype));
                    break;
                case "圓柱體":
                    shapeArr.Add(new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mtype));
                    break;
                case "金字塔":
                    shapeArr.Add(new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), _mtype));
                    break;
                default:
                    break;
            }
            txtAmountOfShape.Text = Shape3D.Amount.ToString();
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();
            ShowAllShapeInfo(txtMessage);
        }
        private void ShowAllShapeInfo(TextBox box)
        {
            string info="";
            foreach (Shape3D shape in shapeArr)
            {
                info += (shape.ShapeProperty() + "\r\n");
            }
            box.Text = info;
        }

        private void cboxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible= false;
                    txtPara2.Visible = false;
                    break;
                case "立方體":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = false;
                    txtPara2.Visible = false;
                    break;
                case "圓柱體":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                case "金字塔":
                    lblPara1.Text = "邊長";
                    lblPara2.Visible = true;
                    lblPara2.Text = "高";
                    txtPara2.Visible = true;
                    break;
                default:
                    break;

            }

        }

        private void cBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = cBoxMaterial.SelectedItem.ToString();
            double density;
            bool canModified = false;
            switch (material)
            {
                case "鋁":
                    density = 2.7; 
                    break;
                case "鐵":
                    density = 7.87;
                    break;
                case "鉛":
                    density = 11.3;
                    break;
               
                default:
                    density = 0;
                    canModified = true;
                    break;
            }
            txtDensity.Text = density.ToString();
            if (!canModified)
                txtDensity.Enabled = false;
        }

        private void btn_FindHeaviestShape_Click(object sender, EventArgs e)
        {
            string info = "";
            double maxWeight = 0;
            int index = 0;
            foreach(Shape3D shape in shapeArr)
            {
                if(shape.Weight() > maxWeight)
                {
                    maxWeight = shape.Weight();
                    info = shape.ShapeProperty();
                }
                index++;
            }
            txt_ShowHeaviestShape.Text = info;
        }

        private bool ShapeUp(Shape3D a, Shape3D b)
        {
            if (a.Shape > b.Shape)
                return true;
            else return false;
        }
        private bool ShapeDown(Shape3D a, Shape3D b)
        {
            if (a.Shape < b.Shape)
                return true;
            else return false;
        }
        private bool MaterialUp(Shape3D a, Shape3D b)
        {
            if (a.Material > b.Material)
                return true;
            else return false;
        }
        private bool MaterialDown(Shape3D a, Shape3D b)
        {
            if (a.Material < b.Material)
                return true;
            else return false;
        }
        private bool VolumeUp(Shape3D a, Shape3D b)
        {
            if (a.Volume() > b.Volume())
                return true;
            else return false;
        }
        private bool VolumeDown(Shape3D a, Shape3D b)
        {
            if (a.Volume() < b.Volume())
                return true;
            else return false;
        }
        private bool WeightUp(Shape3D a, Shape3D b)
        {
            if (a.Weight() > b.Weight())
                return true;
            else return false;
        }
        private bool WeightDown(Shape3D a, Shape3D b)
        {
            if (a.Weight() < b.Weight())
                return true;
            else return false;
        }

        private void BubbleSort(Compare compare)
        {
            object temp;
            for(int i = 0; i < shapeArr.Count; i++)
            {
                for (int j = 0; j < shapeArr.Count - 1; j++)
                {
                    if(compare((Shape3D)shapeArr[j], (Shape3D)shapeArr[j + 1]))
                    {
                        temp = shapeArr[j];
                        shapeArr[j] = shapeArr[j + 1];
                        shapeArr[j + 1] = temp;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "形狀":
                    if(radioButton1.Checked)
                        BubbleSort(ShapeUp);
                    else BubbleSort(ShapeDown);
                    break;
                case "材料":
                    if (radioButton1.Checked)
                        BubbleSort(MaterialUp);
                    else BubbleSort(MaterialDown);
                    break;
                case "體積":
                    if (radioButton1.Checked)
                        BubbleSort(VolumeUp);
                    else BubbleSort(VolumeDown);
                    break;
                case "重量":
                    if (radioButton1.Checked)
                        BubbleSort(WeightUp);
                    else BubbleSort(WeightDown);
                    break;
                default :
                    break;

            }
            ShowAllShapeInfo(textBox1);
        }
    }
}
