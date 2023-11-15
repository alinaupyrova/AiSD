namespace zad4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblinput = new System.Windows.Forms.TextBox();
            this.tblBubblesort = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tblinput
            // 
            this.tblinput.Location = new System.Drawing.Point(139, 87);
            this.tblinput.Name = "tblinput";
            this.tblinput.Size = new System.Drawing.Size(194, 23);
            this.tblinput.TabIndex = 0;
            this.tblinput.TextChanged += new System.EventHandler(this.tblinput_TextChanged);
            // 
            // tblBubblesort
            // 
            this.tblBubblesort.Location = new System.Drawing.Point(139, 123);
            this.tblBubblesort.Name = "tblBubblesort";
            this.tblBubblesort.Size = new System.Drawing.Size(75, 23);
            this.tblBubblesort.TabIndex = 1;
            this.tblBubblesort.Text = "start";
            this.tblBubblesort.UseVisualStyleBackColor = true;
            this.tblBubblesort.Click += new System.EventHandler(this.tblBubblesort_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(295, 131);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(38, 15);
            this.lblWynik.TabIndex = 3;
            this.lblWynik.Text = "label2";
            this.lblWynik.Click += new System.EventHandler(this.tblwynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.tblBubblesort);
            this.Controls.Add(this.tblinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tblinput;
        private Button tblBubblesort;
        private Label tblwynik;
        private Label lblWynik;
    }
}