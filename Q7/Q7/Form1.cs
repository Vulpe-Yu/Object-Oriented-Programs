using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q7
{
    public partial class Form1 : Form
    {
        private Item[] Arr = new Item[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    Arr[Item.Amount] = new Ball(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    txtMessage.AppendText(Arr[Item.Amount - 1].ShapeProperty());
                    break;
                case "立方體":
                    Arr[Item.Amount] = new Cube(Double.Parse(txtPara1.Text), Double.Parse(txtDensity.Text));
                    txtMessage.AppendText(Arr[Item.Amount - 1].ShapeProperty());
                    break;
                case "圓柱體":
                    Arr[Item.Amount] = new Cylinder(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), Double.Parse(txtDensity.Text));
                    txtMessage.AppendText(Arr[Item.Amount - 1].ShapeProperty());
                    break;
                case "金字塔":
                    Arr[Item.Amount] = new Pyramid(Double.Parse(txtPara1.Text), Double.Parse(txtPara2.Text), Double.Parse(txtDensity.Text));
                    txtMessage.AppendText(Arr[Item.Amount - 1].ShapeProperty());
                    break;
                default:
                    break;
            }
            txtMessage.AppendText("\r\n");
            txtAmountOfShape.Text = Item.Amount.ToString();
            txtBallAmount.Text = Ball.Amount.ToString();
            txtCubeAmount.Text = Cube.Amount.ToString();
            txtCylinderAmount.Text = Cylinder.Amount.ToString();
            txtPyramidAmount.Text = Pyramid.Amount.ToString();


        }

        private void cboxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = cboxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "球":
                    lblPara1.Text = "半徑";
                    lblPara2.Visible = false;
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
            while (Arr[index] != null)
            {
                if (Arr[index].Weight() > maxWeight)
                {
                    maxWeight = Arr[index].Weight();
                    info = Arr[index].ShapeProperty();
                }
                index++;
            }
            txt_ShowHeaviestShape.Text = info;
        }
    }
}
