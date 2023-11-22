namespace MeakKitProject
{
    partial class Form6
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
            this.button1_Yes = new System.Windows.Forms.Button();
            this.button2_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Yes
            // 
            this.button1_Yes.Location = new System.Drawing.Point(98, 70);
            this.button1_Yes.Name = "button1_Yes";
            this.button1_Yes.Size = new System.Drawing.Size(75, 23);
            this.button1_Yes.TabIndex = 0;
            this.button1_Yes.Text = "예";
            this.button1_Yes.UseVisualStyleBackColor = true;
            this.button1_Yes.Click += new System.EventHandler(this.button1_Yes_Click);
            // 
            // button2_No
            // 
            this.button2_No.Location = new System.Drawing.Point(189, 70);
            this.button2_No.Name = "button2_No";
            this.button2_No.Size = new System.Drawing.Size(75, 23);
            this.button2_No.TabIndex = 1;
            this.button2_No.Text = "아니오";
            this.button2_No.UseVisualStyleBackColor = true;
            this.button2_No.Click += new System.EventHandler(this.button2_No_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 189);
            this.Controls.Add(this.button2_No);
            this.Controls.Add(this.button1_Yes);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Yes;
        private System.Windows.Forms.Button button2_No;
    }
}