namespace ModifyProduct
{
    partial class modifyProdForm
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
            this.prodModPartDeleteButton = new System.Windows.Forms.Button();
            this.prodModPartAddButton = new System.Windows.Forms.Button();
            this.prodModifyCancelButton = new System.Windows.Forms.Button();
            this.prodModPartSearchButton = new System.Windows.Forms.Button();
            this.prodModSaveButton = new System.Windows.Forms.Button();
            this.prodModAllPartsGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modProdName = new System.Windows.Forms.TextBox();
            this.modProdPrice = new System.Windows.Forms.TextBox();
            this.modProdInvLvl = new System.Windows.Forms.TextBox();
            this.modProdMin = new System.Windows.Forms.TextBox();
            this.modProdMax = new System.Windows.Forms.TextBox();
            this.modProdID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modProdAssociatedPartsGrid = new System.Windows.Forms.DataGridView();
            this.prodModAssociatedPartSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodModAllPartsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdAssociatedPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // prodModPartDeleteButton
            // 
            this.prodModPartDeleteButton.Location = new System.Drawing.Point(922, 548);
            this.prodModPartDeleteButton.Name = "prodModPartDeleteButton";
            this.prodModPartDeleteButton.Size = new System.Drawing.Size(86, 26);
            this.prodModPartDeleteButton.TabIndex = 35;
            this.prodModPartDeleteButton.Text = "Delete Part";
            this.prodModPartDeleteButton.UseVisualStyleBackColor = true;
            this.prodModPartDeleteButton.Click += new System.EventHandler(this.ModProdDeletePartButton_Click);
            // 
            // prodModPartAddButton
            // 
            this.prodModPartAddButton.Location = new System.Drawing.Point(930, 283);
            this.prodModPartAddButton.Name = "prodModPartAddButton";
            this.prodModPartAddButton.Size = new System.Drawing.Size(78, 26);
            this.prodModPartAddButton.TabIndex = 34;
            this.prodModPartAddButton.Text = "Add Part";
            this.prodModPartAddButton.UseVisualStyleBackColor = true;
            this.prodModPartAddButton.Click += new System.EventHandler(this.ModProdAddPartButton_Click);
            // 
            // prodModifyCancelButton
            // 
            this.prodModifyCancelButton.Location = new System.Drawing.Point(280, 438);
            this.prodModifyCancelButton.Name = "prodModifyCancelButton";
            this.prodModifyCancelButton.Size = new System.Drawing.Size(73, 26);
            this.prodModifyCancelButton.TabIndex = 33;
            this.prodModifyCancelButton.Text = "Cancel";
            this.prodModifyCancelButton.UseVisualStyleBackColor = true;
            this.prodModifyCancelButton.Click += new System.EventHandler(this.ModProdCancelButton_Click);
            // 
            // prodModPartSearchButton
            // 
            this.prodModPartSearchButton.Location = new System.Drawing.Point(734, 47);
            this.prodModPartSearchButton.Name = "prodModPartSearchButton";
            this.prodModPartSearchButton.Size = new System.Drawing.Size(81, 26);
            this.prodModPartSearchButton.TabIndex = 32;
            this.prodModPartSearchButton.Text = "Search";
            this.prodModPartSearchButton.UseVisualStyleBackColor = true;
            this.prodModPartSearchButton.Click += new System.EventHandler(this.ModProdSearchButton_Click);
            // 
            // prodModSaveButton
            // 
            this.prodModSaveButton.Location = new System.Drawing.Point(73, 438);
            this.prodModSaveButton.Name = "prodModSaveButton";
            this.prodModSaveButton.Size = new System.Drawing.Size(72, 26);
            this.prodModSaveButton.TabIndex = 31;
            this.prodModSaveButton.Text = "Save";
            this.prodModSaveButton.UseVisualStyleBackColor = true;
            this.prodModSaveButton.Click += new System.EventHandler(this.ModProdSaveButton_Click);
            // 
            // prodModAllPartsGrid
            // 
            this.prodModAllPartsGrid.AllowUserToAddRows = false;
            this.prodModAllPartsGrid.AllowUserToDeleteRows = false;
            this.prodModAllPartsGrid.AllowUserToResizeColumns = false;
            this.prodModAllPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodModAllPartsGrid.Location = new System.Drawing.Point(500, 79);
            this.prodModAllPartsGrid.MultiSelect = false;
            this.prodModAllPartsGrid.Name = "prodModAllPartsGrid";
            this.prodModAllPartsGrid.ReadOnly = true;
            this.prodModAllPartsGrid.RowHeadersWidth = 51;
            this.prodModAllPartsGrid.RowTemplate.Height = 24;
            this.prodModAllPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodModAllPartsGrid.Size = new System.Drawing.Size(508, 198);
            this.prodModAllPartsGrid.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Inventory Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Min Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Max Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // modProdName
            // 
            this.modProdName.Location = new System.Drawing.Point(43, 176);
            this.modProdName.Name = "modProdName";
            this.modProdName.Size = new System.Drawing.Size(142, 22);
            this.modProdName.TabIndex = 1;
            // 
            // modProdPrice
            // 
            this.modProdPrice.Location = new System.Drawing.Point(69, 300);
            this.modProdPrice.Name = "modProdPrice";
            this.modProdPrice.Size = new System.Drawing.Size(100, 22);
            this.modProdPrice.TabIndex = 3;
            // 
            // modProdInvLvl
            // 
            this.modProdInvLvl.Location = new System.Drawing.Point(43, 236);
            this.modProdInvLvl.Name = "modProdInvLvl";
            this.modProdInvLvl.Size = new System.Drawing.Size(142, 22);
            this.modProdInvLvl.TabIndex = 2;
            // 
            // modProdMin
            // 
            this.modProdMin.Location = new System.Drawing.Point(43, 366);
            this.modProdMin.Name = "modProdMin";
            this.modProdMin.Size = new System.Drawing.Size(142, 22);
            this.modProdMin.TabIndex = 4;
            // 
            // modProdMax
            // 
            this.modProdMax.Location = new System.Drawing.Point(251, 363);
            this.modProdMax.Name = "modProdMax";
            this.modProdMax.Size = new System.Drawing.Size(142, 22);
            this.modProdMax.TabIndex = 5;
            // 
            // modProdID
            // 
            this.modProdID.Enabled = false;
            this.modProdID.Location = new System.Drawing.Point(43, 120);
            this.modProdID.Name = "modProdID";
            this.modProdID.ReadOnly = true;
            this.modProdID.Size = new System.Drawing.Size(142, 22);
            this.modProdID.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(47, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "$";
            // 
            // modProdAssociatedPartsGrid
            // 
            this.modProdAssociatedPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProdAssociatedPartsGrid.Location = new System.Drawing.Point(500, 344);
            this.modProdAssociatedPartsGrid.MultiSelect = false;
            this.modProdAssociatedPartsGrid.Name = "modProdAssociatedPartsGrid";
            this.modProdAssociatedPartsGrid.ReadOnly = true;
            this.modProdAssociatedPartsGrid.RowHeadersWidth = 51;
            this.modProdAssociatedPartsGrid.RowTemplate.Height = 24;
            this.modProdAssociatedPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modProdAssociatedPartsGrid.Size = new System.Drawing.Size(508, 198);
            this.modProdAssociatedPartsGrid.TabIndex = 37;
            // 
            // prodModAssociatedPartSearch
            // 
            this.prodModAssociatedPartSearch.Location = new System.Drawing.Point(821, 47);
            this.prodModAssociatedPartSearch.Name = "prodModAssociatedPartSearch";
            this.prodModAssociatedPartSearch.Size = new System.Drawing.Size(187, 22);
            this.prodModAssociatedPartSearch.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "All Candidate Parts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Associated Parts";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 41);
            this.label11.TabIndex = 42;
            this.label11.Text = "Modify Product";
            // 
            // modifyProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 592);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.prodModAssociatedPartSearch);
            this.Controls.Add(this.modProdAssociatedPartsGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodModPartDeleteButton);
            this.Controls.Add(this.prodModPartAddButton);
            this.Controls.Add(this.prodModifyCancelButton);
            this.Controls.Add(this.prodModPartSearchButton);
            this.Controls.Add(this.prodModSaveButton);
            this.Controls.Add(this.prodModAllPartsGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modProdName);
            this.Controls.Add(this.modProdPrice);
            this.Controls.Add(this.modProdInvLvl);
            this.Controls.Add(this.modProdMin);
            this.Controls.Add(this.modProdMax);
            this.Controls.Add(this.modProdID);
            this.Name = "modifyProdForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.prodModAllPartsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProdAssociatedPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prodModPartDeleteButton;
        private System.Windows.Forms.Button prodModPartAddButton;
        private System.Windows.Forms.Button prodModifyCancelButton;
        private System.Windows.Forms.Button prodModPartSearchButton;
        private System.Windows.Forms.Button prodModSaveButton;
        private System.Windows.Forms.DataGridView prodModAllPartsGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modProdName;
        private System.Windows.Forms.TextBox modProdPrice;
        private System.Windows.Forms.TextBox modProdInvLvl;
        private System.Windows.Forms.TextBox modProdMin;
        private System.Windows.Forms.TextBox modProdMax;
        private System.Windows.Forms.TextBox modProdID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView modProdAssociatedPartsGrid;
        private System.Windows.Forms.TextBox prodModAssociatedPartSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}