namespace DrawTree
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
            this.b1length = new System.Windows.Forms.NumericUpDown();
            this.b2length = new System.Windows.Forms.NumericUpDown();
            this.b3length = new System.Windows.Forms.NumericUpDown();
            this.b4length = new System.Windows.Forms.NumericUpDown();
            this.b1angle = new System.Windows.Forms.NumericUpDown();
            this.b2angle = new System.Windows.Forms.NumericUpDown();
            this.b3angle = new System.Windows.Forms.NumericUpDown();
            this.b4angle = new System.Windows.Forms.NumericUpDown();
            this.b5angle = new System.Windows.Forms.NumericUpDown();
            this.b5length = new System.Windows.Forms.NumericUpDown();
            this.itNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.b1length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b1length
            // 
            this.b1length.DecimalPlaces = 2;
            this.b1length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b1length.Location = new System.Drawing.Point(203, 511);
            this.b1length.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b1length.Name = "b1length";
            this.b1length.Size = new System.Drawing.Size(44, 20);
            this.b1length.TabIndex = 1;
            this.b1length.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // b2length
            // 
            this.b2length.DecimalPlaces = 2;
            this.b2length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b2length.Location = new System.Drawing.Point(262, 511);
            this.b2length.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b2length.Name = "b2length";
            this.b2length.Size = new System.Drawing.Size(44, 20);
            this.b2length.TabIndex = 2;
            this.b2length.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // b3length
            // 
            this.b3length.DecimalPlaces = 2;
            this.b3length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b3length.Location = new System.Drawing.Point(322, 511);
            this.b3length.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b3length.Name = "b3length";
            this.b3length.Size = new System.Drawing.Size(44, 20);
            this.b3length.TabIndex = 3;
            this.b3length.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // b4length
            // 
            this.b4length.DecimalPlaces = 2;
            this.b4length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b4length.Location = new System.Drawing.Point(390, 511);
            this.b4length.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b4length.Name = "b4length";
            this.b4length.Size = new System.Drawing.Size(44, 20);
            this.b4length.TabIndex = 4;
            this.b4length.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // b1angle
            // 
            this.b1angle.Location = new System.Drawing.Point(203, 537);
            this.b1angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.b1angle.Name = "b1angle";
            this.b1angle.Size = new System.Drawing.Size(41, 20);
            this.b1angle.TabIndex = 5;
            this.b1angle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // b2angle
            // 
            this.b2angle.Location = new System.Drawing.Point(262, 537);
            this.b2angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.b2angle.Name = "b2angle";
            this.b2angle.Size = new System.Drawing.Size(41, 20);
            this.b2angle.TabIndex = 6;
            this.b2angle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // b3angle
            // 
            this.b3angle.Location = new System.Drawing.Point(322, 537);
            this.b3angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.b3angle.Name = "b3angle";
            this.b3angle.Size = new System.Drawing.Size(41, 20);
            this.b3angle.TabIndex = 7;
            this.b3angle.Value = new decimal(new int[] {
            325,
            0,
            0,
            0});
            // 
            // b4angle
            // 
            this.b4angle.Location = new System.Drawing.Point(390, 537);
            this.b4angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.b4angle.Name = "b4angle";
            this.b4angle.Size = new System.Drawing.Size(41, 20);
            this.b4angle.TabIndex = 8;
            this.b4angle.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // b5angle
            // 
            this.b5angle.Location = new System.Drawing.Point(449, 537);
            this.b5angle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.b5angle.Name = "b5angle";
            this.b5angle.Size = new System.Drawing.Size(41, 20);
            this.b5angle.TabIndex = 10;
            // 
            // b5length
            // 
            this.b5length.DecimalPlaces = 2;
            this.b5length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b5length.Location = new System.Drawing.Point(449, 511);
            this.b5length.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b5length.Name = "b5length";
            this.b5length.Size = new System.Drawing.Size(44, 20);
            this.b5length.TabIndex = 9;
            // 
            // itNumber
            // 
            this.itNumber.Location = new System.Drawing.Point(307, 579);
            this.itNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.itNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itNumber.Name = "itNumber";
            this.itNumber.Size = new System.Drawing.Size(29, 20);
            this.itNumber.TabIndex = 11;
            this.itNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 611);
            this.Controls.Add(this.itNumber);
            this.Controls.Add(this.b5angle);
            this.Controls.Add(this.b5length);
            this.Controls.Add(this.b4angle);
            this.Controls.Add(this.b3angle);
            this.Controls.Add(this.b2angle);
            this.Controls.Add(this.b1angle);
            this.Controls.Add(this.b4length);
            this.Controls.Add(this.b3length);
            this.Controls.Add(this.b2length);
            this.Controls.Add(this.b1length);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.b1length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown b1length;
        private System.Windows.Forms.NumericUpDown b2length;
        private System.Windows.Forms.NumericUpDown b3length;
        private System.Windows.Forms.NumericUpDown b4length;
        private System.Windows.Forms.NumericUpDown b1angle;
        private System.Windows.Forms.NumericUpDown b2angle;
        private System.Windows.Forms.NumericUpDown b3angle;
        private System.Windows.Forms.NumericUpDown b4angle;
        private System.Windows.Forms.NumericUpDown b5angle;
        private System.Windows.Forms.NumericUpDown b5length;
        private System.Windows.Forms.NumericUpDown itNumber;
    }
}

