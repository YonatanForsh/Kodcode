namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblResolt = new System.Windows.Forms.Label();
            this.btnEql = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.plus_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.mul_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.txt2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResolt, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEql, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbOperator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plus_button, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.minus_button, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mul_button, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.div_button, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 258);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(211, 3);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(99, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt2.Enter += new System.EventHandler(this.txt2_Enter);
            // 
            // lblResolt
            // 
            this.lblResolt.AutoSize = true;
            this.lblResolt.Location = new System.Drawing.Point(390, 0);
            this.lblResolt.Name = "lblResolt";
            this.lblResolt.Size = new System.Drawing.Size(32, 13);
            this.lblResolt.TabIndex = 7;
            this.lblResolt.Text = "resolt\r\n";
            this.lblResolt.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnEql
            // 
            this.btnEql.BackColor = System.Drawing.Color.Turquoise;
            this.btnEql.Location = new System.Drawing.Point(316, 3);
            this.btnEql.Name = "btnEql";
            this.btnEql.Size = new System.Drawing.Size(68, 31);
            this.btnEql.TabIndex = 8;
            this.btnEql.Text = "=";
            this.btnEql.UseVisualStyleBackColor = false;
            this.btnEql.Click += new System.EventHandler(this.btnEql_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(3, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 44);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(211, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 44);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(3, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 47);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(211, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 47);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.Location = new System.Drawing.Point(105, 210);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 45);
            this.button10.TabIndex = 18;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(105, 3);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(100, 21);
            this.cmbOperator.TabIndex = 19;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbOperator.TextChanged += new System.EventHandler(this.cmbOperator_TextChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(105, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 47);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(105, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 44);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(211, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(105, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkSalmon;
            this.button11.Location = new System.Drawing.Point(211, 210);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 45);
            this.button11.TabIndex = 20;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.allButtons_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkSalmon;
            this.button12.Location = new System.Drawing.Point(3, 210);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 45);
            this.button12.TabIndex = 21;
            this.button12.Text = "Delete";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.delete_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(3, 3);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(96, 20);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt1_Enter);
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(316, 51);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(68, 47);
            this.plus_button.TabIndex = 22;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(316, 107);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(68, 44);
            this.minus_button.TabIndex = 23;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            // 
            // mul_button
            // 
            this.mul_button.Location = new System.Drawing.Point(316, 157);
            this.mul_button.Name = "mul_button";
            this.mul_button.Size = new System.Drawing.Size(68, 47);
            this.mul_button.TabIndex = 24;
            this.mul_button.Text = "*";
            this.mul_button.UseVisualStyleBackColor = true;
            this.mul_button.Click += new System.EventHandler(this.mul_button_Click);
            // 
            // div_button
            // 
            this.div_button.Location = new System.Drawing.Point(316, 210);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(68, 45);
            this.div_button.TabIndex = 25;
            this.div_button.Text = "/";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblResolt;
        private System.Windows.Forms.Button btnEql;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button mul_button;
        private System.Windows.Forms.Button div_button;
    }
}

