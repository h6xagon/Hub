
namespace Hub
{
    partial class Form4
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
            this.rightPos = new System.Windows.Forms.Button();
            this.leftPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(80, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stäng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rightPos
            // 
            this.rightPos.Location = new System.Drawing.Point(80, 74);
            this.rightPos.Name = "rightPos";
            this.rightPos.Size = new System.Drawing.Size(75, 23);
            this.rightPos.TabIndex = 2;
            this.rightPos.Text = "Höger";
            this.rightPos.UseVisualStyleBackColor = true;
            this.rightPos.Click += new System.EventHandler(this.rightPos_Click);
            // 
            // leftPos
            // 
            this.leftPos.Location = new System.Drawing.Point(-1, 74);
            this.leftPos.Name = "leftPos";
            this.leftPos.Size = new System.Drawing.Size(75, 23);
            this.leftPos.TabIndex = 3;
            this.leftPos.Text = "Vänster";
            this.leftPos.UseVisualStyleBackColor = true;
            this.leftPos.Click += new System.EventHandler(this.leftPos_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 127);
            this.Controls.Add(this.leftPos);
            this.Controls.Add(this.rightPos);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "§+-";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rightPos;
        private System.Windows.Forms.Button leftPos;
    }
}