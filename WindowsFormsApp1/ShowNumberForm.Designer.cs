namespace WindowsFormsApp1
{
    partial class ShowNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowNumberForm));
            this.outputNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputNumber
            // 
            this.outputNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 350F);
            this.outputNumber.ForeColor = System.Drawing.Color.White;
            this.outputNumber.Location = new System.Drawing.Point(0, 0);
            this.outputNumber.Name = "outputNumber";
            this.outputNumber.Size = new System.Drawing.Size(1830, 863);
            this.outputNumber.TabIndex = 0;
            this.outputNumber.Text = "0";
            this.outputNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1830, 863);
            this.Controls.Add(this.outputNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowNumberForm";
            this.Text = "ShowNumberForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputNumber;
    }
}