namespace CST_150_ListTogv
{
    partial class FrmInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvInv = new DataGridView();
            ntmIncQty = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(167, 104);
            gvInv.Name = "gvInv";
            gvInv.RowTemplate.Height = 25;
            gvInv.Size = new Size(539, 334);
            gvInv.TabIndex = 0;
            gvInv.Click += GridView_ClickEventHandler;
            // 
            // ntmIncQty
            // 
            ntmIncQty.Location = new Point(167, 53);
            ntmIncQty.Name = "ntmIncQty";
            ntmIncQty.Size = new Size(75, 23);
            ntmIncQty.TabIndex = 1;
            ntmIncQty.Text = "IncQty";
            ntmIncQty.UseVisualStyleBackColor = true;
            ntmIncQty.Click += BtnIncQty_clickEventHandler;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(306, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDeleteItem_EventHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 459);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 3;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(250, 451);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 29);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(382, 451);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_ClickEvent;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(ntmIncQty);
            Controls.Add(gvInv);
            Name = "FrmInventory";
            Text = "Inventory";
            Load += PopulateGrid_LoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvInv;
        private Button ntmIncQty;
        private Button btnDelete;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}
