
namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMminus = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMplus = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonDivated = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.TextBox();
            this.currentOperation = new System.Windows.Forms.Label();
            this.button_x_on_y = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMR
            // 
            this.buttonMR.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMR.Location = new System.Drawing.Point(94, 161);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(69, 57);
            this.buttonMR.TabIndex = 0;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMemory);
            // 
            // buttonMminus
            // 
            this.buttonMminus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMminus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMminus.Location = new System.Drawing.Point(244, 161);
            this.buttonMminus.Name = "buttonMminus";
            this.buttonMminus.Size = new System.Drawing.Size(69, 57);
            this.buttonMminus.TabIndex = 1;
            this.buttonMminus.Text = "M-";
            this.buttonMminus.UseVisualStyleBackColor = true;
            this.buttonMminus.Click += new System.EventHandler(this.buttonMemory);
            // 
            // buttonMS
            // 
            this.buttonMS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMS.Location = new System.Drawing.Point(169, 161);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(69, 57);
            this.buttonMS.TabIndex = 2;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMemory);
            // 
            // buttonMplus
            // 
            this.buttonMplus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMplus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMplus.Location = new System.Drawing.Point(319, 161);
            this.buttonMplus.Name = "buttonMplus";
            this.buttonMplus.Size = new System.Drawing.Size(69, 57);
            this.buttonMplus.TabIndex = 3;
            this.buttonMplus.Text = "M+";
            this.buttonMplus.UseVisualStyleBackColor = true;
            this.buttonMplus.Click += new System.EventHandler(this.buttonMemory);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoot.Location = new System.Drawing.Point(19, 229);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(69, 57);
            this.buttonRoot.TabIndex = 8;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.operator_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(168, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 57);
            this.button8.TabIndex = 7;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.clear);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(93, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 57);
            this.button9.TabIndex = 4;
            this.button9.Text = "CE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.clear2);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(244, 229);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 57);
            this.button10.TabIndex = 5;
            this.button10.Text = "🠔";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.removeLast);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMultiply.Location = new System.Drawing.Point(244, 354);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(69, 57);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.six.Location = new System.Drawing.Point(169, 354);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(69, 57);
            this.six.TabIndex = 17;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.number_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.five.Location = new System.Drawing.Point(94, 354);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(69, 57);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.number_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.four.Location = new System.Drawing.Point(19, 354);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(69, 57);
            this.four.TabIndex = 15;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.number_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPercent.Location = new System.Drawing.Point(319, 291);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(69, 57);
            this.buttonPercent.TabIndex = 13;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonDivated
            // 
            this.buttonDivated.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivated.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDivated.Location = new System.Drawing.Point(244, 291);
            this.buttonDivated.Name = "buttonDivated";
            this.buttonDivated.Size = new System.Drawing.Size(69, 57);
            this.buttonDivated.TabIndex = 11;
            this.buttonDivated.Text = "/";
            this.buttonDivated.UseVisualStyleBackColor = true;
            this.buttonDivated.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nine.Location = new System.Drawing.Point(169, 291);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(69, 57);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.number_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eight.Location = new System.Drawing.Point(94, 291);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(69, 57);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.number_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seven.Location = new System.Drawing.Point(19, 291);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(69, 57);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.number_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEqual.Location = new System.Drawing.Point(319, 417);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(69, 120);
            this.buttonEqual.TabIndex = 28;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.equal);
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSum.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSum.Location = new System.Drawing.Point(244, 480);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(69, 57);
            this.buttonSum.TabIndex = 26;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPoint.Location = new System.Drawing.Point(169, 480);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(69, 57);
            this.buttonPoint.TabIndex = 27;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.number_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zero.Location = new System.Drawing.Point(19, 480);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(144, 57);
            this.zero.TabIndex = 25;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.number_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("Times New Roman", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubtract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSubtract.Location = new System.Drawing.Point(244, 417);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(69, 57);
            this.buttonSubtract.TabIndex = 21;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.three.Location = new System.Drawing.Point(169, 417);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(69, 57);
            this.three.TabIndex = 22;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.number_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.two.Location = new System.Drawing.Point(94, 417);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(69, 57);
            this.two.TabIndex = 19;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.number_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.one.Location = new System.Drawing.Point(19, 417);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(69, 57);
            this.one.TabIndex = 20;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.number_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(19, 90);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(369, 50);
            this.buttonResult.TabIndex = 29;
            this.buttonResult.Text = "0";
            this.buttonResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonResult.TextChanged += new System.EventHandler(this.buttonResult_TextChanged);
            // 
            // currentOperation
            // 
            this.currentOperation.AutoSize = true;
            this.currentOperation.BackColor = System.Drawing.SystemColors.Control;
            this.currentOperation.Font = new System.Drawing.Font("Times New Roman", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentOperation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentOperation.Location = new System.Drawing.Point(19, 44);
            this.currentOperation.Name = "currentOperation";
            this.currentOperation.Size = new System.Drawing.Size(0, 35);
            this.currentOperation.TabIndex = 30;
            // 
            // button_x_on_y
            // 
            this.button_x_on_y.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_x_on_y.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_x_on_y.Location = new System.Drawing.Point(319, 354);
            this.button_x_on_y.Name = "button_x_on_y";
            this.button_x_on_y.Size = new System.Drawing.Size(69, 57);
            this.button_x_on_y.TabIndex = 18;
            this.button_x_on_y.Text = "^";
            this.button_x_on_y.UseVisualStyleBackColor = true;
            this.button_x_on_y.Click += new System.EventHandler(this.operator_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMC.Location = new System.Drawing.Point(19, 161);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(69, 57);
            this.buttonMC.TabIndex = 0;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMemory);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(407, 562);
            this.Controls.Add(this.currentOperation);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.button_x_on_y);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonDivated);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonMplus);
            this.Controls.Add(this.buttonMminus);
            this.Controls.Add(this.buttonMS);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMminus;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button buttonMplus;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonDivated;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TextBox buttonResult;
        private System.Windows.Forms.Label currentOperation;
        private System.Windows.Forms.Button button_x_on_y;
        private System.Windows.Forms.Button buttonMC;
    }
}

