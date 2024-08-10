namespace CST_150_ListTogv
{
    partial class FrmSecondary
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
            gvSearchResults = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchResults.Location = new Point(144, 36);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.RowTemplate.Height = 25;
            gvSearchResults.Size = new Size(527, 285);
            gvSearchResults.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(324, 363);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(134, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close Search";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmSecondary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(gvSearchResults);
            Name = "FrmSecondary";
            Text = "FrmSecondary";
            Load += FrmSecondary_Load;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvSearchResults;
        private Button btnClose;
    }
}