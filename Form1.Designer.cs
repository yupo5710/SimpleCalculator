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
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            SuspendLayout();
            // 
            // btnCe
            // 
            btnCe.BackColor = SystemColors.ControlLight;
            btnCe.Location = new Point(23, 345);
            btnCe.Margin = new Padding(3, 2, 3, 2);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(150, 63);
            btnCe.TabIndex = 0;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnCe_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ControlLight;
            btnC.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnC.Location = new Point(215, 345);
            btnC.Margin = new Padding(3, 2, 3, 2);
            btnC.Name = "btnC";
            btnC.Size = new Size(150, 63);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnClear_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ControlLight;
            btnDel.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnDel.Location = new Point(408, 345);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 63);
            btnDel.TabIndex = 2;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnBack_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.AppWorkspace;
            btnDiv.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnDiv.Location = new Point(583, 345);
            btnDiv.Margin = new Padding(3, 2, 3, 2);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(150, 63);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnOperator_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.White;
            btn7.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn7.Location = new Point(23, 441);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 63);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumeber_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.White;
            btn8.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn8.Location = new Point(215, 441);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 63);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumeber_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.White;
            btn9.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn9.Location = new Point(408, 441);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 63);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumeber_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.AppWorkspace;
            btnMul.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnMul.Location = new Point(583, 441);
            btnMul.Margin = new Padding(3, 2, 3, 2);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(150, 63);
            btnMul.TabIndex = 7;
            btnMul.Text = "X";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnOperator_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.White;
            btn4.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn4.Location = new Point(23, 535);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 63);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumeber_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.White;
            btn5.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn5.Location = new Point(215, 535);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 63);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumeber_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.White;
            btn6.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn6.Location = new Point(408, 535);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 63);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumeber_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.AppWorkspace;
            btnSub.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnSub.Location = new Point(583, 535);
            btnSub.Margin = new Padding(3, 2, 3, 2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(150, 63);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnOperator_Click;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.White;
            btnSign.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnSign.Location = new Point(23, 713);
            btnSign.Margin = new Padding(3, 2, 3, 2);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(150, 63);
            btnSign.TabIndex = 12;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.White;
            btn0.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn0.Location = new Point(215, 713);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(150, 63);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumeber_Click;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.White;
            btnPoint.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnPoint.Location = new Point(408, 713);
            btnPoint.Margin = new Padding(3, 2, 3, 2);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(150, 63);
            btnPoint.TabIndex = 14;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(128, 255, 128);
            btnEqual.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnEqual.Location = new Point(583, 713);
            btnEqual.Margin = new Padding(3, 2, 3, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 63);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // labelSimpleCalculator
            // 
            labelSimpleCalculator.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelSimpleCalculator.ForeColor = Color.Cyan;
            labelSimpleCalculator.Location = new Point(23, -6);
            labelSimpleCalculator.Name = "labelSimpleCalculator";
            labelSimpleCalculator.Size = new Size(686, 115);
            labelSimpleCalculator.TabIndex = 16;
            labelSimpleCalculator.Text = "Simple Calculator";
            // 
            // txtFormular
            // 
            txtFormular.Location = new Point(87, 99);
            txtFormular.Margin = new Padding(3, 2, 3, 2);
            txtFormular.Multiline = true;
            txtFormular.Name = "txtFormular";
            txtFormular.Size = new Size(593, 101);
            txtFormular.TabIndex = 17;
            txtFormular.Click += btnNumeber_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(87, 228);
            txtInput.Margin = new Padding(3, 2, 3, 2);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(471, 103);
            txtInput.TabIndex = 18;
            txtInput.Click += btnOperator_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn1.Location = new Point(23, 624);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 60);
            btn1.TabIndex = 19;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumeber_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.White;
            btn2.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn2.Location = new Point(215, 624);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 60);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumeber_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.White;
            btn3.Font = new Font("굴림", 9F, FontStyle.Bold);
            btn3.Location = new Point(408, 624);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 60);
            btn3.TabIndex = 21;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumeber_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.AppWorkspace;
            btnAdd.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(583, 624);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 60);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOperator_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = SystemColors.AppWorkspace;
            btnOpenParenthesis.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnOpenParenthesis.Location = new Point(583, 258);
            btnOpenParenthesis.Margin = new Padding(3, 2, 3, 2);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(74, 63);
            btnOpenParenthesis.TabIndex = 23;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = SystemColors.AppWorkspace;
            btnCloseParenthesis.Font = new Font("굴림", 9F, FontStyle.Bold);
            btnCloseParenthesis.Location = new Point(659, 258);
            btnCloseParenthesis.Margin = new Padding(3, 2, 3, 2);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(74, 63);
            btnCloseParenthesis.TabIndex = 24;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 824);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
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
            Font = new Font("굴림", 9F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
    }
}
