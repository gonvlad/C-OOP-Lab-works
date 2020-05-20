namespace WinAnim
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
            this.btn_AW_BLEND = new System.Windows.Forms.Button();
            this.btn_HOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btn_Center_AW_SLIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AW_BLEND
            // 
            this.btn_AW_BLEND.BackColor = System.Drawing.Color.Orange;
            this.btn_AW_BLEND.Location = new System.Drawing.Point(30, 62);
            this.btn_AW_BLEND.Name = "btn_AW_BLEND";
            this.btn_AW_BLEND.Size = new System.Drawing.Size(232, 23);
            this.btn_AW_BLEND.TabIndex = 0;
            this.btn_AW_BLEND.Text = "Проявление";
            this.btn_AW_BLEND.UseVisualStyleBackColor = false;
            this.btn_AW_BLEND.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_HOR_AW_SLIDE
            // 
            this.btn_HOR_AW_SLIDE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_HOR_AW_SLIDE.Location = new System.Drawing.Point(30, 118);
            this.btn_HOR_AW_SLIDE.Name = "btn_HOR_AW_SLIDE";
            this.btn_HOR_AW_SLIDE.Size = new System.Drawing.Size(232, 23);
            this.btn_HOR_AW_SLIDE.TabIndex = 1;
            this.btn_HOR_AW_SLIDE.Text = "Горизонтальное проявление";
            this.btn_HOR_AW_SLIDE.UseVisualStyleBackColor = false;
            this.btn_HOR_AW_SLIDE.Click += new System.EventHandler(this.btn_HOR_AW_SLIDE_Click);
            // 
            // btn_Center_AW_SLIDE
            // 
            this.btn_Center_AW_SLIDE.BackColor = System.Drawing.Color.Lime;
            this.btn_Center_AW_SLIDE.Location = new System.Drawing.Point(30, 182);
            this.btn_Center_AW_SLIDE.Name = "btn_Center_AW_SLIDE";
            this.btn_Center_AW_SLIDE.Size = new System.Drawing.Size(232, 23);
            this.btn_Center_AW_SLIDE.TabIndex = 2;
            this.btn_Center_AW_SLIDE.Text = "Появление из центра";
            this.btn_Center_AW_SLIDE.UseVisualStyleBackColor = false;
            this.btn_Center_AW_SLIDE.Click += new System.EventHandler(this.btnCenter_AW_SLIDE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Center_AW_SLIDE);
            this.Controls.Add(this.btn_HOR_AW_SLIDE);
            this.Controls.Add(this.btn_AW_BLEND);
            this.Name = "Form1";
            this.Text = "Анимация формы ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AW_BLEND;
        private System.Windows.Forms.Button btn_HOR_AW_SLIDE;
        private System.Windows.Forms.Button btn_Center_AW_SLIDE;
    }
}

