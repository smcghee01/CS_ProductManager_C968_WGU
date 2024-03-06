namespace HomePage
{
    partial class HomePage
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
            this.homePartAdd = new System.Windows.Forms.Button();
            this.homePartDelete = new System.Windows.Forms.Button();
            this.homeSearchButton = new System.Windows.Forms.Button();
            this.homeExitButton = new System.Windows.Forms.Button();
            this.homeProdTextBox = new System.Windows.Forms.TextBox();
            this.homePartTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.homePartMod = new System.Windows.Forms.Button();
            this.homeProdMod = new System.Windows.Forms.Button();
            this.homeProdDelete = new System.Windows.Forms.Button();
            this.homeProdAdd = new System.Windows.Forms.Button();
            this.homePartSearch = new System.Windows.Forms.Button();
            this.homeProdDataGrid = new System.Windows.Forms.DataGridView();
            this.homePartDataGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeProdDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // homePartAdd
            // 
            this.homePartAdd.Location = new System.Drawing.Point(1226, 466);
            this.homePartAdd.Name = "homePartAdd";
            this.homePartAdd.Size = new System.Drawing.Size(80, 26);
            this.homePartAdd.TabIndex = 0;
            this.homePartAdd.Text = "Add";
            this.homePartAdd.UseVisualStyleBackColor = true;
            this.homePartAdd.Click += new System.EventHandler(this.homePartAddButton_Click);
            // 
            // homePartDelete
            // 
            this.homePartDelete.Location = new System.Drawing.Point(1312, 466);
            this.homePartDelete.Name = "homePartDelete";
            this.homePartDelete.Size = new System.Drawing.Size(80, 26);
            this.homePartDelete.TabIndex = 1;
            this.homePartDelete.Text = "Delete";
            this.homePartDelete.UseVisualStyleBackColor = true;
            this.homePartDelete.Click += new System.EventHandler(this.homePartDeleteButton_Click);
            // 
            // homeSearchButton
            // 
            this.homeSearchButton.Location = new System.Drawing.Point(500, 69);
            this.homeSearchButton.Name = "homeSearchButton";
            this.homeSearchButton.Size = new System.Drawing.Size(80, 27);
            this.homeSearchButton.TabIndex = 2;
            this.homeSearchButton.Text = "Search";
            this.homeSearchButton.UseVisualStyleBackColor = true;
            this.homeSearchButton.Click += new System.EventHandler(this.homeProdSearchButton_Click);
            // 
            // homeExitButton
            // 
            this.homeExitButton.Location = new System.Drawing.Point(1398, 538);
            this.homeExitButton.Name = "homeExitButton";
            this.homeExitButton.Size = new System.Drawing.Size(80, 27);
            this.homeExitButton.TabIndex = 3;
            this.homeExitButton.Text = "Exit";
            this.homeExitButton.UseVisualStyleBackColor = true;
            this.homeExitButton.Click += new System.EventHandler(this.homeExitButton_Click);
            // 
            // homeProdTextBox
            // 
            this.homeProdTextBox.Location = new System.Drawing.Point(586, 72);
            this.homeProdTextBox.Name = "homeProdTextBox";
            this.homeProdTextBox.Size = new System.Drawing.Size(166, 22);
            this.homeProdTextBox.TabIndex = 6;
            // 
            // homePartTextBox
            // 
            this.homePartTextBox.Location = new System.Drawing.Point(1310, 69);
            this.homePartTextBox.Name = "homePartTextBox";
            this.homePartTextBox.Size = new System.Drawing.Size(168, 22);
            this.homePartTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parts";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(12, 72);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(60, 16);
            this.Product.TabIndex = 9;
            this.Product.Text = "Products";
            // 
            // homePartMod
            // 
            this.homePartMod.Location = new System.Drawing.Point(1398, 466);
            this.homePartMod.Name = "homePartMod";
            this.homePartMod.Size = new System.Drawing.Size(80, 26);
            this.homePartMod.TabIndex = 10;
            this.homePartMod.Text = "Modify";
            this.homePartMod.UseVisualStyleBackColor = true;
            this.homePartMod.Click += new System.EventHandler(this.homePartModifyButton_Click);
            // 
            // homeProdMod
            // 
            this.homeProdMod.Location = new System.Drawing.Point(672, 466);
            this.homeProdMod.Name = "homeProdMod";
            this.homeProdMod.Size = new System.Drawing.Size(80, 26);
            this.homeProdMod.TabIndex = 13;
            this.homeProdMod.Text = "Modify";
            this.homeProdMod.UseVisualStyleBackColor = true;
            this.homeProdMod.Click += new System.EventHandler(this.homeProdModifyButton_Click);
            // 
            // homeProdDelete
            // 
            this.homeProdDelete.Location = new System.Drawing.Point(586, 466);
            this.homeProdDelete.Name = "homeProdDelete";
            this.homeProdDelete.Size = new System.Drawing.Size(80, 26);
            this.homeProdDelete.TabIndex = 12;
            this.homeProdDelete.Text = "Delete";
            this.homeProdDelete.UseVisualStyleBackColor = true;
            this.homeProdDelete.Click += new System.EventHandler(this.homeProdDeleteButton_Click);
            // 
            // homeProdAdd
            // 
            this.homeProdAdd.Location = new System.Drawing.Point(500, 466);
            this.homeProdAdd.Name = "homeProdAdd";
            this.homeProdAdd.Size = new System.Drawing.Size(80, 26);
            this.homeProdAdd.TabIndex = 11;
            this.homeProdAdd.Text = "Add";
            this.homeProdAdd.UseVisualStyleBackColor = true;
            this.homeProdAdd.Click += new System.EventHandler(this.homeProdAddButton_Click);
            // 
            // homePartSearch
            // 
            this.homePartSearch.Location = new System.Drawing.Point(1224, 67);
            this.homePartSearch.Name = "homePartSearch";
            this.homePartSearch.Size = new System.Drawing.Size(80, 27);
            this.homePartSearch.TabIndex = 14;
            this.homePartSearch.Text = "Search";
            this.homePartSearch.UseVisualStyleBackColor = true;
            this.homePartSearch.Click += new System.EventHandler(this.homePartSearchButton_Click);
            // 
            // homeProdDataGrid
            // 
            this.homeProdDataGrid.AllowUserToAddRows = false;
            this.homeProdDataGrid.AllowUserToDeleteRows = false;
            this.homeProdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeProdDataGrid.Location = new System.Drawing.Point(15, 100);
            this.homeProdDataGrid.MultiSelect = false;
            this.homeProdDataGrid.Name = "homeProdDataGrid";
            this.homeProdDataGrid.ReadOnly = true;
            this.homeProdDataGrid.RowHeadersWidth = 51;
            this.homeProdDataGrid.RowTemplate.Height = 24;
            this.homeProdDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homeProdDataGrid.Size = new System.Drawing.Size(737, 348);
            this.homeProdDataGrid.TabIndex = 15;
            // 
            // homePartDataGrid
            // 
            this.homePartDataGrid.AllowUserToAddRows = false;
            this.homePartDataGrid.AllowUserToDeleteRows = false;
            this.homePartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homePartDataGrid.Location = new System.Drawing.Point(774, 100);
            this.homePartDataGrid.MultiSelect = false;
            this.homePartDataGrid.Name = "homePartDataGrid";
            this.homePartDataGrid.RowHeadersWidth = 51;
            this.homePartDataGrid.RowTemplate.Height = 24;
            this.homePartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.homePartDataGrid.Size = new System.Drawing.Size(704, 348);
            this.homePartDataGrid.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 41);
            this.label11.TabIndex = 44;
            this.label11.Text = "Inventory Manager";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 577);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.homePartDataGrid);
            this.Controls.Add(this.homeProdDataGrid);
            this.Controls.Add(this.homePartSearch);
            this.Controls.Add(this.homeProdMod);
            this.Controls.Add(this.homeProdDelete);
            this.Controls.Add(this.homeProdAdd);
            this.Controls.Add(this.homePartMod);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePartTextBox);
            this.Controls.Add(this.homeProdTextBox);
            this.Controls.Add(this.homeExitButton);
            this.Controls.Add(this.homeSearchButton);
            this.Controls.Add(this.homePartDelete);
            this.Controls.Add(this.homePartAdd);
            this.Name = "HomePage";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.homeProdDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePartDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homePartAdd;
        private System.Windows.Forms.Button homePartDelete;
        private System.Windows.Forms.Button homeSearchButton;
        private System.Windows.Forms.Button homeExitButton;
        private System.Windows.Forms.TextBox homeProdTextBox;
        private System.Windows.Forms.TextBox homePartTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button homePartMod;
        private System.Windows.Forms.Button homeProdMod;
        private System.Windows.Forms.Button homeProdDelete;
        private System.Windows.Forms.Button homeProdAdd;
        private System.Windows.Forms.Button homePartSearch;
        private System.Windows.Forms.DataGridView homeProdDataGrid;
        private System.Windows.Forms.DataGridView homePartDataGrid;
        private System.Windows.Forms.Label label11;
    }
}