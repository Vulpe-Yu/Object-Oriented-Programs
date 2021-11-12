
namespace Q7
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxMaterial = new System.Windows.Forms.GroupBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGeometry = new System.Windows.Forms.GroupBox();
            this.txtPara2 = new System.Windows.Forms.TextBox();
            this.txtPara1 = new System.Windows.Forms.TextBox();
            this.lblPara2 = new System.Windows.Forms.Label();
            this.lblPara1 = new System.Windows.Forms.Label();
            this.cboxShape = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxAmountOfShape = new System.Windows.Forms.GroupBox();
            this.txtPyramidAmount = new System.Windows.Forms.TextBox();
            this.txtCylinderAmount = new System.Windows.Forms.TextBox();
            this.txtCubeAmount = new System.Windows.Forms.TextBox();
            this.txtBallAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountOfShape = new System.Windows.Forms.TextBox();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.grpBoxMessage = new System.Windows.Forms.GroupBox();
            this.txt_ShowHeaviestShape = new System.Windows.Forms.TextBox();
            this.btn_FindHeaviestShape = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpBoxMaterial.SuspendLayout();
            this.grpBoxGeometry.SuspendLayout();
            this.grpBoxAmountOfShape.SuspendLayout();
            this.grpBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxMaterial
            // 
            this.grpBoxMaterial.Controls.Add(this.txtDensity);
            this.grpBoxMaterial.Controls.Add(this.label2);
            this.grpBoxMaterial.Controls.Add(this.cBoxMaterial);
            this.grpBoxMaterial.Controls.Add(this.label1);
            this.grpBoxMaterial.Location = new System.Drawing.Point(13, 13);
            this.grpBoxMaterial.Name = "grpBoxMaterial";
            this.grpBoxMaterial.Size = new System.Drawing.Size(329, 85);
            this.grpBoxMaterial.TabIndex = 0;
            this.grpBoxMaterial.TabStop = false;
            this.grpBoxMaterial.Text = "Material";
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(110, 53);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(161, 22);
            this.txtDensity.TabIndex = 3;
            this.txtDensity.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密度";
            // 
            // cBoxMaterial
            // 
            this.cBoxMaterial.FormattingEnabled = true;
            this.cBoxMaterial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛",
            "自行輸入密度"});
            this.cBoxMaterial.Location = new System.Drawing.Point(110, 21);
            this.cBoxMaterial.Name = "cBoxMaterial";
            this.cBoxMaterial.Size = new System.Drawing.Size(161, 20);
            this.cBoxMaterial.TabIndex = 1;
            this.cBoxMaterial.SelectedIndexChanged += new System.EventHandler(this.cBoxMaterial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "材質";
            // 
            // grpBoxGeometry
            // 
            this.grpBoxGeometry.Controls.Add(this.txtPara2);
            this.grpBoxGeometry.Controls.Add(this.txtPara1);
            this.grpBoxGeometry.Controls.Add(this.lblPara2);
            this.grpBoxGeometry.Controls.Add(this.lblPara1);
            this.grpBoxGeometry.Controls.Add(this.cboxShape);
            this.grpBoxGeometry.Controls.Add(this.label3);
            this.grpBoxGeometry.Location = new System.Drawing.Point(12, 108);
            this.grpBoxGeometry.Name = "grpBoxGeometry";
            this.grpBoxGeometry.Size = new System.Drawing.Size(329, 130);
            this.grpBoxGeometry.TabIndex = 1;
            this.grpBoxGeometry.TabStop = false;
            this.grpBoxGeometry.Text = "Geometry";
            // 
            // txtPara2
            // 
            this.txtPara2.Location = new System.Drawing.Point(110, 90);
            this.txtPara2.Name = "txtPara2";
            this.txtPara2.Size = new System.Drawing.Size(161, 22);
            this.txtPara2.TabIndex = 5;
            // 
            // txtPara1
            // 
            this.txtPara1.Location = new System.Drawing.Point(110, 61);
            this.txtPara1.Name = "txtPara1";
            this.txtPara1.Size = new System.Drawing.Size(161, 22);
            this.txtPara1.TabIndex = 4;
            // 
            // lblPara2
            // 
            this.lblPara2.AutoSize = true;
            this.lblPara2.Location = new System.Drawing.Point(43, 93);
            this.lblPara2.Name = "lblPara2";
            this.lblPara2.Size = new System.Drawing.Size(35, 12);
            this.lblPara2.TabIndex = 3;
            this.lblPara2.Text = "參數2";
            // 
            // lblPara1
            // 
            this.lblPara1.AutoSize = true;
            this.lblPara1.Location = new System.Drawing.Point(43, 61);
            this.lblPara1.Name = "lblPara1";
            this.lblPara1.Size = new System.Drawing.Size(35, 12);
            this.lblPara1.TabIndex = 2;
            this.lblPara1.Text = "參數1";
            // 
            // cboxShape
            // 
            this.cboxShape.FormattingEnabled = true;
            this.cboxShape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cboxShape.Location = new System.Drawing.Point(110, 35);
            this.cboxShape.Name = "cboxShape";
            this.cboxShape.Size = new System.Drawing.Size(161, 20);
            this.cboxShape.TabIndex = 1;
            this.cboxShape.SelectedIndexChanged += new System.EventHandler(this.cboxShape_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "形狀";
            // 
            // grpBoxAmountOfShape
            // 
            this.grpBoxAmountOfShape.Controls.Add(this.txtPyramidAmount);
            this.grpBoxAmountOfShape.Controls.Add(this.txtCylinderAmount);
            this.grpBoxAmountOfShape.Controls.Add(this.txtCubeAmount);
            this.grpBoxAmountOfShape.Controls.Add(this.txtBallAmount);
            this.grpBoxAmountOfShape.Controls.Add(this.label8);
            this.grpBoxAmountOfShape.Controls.Add(this.label7);
            this.grpBoxAmountOfShape.Controls.Add(this.label6);
            this.grpBoxAmountOfShape.Controls.Add(this.label5);
            this.grpBoxAmountOfShape.Controls.Add(this.label4);
            this.grpBoxAmountOfShape.Controls.Add(this.txtAmountOfShape);
            this.grpBoxAmountOfShape.Controls.Add(this.btnAddShape);
            this.grpBoxAmountOfShape.Location = new System.Drawing.Point(13, 244);
            this.grpBoxAmountOfShape.Name = "grpBoxAmountOfShape";
            this.grpBoxAmountOfShape.Size = new System.Drawing.Size(329, 144);
            this.grpBoxAmountOfShape.TabIndex = 2;
            this.grpBoxAmountOfShape.TabStop = false;
            this.grpBoxAmountOfShape.Text = "Amount Of Shape";
            // 
            // txtPyramidAmount
            // 
            this.txtPyramidAmount.Location = new System.Drawing.Point(219, 104);
            this.txtPyramidAmount.Name = "txtPyramidAmount";
            this.txtPyramidAmount.Size = new System.Drawing.Size(45, 22);
            this.txtPyramidAmount.TabIndex = 10;
            this.txtPyramidAmount.Text = "0";
            // 
            // txtCylinderAmount
            // 
            this.txtCylinderAmount.Location = new System.Drawing.Point(152, 104);
            this.txtCylinderAmount.Name = "txtCylinderAmount";
            this.txtCylinderAmount.Size = new System.Drawing.Size(45, 22);
            this.txtCylinderAmount.TabIndex = 9;
            this.txtCylinderAmount.Text = "0";
            // 
            // txtCubeAmount
            // 
            this.txtCubeAmount.Location = new System.Drawing.Point(85, 104);
            this.txtCubeAmount.Name = "txtCubeAmount";
            this.txtCubeAmount.Size = new System.Drawing.Size(45, 22);
            this.txtCubeAmount.TabIndex = 8;
            this.txtCubeAmount.Text = "0";
            // 
            // txtBallAmount
            // 
            this.txtBallAmount.Location = new System.Drawing.Point(18, 104);
            this.txtBallAmount.Name = "txtBallAmount";
            this.txtBallAmount.Size = new System.Drawing.Size(45, 22);
            this.txtBallAmount.TabIndex = 7;
            this.txtBallAmount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "總數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "金字塔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "圓柱體";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "立方體";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "     球";
            // 
            // txtAmountOfShape
            // 
            this.txtAmountOfShape.Location = new System.Drawing.Point(119, 45);
            this.txtAmountOfShape.Name = "txtAmountOfShape";
            this.txtAmountOfShape.Size = new System.Drawing.Size(145, 22);
            this.txtAmountOfShape.TabIndex = 1;
            this.txtAmountOfShape.Text = "0";
            // 
            // btnAddShape
            // 
            this.btnAddShape.Location = new System.Drawing.Point(18, 43);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(75, 23);
            this.btnAddShape.TabIndex = 0;
            this.btnAddShape.Text = "Add";
            this.btnAddShape.UseVisualStyleBackColor = true;
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // grpBoxMessage
            // 
            this.grpBoxMessage.Controls.Add(this.txt_ShowHeaviestShape);
            this.grpBoxMessage.Controls.Add(this.btn_FindHeaviestShape);
            this.grpBoxMessage.Controls.Add(this.txtMessage);
            this.grpBoxMessage.Location = new System.Drawing.Point(359, 13);
            this.grpBoxMessage.Name = "grpBoxMessage";
            this.grpBoxMessage.Size = new System.Drawing.Size(509, 375);
            this.grpBoxMessage.TabIndex = 3;
            this.grpBoxMessage.TabStop = false;
            this.grpBoxMessage.Text = "Message";
            // 
            // txt_ShowHeaviestShape
            // 
            this.txt_ShowHeaviestShape.Location = new System.Drawing.Point(5, 319);
            this.txt_ShowHeaviestShape.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ShowHeaviestShape.Name = "txt_ShowHeaviestShape";
            this.txt_ShowHeaviestShape.Size = new System.Drawing.Size(482, 22);
            this.txt_ShowHeaviestShape.TabIndex = 2;
            // 
            // btn_FindHeaviestShape
            // 
            this.btn_FindHeaviestShape.Location = new System.Drawing.Point(5, 283);
            this.btn_FindHeaviestShape.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_FindHeaviestShape.Name = "btn_FindHeaviestShape";
            this.btn_FindHeaviestShape.Size = new System.Drawing.Size(90, 31);
            this.btn_FindHeaviestShape.TabIndex = 1;
            this.btn_FindHeaviestShape.Text = "最重的物件";
            this.btn_FindHeaviestShape.UseVisualStyleBackColor = true;
            this.btn_FindHeaviestShape.Click += new System.EventHandler(this.btn_FindHeaviestShape_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(7, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(482, 242);
            this.txtMessage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 415);
            this.Controls.Add(this.grpBoxMessage);
            this.Controls.Add(this.grpBoxAmountOfShape);
            this.Controls.Add(this.grpBoxGeometry);
            this.Controls.Add(this.grpBoxMaterial);
            this.Name = "Form1";
            this.Text = "106_Classwork6";
            this.grpBoxMaterial.ResumeLayout(false);
            this.grpBoxMaterial.PerformLayout();
            this.grpBoxGeometry.ResumeLayout(false);
            this.grpBoxGeometry.PerformLayout();
            this.grpBoxAmountOfShape.ResumeLayout(false);
            this.grpBoxAmountOfShape.PerformLayout();
            this.grpBoxMessage.ResumeLayout(false);
            this.grpBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMaterial;
        private System.Windows.Forms.ComboBox cBoxMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxGeometry;
        private System.Windows.Forms.ComboBox cboxShape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBoxAmountOfShape;
        private System.Windows.Forms.TextBox txtAmountOfShape;
        private System.Windows.Forms.Button btnAddShape;
        private System.Windows.Forms.GroupBox grpBoxMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPara2;
        private System.Windows.Forms.TextBox txtPara1;
        private System.Windows.Forms.Label lblPara2;
        private System.Windows.Forms.Label lblPara1;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPyramidAmount;
        private System.Windows.Forms.TextBox txtCylinderAmount;
        private System.Windows.Forms.TextBox txtCubeAmount;
        private System.Windows.Forms.TextBox txtBallAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ShowHeaviestShape;
        private System.Windows.Forms.Button btn_FindHeaviestShape;
    }
}

