namespace Q6
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Material = new System.Windows.Forms.GroupBox();
            this.textBox_Density = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Material = new System.Windows.Forms.ComboBox();
            this.groupBox_Geometry = new System.Windows.Forms.GroupBox();
            this.textBox_ref2 = new System.Windows.Forms.TextBox();
            this.textBox_ref1 = new System.Windows.Forms.TextBox();
            this.label_ref2 = new System.Windows.Forms.Label();
            this.label_ref1 = new System.Windows.Forms.Label();
            this.comboBox_Shape = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Amont = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Pyramid = new System.Windows.Forms.TextBox();
            this.textBox_Cylinder = new System.Windows.Forms.TextBox();
            this.textBox_Cube = new System.Windows.Forms.TextBox();
            this.textBox_Ball = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox_Result = new System.Windows.Forms.GroupBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Material.SuspendLayout();
            this.groupBox_Geometry.SuspendLayout();
            this.groupBox_Amont.SuspendLayout();
            this.groupBox_Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Material
            // 
            this.groupBox_Material.Controls.Add(this.textBox_Density);
            this.groupBox_Material.Controls.Add(this.label2);
            this.groupBox_Material.Controls.Add(this.label1);
            this.groupBox_Material.Controls.Add(this.comboBox_Material);
            this.groupBox_Material.Location = new System.Drawing.Point(18, 18);
            this.groupBox_Material.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Material.Name = "groupBox_Material";
            this.groupBox_Material.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Material.Size = new System.Drawing.Size(320, 201);
            this.groupBox_Material.TabIndex = 0;
            this.groupBox_Material.TabStop = false;
            this.groupBox_Material.Text = "Material";
            // 
            // textBox_Density
            // 
            this.textBox_Density.Location = new System.Drawing.Point(111, 124);
            this.textBox_Density.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Density.Name = "textBox_Density";
            this.textBox_Density.Size = new System.Drawing.Size(152, 29);
            this.textBox_Density.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "密度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "材質";
            // 
            // comboBox_Material
            // 
            this.comboBox_Material.FormattingEnabled = true;
            this.comboBox_Material.Location = new System.Drawing.Point(111, 46);
            this.comboBox_Material.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Material.Name = "comboBox_Material";
            this.comboBox_Material.Size = new System.Drawing.Size(152, 26);
            this.comboBox_Material.TabIndex = 0;
            this.comboBox_Material.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Material_SelectedIndexChanged);
            // 
            // groupBox_Geometry
            // 
            this.groupBox_Geometry.Controls.Add(this.textBox_ref2);
            this.groupBox_Geometry.Controls.Add(this.textBox_ref1);
            this.groupBox_Geometry.Controls.Add(this.label_ref2);
            this.groupBox_Geometry.Controls.Add(this.label_ref1);
            this.groupBox_Geometry.Controls.Add(this.comboBox_Shape);
            this.groupBox_Geometry.Controls.Add(this.label3);
            this.groupBox_Geometry.Location = new System.Drawing.Point(18, 228);
            this.groupBox_Geometry.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Geometry.Name = "groupBox_Geometry";
            this.groupBox_Geometry.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Geometry.Size = new System.Drawing.Size(320, 266);
            this.groupBox_Geometry.TabIndex = 1;
            this.groupBox_Geometry.TabStop = false;
            this.groupBox_Geometry.Text = "Geometry";
            // 
            // textBox_ref2
            // 
            this.textBox_ref2.Location = new System.Drawing.Point(111, 196);
            this.textBox_ref2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ref2.Name = "textBox_ref2";
            this.textBox_ref2.Size = new System.Drawing.Size(152, 29);
            this.textBox_ref2.TabIndex = 5;
            // 
            // textBox_ref1
            // 
            this.textBox_ref1.Location = new System.Drawing.Point(111, 122);
            this.textBox_ref1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ref1.Name = "textBox_ref1";
            this.textBox_ref1.Size = new System.Drawing.Size(152, 29);
            this.textBox_ref1.TabIndex = 4;
            // 
            // label_ref2
            // 
            this.label_ref2.AutoSize = true;
            this.label_ref2.Location = new System.Drawing.Point(39, 201);
            this.label_ref2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ref2.Name = "label_ref2";
            this.label_ref2.Size = new System.Drawing.Size(44, 18);
            this.label_ref2.TabIndex = 4;
            this.label_ref2.Text = "高度";
            // 
            // label_ref1
            // 
            this.label_ref1.AutoSize = true;
            this.label_ref1.Location = new System.Drawing.Point(39, 126);
            this.label_ref1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ref1.Name = "label_ref1";
            this.label_ref1.Size = new System.Drawing.Size(44, 18);
            this.label_ref1.TabIndex = 3;
            this.label_ref1.Text = "半徑";
            // 
            // comboBox_Shape
            // 
            this.comboBox_Shape.FormattingEnabled = true;
            this.comboBox_Shape.Location = new System.Drawing.Point(111, 45);
            this.comboBox_Shape.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Shape.Name = "comboBox_Shape";
            this.comboBox_Shape.Size = new System.Drawing.Size(152, 26);
            this.comboBox_Shape.TabIndex = 2;
            this.comboBox_Shape.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Shape_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "形狀";
            // 
            // groupBox_Amont
            // 
            this.groupBox_Amont.Controls.Add(this.label8);
            this.groupBox_Amont.Controls.Add(this.label7);
            this.groupBox_Amont.Controls.Add(this.label6);
            this.groupBox_Amont.Controls.Add(this.label5);
            this.groupBox_Amont.Controls.Add(this.textBox_Pyramid);
            this.groupBox_Amont.Controls.Add(this.textBox_Cylinder);
            this.groupBox_Amont.Controls.Add(this.textBox_Cube);
            this.groupBox_Amont.Controls.Add(this.textBox_Ball);
            this.groupBox_Amont.Controls.Add(this.label4);
            this.groupBox_Amont.Controls.Add(this.textBox_sum);
            this.groupBox_Amont.Controls.Add(this.button_Add);
            this.groupBox_Amont.Location = new System.Drawing.Point(18, 502);
            this.groupBox_Amont.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Amont.Name = "groupBox_Amont";
            this.groupBox_Amont.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Amont.Size = new System.Drawing.Size(564, 324);
            this.groupBox_Amont.TabIndex = 2;
            this.groupBox_Amont.TabStop = false;
            this.groupBox_Amont.Text = "Amont Of Shape";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "金字塔";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "圓柱體";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "立方體";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "球";
            // 
            // textBox_Pyramid
            // 
            this.textBox_Pyramid.Location = new System.Drawing.Point(435, 252);
            this.textBox_Pyramid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Pyramid.Name = "textBox_Pyramid";
            this.textBox_Pyramid.Size = new System.Drawing.Size(90, 29);
            this.textBox_Pyramid.TabIndex = 10;
            // 
            // textBox_Cylinder
            // 
            this.textBox_Cylinder.Location = new System.Drawing.Point(304, 252);
            this.textBox_Cylinder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Cylinder.Name = "textBox_Cylinder";
            this.textBox_Cylinder.Size = new System.Drawing.Size(90, 29);
            this.textBox_Cylinder.TabIndex = 9;
            // 
            // textBox_Cube
            // 
            this.textBox_Cube.Location = new System.Drawing.Point(174, 252);
            this.textBox_Cube.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Cube.Name = "textBox_Cube";
            this.textBox_Cube.Size = new System.Drawing.Size(90, 29);
            this.textBox_Cube.TabIndex = 8;
            // 
            // textBox_Ball
            // 
            this.textBox_Ball.Location = new System.Drawing.Point(42, 252);
            this.textBox_Ball.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ball.Name = "textBox_Ball";
            this.textBox_Ball.Size = new System.Drawing.Size(90, 29);
            this.textBox_Ball.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "總數";
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(196, 90);
            this.textBox_sum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(152, 29);
            this.textBox_sum.TabIndex = 6;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(42, 90);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(112, 34);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // groupBox_Result
            // 
            this.groupBox_Result.Controls.Add(this.textBox_output);
            this.groupBox_Result.Controls.Add(this.button_Clear);
            this.groupBox_Result.Location = new System.Drawing.Point(591, 18);
            this.groupBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Result.Name = "groupBox_Result";
            this.groupBox_Result.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Result.Size = new System.Drawing.Size(939, 807);
            this.groupBox_Result.TabIndex = 3;
            this.groupBox_Result.TabStop = false;
            this.groupBox_Result.Text = "Message";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(44, 51);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(852, 661);
            this.textBox_output.TabIndex = 16;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(804, 750);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(112, 34);
            this.button_Clear.TabIndex = 15;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 843);
            this.Controls.Add(this.groupBox_Result);
            this.Controls.Add(this.groupBox_Amont);
            this.Controls.Add(this.groupBox_Geometry);
            this.Controls.Add(this.groupBox_Material);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quiz6";
            this.groupBox_Material.ResumeLayout(false);
            this.groupBox_Material.PerformLayout();
            this.groupBox_Geometry.ResumeLayout(false);
            this.groupBox_Geometry.PerformLayout();
            this.groupBox_Amont.ResumeLayout(false);
            this.groupBox_Amont.PerformLayout();
            this.groupBox_Result.ResumeLayout(false);
            this.groupBox_Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Material;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Density;
        private System.Windows.Forms.GroupBox groupBox_Geometry;
        private System.Windows.Forms.ComboBox comboBox_Shape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ref2;
        private System.Windows.Forms.TextBox textBox_ref1;
        private System.Windows.Forms.Label label_ref2;
        private System.Windows.Forms.Label label_ref1;
        private System.Windows.Forms.GroupBox groupBox_Amont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Pyramid;
        private System.Windows.Forms.TextBox textBox_Cylinder;
        private System.Windows.Forms.TextBox textBox_Cube;
        private System.Windows.Forms.TextBox textBox_Ball;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox groupBox_Result;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_output;
    }
}

