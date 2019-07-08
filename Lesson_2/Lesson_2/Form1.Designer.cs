namespace Lesson_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.txtStartText = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnPhoneOk = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPswd = new System.Windows.Forms.TextBox();
            this.btnPswd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timerSizeForm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOk.Location = new System.Drawing.Point(21, 27);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 66);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnOk_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Location = new System.Drawing.Point(21, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(21, 225);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(88, 48);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Wait";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(21, 309);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(2, 15);
            this.lblState.TabIndex = 2;
            // 
            // txtStartText
            // 
            this.txtStartText.AcceptsReturn = true;
            this.txtStartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStartText.Location = new System.Drawing.Point(141, 27);
            this.txtStartText.Multiline = true;
            this.txtStartText.Name = "txtStartText";
            this.txtStartText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStartText.Size = new System.Drawing.Size(303, 86);
            this.txtStartText.TabIndex = 3;
            this.txtStartText.TextChanged += new System.EventHandler(this.txtStartText_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(141, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // btnPhoneOk
            // 
            this.btnPhoneOk.Location = new System.Drawing.Point(402, 134);
            this.btnPhoneOk.Name = "btnPhoneOk";
            this.btnPhoneOk.Size = new System.Drawing.Size(42, 23);
            this.btnPhoneOk.TabIndex = 5;
            this.btnPhoneOk.Text = "OK";
            this.btnPhoneOk.UseVisualStyleBackColor = true;
            this.btnPhoneOk.Click += new System.EventHandler(this.btnPhoneOk_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 360);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 13);
            this.lblPhone.TabIndex = 6;
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(141, 162);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(243, 20);
            this.txtPswd.TabIndex = 7;
            // 
            // btnPswd
            // 
            this.btnPswd.Location = new System.Drawing.Point(402, 162);
            this.btnPswd.Name = "btnPswd";
            this.btnPswd.Size = new System.Drawing.Size(42, 23);
            this.btnPswd.TabIndex = 5;
            this.btnPswd.Text = "OK";
            this.btnPswd.UseVisualStyleBackColor = true;
            this.btnPswd.Click += new System.EventHandler(this.btnPswd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(730, 41);
            this.lblInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 8;
            // 
            // timerSizeForm
            // 
            this.timerSizeForm.Interval = 1;
            this.timerSizeForm.Tick += new System.EventHandler(this.timerSizeForm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnPswd);
            this.Controls.Add(this.btnPhoneOk);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtStartText);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "My form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOk_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnOk_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtStartText;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnPhoneOk;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPswd;
        private System.Windows.Forms.Button btnPswd;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timerSizeForm;
    }
}

