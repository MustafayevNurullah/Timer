namespace WindowsFormsApp4
{
    partial class Form1
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
            this.Baku_Button = new System.Windows.Forms.Button();
            this.London_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 194);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Baku_Button
            // 
            this.Baku_Button.Location = new System.Drawing.Point(187, 268);
            this.Baku_Button.Name = "Baku_Button";
            this.Baku_Button.Size = new System.Drawing.Size(75, 23);
            this.Baku_Button.TabIndex = 1;
            this.Baku_Button.Text = "Baku";
            this.Baku_Button.UseVisualStyleBackColor = true;
            this.Baku_Button.Click += new System.EventHandler(this.Baku_Button_Click);
            // 
            // London_Button
            // 
            this.London_Button.Location = new System.Drawing.Point(508, 268);
            this.London_Button.Name = "London_Button";
            this.London_Button.Size = new System.Drawing.Size(82, 23);
            this.London_Button.TabIndex = 2;
            this.London_Button.Text = "London";
            this.London_Button.UseVisualStyleBackColor = true;
            this.London_Button.Click += new System.EventHandler(this.London_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.London_Button);
            this.Controls.Add(this.Baku_Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Baku_Button;
        private System.Windows.Forms.Button London_Button;
    }
}

