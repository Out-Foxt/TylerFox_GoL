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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(31, 398);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(147, 40);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(203, 398);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.HeightNumericUpDown1.TabIndex = 0;
            this.HeightNumericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
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
            this.WidthNumericUpDown2.TabIndex = 1;
            this.WidthNumericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval (In Miliseconds)";
            // 
            // IntervalNumericUpDown3
            // 
            this.IntervalNumericUpDown3.Location = new System.Drawing.Point(399, 179);
            this.IntervalNumericUpDown3.Name = "IntervalNumericUpDown3";
            this.IntervalNumericUpDown3.Size = new System.Drawing.Size(75, 26);
            this.IntervalNumericUpDown3.TabIndex = 2;
            this.IntervalNumericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.IntervalNumericUpDown3.ValueChanged += new System.EventHandler(this.IntervalNumericUpDown3_ValueChanged);
            // 
            // ModalDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntervalNumericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthNumericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightNumericUpDown1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModalDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModalDialog";
            this.Load += new System.EventHandler(this.ModalDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown IntervalNumericUpDown3;
    }
}