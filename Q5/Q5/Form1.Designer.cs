
namespace Q5
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
            this.groupBox_Input = new System.Windows.Forms.GroupBox();
            this.label_XCoord = new System.Windows.Forms.Label();
            this.textBox_PointY3 = new System.Windows.Forms.TextBox();
            this.textBox_PointY2 = new System.Windows.Forms.TextBox();
            this.textBox_PointY1 = new System.Windows.Forms.TextBox();
            this.textBox_PointX3 = new System.Windows.Forms.TextBox();
            this.textBox_PointX2 = new System.Windows.Forms.TextBox();
            this.textBox_PointX1 = new System.Windows.Forms.TextBox();
            this.label__YCoord = new System.Windows.Forms.Label();
            this.label_Point1 = new System.Windows.Forms.Label();
            this.label_Point2 = new System.Windows.Forms.Label();
            this.label_Point3 = new System.Windows.Forms.Label();
            this.groupBox_Function = new System.Windows.Forms.GroupBox();
            this.checkBox_Area = new System.Windows.Forms.CheckBox();
            this.checkBox_Length = new System.Windows.Forms.CheckBox();
            this.checkBox_Angle = new System.Windows.Forms.CheckBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.groupBox_Input.SuspendLayout();
            this.groupBox_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Input
            // 
            this.groupBox_Input.Controls.Add(this.label_Point3);
            this.groupBox_Input.Controls.Add(this.label_Point2);
            this.groupBox_Input.Controls.Add(this.label_Point1);
            this.groupBox_Input.Controls.Add(this.label_XCoord);
            this.groupBox_Input.Controls.Add(this.label__YCoord);
            this.groupBox_Input.Controls.Add(this.textBox_PointY3);
            this.groupBox_Input.Controls.Add(this.textBox_PointY2);
            this.groupBox_Input.Controls.Add(this.textBox_PointY1);
            this.groupBox_Input.Controls.Add(this.textBox_PointX3);
            this.groupBox_Input.Controls.Add(this.textBox_PointX2);
            this.groupBox_Input.Controls.Add(this.textBox_PointX1);
            this.groupBox_Input.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Input.Name = "groupBox_Input";
            this.groupBox_Input.Size = new System.Drawing.Size(426, 206);
            this.groupBox_Input.TabIndex = 0;
            this.groupBox_Input.TabStop = false;
            this.groupBox_Input.Text = "座標輸入";
            // 
            // label_XCoord
            // 
            this.label_XCoord.AutoSize = true;
            this.label_XCoord.Location = new System.Drawing.Point(138, 25);
            this.label_XCoord.Name = "label_XCoord";
            this.label_XCoord.Size = new System.Drawing.Size(56, 18);
            this.label_XCoord.TabIndex = 1;
            this.label_XCoord.Text = "X座標";
            // 
            // textBox_PointY3
            // 
            this.textBox_PointY3.Location = new System.Drawing.Point(253, 148);
            this.textBox_PointY3.Name = "textBox_PointY3";
            this.textBox_PointY3.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointY3.TabIndex = 1;
            // 
            // textBox_PointY2
            // 
            this.textBox_PointY2.Location = new System.Drawing.Point(253, 102);
            this.textBox_PointY2.Name = "textBox_PointY2";
            this.textBox_PointY2.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointY2.TabIndex = 1;
            // 
            // textBox_PointY1
            // 
            this.textBox_PointY1.Location = new System.Drawing.Point(253, 57);
            this.textBox_PointY1.Name = "textBox_PointY1";
            this.textBox_PointY1.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointY1.TabIndex = 1;
            // 
            // textBox_PointX3
            // 
            this.textBox_PointX3.Location = new System.Drawing.Point(126, 148);
            this.textBox_PointX3.Name = "textBox_PointX3";
            this.textBox_PointX3.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointX3.TabIndex = 1;
            // 
            // textBox_PointX2
            // 
            this.textBox_PointX2.Location = new System.Drawing.Point(126, 102);
            this.textBox_PointX2.Name = "textBox_PointX2";
            this.textBox_PointX2.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointX2.TabIndex = 1;
            // 
            // textBox_PointX1
            // 
            this.textBox_PointX1.Location = new System.Drawing.Point(126, 57);
            this.textBox_PointX1.Name = "textBox_PointX1";
            this.textBox_PointX1.Size = new System.Drawing.Size(100, 29);
            this.textBox_PointX1.TabIndex = 0;
            // 
            // label__YCoord
            // 
            this.label__YCoord.AutoSize = true;
            this.label__YCoord.Location = new System.Drawing.Point(266, 25);
            this.label__YCoord.Name = "label__YCoord";
            this.label__YCoord.Size = new System.Drawing.Size(56, 18);
            this.label__YCoord.TabIndex = 2;
            this.label__YCoord.Text = "Y座標";
            // 
            // label_Point1
            // 
            this.label_Point1.AutoSize = true;
            this.label_Point1.Location = new System.Drawing.Point(28, 60);
            this.label_Point1.Name = "label_Point1";
            this.label_Point1.Size = new System.Drawing.Size(51, 18);
            this.label_Point1.TabIndex = 3;
            this.label_Point1.Text = "Point1";
            // 
            // label_Point2
            // 
            this.label_Point2.AutoSize = true;
            this.label_Point2.Location = new System.Drawing.Point(28, 105);
            this.label_Point2.Name = "label_Point2";
            this.label_Point2.Size = new System.Drawing.Size(51, 18);
            this.label_Point2.TabIndex = 4;
            this.label_Point2.Text = "Point2";
            // 
            // label_Point3
            // 
            this.label_Point3.AutoSize = true;
            this.label_Point3.Location = new System.Drawing.Point(28, 151);
            this.label_Point3.Name = "label_Point3";
            this.label_Point3.Size = new System.Drawing.Size(51, 18);
            this.label_Point3.TabIndex = 4;
            this.label_Point3.Text = "Point3";
            // 
            // groupBox_Function
            // 
            this.groupBox_Function.Controls.Add(this.checkBox_Angle);
            this.groupBox_Function.Controls.Add(this.checkBox_Length);
            this.groupBox_Function.Controls.Add(this.checkBox_Area);
            this.groupBox_Function.Location = new System.Drawing.Point(469, 12);
            this.groupBox_Function.Name = "groupBox_Function";
            this.groupBox_Function.Size = new System.Drawing.Size(319, 205);
            this.groupBox_Function.TabIndex = 1;
            this.groupBox_Function.TabStop = false;
            this.groupBox_Function.Text = "功能選擇";
            // 
            // checkBox_Area
            // 
            this.checkBox_Area.AutoSize = true;
            this.checkBox_Area.Location = new System.Drawing.Point(65, 51);
            this.checkBox_Area.Name = "checkBox_Area";
            this.checkBox_Area.Size = new System.Drawing.Size(106, 22);
            this.checkBox_Area.TabIndex = 0;
            this.checkBox_Area.Text = "計算面積";
            this.checkBox_Area.UseVisualStyleBackColor = true;
            // 
            // checkBox_Length
            // 
            this.checkBox_Length.AutoSize = true;
            this.checkBox_Length.Location = new System.Drawing.Point(65, 101);
            this.checkBox_Length.Name = "checkBox_Length";
            this.checkBox_Length.Size = new System.Drawing.Size(106, 22);
            this.checkBox_Length.TabIndex = 1;
            this.checkBox_Length.Text = "計算周長";
            this.checkBox_Length.UseVisualStyleBackColor = true;
            // 
            // checkBox_Angle
            // 
            this.checkBox_Angle.AutoSize = true;
            this.checkBox_Angle.Location = new System.Drawing.Point(65, 150);
            this.checkBox_Angle.Name = "checkBox_Angle";
            this.checkBox_Angle.Size = new System.Drawing.Size(160, 22);
            this.checkBox_Angle.TabIndex = 2;
            this.checkBox_Angle.Text = "檢視三角形類別";
            this.checkBox_Angle.UseVisualStyleBackColor = true;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(52, 280);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(684, 155);
            this.textBox_Result.TabIndex = 2;
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(639, 231);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(97, 34);
            this.button_Run.TabIndex = 3;
            this.button_Run.Text = "計算";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.groupBox_Function);
            this.Controls.Add(this.groupBox_Input);
            this.Name = "Form1";
            this.Text = "110 Quiz5";
            this.groupBox_Input.ResumeLayout(false);
            this.groupBox_Input.PerformLayout();
            this.groupBox_Function.ResumeLayout(false);
            this.groupBox_Function.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Input;
        private System.Windows.Forms.Label label_XCoord;
        private System.Windows.Forms.TextBox textBox_PointY3;
        private System.Windows.Forms.TextBox textBox_PointY2;
        private System.Windows.Forms.TextBox textBox_PointY1;
        private System.Windows.Forms.TextBox textBox_PointX3;
        private System.Windows.Forms.TextBox textBox_PointX2;
        private System.Windows.Forms.TextBox textBox_PointX1;
        private System.Windows.Forms.Label label__YCoord;
        private System.Windows.Forms.Label label_Point1;
        private System.Windows.Forms.Label label_Point3;
        private System.Windows.Forms.Label label_Point2;
        private System.Windows.Forms.GroupBox groupBox_Function;
        private System.Windows.Forms.CheckBox checkBox_Area;
        private System.Windows.Forms.CheckBox checkBox_Angle;
        private System.Windows.Forms.CheckBox checkBox_Length;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Run;
    }
}

