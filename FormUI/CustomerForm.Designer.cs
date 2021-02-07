
namespace FormUI
{
    partial class CustomerForm
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
            this.labelCustomerEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomerEnter
            // 
            this.labelCustomerEnter.AutoSize = true;
            this.labelCustomerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCustomerEnter.Location = new System.Drawing.Point(238, 19);
            this.labelCustomerEnter.Name = "labelCustomerEnter";
            this.labelCustomerEnter.Size = new System.Drawing.Size(208, 31);
            this.labelCustomerEnter.TabIndex = 0;
            this.labelCustomerEnter.Text = "Customer Panel";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(750, 415);
            this.Controls.Add(this.labelCustomerEnter);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerEnter;
    }
}