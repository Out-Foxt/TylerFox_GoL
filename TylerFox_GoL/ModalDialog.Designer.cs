namespace TylerFox_GoL
{
    partial class ModalDialog
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
            this.button1OK = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.HeightNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.IntervalNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1OK
            // 
            this.button1OK.Location = new System.Drawing.Point(31, 398);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(147, 40);
            this.button1OK.TabIndex = 0;
            this.button1OK.Text = "Ok";
            this.button1OK.UseVisualStyleBackColor = true;
            // 
            // button2Cancel
            // 
            this.button2Cancel.Location = new System.Drawing.Point(219, 398);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(147, 40);
            this.button2Cancel.TabIndex = 1;
            this.button2Cancel.Text = "Cancel";
            this.button2Cancel.UseVisualStyleBackColor = true;
            // 
            // HeightNumericUpDown1
            // 
            this.HeightNumericUpDown1.Location = new System.Drawing.Point(399, 69);
            this.HeightNumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightNumericUpDown1.Name = "HeightNumericUpDown1";
            this.HeightNumericUpDown1.Size = new System.Drawing.Size(75, 26);
            this.HeightNumericUpDown1.TabIndex = 2;
            this.HeightNumericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height of the Universe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width of the Universe";
            // 
            // WidthNumericUpDown2
            // 
            this.WidthNumericUpDown2.Location = new System.Drawing.Point(399, 119);
            this.WidthNumericUpDown2.Name = "WidthNumericUpDown2";
            this.WidthNumericUpDown2.Size = new System.Drawing.Size(75, 26);
            this.WidthNumericUpDown2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval (In Miliseconds)";
            // 
            // IntervalNumericUpDown3
            // 
            this.IntervalNumericUpDown3.Location = new System.Drawing.Point(399, 169);
            this.IntervalNumericUpDown3.Name = "IntervalNumericUpDown3";
            this.IntervalNumericUpDown3.Size = new System.Drawing.Size(75, 26);
            this.IntervalNumericUpDown3.TabIndex = 7;
            // 
            // ModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntervalNumericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthNumericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightNumericUpDown1);
            this.Controls.Add(this.button2Cancel);
            this.Controls.Add(this.button1OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModalDialog";
            this.Text = "ModalDialog";
            this.Load += new System.EventHandler(this.ModalDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1OK;
        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IntervalNumericUpDown3;
    }
}