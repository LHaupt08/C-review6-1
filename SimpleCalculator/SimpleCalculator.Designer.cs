namespace SimpleCalculator
{
    partial class SimpleCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtOpe1 = new TextBox();
            txtOperator = new TextBox();
            txtOpe2 = new TextBox();
            label4 = new Label();
            txtResult = new TextBox();
            label5 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Operand 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Operator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Operand 2:";
            // 
            // txtOpe1
            // 
            txtOpe1.Location = new Point(83, 6);
            txtOpe1.Name = "txtOpe1";
            txtOpe1.Size = new Size(131, 23);
            txtOpe1.TabIndex = 3;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(83, 38);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(131, 23);
            txtOperator.TabIndex = 4;
            // 
            // txtOpe2
            // 
            txtOpe2.Location = new Point(83, 72);
            txtOpe2.Name = "txtOpe2";
            txtOpe2.Size = new Size(131, 23);
            txtOpe2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 6;
            label4.Text = "_______________________________________";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(83, 116);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(131, 23);
            txtResult.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 119);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "Result:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(23, 160);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(126, 160);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 192);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtOpe2);
            Controls.Add(txtOperator);
            Controls.Add(txtOpe1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SimpleCalculator";
            RightToLeftLayout = true;
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOpe1;
        private TextBox txtOperator;
        private TextBox txtOpe2;
        private Label label4;
        private TextBox txtResult;
        private Label label5;
        private Button btnCalculate;
        private Button btnExit;
    }
}
