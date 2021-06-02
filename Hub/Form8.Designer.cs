
namespace Hub
{
    partial class Form8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addSE = new System.Windows.Forms.TextBox();
            this.addEN = new System.Windows.Forms.TextBox();
            this.ansSE = new System.Windows.Forms.TextBox();
            this.ansEN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNewG = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.gbxTest = new System.Windows.Forms.GroupBox();
            this.gbxRes = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            this.gbxTest.SuspendLayout();
            this.gbxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(176, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SE ord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "EN ord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SE ord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "EN ord";
            // 
            // addSE
            // 
            this.addSE.Location = new System.Drawing.Point(71, 35);
            this.addSE.Name = "addSE";
            this.addSE.Size = new System.Drawing.Size(100, 20);
            this.addSE.TabIndex = 8;
            // 
            // addEN
            // 
            this.addEN.Location = new System.Drawing.Point(71, 69);
            this.addEN.Name = "addEN";
            this.addEN.Size = new System.Drawing.Size(100, 20);
            this.addEN.TabIndex = 9;
            // 
            // ansSE
            // 
            this.ansSE.Enabled = false;
            this.ansSE.Location = new System.Drawing.Point(63, 19);
            this.ansSE.Name = "ansSE";
            this.ansSE.Size = new System.Drawing.Size(100, 20);
            this.ansSE.TabIndex = 10;
            // 
            // ansEN
            // 
            this.ansEN.Location = new System.Drawing.Point(63, 62);
            this.ansEN.Name = "ansEN";
            this.ansEN.Size = new System.Drawing.Size(100, 20);
            this.ansEN.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Lägg till glosa";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addGlosa_Click);
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(25, 88);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(75, 23);
            this.btnAns.TabIndex = 13;
            this.btnAns.Text = "Svara";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(14, 318);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Starta Glostest";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNewG
            // 
            this.btnNewG.Enabled = false;
            this.btnNewG.Location = new System.Drawing.Point(95, 318);
            this.btnNewG.Name = "btnNewG";
            this.btnNewG.Size = new System.Drawing.Size(75, 23);
            this.btnNewG.TabIndex = 15;
            this.btnNewG.Text = "Nya glosor";
            this.btnNewG.UseVisualStyleBackColor = true;
            this.btnNewG.Click += new System.EventHandler(this.btnNewG_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.addEN);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.addSE);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Location = new System.Drawing.Point(24, 32);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(200, 152);
            this.gbxAdd.TabIndex = 16;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Lägg till glosor";
            this.gbxAdd.Enter += new System.EventHandler(this.gbxAdd_Enter);
            // 
            // gbxTest
            // 
            this.gbxTest.Controls.Add(this.ansSE);
            this.gbxTest.Controls.Add(this.label6);
            this.gbxTest.Controls.Add(this.label7);
            this.gbxTest.Controls.Add(this.ansEN);
            this.gbxTest.Controls.Add(this.btnAns);
            this.gbxTest.Location = new System.Drawing.Point(24, 190);
            this.gbxTest.Name = "gbxTest";
            this.gbxTest.Size = new System.Drawing.Size(200, 122);
            this.gbxTest.TabIndex = 17;
            this.gbxTest.TabStop = false;
            this.gbxTest.Text = "Glostest";
            // 
            // gbxRes
            // 
            this.gbxRes.Controls.Add(this.textBox1);
            this.gbxRes.Controls.Add(this.lblAmount);
            this.gbxRes.Controls.Add(this.lblRes);
            this.gbxRes.Location = new System.Drawing.Point(231, 32);
            this.gbxRes.Name = "gbxRes";
            this.gbxRes.Size = new System.Drawing.Size(200, 280);
            this.gbxRes.TabIndex = 18;
            this.gbxRes.TabStop = false;
            this.gbxRes.Text = "Resultat";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 239);
            this.textBox1.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 261);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 13);
            this.lblAmount.TabIndex = 1;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(7, 20);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 0;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 345);
            this.Controls.Add(this.gbxRes);
            this.Controls.Add(this.gbxTest);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.btnNewG);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxTest.ResumeLayout(false);
            this.gbxTest.PerformLayout();
            this.gbxRes.ResumeLayout(false);
            this.gbxRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addSE;
        private System.Windows.Forms.TextBox addEN;
        private System.Windows.Forms.TextBox ansSE;
        private System.Windows.Forms.TextBox ansEN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNewG;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.GroupBox gbxTest;
        private System.Windows.Forms.GroupBox gbxRes;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textBox1;
    }
}