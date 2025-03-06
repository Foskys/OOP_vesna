namespace _1lab
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            firstNumberInput = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            buttonF = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button9 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            buttonE = new Button();
            button8 = new Button();
            buttonCE = new Button();
            buttonAND = new Button();
            buttonOR = new Button();
            buttonXOR = new Button();
            buttonNOT = new Button();
            buttonEq = new Button();
            buttonDEL = new Button();
            buttonUMinus = new Button();
            radioButtonHEX = new RadioButton();
            radioButtonDEC = new RadioButton();
            radioButtonOCT = new RadioButton();
            radioButtonBIN = new RadioButton();
            operationInput = new TextBox();
            secondNumberInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // firstNumberInput
            // 
            firstNumberInput.CharacterCasing = CharacterCasing.Upper;
            firstNumberInput.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstNumberInput.ForeColor = Color.PaleGreen;
            firstNumberInput.Location = new Point(10, 16);
            firstNumberInput.Margin = new Padding(3, 4, 3, 4);
            firstNumberInput.Name = "firstNumberInput";
            firstNumberInput.ReadOnly = true;
            firstNumberInput.Size = new Size(600, 45);
            firstNumberInput.TabIndex = 0;
            firstNumberInput.TextAlign = HorizontalAlignment.Right;
            firstNumberInput.TextChanged += firstNumberInput_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.Controls.Add(buttonA, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonB, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonC, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonD, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonF, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 3, 1);
            tableLayoutPanel1.Controls.Add(button9, 4, 0);
            tableLayoutPanel1.Controls.Add(button6, 4, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 2);
            tableLayoutPanel1.Controls.Add(button2, 3, 2);
            tableLayoutPanel1.Controls.Add(button3, 4, 2);
            tableLayoutPanel1.Controls.Add(button0, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonE, 0, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 0);
            tableLayoutPanel1.Controls.Add(buttonCE, 6, 0);
            tableLayoutPanel1.Controls.Add(buttonAND, 5, 1);
            tableLayoutPanel1.Controls.Add(buttonOR, 6, 1);
            tableLayoutPanel1.Controls.Add(buttonXOR, 5, 2);
            tableLayoutPanel1.Controls.Add(buttonNOT, 6, 2);
            tableLayoutPanel1.Controls.Add(buttonEq, 6, 3);
            tableLayoutPanel1.Controls.Add(buttonDEL, 5, 0);
            tableLayoutPanel1.Controls.Add(buttonUMinus, 5, 3);
            tableLayoutPanel1.Location = new Point(10, 380);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(600, 500);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonA
            // 
            buttonA.BackColor = Color.PaleGreen;
            buttonA.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonA.ForeColor = Color.White;
            buttonA.Location = new Point(3, 3);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(79, 100);
            buttonA.TabIndex = 21;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.BackColor = Color.PaleGreen;
            buttonB.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonB.ForeColor = Color.White;
            buttonB.Location = new Point(88, 4);
            buttonB.Margin = new Padding(3, 4, 3, 4);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(79, 100);
            buttonB.TabIndex = 22;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.PaleGreen;
            buttonC.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonC.ForeColor = Color.White;
            buttonC.Location = new Point(3, 129);
            buttonC.Margin = new Padding(3, 4, 3, 4);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(79, 100);
            buttonC.TabIndex = 23;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.PaleGreen;
            buttonD.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonD.ForeColor = Color.White;
            buttonD.Location = new Point(88, 129);
            buttonD.Margin = new Padding(3, 4, 3, 4);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(79, 100);
            buttonD.TabIndex = 24;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // buttonF
            // 
            buttonF.BackColor = Color.PaleGreen;
            buttonF.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonF.ForeColor = Color.White;
            buttonF.Location = new Point(88, 254);
            buttonF.Margin = new Padding(3, 4, 3, 4);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(79, 100);
            buttonF.TabIndex = 26;
            buttonF.Text = "F";
            buttonF.UseVisualStyleBackColor = false;
            buttonF.Click += buttonF_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.ForeColor = Color.CornflowerBlue;
            button7.Location = new Point(173, 4);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(79, 100);
            button7.TabIndex = 18;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.CornflowerBlue;
            button4.Location = new Point(173, 129);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(79, 100);
            button4.TabIndex = 15;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.CornflowerBlue;
            button5.Location = new Point(258, 129);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(79, 100);
            button5.TabIndex = 16;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.ForeColor = Color.CornflowerBlue;
            button9.Location = new Point(343, 4);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(79, 100);
            button9.TabIndex = 20;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.CornflowerBlue;
            button6.Location = new Point(343, 129);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(79, 100);
            button6.TabIndex = 17;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(173, 254);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(79, 100);
            button1.TabIndex = 12;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(258, 254);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(79, 100);
            button2.TabIndex = 13;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.CornflowerBlue;
            button3.Location = new Point(343, 254);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(79, 100);
            button3.TabIndex = 14;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button0.ForeColor = Color.CornflowerBlue;
            button0.Location = new Point(258, 379);
            button0.Margin = new Padding(3, 4, 3, 4);
            button0.Name = "button0";
            button0.Size = new Size(79, 100);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonE
            // 
            buttonE.BackColor = Color.PaleGreen;
            buttonE.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonE.ForeColor = Color.White;
            buttonE.Location = new Point(3, 254);
            buttonE.Margin = new Padding(3, 4, 3, 4);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(79, 100);
            buttonE.TabIndex = 25;
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = false;
            buttonE.Click += buttonE_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.ForeColor = Color.CornflowerBlue;
            button8.Location = new Point(258, 4);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(79, 100);
            button8.TabIndex = 19;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(255, 128, 128);
            buttonCE.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCE.ForeColor = Color.White;
            buttonCE.Location = new Point(513, 4);
            buttonCE.Margin = new Padding(3, 4, 3, 4);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(84, 100);
            buttonCE.TabIndex = 31;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonAND
            // 
            buttonAND.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAND.ForeColor = Color.FromArgb(255, 128, 128);
            buttonAND.Location = new Point(428, 129);
            buttonAND.Margin = new Padding(3, 4, 3, 4);
            buttonAND.Name = "buttonAND";
            buttonAND.Size = new Size(79, 100);
            buttonAND.TabIndex = 27;
            buttonAND.Text = "AND";
            buttonAND.UseVisualStyleBackColor = true;
            buttonAND.Click += buttonAND_Click;
            // 
            // buttonOR
            // 
            buttonOR.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOR.ForeColor = Color.FromArgb(255, 128, 128);
            buttonOR.Location = new Point(513, 129);
            buttonOR.Margin = new Padding(3, 4, 3, 4);
            buttonOR.Name = "buttonOR";
            buttonOR.Size = new Size(84, 100);
            buttonOR.TabIndex = 28;
            buttonOR.Text = "OR";
            buttonOR.UseVisualStyleBackColor = true;
            buttonOR.Click += buttonOR_Click;
            // 
            // buttonXOR
            // 
            buttonXOR.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonXOR.ForeColor = Color.FromArgb(255, 128, 128);
            buttonXOR.Location = new Point(428, 254);
            buttonXOR.Margin = new Padding(3, 4, 3, 4);
            buttonXOR.Name = "buttonXOR";
            buttonXOR.Size = new Size(79, 100);
            buttonXOR.TabIndex = 29;
            buttonXOR.Text = "XOR";
            buttonXOR.UseVisualStyleBackColor = true;
            buttonXOR.Click += buttonXOR_Click;
            // 
            // buttonNOT
            // 
            buttonNOT.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNOT.ForeColor = Color.FromArgb(255, 128, 128);
            buttonNOT.Location = new Point(513, 254);
            buttonNOT.Margin = new Padding(3, 4, 3, 4);
            buttonNOT.Name = "buttonNOT";
            buttonNOT.Size = new Size(84, 100);
            buttonNOT.TabIndex = 30;
            buttonNOT.Text = "NOT";
            buttonNOT.UseVisualStyleBackColor = true;
            buttonNOT.Click += buttonNOT_Click;
            // 
            // buttonEq
            // 
            buttonEq.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEq.ForeColor = Color.FromArgb(255, 128, 128);
            buttonEq.Location = new Point(513, 379);
            buttonEq.Margin = new Padding(3, 4, 3, 4);
            buttonEq.Name = "buttonEq";
            buttonEq.Size = new Size(84, 100);
            buttonEq.TabIndex = 32;
            buttonEq.Text = "=";
            buttonEq.UseVisualStyleBackColor = true;
            buttonEq.Click += buttonEq_Click;
            // 
            // buttonDEL
            // 
            buttonDEL.BackColor = Color.FromArgb(255, 128, 128);
            buttonDEL.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDEL.ForeColor = Color.White;
            buttonDEL.Location = new Point(428, 4);
            buttonDEL.Margin = new Padding(3, 4, 3, 4);
            buttonDEL.Name = "buttonDEL";
            buttonDEL.Size = new Size(79, 100);
            buttonDEL.TabIndex = 33;
            buttonDEL.Text = "DEL";
            buttonDEL.UseVisualStyleBackColor = false;
            buttonDEL.Click += buttonDEL_Click;
            // 
            // buttonUMinus
            // 
            buttonUMinus.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUMinus.ForeColor = Color.FromArgb(255, 128, 128);
            buttonUMinus.Location = new Point(428, 379);
            buttonUMinus.Margin = new Padding(3, 4, 3, 4);
            buttonUMinus.Name = "buttonUMinus";
            buttonUMinus.Size = new Size(79, 100);
            buttonUMinus.TabIndex = 34;
            buttonUMinus.Text = "+/-";
            buttonUMinus.UseVisualStyleBackColor = true;
            buttonUMinus.Click += buttonUMinus_Click;
            // 
            // radioButtonHEX
            // 
            radioButtonHEX.AutoSize = true;
            radioButtonHEX.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonHEX.Location = new Point(10, 219);
            radioButtonHEX.Margin = new Padding(3, 4, 3, 4);
            radioButtonHEX.Name = "radioButtonHEX";
            radioButtonHEX.Size = new Size(65, 24);
            radioButtonHEX.TabIndex = 3;
            radioButtonHEX.TabStop = true;
            radioButtonHEX.Text = "HEX";
            radioButtonHEX.UseVisualStyleBackColor = true;
            radioButtonHEX.CheckedChanged += radioButtonHEX_CheckedChanged;
            // 
            // radioButtonDEC
            // 
            radioButtonDEC.AutoSize = true;
            radioButtonDEC.Checked = true;
            radioButtonDEC.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonDEC.Location = new Point(10, 256);
            radioButtonDEC.Margin = new Padding(3, 4, 3, 4);
            radioButtonDEC.Name = "radioButtonDEC";
            radioButtonDEC.Size = new Size(66, 24);
            radioButtonDEC.TabIndex = 4;
            radioButtonDEC.TabStop = true;
            radioButtonDEC.Text = "DEC";
            radioButtonDEC.UseVisualStyleBackColor = true;
            radioButtonDEC.CheckedChanged += radioButtonDEC_CheckedChanged;
            // 
            // radioButtonOCT
            // 
            radioButtonOCT.AutoSize = true;
            radioButtonOCT.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonOCT.Location = new Point(10, 294);
            radioButtonOCT.Margin = new Padding(3, 4, 3, 4);
            radioButtonOCT.Name = "radioButtonOCT";
            radioButtonOCT.Size = new Size(65, 24);
            radioButtonOCT.TabIndex = 5;
            radioButtonOCT.TabStop = true;
            radioButtonOCT.Text = "OCT";
            radioButtonOCT.UseVisualStyleBackColor = true;
            radioButtonOCT.CheckedChanged += radioButtonOCT_CheckedChanged;
            // 
            // radioButtonBIN
            // 
            radioButtonBIN.AutoSize = true;
            radioButtonBIN.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioButtonBIN.Location = new Point(10, 331);
            radioButtonBIN.Margin = new Padding(3, 4, 3, 4);
            radioButtonBIN.Name = "radioButtonBIN";
            radioButtonBIN.RightToLeft = RightToLeft.No;
            radioButtonBIN.Size = new Size(58, 24);
            radioButtonBIN.TabIndex = 6;
            radioButtonBIN.TabStop = true;
            radioButtonBIN.Text = "BIN";
            radioButtonBIN.UseVisualStyleBackColor = true;
            radioButtonBIN.CheckedChanged += radioButtonBIN_CheckedChanged;
            // 
            // operationInput
            // 
            operationInput.CharacterCasing = CharacterCasing.Upper;
            operationInput.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            operationInput.ForeColor = Color.CornflowerBlue;
            operationInput.Location = new Point(10, 80);
            operationInput.Margin = new Padding(3, 4, 3, 4);
            operationInput.Name = "operationInput";
            operationInput.ReadOnly = true;
            operationInput.Size = new Size(600, 45);
            operationInput.TabIndex = 7;
            operationInput.TextAlign = HorizontalAlignment.Right;
            // 
            // secondNumberInput
            // 
            secondNumberInput.CharacterCasing = CharacterCasing.Upper;
            secondNumberInput.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 204);
            secondNumberInput.ForeColor = Color.CornflowerBlue;
            secondNumberInput.Location = new Point(10, 144);
            secondNumberInput.Margin = new Padding(3, 4, 3, 4);
            secondNumberInput.Name = "secondNumberInput";
            secondNumberInput.ReadOnly = true;
            secondNumberInput.Size = new Size(600, 45);
            secondNumberInput.TabIndex = 8;
            secondNumberInput.TextAlign = HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(638, 733);
            Controls.Add(secondNumberInput);
            Controls.Add(operationInput);
            Controls.Add(radioButtonBIN);
            Controls.Add(radioButtonOCT);
            Controls.Add(radioButtonDEC);
            Controls.Add(radioButtonHEX);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(firstNumberInput);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(10, 12, 10, 12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бинарный калькулятор";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox firstNumberInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonNOT;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.RadioButton radioButtonHEX;
        private System.Windows.Forms.RadioButton radioButtonOCT;
        private System.Windows.Forms.RadioButton radioButtonBIN;
        private System.Windows.Forms.RadioButton radioButtonDEC;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.TextBox operationInput;
        private System.Windows.Forms.TextBox secondNumberInput;
        private System.Windows.Forms.Button buttonUMinus;
    }
}