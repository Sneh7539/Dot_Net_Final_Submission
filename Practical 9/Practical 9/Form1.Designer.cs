namespace Practical_9
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
            this.btnIncrease = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(83, 29);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(94, 38);
            this.btnIncrease.TabIndex = 0;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(162, 105);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(96, 17);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "Hello World";
            this.lblFont.Click += new System.EventHandler(this.lblFont_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(223, 29);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(94, 38);
            this.btnDecrease.TabIndex = 0;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnDecrease;
    }
}

