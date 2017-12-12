namespace DemoSsh
{
    partial class ScanPort
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtStaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStaus
            // 
            this.txtStaus.Location = new System.Drawing.Point(196, 328);
            this.txtStaus.Multiline = true;
            this.txtStaus.Name = "txtStaus";
            this.txtStaus.Size = new System.Drawing.Size(479, 184);
            this.txtStaus.TabIndex = 2;
            // 
            // ScanPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 562);
            this.Controls.Add(this.txtStaus);
            this.Controls.Add(this.button1);
            this.Name = "ScanPort";
            this.Text = "ScanPort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStaus;
    }
}