﻿namespace Act_01_LAb_08
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.label_hobby = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.radioButton_married = new System.Windows.Forms.RadioButton();
            this.radioButton_unmarried = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.checkBox_Read = new System.Windows.Forms.CheckBox();
            this.checkBox_Paint = new System.Windows.Forms.CheckBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(70, 69);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(121, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Customer Name:";
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_country.Location = new System.Drawing.Point(70, 131);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(63, 16);
            this.label_country.TabIndex = 1;
            this.label_country.Text = "Country:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(208, 69);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(172, 20);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // comboBox_country
            // 
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Items.AddRange(new object[] {
            "Pakistan",
            "India",
            "Bangladesh",
            "Nepal"});
            this.comboBox_country.Location = new System.Drawing.Point(208, 131);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(172, 21);
            this.comboBox_country.TabIndex = 3;
            this.comboBox_country.SelectedIndexChanged += new System.EventHandler(this.comboBox_country_SelectedIndexChanged);
            // 
            // label_hobby
            // 
            this.label_hobby.AutoSize = true;
            this.label_hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hobby.Location = new System.Drawing.Point(79, 329);
            this.label_hobby.Name = "label_hobby";
            this.label_hobby.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_hobby.Size = new System.Drawing.Size(57, 16);
            this.label_hobby.TabIndex = 4;
            this.label_hobby.Text = "Hobby:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(76, 414);
            this.label_status.Name = "label_status";
            this.label_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_status.Size = new System.Drawing.Size(54, 16);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Status:";
            // 
            // radioButton_married
            // 
            this.radioButton_married.AutoSize = true;
            this.radioButton_married.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_married.Location = new System.Drawing.Point(189, 451);
            this.radioButton_married.Name = "radioButton_married";
            this.radioButton_married.Size = new System.Drawing.Size(73, 20);
            this.radioButton_married.TabIndex = 6;
            this.radioButton_married.TabStop = true;
            this.radioButton_married.Text = "Married";
            this.radioButton_married.UseVisualStyleBackColor = true;
            // 
            // radioButton_unmarried
            // 
            this.radioButton_unmarried.AutoSize = true;
            this.radioButton_unmarried.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_unmarried.Location = new System.Drawing.Point(311, 451);
            this.radioButton_unmarried.Name = "radioButton_unmarried";
            this.radioButton_unmarried.Size = new System.Drawing.Size(90, 20);
            this.radioButton_unmarried.TabIndex = 7;
            this.radioButton_unmarried.TabStop = true;
            this.radioButton_unmarried.Text = "Unmarried";
            this.radioButton_unmarried.UseVisualStyleBackColor = true;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(18, 29);
            this.label_gender.Name = "label_gender";
            this.label_gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_gender.Size = new System.Drawing.Size(62, 16);
            this.label_gender.TabIndex = 8;
            this.label_gender.Text = "Gender:";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.Location = new System.Drawing.Point(139, 71);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(59, 20);
            this.radioButton_Male.TabIndex = 9;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.Location = new System.Drawing.Point(261, 71);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(77, 20);
            this.radioButton_Female.TabIndex = 10;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // checkBox_Read
            // 
            this.checkBox_Read.AutoSize = true;
            this.checkBox_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Read.Location = new System.Drawing.Point(192, 377);
            this.checkBox_Read.Name = "checkBox_Read";
            this.checkBox_Read.Size = new System.Drawing.Size(85, 20);
            this.checkBox_Read.TabIndex = 11;
            this.checkBox_Read.Text = "Reading";
            this.checkBox_Read.UseVisualStyleBackColor = true;
            // 
            // checkBox_Paint
            // 
            this.checkBox_Paint.AutoSize = true;
            this.checkBox_Paint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Paint.Location = new System.Drawing.Point(314, 377);
            this.checkBox_Paint.Name = "checkBox_Paint";
            this.checkBox_Paint.Size = new System.Drawing.Size(82, 20);
            this.checkBox_Paint.TabIndex = 12;
            this.checkBox_Paint.Text = "Painting";
            this.checkBox_Paint.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            this.btn_preview.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(189, 546);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(186, 41);
            this.btn_preview.TabIndex = 13;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_gender);
            this.groupBox1.Controls.Add(this.radioButton_Male);
            this.groupBox1.Controls.Add(this.radioButton_Female);
            this.groupBox1.Location = new System.Drawing.Point(58, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 115);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(484, 12);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.Size = new System.Drawing.Size(806, 600);
            this.dtgCustomer.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 637);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.checkBox_Read);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_hobby);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.checkBox_Paint);
            this.Controls.Add(this.radioButton_unmarried);
            this.Controls.Add(this.radioButton_married);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.Label label_hobby;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RadioButton radioButton_married;
        private System.Windows.Forms.RadioButton radioButton_unmarried;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.CheckBox checkBox_Read;
        private System.Windows.Forms.CheckBox checkBox_Paint;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgCustomer;
    }
}
