namespace PDFReader2
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
            this.buttonNormalPDF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonImgPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNormalPDF
            // 
            this.buttonNormalPDF.Location = new System.Drawing.Point(12, 12);
            this.buttonNormalPDF.Name = "buttonNormalPDF";
            this.buttonNormalPDF.Size = new System.Drawing.Size(93, 85);
            this.buttonNormalPDF.TabIndex = 0;
            this.buttonNormalPDF.Text = "Normal PDF";
            this.buttonNormalPDF.UseVisualStyleBackColor = true;
            this.buttonNormalPDF.Click += new System.EventHandler(this.buttonNormalPDF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(111, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonImgPDF
            // 
            this.buttonImgPDF.Location = new System.Drawing.Point(12, 103);
            this.buttonImgPDF.Name = "buttonImgPDF";
            this.buttonImgPDF.Size = new System.Drawing.Size(93, 85);
            this.buttonImgPDF.TabIndex = 2;
            this.buttonImgPDF.Text = "Fotoğraf PDF";
            this.buttonImgPDF.UseVisualStyleBackColor = true;
            this.buttonImgPDF.Click += new System.EventHandler(this.buttonImgPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonImgPDF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonNormalPDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNormalPDF;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonImgPDF;
    }
}

