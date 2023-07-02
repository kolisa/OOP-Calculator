namespace OOP_Calculator
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
            labelCurrentOperation = new Label();
            tbResults = new TextBox();
            btnEqualTo = new Button();
            button16 = new Button();
            button17 = new Button();
            button19 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            btnC = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnCE = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonOne = new Button();
            SuspendLayout();
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.BackColor = SystemColors.Window;
            labelCurrentOperation.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurrentOperation.ForeColor = SystemColors.ControlDark;
            labelCurrentOperation.Location = new Point(8, 12);
            labelCurrentOperation.Margin = new Padding(4, 0, 4, 0);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 29);
            labelCurrentOperation.TabIndex = 41;
            // 
            // tbResults
            // 
            tbResults.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbResults.Location = new Point(16, 39);
            tbResults.Margin = new Padding(4);
            tbResults.Name = "tbResults";
            tbResults.Size = new Size(341, 34);
            tbResults.TabIndex = 40;
            tbResults.Text = "0";
            tbResults.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEqualTo
            // 
            btnEqualTo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqualTo.Location = new Point(288, 204);
            btnEqualTo.Margin = new Padding(4);
            btnEqualTo.Name = "btnEqualTo";
            btnEqualTo.Size = new Size(71, 118);
            btnEqualTo.TabIndex = 39;
            btnEqualTo.Text = "=";
            btnEqualTo.UseVisualStyleBackColor = true;
            btnEqualTo.Click += btnEqualTo_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(220, 267);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(60, 55);
            button16.TabIndex = 38;
            button16.Text = "+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += operator_click;
            // 
            // button17
            // 
            button17.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(152, 267);
            button17.Margin = new Padding(4);
            button17.Name = "button17";
            button17.Size = new Size(60, 55);
            button17.TabIndex = 37;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(16, 267);
            button19.Margin = new Padding(4);
            button19.Name = "button19";
            button19.Size = new Size(128, 55);
            button19.TabIndex = 36;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = true;
            button19.Click += btnNumbers_click;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(220, 204);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(60, 55);
            button11.TabIndex = 35;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += operator_click;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(152, 204);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.Size = new Size(60, 55);
            button12.TabIndex = 34;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnNumbers_click;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(84, 204);
            button13.Margin = new Padding(4);
            button13.Name = "button13";
            button13.Size = new Size(60, 55);
            button13.TabIndex = 33;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnNumbers_click;
            // 
            // button14
            // 
            button14.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(16, 204);
            button14.Margin = new Padding(4);
            button14.Name = "button14";
            button14.Size = new Size(60, 55);
            button14.TabIndex = 32;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = true;
            button14.Click += btnNumbers_click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.Location = new Point(288, 142);
            btnC.Margin = new Padding(4);
            btnC.Name = "btnC";
            btnC.Size = new Size(71, 55);
            btnC.TabIndex = 31;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(220, 142);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(60, 55);
            button6.TabIndex = 30;
            button6.Text = "*";
            button6.UseVisualStyleBackColor = true;
            button6.Click += operator_click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(152, 142);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(60, 55);
            button7.TabIndex = 29;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumbers_click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(84, 142);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(60, 55);
            button8.TabIndex = 28;
            button8.Text = "5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumbers_click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(16, 142);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(60, 55);
            button9.TabIndex = 27;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumbers_click;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCE.Location = new Point(288, 79);
            btnCE.Margin = new Padding(4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(71, 55);
            btnCE.TabIndex = 26;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(220, 79);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(60, 55);
            button3.TabIndex = 25;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += operator_click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(152, 79);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(60, 55);
            button2.TabIndex = 24;
            button2.Text = "9";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumbers_click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(84, 79);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(60, 55);
            button1.TabIndex = 23;
            button1.Text = "8";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumbers_click;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOne.Location = new Point(16, 79);
            buttonOne.Margin = new Padding(4);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(60, 55);
            buttonOne.TabIndex = 22;
            buttonOne.Text = "7";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += btnNumbers_click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 342);
            Controls.Add(labelCurrentOperation);
            Controls.Add(tbResults);
            Controls.Add(btnEqualTo);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button19);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(btnC);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(btnCE);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonOne);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurrentOperation;
        private TextBox tbResults;
        private Button btnEqualTo;
        private Button button16;
        private Button button17;
        private Button button19;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btnC;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnCE;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonOne;
    }
}