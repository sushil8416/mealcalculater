namespace Assignment_4
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
            this.lblMealCost = new System.Windows.Forms.Label();
            this.txtMealCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdkGrtThan = new System.Windows.Forms.RadioButton();
            this.rdkLessThan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkMilitary = new System.Windows.Forms.CheckBox();
            this.tipitemsListBox = new System.Windows.Forms.ListBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMealCost
            // 
            this.lblMealCost.AutoSize = true;
            this.lblMealCost.Location = new System.Drawing.Point(361, 76);
            this.lblMealCost.Name = "lblMealCost";
            this.lblMealCost.Size = new System.Drawing.Size(54, 13);
            this.lblMealCost.TabIndex = 0;
            this.lblMealCost.Text = "Meal Cost";
            // 
            // txtMealCost
            // 
            this.txtMealCost.Location = new System.Drawing.Point(477, 76);
            this.txtMealCost.Name = "txtMealCost";
            this.txtMealCost.Size = new System.Drawing.Size(144, 20);
            this.txtMealCost.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdkGrtThan);
            this.groupBox1.Controls.Add(this.rdkLessThan);
            this.groupBox1.Location = new System.Drawing.Point(108, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Size";
            // 
            // rdkGrtThan
            // 
            this.rdkGrtThan.AutoSize = true;
            this.rdkGrtThan.Location = new System.Drawing.Point(35, 114);
            this.rdkGrtThan.Name = "rdkGrtThan";
            this.rdkGrtThan.Size = new System.Drawing.Size(70, 17);
            this.rdkGrtThan.TabIndex = 1;
            this.rdkGrtThan.TabStop = true;
            this.rdkGrtThan.Text = "6 or More";
            this.rdkGrtThan.UseVisualStyleBackColor = true;
            this.rdkGrtThan.CheckedChanged += new System.EventHandler(this.rdkGrtThan_CheckedChanged);
            // 
            // rdkLessThan
            // 
            this.rdkLessThan.AutoSize = true;
            this.rdkLessThan.Location = new System.Drawing.Point(35, 45);
            this.rdkLessThan.Name = "rdkLessThan";
            this.rdkLessThan.Size = new System.Drawing.Size(84, 17);
            this.rdkLessThan.TabIndex = 0;
            this.rdkLessThan.TabStop = true;
            this.rdkLessThan.Text = "Less Than 6";
            this.rdkLessThan.UseVisualStyleBackColor = true;
            this.rdkLessThan.CheckedChanged += new System.EventHandler(this.rdkLessThan_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSeniorCitizen);
            this.groupBox2.Controls.Add(this.chkStudent);
            this.groupBox2.Controls.Add(this.chkMilitary);
            this.groupBox2.Location = new System.Drawing.Point(467, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Discount (10%)";
            // 
            // chkSeniorCitizen
            // 
            this.chkSeniorCitizen.AutoSize = true;
            this.chkSeniorCitizen.Location = new System.Drawing.Point(54, 141);
            this.chkSeniorCitizen.Name = "chkSeniorCitizen";
            this.chkSeniorCitizen.Size = new System.Drawing.Size(90, 17);
            this.chkSeniorCitizen.TabIndex = 2;
            this.chkSeniorCitizen.Text = "Senior Citizen";
            this.chkSeniorCitizen.UseVisualStyleBackColor = true;
            this.chkSeniorCitizen.CheckedChanged += new System.EventHandler(this.chkSeniorCitizen_CheckedChanged);
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(54, 94);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(63, 17);
            this.chkStudent.TabIndex = 1;
            this.chkStudent.Text = "Student";
            this.chkStudent.UseVisualStyleBackColor = true;
            this.chkStudent.CheckedChanged += new System.EventHandler(this.chkStudent_CheckedChanged);
            // 
            // chkMilitary
            // 
            this.chkMilitary.AutoSize = true;
            this.chkMilitary.Location = new System.Drawing.Point(54, 46);
            this.chkMilitary.Name = "chkMilitary";
            this.chkMilitary.Size = new System.Drawing.Size(100, 17);
            this.chkMilitary.TabIndex = 0;
            this.chkMilitary.Text = "Military/Veteran";
            this.chkMilitary.UseVisualStyleBackColor = true;
            this.chkMilitary.CheckedChanged += new System.EventHandler(this.chkMilitary_CheckedChanged);
            // 
            // tipitemsListBox
            // 
            this.tipitemsListBox.FormattingEnabled = true;
            this.tipitemsListBox.Location = new System.Drawing.Point(295, 419);
            this.tipitemsListBox.Name = "tipitemsListBox";
            this.tipitemsListBox.Size = new System.Drawing.Size(263, 108);
            this.tipitemsListBox.TabIndex = 4;
            this.tipitemsListBox.SelectedIndexChanged += new System.EventHandler(this.tipitemsListBox_SelectedIndexChanged);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Enabled = false;
            this.btnCalculateTotal.Location = new System.Drawing.Point(373, 536);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateTotal.TabIndex = 5;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 571);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.tipitemsListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMealCost);
            this.Controls.Add(this.lblMealCost);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meal Cost Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealCost;
        private System.Windows.Forms.TextBox txtMealCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdkGrtThan;
        private System.Windows.Forms.RadioButton rdkLessThan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkSeniorCitizen;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkMilitary;
        private System.Windows.Forms.ListBox tipitemsListBox;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}

