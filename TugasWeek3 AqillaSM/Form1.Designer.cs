namespace TugasWeek3_AqillaSM
{
    partial class FormWarna
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
            this.LabelInput = new System.Windows.Forms.Label();
            this.TBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonProses = new System.Windows.Forms.Button();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(55, 49);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(112, 25);
            this.LabelInput.TabIndex = 0;
            this.LabelInput.Text = "Input Data :";
            // 
            // TBoxInput
            // 
            this.TBoxInput.Location = new System.Drawing.Point(60, 77);
            this.TBoxInput.Name = "TBoxInput";
            this.TBoxInput.Size = new System.Drawing.Size(515, 30);
            this.TBoxInput.TabIndex = 1;
            this.TBoxInput.TextChanged += new System.EventHandler(this.TBoxInput_TextChanged);
            // 
            // ButtonProses
            // 
            this.ButtonProses.Location = new System.Drawing.Point(60, 154);
            this.ButtonProses.Name = "ButtonProses";
            this.ButtonProses.Size = new System.Drawing.Size(95, 32);
            this.ButtonProses.TabIndex = 2;
            this.ButtonProses.Text = "Proses";
            this.ButtonProses.UseVisualStyleBackColor = true;
            this.ButtonProses.Click += new System.EventHandler(this.ButtonProses_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(60, 234);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(93, 25);
            this.LabelOutput.TabIndex = 3;
            this.LabelOutput.Text = "[EMPTY]";
            this.LabelOutput.Click += new System.EventHandler(this.LabelOutput_Click);
            // 
            // FormWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 382);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.ButtonProses);
            this.Controls.Add(this.TBoxInput);
            this.Controls.Add(this.LabelInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormWarna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pengaturan Warna";
            this.Load += new System.EventHandler(this.FormWarna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.TextBox TBoxInput;
        private System.Windows.Forms.Button ButtonProses;
        private System.Windows.Forms.Label LabelOutput;
    }
}

