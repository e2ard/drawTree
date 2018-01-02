namespace Julia
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputIm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.itNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newtonA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Julia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputRe
            // 
            this.inputRe.Location = new System.Drawing.Point(153, 322);
            this.inputRe.Name = "inputRe";
            this.inputRe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputRe.Size = new System.Drawing.Size(53, 20);
            this.inputRe.TabIndex = 1;
            this.inputRe.Text = "-0.7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Re:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Im:";
            // 
            // inputIm
            // 
            this.inputIm.Location = new System.Drawing.Point(246, 322);
            this.inputIm.Name = "inputIm";
            this.inputIm.Size = new System.Drawing.Size(53, 20);
            this.inputIm.TabIndex = 3;
            this.inputIm.Text = "0.27015";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Draw ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Newton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "It:";
            // 
            // itNum
            // 
            this.itNum.Location = new System.Drawing.Point(64, 323);
            this.itNum.Name = "itNum";
            this.itNum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itNum.Size = new System.Drawing.Size(53, 20);
            this.itNum.TabIndex = 7;
            this.itNum.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "a (Neton)";
            // 
            // newtonA
            // 
            this.newtonA.Location = new System.Drawing.Point(464, 319);
            this.newtonA.Name = "newtonA";
            this.newtonA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.newtonA.Size = new System.Drawing.Size(53, 20);
            this.newtonA.TabIndex = 9;
            this.newtonA.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newtonA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputIm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputRe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputIm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newtonA;
    }
}

