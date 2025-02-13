namespace hocWinForm
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.button1 = new System.Windows.Forms.Button();
            this.Welcom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(386, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcom
            // 
            this.Welcom.AutoSize = true;
            this.Welcom.BackColor = System.Drawing.SystemColors.Info;
            this.Welcom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Welcom.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcom.ForeColor = System.Drawing.Color.Crimson;
            this.Welcom.Location = new System.Drawing.Point(242, 121);
            this.Welcom.Name = "Welcom";
            this.Welcom.Size = new System.Drawing.Size(405, 46);
            this.Welcom.TabIndex = 1;
            this.Welcom.Text = "Welcome Player01!";
            this.Welcom.Click += new System.EventHandler(this.Welcom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(364, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level 1";
            // 
            // Start
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcom);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu nối thú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Welcom;
        private System.Windows.Forms.Label label1;
    }
}