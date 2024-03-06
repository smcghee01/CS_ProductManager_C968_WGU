namespace ModifyPart
{
    partial class modifyPartForm
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
            this.modPartCancelButton = new System.Windows.Forms.Button();
            this.modPartSaveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.modPartCompanyName = new System.Windows.Forms.TextBox();
            this.modPartMachineID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modPartOutsourced = new System.Windows.Forms.RadioButton();
            this.modPartInhouse = new System.Windows.Forms.RadioButton();
            this.modPartName = new System.Windows.Forms.TextBox();
            this.modPartInventory = new System.Windows.Forms.TextBox();
            this.modPartPrice = new System.Windows.Forms.TextBox();
            this.modPartMax = new System.Windows.Forms.TextBox();
            this.modPartMin = new System.Windows.Forms.TextBox();
            this.modPartID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modPartCancelButton
            // 
            this.modPartCancelButton.Location = new System.Drawing.Point(357, 473);
            this.modPartCancelButton.Name = "modPartCancelButton";
            this.modPartCancelButton.Size = new System.Drawing.Size(86, 23);
            this.modPartCancelButton.TabIndex = 8;
            this.modPartCancelButton.Text = "Cancel";
            this.modPartCancelButton.UseVisualStyleBackColor = true;
            this.modPartCancelButton.Click += new System.EventHandler(this.modPartCancelButton_Click);
            // 
            // modPartSaveButton
            // 
            this.modPartSaveButton.Location = new System.Drawing.Point(87, 473);
            this.modPartSaveButton.Name = "modPartSaveButton";
            this.modPartSaveButton.Size = new System.Drawing.Size(86, 23);
            this.modPartSaveButton.TabIndex = 7;
            this.modPartSaveButton.Text = "Save";
            this.modPartSaveButton.UseVisualStyleBackColor = true;
            this.modPartSaveButton.Click += new System.EventHandler(this.modPartSaveButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Machine ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Company Name";
            // 
            // modPartCompanyName
            // 
            this.modPartCompanyName.Location = new System.Drawing.Point(314, 402);
            this.modPartCompanyName.Name = "modPartCompanyName";
            this.modPartCompanyName.Size = new System.Drawing.Size(184, 22);
            this.modPartCompanyName.TabIndex = 6;
            // 
            // modPartMachineID
            // 
            this.modPartMachineID.Location = new System.Drawing.Point(53, 402);
            this.modPartMachineID.Name = "modPartMachineID";
            this.modPartMachineID.Size = new System.Drawing.Size(177, 22);
            this.modPartMachineID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Part Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Minimum Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Maximum Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Inventory Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Part ID";
            // 
            // modPartOutsourced
            // 
            this.modPartOutsourced.AutoSize = true;
            this.modPartOutsourced.Location = new System.Drawing.Point(29, 64);
            this.modPartOutsourced.Name = "modPartOutsourced";
            this.modPartOutsourced.Size = new System.Drawing.Size(97, 20);
            this.modPartOutsourced.TabIndex = 28;
            this.modPartOutsourced.Text = "Outsourced";
            this.modPartOutsourced.UseVisualStyleBackColor = true;
            // 
            // modPartInhouse
            // 
            this.modPartInhouse.AutoSize = true;
            this.modPartInhouse.Location = new System.Drawing.Point(29, 34);
            this.modPartInhouse.Name = "modPartInhouse";
            this.modPartInhouse.Size = new System.Drawing.Size(75, 20);
            this.modPartInhouse.TabIndex = 27;
            this.modPartInhouse.Text = "Inhouse";
            this.modPartInhouse.UseVisualStyleBackColor = true;
            // 
            // modPartName
            // 
            this.modPartName.Location = new System.Drawing.Point(45, 155);
            this.modPartName.Name = "modPartName";
            this.modPartName.Size = new System.Drawing.Size(185, 22);
            this.modPartName.TabIndex = 0;
            // 
            // modPartInventory
            // 
            this.modPartInventory.Location = new System.Drawing.Point(45, 241);
            this.modPartInventory.Name = "modPartInventory";
            this.modPartInventory.Size = new System.Drawing.Size(185, 22);
            this.modPartInventory.TabIndex = 1;
            // 
            // modPartPrice
            // 
            this.modPartPrice.Location = new System.Drawing.Point(56, 327);
            this.modPartPrice.Name = "modPartPrice";
            this.modPartPrice.Size = new System.Drawing.Size(152, 22);
            this.modPartPrice.TabIndex = 4;
            // 
            // modPartMax
            // 
            this.modPartMax.Location = new System.Drawing.Point(314, 208);
            this.modPartMax.Name = "modPartMax";
            this.modPartMax.Size = new System.Drawing.Size(185, 22);
            this.modPartMax.TabIndex = 2;
            // 
            // modPartMin
            // 
            this.modPartMin.Location = new System.Drawing.Point(314, 282);
            this.modPartMin.Name = "modPartMin";
            this.modPartMin.Size = new System.Drawing.Size(185, 22);
            this.modPartMin.TabIndex = 3;
            // 
            // modPartID
            // 
            this.modPartID.Enabled = false;
            this.modPartID.Location = new System.Drawing.Point(45, 80);
            this.modPartID.Name = "modPartID";
            this.modPartID.ReadOnly = true;
            this.modPartID.Size = new System.Drawing.Size(185, 22);
            this.modPartID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modPartOutsourced);
            this.groupBox1.Controls.Add(this.modPartInhouse);
            this.groupBox1.Location = new System.Drawing.Point(298, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 105);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part Source";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 41);
            this.label11.TabIndex = 44;
            this.label11.Text = "Modify Part";
            // 
            // modifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modPartCancelButton);
            this.Controls.Add(this.modPartSaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modPartCompanyName);
            this.Controls.Add(this.modPartMachineID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modPartName);
            this.Controls.Add(this.modPartInventory);
            this.Controls.Add(this.modPartPrice);
            this.Controls.Add(this.modPartMax);
            this.Controls.Add(this.modPartMin);
            this.Controls.Add(this.modPartID);
            this.Name = "modifyPartForm";
            this.Text = "Part";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modPartCancelButton;
        private System.Windows.Forms.Button modPartSaveButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modPartCompanyName;
        private System.Windows.Forms.TextBox modPartMachineID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton modPartOutsourced;
        private System.Windows.Forms.RadioButton modPartInhouse;
        private System.Windows.Forms.TextBox modPartName;
        private System.Windows.Forms.TextBox modPartInventory;
        private System.Windows.Forms.TextBox modPartPrice;
        private System.Windows.Forms.TextBox modPartMax;
        private System.Windows.Forms.TextBox modPartMin;
        private System.Windows.Forms.TextBox modPartID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
    }
}