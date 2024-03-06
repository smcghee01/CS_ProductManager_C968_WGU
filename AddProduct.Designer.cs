namespace AddProduct
{
    partial class AddProductForm
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
            this.addProdID = new System.Windows.Forms.TextBox();
            this.addProdMax = new System.Windows.Forms.TextBox();
            this.addProdMin = new System.Windows.Forms.TextBox();
            this.addProdInventory = new System.Windows.Forms.TextBox();
            this.addProdPrice = new System.Windows.Forms.TextBox();
            this.addProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.partProdAssociationGrid = new System.Windows.Forms.DataGridView();
            this.ProdAddSaveButton = new System.Windows.Forms.Button();
            this.ProdAddSearchButton = new System.Windows.Forms.Button();
            this.ProdAddCancelButton = new System.Windows.Forms.Button();
            this.ProdAddPartAddButton = new System.Windows.Forms.Button();
            this.ProdAddDeletePartButton = new System.Windows.Forms.Button();
            this.prodAddAllPartsGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.partAddSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partProdAssociationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodAddAllPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProdID
            // 
            this.addProdID.Enabled = false;
            this.addProdID.Location = new System.Drawing.Point(48, 109);
            this.addProdID.Name = "addProdID";
            this.addProdID.ReadOnly = true;
            this.addProdID.Size = new System.Drawing.Size(142, 22);
            this.addProdID.TabIndex = 0;
            // 
            // addProdMax
            // 
            this.addProdMax.Location = new System.Drawing.Point(282, 382);
            this.addProdMax.Name = "addProdMax";
            this.addProdMax.Size = new System.Drawing.Size(142, 22);
            this.addProdMax.TabIndex = 5;
            // 
            // addProdMin
            // 
            this.addProdMin.Location = new System.Drawing.Point(48, 382);
            this.addProdMin.Name = "addProdMin";
            this.addProdMin.Size = new System.Drawing.Size(142, 22);
            this.addProdMin.TabIndex = 4;
            // 
            // addProdInventory
            // 
            this.addProdInventory.Location = new System.Drawing.Point(48, 236);
            this.addProdInventory.Name = "addProdInventory";
            this.addProdInventory.Size = new System.Drawing.Size(142, 22);
            this.addProdInventory.TabIndex = 2;
            // 
            // addProdPrice
            // 
            this.addProdPrice.Location = new System.Drawing.Point(76, 307);
            this.addProdPrice.Name = "addProdPrice";
            this.addProdPrice.Size = new System.Drawing.Size(100, 22);
            this.addProdPrice.TabIndex = 3;
            // 
            // addProdName
            // 
            this.addProdName.Location = new System.Drawing.Point(48, 170);
            this.addProdName.Name = "addProdName";
            this.addProdName.Size = new System.Drawing.Size(142, 22);
            this.addProdName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(100, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Min Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inventory Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // partProdAssociationGrid
            // 
            this.partProdAssociationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partProdAssociationGrid.Location = new System.Drawing.Point(494, 332);
            this.partProdAssociationGrid.MultiSelect = false;
            this.partProdAssociationGrid.Name = "partProdAssociationGrid";
            this.partProdAssociationGrid.ReadOnly = true;
            this.partProdAssociationGrid.RowHeadersWidth = 51;
            this.partProdAssociationGrid.RowTemplate.Height = 24;
            this.partProdAssociationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partProdAssociationGrid.Size = new System.Drawing.Size(506, 198);
            this.partProdAssociationGrid.TabIndex = 12;
            // 
            // ProdAddSaveButton
            // 
            this.ProdAddSaveButton.Location = new System.Drawing.Point(82, 444);
            this.ProdAddSaveButton.Name = "ProdAddSaveButton";
            this.ProdAddSaveButton.Size = new System.Drawing.Size(72, 26);
            this.ProdAddSaveButton.TabIndex = 6;
            this.ProdAddSaveButton.Text = "Save";
            this.ProdAddSaveButton.UseVisualStyleBackColor = true;
            this.ProdAddSaveButton.Click += new System.EventHandler(this.ProdAddSaveButton_Click);
            // 
            // ProdAddSearchButton
            // 
            this.ProdAddSearchButton.Location = new System.Drawing.Point(708, 51);
            this.ProdAddSearchButton.Name = "ProdAddSearchButton";
            this.ProdAddSearchButton.Size = new System.Drawing.Size(81, 26);
            this.ProdAddSearchButton.TabIndex = 14;
            this.ProdAddSearchButton.Text = "Search";
            this.ProdAddSearchButton.UseVisualStyleBackColor = true;
            this.ProdAddSearchButton.Click += new System.EventHandler(this.ProdAddSearchButton_Click);
            // 
            // ProdAddCancelButton
            // 
            this.ProdAddCancelButton.Location = new System.Drawing.Point(308, 444);
            this.ProdAddCancelButton.Name = "ProdAddCancelButton";
            this.ProdAddCancelButton.Size = new System.Drawing.Size(73, 26);
            this.ProdAddCancelButton.TabIndex = 7;
            this.ProdAddCancelButton.Text = "Cancel";
            this.ProdAddCancelButton.UseVisualStyleBackColor = true;
            this.ProdAddCancelButton.Click += new System.EventHandler(this.ProdAddCancelButton_Click);
            // 
            // ProdAddPartAddButton
            // 
            this.ProdAddPartAddButton.Location = new System.Drawing.Point(922, 277);
            this.ProdAddPartAddButton.Name = "ProdAddPartAddButton";
            this.ProdAddPartAddButton.Size = new System.Drawing.Size(78, 26);
            this.ProdAddPartAddButton.TabIndex = 16;
            this.ProdAddPartAddButton.Text = "Add Part";
            this.ProdAddPartAddButton.UseVisualStyleBackColor = true;
            this.ProdAddPartAddButton.Click += new System.EventHandler(this.ProdAddPartButton_Click);
            // 
            // ProdAddDeletePartButton
            // 
            this.ProdAddDeletePartButton.Location = new System.Drawing.Point(914, 536);
            this.ProdAddDeletePartButton.Name = "ProdAddDeletePartButton";
            this.ProdAddDeletePartButton.Size = new System.Drawing.Size(86, 26);
            this.ProdAddDeletePartButton.TabIndex = 17;
            this.ProdAddDeletePartButton.Text = "Delete Part";
            this.ProdAddDeletePartButton.UseVisualStyleBackColor = true;
            this.ProdAddDeletePartButton.Click += new System.EventHandler(this.ProdDeletePartButton_Click);
            // 
            // prodAddAllPartsGrid
            // 
            this.prodAddAllPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodAddAllPartsGrid.Location = new System.Drawing.Point(494, 83);
            this.prodAddAllPartsGrid.MultiSelect = false;
            this.prodAddAllPartsGrid.Name = "prodAddAllPartsGrid";
            this.prodAddAllPartsGrid.ReadOnly = true;
            this.prodAddAllPartsGrid.RowHeadersWidth = 51;
            this.prodAddAllPartsGrid.RowTemplate.Height = 24;
            this.prodAddAllPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodAddAllPartsGrid.Size = new System.Drawing.Size(506, 188);
            this.prodAddAllPartsGrid.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "All Candidate Parts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Associated Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "$";
            // 
            // partAddSearch
            // 
            this.partAddSearch.Location = new System.Drawing.Point(795, 53);
            this.partAddSearch.Name = "partAddSearch";
            this.partAddSearch.Size = new System.Drawing.Size(205, 22);
            this.partAddSearch.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 41);
            this.label11.TabIndex = 43;
            this.label11.Text = "Add Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 578);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.partAddSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodAddAllPartsGrid);
            this.Controls.Add(this.ProdAddDeletePartButton);
            this.Controls.Add(this.ProdAddPartAddButton);
            this.Controls.Add(this.ProdAddCancelButton);
            this.Controls.Add(this.ProdAddSearchButton);
            this.Controls.Add(this.ProdAddSaveButton);
            this.Controls.Add(this.partProdAssociationGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProdName);
            this.Controls.Add(this.addProdPrice);
            this.Controls.Add(this.addProdInventory);
            this.Controls.Add(this.addProdMin);
            this.Controls.Add(this.addProdMax);
            this.Controls.Add(this.addProdID);
            this.Name = "AddProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.partProdAssociationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodAddAllPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProdID;
        private System.Windows.Forms.TextBox addProdMax;
        private System.Windows.Forms.TextBox addProdMin;
        private System.Windows.Forms.TextBox addProdInventory;
        private System.Windows.Forms.TextBox addProdPrice;
        private System.Windows.Forms.TextBox addProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView partProdAssociationGrid;
        private System.Windows.Forms.Button ProdAddSaveButton;
        private System.Windows.Forms.Button ProdAddSearchButton;
        private System.Windows.Forms.Button ProdAddCancelButton;
        private System.Windows.Forms.Button ProdAddPartAddButton;
        private System.Windows.Forms.Button ProdAddDeletePartButton;
        private System.Windows.Forms.DataGridView prodAddAllPartsGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox partAddSearch;
        private System.Windows.Forms.Label label11;
    }
}