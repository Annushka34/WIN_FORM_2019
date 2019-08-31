namespace _07_ListView_ImgList
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
            this.chB1 = new System.Windows.Forms.CheckBox();
            this.chB2 = new System.Windows.Forms.CheckBox();
            this.chB3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chB1
            // 
            this.chB1.AutoSize = true;
            this.chB1.Location = new System.Drawing.Point(26, 34);
            this.chB1.MinimumSize = new System.Drawing.Size(150, 50);
            this.chB1.Name = "chB1";
            this.chB1.Size = new System.Drawing.Size(150, 50);
            this.chB1.TabIndex = 0;
            this.chB1.Text = "MySql";
            this.chB1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chB1.UseVisualStyleBackColor = true;
            // 
            // chB2
            // 
            this.chB2.AutoSize = true;
            this.chB2.Location = new System.Drawing.Point(26, 90);
            this.chB2.MinimumSize = new System.Drawing.Size(70, 50);
            this.chB2.Name = "chB2";
            this.chB2.Size = new System.Drawing.Size(70, 50);
            this.chB2.TabIndex = 0;
            this.chB2.UseVisualStyleBackColor = true;
            // 
            // chB3
            // 
            this.chB3.AutoSize = true;
            this.chB3.Location = new System.Drawing.Point(26, 146);
            this.chB3.MinimumSize = new System.Drawing.Size(70, 50);
            this.chB3.Name = "chB3";
            this.chB3.Size = new System.Drawing.Size(70, 50);
            this.chB3.TabIndex = 0;
            this.chB3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.chB3);
            this.Controls.Add(this.chB2);
            this.Controls.Add(this.chB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chB1;
        private System.Windows.Forms.CheckBox chB2;
        private System.Windows.Forms.CheckBox chB3;
    }
}

