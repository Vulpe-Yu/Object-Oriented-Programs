using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4; //using namespace。

namespace CW5plus
{
    public partial class Form1 : Form
    {
        private RadioButton[,] radiobutton; //radiobutton陣列，RadioButton為單選，單一groupBox中僅可選中一個。
        private GroupBox[,] groupbox; //groupbox陣列，搭配radiobutton陣列使用，使其可多選。
        int counter = 0; //計算被選中的RadioButton數量。
        RadioButton[] select = new RadioButton[3]; //被選中的RadioButton，陣列儲存。
        private TextBox[,] rowcol = new TextBox[3,2]; //行列值TextBox陣列。
        private TextBox[,] xyCoord = new TextBox[3, 2]; //XY值TextBox陣列。

        public Form1() //建構子。
        {
            InitializeComponent(); //初始化物件。
        }

        private void CreateBoard_Click(object sender, EventArgs e) //Create Pin Board按鍵。
        {
            if (groupBox3.Controls.Count > 0) //groupBox3中控制元件總數大於0，即存在radiobutton。
            {
                foreach (Control item in radiobutton) //清除radiobutton陣列物件。
                {
                    item.Dispose();
                }
                foreach (Control item in groupbox) //清除groupbox陣列物件。
                {
                    item.Dispose();
                }
            }
            int row = int.Parse(Row.Text);
            int col = int.Parse(Col.Text); //讀入行列數。
            radiobutton = new RadioButton[row, col]; //建立新radiobutton陣列。
            groupbox = new GroupBox[row, col]; //建立新groupbox陣列。
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.radiobutton[i, j] = new RadioButton(); //建構新RadioButton物件。
                    this.groupbox[i, j] = new GroupBox(); //建構新GroupBox物件。
                    this.groupbox[i, j].Controls.Add(this.radiobutton[i, j]); //將RadioButton加到GroupBox中。(相當於綁定兩者。)
                    this.groupbox[i, j].Size = new System.Drawing.Size(28, 34); //GroupBox長寬。
                    this.radiobutton[i, j].Size = new System.Drawing.Size(16, 16); //RadioButton長寬。
                    this.groupbox[i, j].Location = new System.Drawing.Point(20 + j * 34, 20 + i * 32); //新建GroupBox相對GroupBox3的位置，座標疊加。(參考點為左上角。)
                    this.radiobutton[i, j].Location = new System.Drawing.Point(7, 12); //RadioButton相對GroupBox的位置。(參考點為左上角。)
                    this.groupBox3.Controls.Add(this.groupbox[i, j]); //加入此GroupBox組件。
                    this.radiobutton[i, j].Name = "radiobutton" + i.ToString() + j.ToString(); //對產生的RadioButton命名。
                    this.radiobutton[i, j].CheckedChanged += new EventHandler(this.radiobutton_CheckedChanged);
                }
            }
        }
        
        private void radiobutton_CheckedChanged(object sender, EventArgs e) //更改所選radiobutton。
        {
            select[counter] = (RadioButton)sender; //被選中的RadioButton。
            if (select[counter].Checked == true) //該RadioButton被選中。
            {
                counter += 1; //計數器+1。
            }
            if (counter == 3) //有三個RadioButton被選中。
            {
                foreach (Control item in radiobutton) //鎖定所有RadioButton。
                {
                    item.Enabled = false;
                }
                foreach (Control item in select) //取消鎖定選中的RadioButton。
                {
                    item.Enabled = true;
                }
            }
            int row = int.Parse(Row.Text);
            int col = int.Parse(Col.Text); //讀入行列數。
            rowcol[0, 0] = Row1;
            rowcol[0, 1] = Col1;
            rowcol[1, 0] = Row2;
            rowcol[1, 1] = Col2;
            rowcol[2, 0] = Row3;
            rowcol[2, 1] = Col3; //TextBox陣列化。
            xyCoord[0, 0] = X1;
            xyCoord[0, 1] = Y1;
            xyCoord[1, 0] = X2;
            xyCoord[1, 1] = Y2;
            xyCoord[2, 0] = X3;
            xyCoord[2, 1] = Y3; //TextBox陣列化。
            double xint = double.Parse(XInt.Text);
            double yint = double.Parse(YInt.Text); //行列距取得。
            for (int k = 0; k < counter; k++)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (radiobutton[i, j] == select[k])
                        {
                            rowcol[k, 0].Text = i.ToString();
                            rowcol[k, 1].Text = j.ToString(); //填入行列值。
                            xyCoord[k, 0].Text = (j * xint).ToString();
                            xyCoord[k, 1].Text = (i * yint).ToString(); //填入XY值。
                        }
                    }
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e) //Reset Pin Board按鍵。
        {
            counter = 0; //Reset Counter，需要放在第一行，否則有問題會影響到陣列索引值。
            foreach (RadioButton item in radiobutton) //所有RadioButton。
            {
                item.Checked = false; //取消選取。
                item.Enabled = true; //可被選取。
            }
            foreach (Control item in rowcol) //清空TextBox。
            {
                item.Text = "";
                item.Enabled = true;
            }
            foreach (Control item in xyCoord)
            {
                item.Text = "";
                item.Enabled = true;
            }
        }

        private void Calculate_Click(object sender, EventArgs e) //計算按鍵。
        {
            string output = ""; //輸出訊息，初始為空。
            Triangle triangle = new Triangle(); //建立new class Triangle。
            triangle.CreatePoints(); //建構內部class Point。
            triangle.ptArr[0].xCoord = double.Parse(X1.Text);
            triangle.ptArr[0].yCoord = double.Parse(Y1.Text);
            triangle.ptArr[1].xCoord = double.Parse(X2.Text);
            triangle.ptArr[1].yCoord = double.Parse(Y2.Text);
            triangle.ptArr[2].xCoord = double.Parse(X3.Text);
            triangle.ptArr[2].yCoord = double.Parse(Y3.Text); //讀入當前座標值。
            if (triangle.isValid() == true) //可形成三角形。
            {
                output += ("面積 = " + triangle.Area().ToString() + Environment.NewLine); //輸出面積。
                //空字串基礎上加入輸出內容。
                //Environment.NewLine換行。
                output += ("周長 = " + triangle.Perimeter().ToString() + Environment.NewLine); //輸出周長。
                switch (triangle.ShapeType()) //分辨類型。
                {
                    case 1:
                        output += ("直角三角形" + Environment.NewLine + Environment.NewLine);
                        break;
                    case 2:
                        output += ("銳角三角形" + Environment.NewLine + Environment.NewLine);
                        break;
                    case 3:
                        output += ("鈍角三角形" + Environment.NewLine + Environment.NewLine);
                        break;
                }
            }
            else //無法形成三角形。
            {
                output += ("此三點無法形成三角形。" + Environment.NewLine + Environment.NewLine);
            }
            Output.AppendText(output); //輸出結果。
            //或Output.Text = output;
        }

        private void Clear_Click(object sender, EventArgs e) //Clear Result按鍵。
        {
            Output.Clear(); //清空輸出方塊。
        }
    }
}
