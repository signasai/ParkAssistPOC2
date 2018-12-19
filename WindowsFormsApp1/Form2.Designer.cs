namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnUserSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserSubmit
            // 
            this.btnUserSubmit.Location = new System.Drawing.Point(524, 383);
            this.btnUserSubmit.Name = "btnUserSubmit";
            this.btnUserSubmit.Size = new System.Drawing.Size(174, 30);
            this.btnUserSubmit.TabIndex = 0;
            this.btnUserSubmit.Text = "Submit";
            this.btnUserSubmit.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserSubmit);
            this.Name = "Form2";
            this.Text = "User Registration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSubmit;
    }
}