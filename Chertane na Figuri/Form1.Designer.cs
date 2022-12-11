namespace Chertane_na_Figuri
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
            this.TriangleBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.BonusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Location = new System.Drawing.Point(59, 337);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(106, 44);
            this.TriangleBtn.TabIndex = 0;
            this.TriangleBtn.Text = "Triangle";
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(208, 337);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(106, 44);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.AutoEllipsis = true;
            this.RectangleBtn.Location = new System.Drawing.Point(359, 337);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(106, 44);
            this.RectangleBtn.TabIndex = 2;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // BonusBtn
            // 
            this.BonusBtn.Location = new System.Drawing.Point(501, 337);
            this.BonusBtn.Name = "BonusBtn";
            this.BonusBtn.Size = new System.Drawing.Size(106, 44);
            this.BonusBtn.TabIndex = 3;
            this.BonusBtn.Text = "Bonus";
            this.BonusBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.BonusBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button BonusBtn;
    }
}

