namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCe = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btnSign = new Button();
            btn0 = new Button();
            btnPoint = new Button();
            btnEqual = new Button();
            labelSimpleCalculator = new Label();
            txtFormular = new TextBox();
            txtInput = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnCe
            // 
            btnCe.Location = new Point(23, 303);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(150, 84);
            btnCe.TabIndex = 0;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += btnCe_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(215, 303);
            btnC.Name = "btnC";
            btnC.Size = new Size(150, 84);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnClear_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(408, 303);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 84);
            btnDel.TabIndex = 2;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnBack_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(598, 303);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(150, 84);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "%";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnOperator_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(23, 421);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 84);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumeber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(215, 421);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 84);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumeber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(408, 421);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 84);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumeber_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(598, 421);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(150, 84);
            btnMul.TabIndex = 7;
            btnMul.Text = "X";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnOperator_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(23, 525);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 84);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumeber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(215, 525);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 84);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumeber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(408, 525);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 84);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumeber_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(598, 525);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(150, 84);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnOperator_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(23, 742);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(150, 84);
            btnSign.TabIndex = 12;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(215, 742);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 84);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumeber_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(408, 742);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(150, 84);
            btnPoint.TabIndex = 14;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(598, 742);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 84);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // labelSimpleCalculator
            // 
            labelSimpleCalculator.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelSimpleCalculator.Location = new Point(23, 18);
            labelSimpleCalculator.Name = "labelSimpleCalculator";
            labelSimpleCalculator.Size = new Size(686, 112);
            labelSimpleCalculator.TabIndex = 16;
            labelSimpleCalculator.Text = "Simple Calculator";
            // 
            // txtFormular
            // 
            txtFormular.Location = new Point(87, 120);
            txtFormular.Multiline = true;
            txtFormular.Name = "txtFormular";
            txtFormular.Size = new Size(593, 70);
            txtFormular.TabIndex = 17;
            txtFormular.Click += btnNumeber_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(87, 209);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(593, 67);
            txtInput.TabIndex = 18;
            txtInput.Click += btnOperator_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 637);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 80);
            btn1.TabIndex = 19;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumeber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(215, 637);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 80);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumeber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(408, 637);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 80);
            btn3.TabIndex = 21;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumeber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(598, 637);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 80);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 903);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtInput);
            Controls.Add(txtFormular);
            Controls.Add(labelSimpleCalculator);
            Controls.Add(btnEqual);
            Controls.Add(btnPoint);
            Controls.Add(btn0);
            Controls.Add(btnSign);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMul);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Name = "Form1";
            Text = "Form1";
            Click += btnOperator_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCe;
        private Button btnC;
        private Button btnDel;
        private Button btnDiv;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMul;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btnSign;
        private Button btn0;
        private Button btnPoint;
        private Button btnEqual;
        private Label labelSimpleCalculator;
        private TextBox txtFormular;
        private TextBox txtInput;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
    }
}
