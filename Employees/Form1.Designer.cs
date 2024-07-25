namespace Employees
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.empNumTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fnTB = new System.Windows.Forms.TextBox();
            this.lnTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genderPnl = new System.Windows.Forms.Panel();
            this.femaleRd = new System.Windows.Forms.RadioButton();
            this.maleRd = new System.Windows.Forms.RadioButton();
            this.statusPnl = new System.Windows.Forms.Panel();
            this.windowerRd = new System.Windows.Forms.RadioButton();
            this.divorceeRd = new System.Windows.Forms.RadioButton();
            this.marriedRd = new System.Windows.Forms.RadioButton();
            this.bachelorRd = new System.Windows.Forms.RadioButton();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.houseNumTB = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.srcByEmpNum = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.srcById = new System.Windows.Forms.Button();
            this.empNum = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.houseNum = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.genderPnl.SuspendLayout();
            this.statusPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Gold;
            this.saveBtn.Location = new System.Drawing.Point(421, 332);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 45);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(901, 468);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "שמות העובדים";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // empNumTB
            // 
            this.empNumTB.Location = new System.Drawing.Point(651, 119);
            this.empNumTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.empNumTB.Name = "empNumTB";
            this.empNumTB.Size = new System.Drawing.Size(55, 21);
            this.empNumTB.TabIndex = 2;
            this.empNumTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // fnTB
            // 
            this.fnTB.Location = new System.Drawing.Point(612, 43);
            this.fnTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fnTB.Name = "fnTB";
            this.fnTB.Size = new System.Drawing.Size(115, 21);
            this.fnTB.TabIndex = 10;
            this.fnTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lnTB
            // 
            this.lnTB.Location = new System.Drawing.Point(461, 43);
            this.lnTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lnTB.Name = "lnTB";
            this.lnTB.Size = new System.Drawing.Size(116, 21);
            this.lnTB.TabIndex = 11;
            this.lnTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(318, 43);
            this.idTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(97, 21);
            this.idTB.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // genderPnl
            // 
            this.genderPnl.BackColor = System.Drawing.Color.NavajoWhite;
            this.genderPnl.Controls.Add(this.femaleRd);
            this.genderPnl.Controls.Add(this.maleRd);
            this.genderPnl.Location = new System.Drawing.Point(555, 204);
            this.genderPnl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.genderPnl.Name = "genderPnl";
            this.genderPnl.Size = new System.Drawing.Size(175, 77);
            this.genderPnl.TabIndex = 15;
            this.genderPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // femaleRd
            // 
            this.femaleRd.AutoSize = true;
            this.femaleRd.Location = new System.Drawing.Point(36, 44);
            this.femaleRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.femaleRd.Name = "femaleRd";
            this.femaleRd.Size = new System.Drawing.Size(73, 19);
            this.femaleRd.TabIndex = 1;
            this.femaleRd.TabStop = true;
            this.femaleRd.Text = "Female";
            this.femaleRd.UseVisualStyleBackColor = true;
            // 
            // maleRd
            // 
            this.maleRd.AutoSize = true;
            this.maleRd.Location = new System.Drawing.Point(37, 11);
            this.maleRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maleRd.Name = "maleRd";
            this.maleRd.Size = new System.Drawing.Size(56, 19);
            this.maleRd.TabIndex = 0;
            this.maleRd.TabStop = true;
            this.maleRd.Text = "Male";
            this.maleRd.UseVisualStyleBackColor = true;
            // 
            // statusPnl
            // 
            this.statusPnl.BackColor = System.Drawing.Color.NavajoWhite;
            this.statusPnl.Controls.Add(this.windowerRd);
            this.statusPnl.Controls.Add(this.divorceeRd);
            this.statusPnl.Controls.Add(this.marriedRd);
            this.statusPnl.Controls.Add(this.bachelorRd);
            this.statusPnl.Location = new System.Drawing.Point(307, 204);
            this.statusPnl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.statusPnl.Name = "statusPnl";
            this.statusPnl.Size = new System.Drawing.Size(201, 77);
            this.statusPnl.TabIndex = 16;
            // 
            // windowerRd
            // 
            this.windowerRd.AutoSize = true;
            this.windowerRd.Location = new System.Drawing.Point(104, 44);
            this.windowerRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.windowerRd.Name = "windowerRd";
            this.windowerRd.Size = new System.Drawing.Size(89, 19);
            this.windowerRd.TabIndex = 4;
            this.windowerRd.TabStop = true;
            this.windowerRd.Text = "Windower";
            this.windowerRd.UseVisualStyleBackColor = true;
            // 
            // divorceeRd
            // 
            this.divorceeRd.AutoSize = true;
            this.divorceeRd.Location = new System.Drawing.Point(17, 44);
            this.divorceeRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.divorceeRd.Name = "divorceeRd";
            this.divorceeRd.Size = new System.Drawing.Size(82, 19);
            this.divorceeRd.TabIndex = 3;
            this.divorceeRd.TabStop = true;
            this.divorceeRd.Text = "Divorcee";
            this.divorceeRd.UseVisualStyleBackColor = true;
            // 
            // marriedRd
            // 
            this.marriedRd.AutoSize = true;
            this.marriedRd.Location = new System.Drawing.Point(107, 11);
            this.marriedRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.marriedRd.Name = "marriedRd";
            this.marriedRd.Size = new System.Drawing.Size(74, 19);
            this.marriedRd.TabIndex = 1;
            this.marriedRd.TabStop = true;
            this.marriedRd.Text = "Married";
            this.marriedRd.UseVisualStyleBackColor = true;
            // 
            // bachelorRd
            // 
            this.bachelorRd.AutoSize = true;
            this.bachelorRd.Location = new System.Drawing.Point(17, 11);
            this.bachelorRd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bachelorRd.Name = "bachelorRd";
            this.bachelorRd.Size = new System.Drawing.Size(82, 19);
            this.bachelorRd.TabIndex = 0;
            this.bachelorRd.TabStop = true;
            this.bachelorRd.Text = "Bachelor";
            this.bachelorRd.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Lime;
            this.backBtn.Location = new System.Drawing.Point(362, 414);
            this.backBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 22);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Lime;
            this.nextBtn.Location = new System.Drawing.Point(251, 414);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(101, 22);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(461, 119);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(132, 21);
            this.phoneTB.TabIndex = 19;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(296, 119);
            this.cityTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(132, 21);
            this.cityTB.TabIndex = 20;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(143, 119);
            this.streetTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(132, 21);
            this.streetTB.TabIndex = 21;
            // 
            // houseNumTB
            // 
            this.houseNumTB.Location = new System.Drawing.Point(27, 119);
            this.houseNumTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.houseNumTB.Name = "houseNumTB";
            this.houseNumTB.Size = new System.Drawing.Size(79, 21);
            this.houseNumTB.TabIndex = 22;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Gold;
            this.updateBtn.Location = new System.Drawing.Point(226, 332);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(139, 45);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // srcByEmpNum
            // 
            this.srcByEmpNum.Location = new System.Drawing.Point(29, 212);
            this.srcByEmpNum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.srcByEmpNum.Name = "srcByEmpNum";
            this.srcByEmpNum.Size = new System.Drawing.Size(224, 22);
            this.srcByEmpNum.TabIndex = 24;
            this.srcByEmpNum.Text = "Search By Employee Number";
            this.srcByEmpNum.UseVisualStyleBackColor = true;
            this.srcByEmpNum.Click += new System.EventHandler(this.srcByEmpNum_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.Gold;
            this.newBtn.Location = new System.Drawing.Point(591, 332);
            this.newBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(138, 45);
            this.newBtn.TabIndex = 25;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteBtn.Location = new System.Drawing.Point(52, 332);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 45);
            this.deleteBtn.TabIndex = 26;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // srcById
            // 
            this.srcById.Location = new System.Drawing.Point(28, 248);
            this.srcById.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.srcById.Name = "srcById";
            this.srcById.Size = new System.Drawing.Size(225, 22);
            this.srcById.TabIndex = 27;
            this.srcById.Text = "Search By Id";
            this.srcById.UseVisualStyleBackColor = true;
            // 
            // empNum
            // 
            this.empNum.AutoSize = true;
            this.empNum.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.empNum.Location = new System.Drawing.Point(623, 92);
            this.empNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.empNum.Name = "empNum";
            this.empNum.Size = new System.Drawing.Size(104, 15);
            this.empNum.TabIndex = 28;
            this.empNum.Text = "Employee Num";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fName.Location = new System.Drawing.Point(627, 19);
            this.fName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(79, 15);
            this.fName.TabIndex = 29;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lName.Location = new System.Drawing.Point(485, 19);
            this.lName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(77, 15);
            this.lName.TabIndex = 30;
            this.lName.Text = "Last Name";
            this.lName.Click += new System.EventHandler(this.label4_Click);
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthday.Location = new System.Drawing.Point(168, 19);
            this.birthday.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(95, 15);
            this.birthday.TabIndex = 31;
            this.birthday.Text = "Date Of Birth";
            this.birthday.Click += new System.EventHandler(this.birthday_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.Location = new System.Drawing.Point(358, 19);
            this.id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(20, 15);
            this.id.TabIndex = 32;
            this.id.Text = "Id";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(504, 92);
            this.phone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(48, 15);
            this.phone.TabIndex = 33;
            this.phone.Text = "Phone";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.city.Location = new System.Drawing.Point(345, 92);
            this.city.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(33, 15);
            this.city.TabIndex = 34;
            this.city.Text = "City";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.street.Location = new System.Drawing.Point(183, 92);
            this.street.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(47, 15);
            this.street.TabIndex = 35;
            this.street.Text = "Street";
            this.street.Click += new System.EventHandler(this.label9_Click);
            // 
            // houseNum
            // 
            this.houseNum.AutoSize = true;
            this.houseNum.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.houseNum.Location = new System.Drawing.Point(24, 92);
            this.houseNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.houseNum.Name = "houseNum";
            this.houseNum.Size = new System.Drawing.Size(82, 15);
            this.houseNum.TabIndex = 36;
            this.houseNum.Text = "House Num";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.age.Location = new System.Drawing.Point(49, 19);
            this.age.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 15);
            this.age.TabIndex = 37;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.label11_Click);
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(27, 43);
            this.ageTB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ageTB.Name = "ageTB";
            this.ageTB.ReadOnly = true;
            this.ageTB.Size = new System.Drawing.Size(79, 21);
            this.ageTB.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 508);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.age);
            this.Controls.Add(this.houseNum);
            this.Controls.Add(this.street);
            this.Controls.Add(this.city);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.id);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.empNum);
            this.Controls.Add(this.srcById);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.srcByEmpNum);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.houseNumTB);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.statusPnl);
            this.Controls.Add(this.genderPnl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.lnTB);
            this.Controls.Add(this.fnTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empNumTB);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.saveBtn);
            this.Font = new System.Drawing.Font("Miriam", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.genderPnl.ResumeLayout(false);
            this.genderPnl.PerformLayout();
            this.statusPnl.ResumeLayout(false);
            this.statusPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox empNumTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnTB;
        private System.Windows.Forms.TextBox lnTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel genderPnl;
        private System.Windows.Forms.RadioButton femaleRd;
        private System.Windows.Forms.RadioButton maleRd;
        private System.Windows.Forms.Panel statusPnl;
        private System.Windows.Forms.RadioButton marriedRd;
        private System.Windows.Forms.RadioButton bachelorRd;
        private System.Windows.Forms.RadioButton windowerRd;
        private System.Windows.Forms.RadioButton divorceeRd;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox houseNumTB;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button srcByEmpNum;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button srcById;
        private System.Windows.Forms.Label empNum;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label houseNum;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox ageTB;
    }
}

