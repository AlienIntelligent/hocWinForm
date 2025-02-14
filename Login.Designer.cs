namespace hocWinForm
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.start_Button = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.LabelStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_Button
            // 
            this.start_Button.BackColor = System.Drawing.SystemColors.Info;
            this.start_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.start_Button.Location = new System.Drawing.Point(386, 338);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(117, 58);
            this.start_Button.TabIndex = 0;
            this.start_Button.Text = "READY";
            this.start_Button.UseVisualStyleBackColor = false;
            this.start_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.AcceptsTab = true;
            this.login.Location = new System.Drawing.Point(229, 223);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(433, 48);
            this.login.TabIndex = 2;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelStart
            // 
            this.LabelStart.AutoSize = true;
            this.LabelStart.BackColor = System.Drawing.SystemColors.Info;
            this.LabelStart.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStart.ForeColor = System.Drawing.Color.Navy;
            this.LabelStart.Location = new System.Drawing.Point(198, 93);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(492, 46);
            this.LabelStart.TabIndex = 3;
            this.LabelStart.Text = "ENTER PLAYER NAME";
            this.LabelStart.Click += new System.EventHandler(this.LabelStart_Click);
            // 
            // StartForm
            // 
            this.AcceptButton = this.start_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.login);
            this.Controls.Add(this.start_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu nối thú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label LabelStart;
    }
}

