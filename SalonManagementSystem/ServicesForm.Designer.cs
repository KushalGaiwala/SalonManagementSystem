﻿
namespace SalonManagementSystem
{
    partial class ServicesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Location = new System.Drawing.Point(288, 191);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(40, 17);
            this.lblServicePrice.TabIndex = 1;
            this.lblServicePrice.Text = "Price";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(363, 140);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(100, 22);
            this.txtServiceName.TabIndex = 2;
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Location = new System.Drawing.Point(363, 186);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(100, 22);
            this.txtServicePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Service";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(327, 281);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.label1);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddService;
    }
}