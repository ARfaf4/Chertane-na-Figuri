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
            this.StopBtn = new System.Windows.Forms.Button();
            this.PolygonBtn = new System.Windows.Forms.Button();
            this.SpamModeBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.EpilepticModeBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TriangleBtn
            // 
            this.TriangleBtn.Location = new System.Drawing.Point(12, 540);
            this.TriangleBtn.Name = "TriangleBtn";
            this.TriangleBtn.Size = new System.Drawing.Size(64, 44);
            this.TriangleBtn.TabIndex = 0;
            this.TriangleBtn.Text = "Triangle";
            this.TriangleBtn.UseVisualStyleBackColor = true;
            this.TriangleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(93, 540);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(75, 44);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.AutoEllipsis = true;
            this.RectangleBtn.Location = new System.Drawing.Point(184, 540);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(75, 44);
            this.RectangleBtn.TabIndex = 2;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(368, 540);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 44);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PolygonBtn
            // 
            this.PolygonBtn.Location = new System.Drawing.Point(277, 540);
            this.PolygonBtn.Name = "PolygonBtn";
            this.PolygonBtn.Size = new System.Drawing.Size(75, 44);
            this.PolygonBtn.TabIndex = 4;
            this.PolygonBtn.Text = "Polygon (Glitched)";
            this.PolygonBtn.UseVisualStyleBackColor = true;
            this.PolygonBtn.Click += new System.EventHandler(this.PolygonBtn_Click);
            // 
            // SpamModeBtn
            // 
            this.SpamModeBtn.AutoSize = true;
            this.SpamModeBtn.Location = new System.Drawing.Point(529, 30);
            this.SpamModeBtn.Name = "SpamModeBtn";
            this.SpamModeBtn.Size = new System.Drawing.Size(44, 17);
            this.SpamModeBtn.TabIndex = 5;
            this.SpamModeBtn.TabStop = true;
            this.SpamModeBtn.Text = " ON";
            this.SpamModeBtn.UseVisualStyleBackColor = true;
            this.SpamModeBtn.CheckedChanged += new System.EventHandler(this.SpamModeBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Spam mode:";
            // 
            // EpilepticModeBtn
            // 
            this.EpilepticModeBtn.Location = new System.Drawing.Point(553, 540);
            this.EpilepticModeBtn.Name = "EpilepticModeBtn";
            this.EpilepticModeBtn.Size = new System.Drawing.Size(75, 44);
            this.EpilepticModeBtn.TabIndex = 8;
            this.EpilepticModeBtn.Text = "Epileptic Mode";
            this.EpilepticModeBtn.UseVisualStyleBackColor = true;
            this.EpilepticModeBtn.Click += new System.EventHandler(this.EpilepticModeBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(460, 540);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 44);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Restart";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 617);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.EpilepticModeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpamModeBtn);
            this.Controls.Add(this.PolygonBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.TriangleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TriangleBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PolygonBtn;
        private System.Windows.Forms.RadioButton SpamModeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EpilepticModeBtn;
        private System.Windows.Forms.Button ResetBtn;
    }
}

