namespace PartForm
{
    partial class AddPartForm
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
            this.partAddPartID = new System.Windows.Forms.TextBox();
            this.partAddMin = new System.Windows.Forms.TextBox();
            this.partAddMax = new System.Windows.Forms.TextBox();
            this.partAddPrice = new System.Windows.Forms.TextBox();
            this.partAddInventory = new System.Windows.Forms.TextBox();
            this.partAddPartName = new System.Windows.Forms.TextBox();
            this.addPartInhouseRadio = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.partAddMachineID = new System.Windows.Forms.TextBox();
            this.partAddCompanyName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PartAddSaveButton = new System.Windows.Forms.Button();
            this.partAddCancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // partAddPartID
            // 
            this.partAddPartID.Enabled = false;
            this.partAddPartID.Location = new System.Drawing.Point(29, 79);
            this.partAddPartID.Name = "partAddPartID";
            this.partAddPartID.ReadOnly = true;
            this.partAddPartID.Size = new System.Drawing.Size(185, 22);
            this.partAddPartID.TabIndex = 0;
            // 
            // partAddMin
            // 
            this.partAddMin.Location = new System.Drawing.Point(298, 281);
            this.partAddMin.Name = "partAddMin";
            this.partAddMin.Size = new System.Drawing.Size(185, 22);
            this.partAddMin.TabIndex = 4;
            // 
            // partAddMax
            // 
            this.partAddMax.Location = new System.Drawing.Point(298, 207);
            this.partAddMax.Name = "partAddMax";
            this.partAddMax.Size = new System.Drawing.Size(185, 22);
            this.partAddMax.TabIndex = 3;
            // 
            // partAddPrice
            // 
            this.partAddPrice.Location = new System.Drawing.Point(40, 326);
            this.partAddPrice.Name = "partAddPrice";
            this.partAddPrice.Size = new System.Drawing.Size(152, 22);
            this.partAddPrice.TabIndex = 5;
            // 
            // partAddInventory
            // 
            this.partAddInventory.Location = new System.Drawing.Point(29, 240);
            this.partAddInventory.Name = "partAddInventory";
            this.partAddInventory.Size = new System.Drawing.Size(185, 22);
            this.partAddInventory.TabIndex = 2;
            // 
            // partAddPartName
            // 
            this.partAddPartName.Location = new System.Drawing.Point(29, 154);
            this.partAddPartName.Name = "partAddPartName";
            this.partAddPartName.Size = new System.Drawing.Size(185, 22);
            this.partAddPartName.TabIndex = 1;
            // 
            // addPartInhouseRadio
            // 
            this.addPartInhouseRadio.AutoSize = true;
            this.addPartInhouseRadio.Location = new System.Drawing.Point(32, 32);
            this.addPartInhouseRadio.Name = "addPartInhouseRadio";
            this.addPartInhouseRadio.Size = new System.Drawing.Size(75, 20);
            this.addPartInhouseRadio.TabIndex = 6;
            this.addPartInhouseRadio.TabStop = true;
            this.addPartInhouseRadio.Text = "Inhouse";
            this.addPartInhouseRadio.UseVisualStyleBackColor = true;
            this.addPartInhouseRadio.Click += new System.EventHandler(this.partAddInHouseRadioButtong_Click);
            // 
            // addPartOutsourcedRadio
            // 
            this.addPartOutsourcedRadio.AutoSize = true;
            this.addPartOutsourcedRadio.Location = new System.Drawing.Point(32, 68);
            this.addPartOutsourcedRadio.Name = "addPartOutsourcedRadio";
            this.addPartOutsourcedRadio.Size = new System.Drawing.Size(97, 20);
            this.addPartOutsourcedRadio.TabIndex = 7;
            this.addPartOutsourcedRadio.TabStop = true;
            this.addPartOutsourcedRadio.Text = "Outsourced";
            this.addPartOutsourcedRadio.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadio.Click += new System.EventHandler(this.partAddOutsourcedRadioButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inventory Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Maximum Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minimum Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "$";
            // 
            // partAddMachineID
            // 
            this.partAddMachineID.Location = new System.Drawing.Point(37, 401);
            this.partAddMachineID.Name = "partAddMachineID";
            this.partAddMachineID.Size = new System.Drawing.Size(177, 22);
            this.partAddMachineID.TabIndex = 6;
            // 
            // partAddCompanyName
            // 
            this.partAddCompanyName.Location = new System.Drawing.Point(298, 398);
            this.partAddCompanyName.Name = "partAddCompanyName";
            this.partAddCompanyName.Size = new System.Drawing.Size(184, 22);
            this.partAddCompanyName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Company Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Machine ID";
            // 
            // PartAddSaveButton
            // 
            this.PartAddSaveButton.Location = new System.Drawing.Point(71, 472);
            this.PartAddSaveButton.Name = "PartAddSaveButton";
            this.PartAddSaveButton.Size = new System.Drawing.Size(86, 23);
            this.PartAddSaveButton.TabIndex = 9;
            this.PartAddSaveButton.Text = "Save";
            this.PartAddSaveButton.UseVisualStyleBackColor = true;
            this.PartAddSaveButton.Click += new System.EventHandler(this.PartAddSaveButton_Click);
            // 
            // partAddCancelButton
            // 
            this.partAddCancelButton.Location = new System.Drawing.Point(341, 472);
            this.partAddCancelButton.Name = "partAddCancelButton";
            this.partAddCancelButton.Size = new System.Drawing.Size(86, 23);
            this.partAddCancelButton.TabIndex = 10;
            this.partAddCancelButton.Text = "Cancel";
            this.partAddCancelButton.UseVisualStyleBackColor = true;
            this.partAddCancelButton.Click += new System.EventHandler(this.partAddCancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addPartOutsourcedRadio);
            this.groupBox1.Controls.Add(this.addPartInhouseRadio);
            this.groupBox1.Location = new System.Drawing.Point(280, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part Source";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 41);
            this.label11.TabIndex = 44;
            this.label11.Text = "Add Part";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 541);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.partAddCancelButton);
            this.Controls.Add(this.PartAddSaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.partAddCompanyName);
            this.Controls.Add(this.partAddMachineID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partAddPartName);
            this.Controls.Add(this.partAddInventory);
            this.Controls.Add(this.partAddPrice);
            this.Controls.Add(this.partAddMax);
            this.Controls.Add(this.partAddMin);
            this.Controls.Add(this.partAddPartID);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partAddPartID;
        private System.Windows.Forms.TextBox partAddMin;
        private System.Windows.Forms.TextBox partAddMax;
        private System.Windows.Forms.TextBox partAddPrice;
        private System.Windows.Forms.TextBox partAddInventory;
        private System.Windows.Forms.TextBox partAddPartName;
        private System.Windows.Forms.RadioButton addPartInhouseRadio;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox partAddMachineID;
        private System.Windows.Forms.TextBox partAddCompanyName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PartAddSaveButton;
        private System.Windows.Forms.Button partAddCancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
    }
}