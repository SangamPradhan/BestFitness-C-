namespace Best_Fitness
{
    partial class Athelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Athelete));
            this.cbx_planA = new System.Windows.Forms.ComboBox();
            this.btn_resetA = new System.Windows.Forms.Button();
            this.btn_saveA = new System.Windows.Forms.Button();
            this.tb_privatecoachingA = new System.Windows.Forms.TextBox();
            this.lbl_extratraining = new System.Windows.Forms.Label();
            this.cbx_saunaA = new System.Windows.Forms.ComboBox();
            this.lbl_sauna = new System.Windows.Forms.Label();
            this.extra = new System.Windows.Forms.Label();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.lb_joindate = new System.Windows.Forms.Label();
            this.dateTimePickerA = new System.Windows.Forms.DateTimePicker();
            this.tb_phoneA = new System.Windows.Forms.TextBox();
            this.tb_addressA = new System.Windows.Forms.TextBox();
            this.tb_nameA = new System.Windows.Forms.TextBox();
            this.rbtn_femaleA = new System.Windows.Forms.RadioButton();
            this.rbtn_maleA = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_planA
            // 
            this.cbx_planA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_planA.ForeColor = System.Drawing.Color.Black;
            this.cbx_planA.FormattingEnabled = true;
            this.cbx_planA.Items.AddRange(new object[] {
            "1 ",
            "2",
            "3 ",
            "4",
            "5 ",
            "6 ",
            "7 ",
            "8",
            "9 ",
            "10 ",
            "11",
            "12"});
            this.cbx_planA.Location = new System.Drawing.Point(227, 285);
            this.cbx_planA.Name = "cbx_planA";
            this.cbx_planA.Size = new System.Drawing.Size(121, 21);
            this.cbx_planA.TabIndex = 68;
            this.cbx_planA.SelectedIndexChanged += new System.EventHandler(this.cbx_plan_SelectedIndexChanged);
            // 
            // btn_resetA
            // 
            this.btn_resetA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resetA.Location = new System.Drawing.Point(436, 361);
            this.btn_resetA.Name = "btn_resetA";
            this.btn_resetA.Size = new System.Drawing.Size(75, 28);
            this.btn_resetA.TabIndex = 67;
            this.btn_resetA.Text = "Reset";
            this.btn_resetA.UseVisualStyleBackColor = true;
            this.btn_resetA.Click += new System.EventHandler(this.btn_resetA_Click);
            // 
            // btn_saveA
            // 
            this.btn_saveA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveA.Location = new System.Drawing.Point(311, 361);
            this.btn_saveA.Name = "btn_saveA";
            this.btn_saveA.Size = new System.Drawing.Size(75, 28);
            this.btn_saveA.TabIndex = 66;
            this.btn_saveA.Text = "Save";
            this.btn_saveA.UseVisualStyleBackColor = true;
            this.btn_saveA.Click += new System.EventHandler(this.btn_saveA_Click);
            // 
            // tb_privatecoachingA
            // 
            this.tb_privatecoachingA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_privatecoachingA.Location = new System.Drawing.Point(653, 213);
            this.tb_privatecoachingA.Margin = new System.Windows.Forms.Padding(4);
            this.tb_privatecoachingA.Name = "tb_privatecoachingA";
            this.tb_privatecoachingA.Size = new System.Drawing.Size(82, 26);
            this.tb_privatecoachingA.TabIndex = 65;
            // 
            // lbl_extratraining
            // 
            this.lbl_extratraining.AutoSize = true;
            this.lbl_extratraining.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extratraining.Location = new System.Drawing.Point(574, 163);
            this.lbl_extratraining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_extratraining.Name = "lbl_extratraining";
            this.lbl_extratraining.Size = new System.Drawing.Size(236, 25);
            this.lbl_extratraining.TabIndex = 64;
            this.lbl_extratraining.Text = "PRIVATE COACHING";
            // 
            // cbx_saunaA
            // 
            this.cbx_saunaA.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_saunaA.ForeColor = System.Drawing.Color.Black;
            this.cbx_saunaA.FormattingEnabled = true;
            this.cbx_saunaA.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_saunaA.Location = new System.Drawing.Point(689, 104);
            this.cbx_saunaA.Name = "cbx_saunaA";
            this.cbx_saunaA.Size = new System.Drawing.Size(121, 21);
            this.cbx_saunaA.TabIndex = 63;
            // 
            // lbl_sauna
            // 
            this.lbl_sauna.AutoSize = true;
            this.lbl_sauna.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sauna.Location = new System.Drawing.Point(573, 103);
            this.lbl_sauna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sauna.Name = "lbl_sauna";
            this.lbl_sauna.Size = new System.Drawing.Size(84, 25);
            this.lbl_sauna.TabIndex = 62;
            this.lbl_sauna.Text = "SAUNA";
            // 
            // extra
            // 
            this.extra.AutoSize = true;
            this.extra.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extra.Location = new System.Drawing.Point(564, 46);
            this.extra.Name = "extra";
            this.extra.Size = new System.Drawing.Size(246, 30);
            this.extra.TabIndex = 61;
            this.extra.Text = "EXTRA OPTIONS";
            // 
            // lbl_plan
            // 
            this.lbl_plan.AutoSize = true;
            this.lbl_plan.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.Location = new System.Drawing.Point(9, 285);
            this.lbl_plan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(195, 25);
            this.lbl_plan.TabIndex = 60;
            this.lbl_plan.Text = "Membership plan";
            // 
            // lb_joindate
            // 
            this.lb_joindate.AutoSize = true;
            this.lb_joindate.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_joindate.Location = new System.Drawing.Point(9, 241);
            this.lb_joindate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_joindate.Name = "lb_joindate";
            this.lb_joindate.Size = new System.Drawing.Size(105, 25);
            this.lb_joindate.TabIndex = 55;
            this.lb_joindate.Text = "Join Date";
            // 
            // dateTimePickerA
            // 
            this.dateTimePickerA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerA.Location = new System.Drawing.Point(188, 243);
            this.dateTimePickerA.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerA.Name = "dateTimePickerA";
            this.dateTimePickerA.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerA.TabIndex = 54;
            // 
            // tb_phoneA
            // 
            this.tb_phoneA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phoneA.Location = new System.Drawing.Point(188, 148);
            this.tb_phoneA.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phoneA.Name = "tb_phoneA";
            this.tb_phoneA.Size = new System.Drawing.Size(252, 33);
            this.tb_phoneA.TabIndex = 53;
            // 
            // tb_addressA
            // 
            this.tb_addressA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addressA.Location = new System.Drawing.Point(188, 103);
            this.tb_addressA.Margin = new System.Windows.Forms.Padding(4);
            this.tb_addressA.Name = "tb_addressA";
            this.tb_addressA.Size = new System.Drawing.Size(252, 33);
            this.tb_addressA.TabIndex = 52;
            // 
            // tb_nameA
            // 
            this.tb_nameA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameA.Location = new System.Drawing.Point(188, 66);
            this.tb_nameA.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nameA.Name = "tb_nameA";
            this.tb_nameA.Size = new System.Drawing.Size(252, 33);
            this.tb_nameA.TabIndex = 51;
            // 
            // rbtn_femaleA
            // 
            this.rbtn_femaleA.AutoSize = true;
            this.rbtn_femaleA.BackColor = System.Drawing.Color.Red;
            this.rbtn_femaleA.Location = new System.Drawing.Point(311, 196);
            this.rbtn_femaleA.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_femaleA.Name = "rbtn_femaleA";
            this.rbtn_femaleA.Size = new System.Drawing.Size(67, 17);
            this.rbtn_femaleA.TabIndex = 50;
            this.rbtn_femaleA.TabStop = true;
            this.rbtn_femaleA.Text = "FEMALE";
            this.rbtn_femaleA.UseVisualStyleBackColor = false;
            // 
            // rbtn_maleA
            // 
            this.rbtn_maleA.AutoSize = true;
            this.rbtn_maleA.BackColor = System.Drawing.Color.Lime;
            this.rbtn_maleA.Location = new System.Drawing.Point(188, 196);
            this.rbtn_maleA.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_maleA.Name = "rbtn_maleA";
            this.rbtn_maleA.Size = new System.Drawing.Size(54, 17);
            this.rbtn_maleA.TabIndex = 49;
            this.rbtn_maleA.TabStop = true;
            this.rbtn_maleA.Text = "MALE";
            this.rbtn_maleA.UseVisualStyleBackColor = false;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(9, 196);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(89, 25);
            this.lbl_gender.TabIndex = 48;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(9, 148);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(113, 25);
            this.lbl_phone.TabIndex = 47;
            this.lbl_phone.Text = "Phone no.";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(9, 104);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(96, 25);
            this.lbl_address.TabIndex = 46;
            this.lbl_address.Text = "Address";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(9, 66);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 25);
            this.lbl_name.TabIndex = 45;
            this.lbl_name.Text = "Name";
            // 
            // Athelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.cbx_planA);
            this.Controls.Add(this.btn_resetA);
            this.Controls.Add(this.btn_saveA);
            this.Controls.Add(this.tb_privatecoachingA);
            this.Controls.Add(this.lbl_extratraining);
            this.Controls.Add(this.cbx_saunaA);
            this.Controls.Add(this.lbl_sauna);
            this.Controls.Add(this.extra);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.lb_joindate);
            this.Controls.Add(this.dateTimePickerA);
            this.Controls.Add(this.tb_phoneA);
            this.Controls.Add(this.tb_addressA);
            this.Controls.Add(this.tb_nameA);
            this.Controls.Add(this.rbtn_femaleA);
            this.Controls.Add(this.rbtn_maleA);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "Athelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athelete";
            this.Load += new System.EventHandler(this.Athelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_planA;
        private System.Windows.Forms.Button btn_resetA;
        private System.Windows.Forms.Button btn_saveA;
        private System.Windows.Forms.TextBox tb_privatecoachingA;
        private System.Windows.Forms.Label lbl_extratraining;
        private System.Windows.Forms.ComboBox cbx_saunaA;
        private System.Windows.Forms.Label lbl_sauna;
        private System.Windows.Forms.Label extra;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Label lb_joindate;
        private System.Windows.Forms.DateTimePicker dateTimePickerA;
        private System.Windows.Forms.TextBox tb_phoneA;
        private System.Windows.Forms.TextBox tb_addressA;
        private System.Windows.Forms.TextBox tb_nameA;
        private System.Windows.Forms.RadioButton rbtn_femaleA;
        private System.Windows.Forms.RadioButton rbtn_maleA;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
    }
}