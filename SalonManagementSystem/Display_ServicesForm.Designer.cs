
namespace SalonManagementSystem
{
    partial class Display_ServicesForm
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
            this.dgvViewPackages = new System.Windows.Forms.DataGridView();
            this.dgvViewCategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewPackages
            // 
            this.dgvViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPackages.Location = new System.Drawing.Point(56, 109);
            this.dgvViewPackages.Name = "dgvViewPackages";
            this.dgvViewPackages.RowHeadersWidth = 51;
            this.dgvViewPackages.RowTemplate.Height = 24;
            this.dgvViewPackages.Size = new System.Drawing.Size(585, 353);
            this.dgvViewPackages.TabIndex = 0;
            // 
            // dgvViewCategory
            // 
            this.dgvViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCategory.Location = new System.Drawing.Point(658, 109);
            this.dgvViewCategory.Name = "dgvViewCategory";
            this.dgvViewCategory.RowHeadersWidth = 51;
            this.dgvViewCategory.RowTemplate.Height = 24;
            this.dgvViewCategory.Size = new System.Drawing.Size(441, 353);
            this.dgvViewCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Packages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // Display_ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewCategory);
            this.Controls.Add(this.dgvViewPackages);
            this.Name = "Display_ServicesForm";
            this.Text = "Display_ServicesForm";
            this.Load += new System.EventHandler(this.Display_ServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewPackages;
        private System.Windows.Forms.DataGridView dgvViewCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}