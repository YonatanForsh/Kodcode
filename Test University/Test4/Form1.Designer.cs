namespace Test4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBXDay = new System.Windows.Forms.ComboBox();
            this.CMBXDayInMonth = new System.Windows.Forms.ComboBox();
            this.CMBXMonth = new System.Windows.Forms.ComboBox();
            this.CMBXYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddDateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "יום בשבוע";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "היום בחודש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "חודש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "שנה";
            // 
            // CMBXDay
            // 
            this.CMBXDay.FormattingEnabled = true;
            this.CMBXDay.Items.AddRange(new object[] {
            "באחד בשבת",
            "בשני בשבת",
            "בשלישי בשבת",
            "ברביעי בשבת",
            "בחמישי בשבת",
            "בששי בשבת"});
            this.CMBXDay.Location = new System.Drawing.Point(619, 138);
            this.CMBXDay.Name = "CMBXDay";
            this.CMBXDay.Size = new System.Drawing.Size(98, 21);
            this.CMBXDay.TabIndex = 5;
            // 
            // CMBXDayInMonth
            // 
            this.CMBXDayInMonth.FormattingEnabled = true;
            this.CMBXDayInMonth.Items.AddRange(new object[] {
            "יום אחד לירח פלוני",
            "שני ימים לירח פלוני",
            "שלושה ימים לירח פלוני",
            "ארבעה ימים לירח פלוני",
            "חמישה ימים לירח פלוני",
            "שישה ימים לירח פלוני"});
            this.CMBXDayInMonth.Location = new System.Drawing.Point(453, 138);
            this.CMBXDayInMonth.Name = "CMBXDayInMonth";
            this.CMBXDayInMonth.Size = new System.Drawing.Size(66, 21);
            this.CMBXDayInMonth.TabIndex = 6;
            // 
            // CMBXMonth
            // 
            this.CMBXMonth.FormattingEnabled = true;
            this.CMBXMonth.Items.AddRange(new object[] {
            "תשרי",
            "חשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר א",
            "אדר ב",
            "ניסן",
            "אייר",
            "סיוון",
            "תמוז",
            "אב",
            "אלול"});
            this.CMBXMonth.Location = new System.Drawing.Point(266, 138);
            this.CMBXMonth.Name = "CMBXMonth";
            this.CMBXMonth.Size = new System.Drawing.Size(90, 21);
            this.CMBXMonth.TabIndex = 7;
            // 
            // CMBXYear
            // 
            this.CMBXYear.FormattingEnabled = true;
            this.CMBXYear.Items.AddRange(new object[] {
            "תשפד",
            "תשפה",
            "תשפו",
            "תשפז",
            "תשפח",
            "תשפט",
            "תשצ",
            "תשצא",
            "תשצב",
            "תשצג",
            "תשצד"});
            this.CMBXYear.Location = new System.Drawing.Point(108, 138);
            this.CMBXYear.Name = "CMBXYear";
            this.CMBXYear.Size = new System.Drawing.Size(84, 21);
            this.CMBXYear.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "תאריך הנכון";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddDateBtn
            // 
            this.AddDateBtn.Location = new System.Drawing.Point(310, 266);
            this.AddDateBtn.Name = "AddDateBtn";
            this.AddDateBtn.Size = new System.Drawing.Size(136, 23);
            this.AddDateBtn.TabIndex = 10;
            this.AddDateBtn.Text = "הכנסת תאריך";
            this.AddDateBtn.UseVisualStyleBackColor = true;
            this.AddDateBtn.Click += new System.EventHandler(this.AddDateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddDateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CMBXYear);
            this.Controls.Add(this.CMBXMonth);
            this.Controls.Add(this.CMBXDayInMonth);
            this.Controls.Add(this.CMBXDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBXDay;
        private System.Windows.Forms.ComboBox CMBXDayInMonth;
        private System.Windows.Forms.ComboBox CMBXMonth;
        private System.Windows.Forms.ComboBox CMBXYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddDateBtn;
    }
}

