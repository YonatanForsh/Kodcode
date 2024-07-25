namespace Clock_time
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.ChPBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(316, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(285, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter password";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(283, 138);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(149, 20);
            this.IdTB.TabIndex = 2;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(283, 299);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(149, 20);
            this.PassTB.TabIndex = 3;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            this.PassTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTB_KeyPress);
            // 
            // ChPBtn
            // 
            this.ChPBtn.Location = new System.Drawing.Point(12, 12);
            this.ChPBtn.Name = "ChPBtn";
            this.ChPBtn.Size = new System.Drawing.Size(128, 57);
            this.ChPBtn.TabIndex = 4;
            this.ChPBtn.Text = "Change password";
            this.ChPBtn.UseVisualStyleBackColor = true;
            this.ChPBtn.Click += new System.EventHandler(this.ChPBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChPBtn);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button ChPBtn;
    }
}

