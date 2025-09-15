namespace _23SOECE11059_YASHMAKWANA
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
            n1 = new Label();
            n2 = new Label();
            tb1 = new TextBox();
            tb2 = new TextBox();
            gb1 = new GroupBox();
            rd1 = new RadioButton();
            rd2 = new RadioButton();
            rd3 = new RadioButton();
            rd4 = new RadioButton();
            btn1 = new Button();
            gb2 = new GroupBox();
            a = new Label();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // n1
            // 
            n1.AutoSize = true;
            n1.Location = new Point(77, 60);
            n1.Name = "n1";
            n1.Size = new Size(75, 20);
            n1.TabIndex = 0;
            n1.Text = "Number 1";
            n1.Click += label1_Click;
            // 
            // n2
            // 
            n2.AutoSize = true;
            n2.Location = new Point(77, 110);
            n2.Name = "n2";
            n2.Size = new Size(75, 20);
            n2.TabIndex = 1;
            n2.Text = "Number 2";
            // 
            // tb1
            // 
            tb1.Location = new Point(164, 53);
            tb1.Name = "tb1";
            tb1.Size = new Size(221, 27);
            tb1.TabIndex = 2;
            tb1.TextChanged += textBox1_TextChanged;
            // 
            // tb2
            // 
            tb2.Location = new Point(170, 103);
            tb2.Name = "tb2";
            tb2.Size = new Size(215, 27);
            tb2.TabIndex = 3;
            tb2.TextChanged += tb2_TextChanged;
            // 
            // gb1
            // 
            gb1.Controls.Add(rd4);
            gb1.Controls.Add(rd3);
            gb1.Controls.Add(rd2);
            gb1.Controls.Add(rd1);
            gb1.Location = new Point(77, 174);
            gb1.Name = "gb1";
            gb1.Size = new Size(308, 125);
            gb1.TabIndex = 4;
            gb1.TabStop = false;
            gb1.Text = "Operation";
            // 
            // rd1
            // 
            rd1.AutoSize = true;
            rd1.Location = new Point(19, 37);
            rd1.Name = "rd1";
            rd1.Size = new Size(88, 24);
            rd1.TabIndex = 5;
            rd1.TabStop = true;
            rd1.Text = "Addition";
            rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            rd2.AutoSize = true;
            rd2.Location = new Point(161, 40);
            rd2.Name = "rd2";
            rd2.Size = new Size(106, 24);
            rd2.TabIndex = 6;
            rd2.TabStop = true;
            rd2.Text = "Subtraction";
            rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            rd3.AutoSize = true;
            rd3.Location = new Point(23, 81);
            rd3.Name = "rd3";
            rd3.Size = new Size(126, 24);
            rd3.TabIndex = 7;
            rd3.TabStop = true;
            rd3.Text = "Multiplication ";
            rd3.UseVisualStyleBackColor = true;
            // 
            // rd4
            // 
            rd4.AutoSize = true;
            rd4.Location = new Point(164, 85);
            rd4.Name = "rd4";
            rd4.Size = new Size(79, 24);
            rd4.TabIndex = 8;
            rd4.TabStop = true;
            rd4.Text = "Divison";
            rd4.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(164, 324);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 5;
            btn1.Text = "Answer ";
            btn1.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            gb2.Controls.Add(a);
            gb2.Location = new Point(77, 359);
            gb2.Name = "gb2";
            gb2.Size = new Size(308, 61);
            gb2.TabIndex = 6;
            gb2.TabStop = false;
            gb2.Text = "Answer ";
            gb2.Enter += groupBox2_Enter;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(23, 23);
            a.Name = "a";
            a.Size = new Size(61, 20);
            a.TabIndex = 0;
            a.Text = "Answer ";
            a.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(437, 524);
            Controls.Add(gb2);
            Controls.Add(btn1);
            Controls.Add(gb1);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "Form1";
            Text = "Calculation";
            Load += Form1_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label n1;
        private Label n2;
        private TextBox tb1;
        private TextBox tb2;
        private GroupBox gb1;
        private RadioButton rd4;
        private RadioButton rd3;
        private RadioButton rd2;
        private RadioButton rd1;
        private Button btn1;
        private GroupBox gb2;
        private Label a;
    }
}
