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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
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
            this.btnUserSubmit.Click += new System.EventHandler(this.btnUserSubmit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(259, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(259, 131);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 26);
            this.textBoxAge.TabIndex = 1;
            // 
            // textBoxPh
            // 
            this.textBoxPh.Location = new System.Drawing.Point(259, 227);
            this.textBoxPh.Name = "textBoxPh";
            this.textBoxPh.Size = new System.Drawing.Size(100, 26);
            this.textBoxPh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(157, 230);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnUserSubmit);
            this.Name = "Form2";
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserSubmit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPhone;
    }
}