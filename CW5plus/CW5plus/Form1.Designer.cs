
namespace CW5plus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateBoard = new System.Windows.Forms.Button();
            this.YInt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.XInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Col = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Row = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X3 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Col3 = new System.Windows.Forms.TextBox();
            this.Col2 = new System.Windows.Forms.TextBox();
            this.Row3 = new System.Windows.Forms.TextBox();
            this.Row2 = new System.Windows.Forms.TextBox();
            this.Col1 = new System.Windows.Forms.TextBox();
            this.Row1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateBoard);
            this.groupBox1.Controls.Add(this.YInt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.XInt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Col);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Row);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PinBoard參數";
            // 
            // CreateBoard
            // 
            this.CreateBoard.Location = new System.Drawing.Point(298, 279);
            this.CreateBoard.Name = "CreateBoard";
            this.CreateBoard.Size = new System.Drawing.Size(173, 27);
            this.CreateBoard.TabIndex = 4;
            this.CreateBoard.Text = "Create Pin Board";
            this.CreateBoard.UseVisualStyleBackColor = true;
            this.CreateBoard.Click += new System.EventHandler(this.CreateBoard_Click);
            // 
            // YInt
            // 
            this.YInt.Location = new System.Drawing.Point(361, 185);
            this.YInt.Name = "YInt";
            this.YInt.Size = new System.Drawing.Size(100, 29);
            this.YInt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "列距";
            // 
            // XInt
            // 
            this.XInt.Location = new System.Drawing.Point(120, 185);
            this.XInt.Name = "XInt";
            this.XInt.Size = new System.Drawing.Size(100, 29);
            this.XInt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "行距";
            // 
            // Col
            // 
            this.Col.Location = new System.Drawing.Point(361, 89);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(100, 29);
            this.Col.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "直列數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "橫行數";
            // 
            // Row
            // 
            this.Row.Location = new System.Drawing.Point(120, 89);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(100, 29);
            this.Row.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Calculate);
            this.groupBox2.Controls.Add(this.Y3);
            this.groupBox2.Controls.Add(this.Y2);
            this.groupBox2.Controls.Add(this.Y1);
            this.groupBox2.Controls.Add(this.X3);
            this.groupBox2.Controls.Add(this.X2);
            this.groupBox2.Controls.Add(this.X1);
            this.groupBox2.Controls.Add(this.Col3);
            this.groupBox2.Controls.Add(this.Col2);
            this.groupBox2.Controls.Add(this.Row3);
            this.groupBox2.Controls.Add(this.Row2);
            this.groupBox2.Controls.Add(this.Col1);
            this.groupBox2.Controls.Add(this.Row1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "各點參數";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(403, 317);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(68, 29);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "計算";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(361, 251);
            this.Y3.Name = "Y3";
            this.Y3.ReadOnly = true;
            this.Y3.Size = new System.Drawing.Size(74, 29);
            this.Y3.TabIndex = 14;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(361, 182);
            this.Y2.Name = "Y2";
            this.Y2.ReadOnly = true;
            this.Y2.Size = new System.Drawing.Size(74, 29);
            this.Y2.TabIndex = 13;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(361, 114);
            this.Y1.Name = "Y1";
            this.Y1.ReadOnly = true;
            this.Y1.Size = new System.Drawing.Size(74, 29);
            this.Y1.TabIndex = 12;
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(255, 251);
            this.X3.Name = "X3";
            this.X3.ReadOnly = true;
            this.X3.Size = new System.Drawing.Size(74, 29);
            this.X3.TabIndex = 11;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(255, 182);
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Size = new System.Drawing.Size(74, 29);
            this.X2.TabIndex = 10;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(255, 114);
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Size = new System.Drawing.Size(74, 29);
            this.X1.TabIndex = 4;
            // 
            // Col3
            // 
            this.Col3.Location = new System.Drawing.Point(120, 251);
            this.Col3.Name = "Col3";
            this.Col3.Size = new System.Drawing.Size(69, 29);
            this.Col3.TabIndex = 9;
            // 
            // Col2
            // 
            this.Col2.Location = new System.Drawing.Point(120, 182);
            this.Col2.Name = "Col2";
            this.Col2.Size = new System.Drawing.Size(69, 29);
            this.Col2.TabIndex = 8;
            // 
            // Row3
            // 
            this.Row3.Location = new System.Drawing.Point(21, 251);
            this.Row3.Name = "Row3";
            this.Row3.Size = new System.Drawing.Size(74, 29);
            this.Row3.TabIndex = 7;
            // 
            // Row2
            // 
            this.Row2.Location = new System.Drawing.Point(21, 182);
            this.Row2.Name = "Row2";
            this.Row2.Size = new System.Drawing.Size(74, 29);
            this.Row2.TabIndex = 6;
            // 
            // Col1
            // 
            this.Col1.Location = new System.Drawing.Point(120, 114);
            this.Col1.Name = "Col1";
            this.Col1.Size = new System.Drawing.Size(69, 29);
            this.Col1.TabIndex = 5;
            // 
            // Row1
            // 
            this.Row1.Location = new System.Drawing.Point(21, 114);
            this.Row1.Name = "Row1";
            this.Row1.Size = new System.Drawing.Size(74, 29);
            this.Row1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "X值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "直列";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "橫行";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(518, 468);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(673, 185);
            this.Output.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1078, 674);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 32);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear Result";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(518, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 396);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pin Board 畫面";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(1051, 422);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(140, 31);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset Pin Board";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 718);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Row;
        private System.Windows.Forms.TextBox YInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox XInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Col;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Col3;
        private System.Windows.Forms.TextBox Col2;
        private System.Windows.Forms.TextBox Row3;
        private System.Windows.Forms.TextBox Row2;
        private System.Windows.Forms.TextBox Col1;
        private System.Windows.Forms.TextBox Row1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Reset;
    }
}

