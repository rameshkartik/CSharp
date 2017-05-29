namespace FileConversion
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
            this.btn_DocToPDF = new System.Windows.Forms.Button();
            this.btn_DocToTxt = new System.Windows.Forms.Button();
            this.btn_DocToXps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DocToPDF
            // 
            this.btn_DocToPDF.Location = new System.Drawing.Point(35, 57);
            this.btn_DocToPDF.Name = "btn_DocToPDF";
            this.btn_DocToPDF.Size = new System.Drawing.Size(75, 23);
            this.btn_DocToPDF.TabIndex = 0;
            this.btn_DocToPDF.Text = "Doc to PDF";
            this.btn_DocToPDF.UseVisualStyleBackColor = true;
            this.btn_DocToPDF.Click += new System.EventHandler(this.btn_DocToPDF_Click);
            // 
            // btn_DocToTxt
            // 
            this.btn_DocToTxt.Location = new System.Drawing.Point(238, 57);
            this.btn_DocToTxt.Name = "btn_DocToTxt";
            this.btn_DocToTxt.Size = new System.Drawing.Size(75, 23);
            this.btn_DocToTxt.TabIndex = 1;
            this.btn_DocToTxt.Text = "Doc to Txt";
            this.btn_DocToTxt.UseVisualStyleBackColor = true;
            this.btn_DocToTxt.Click += new System.EventHandler(this.btn_DocToTxt_Click);
            // 
            // btn_DocToXps
            // 
            this.btn_DocToXps.Location = new System.Drawing.Point(130, 164);
            this.btn_DocToXps.Name = "btn_DocToXps";
            this.btn_DocToXps.Size = new System.Drawing.Size(75, 23);
            this.btn_DocToXps.TabIndex = 2;
            this.btn_DocToXps.Text = " Doc To Xps";
            this.btn_DocToXps.UseVisualStyleBackColor = true;
            this.btn_DocToXps.Click += new System.EventHandler(this.btn_DocToXps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 291);
            this.Controls.Add(this.btn_DocToXps);
            this.Controls.Add(this.btn_DocToTxt);
            this.Controls.Add(this.btn_DocToPDF);
            this.Name = "Form1";
            this.Text = "Convertor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DocToPDF;
        private System.Windows.Forms.Button btn_DocToTxt;
        private System.Windows.Forms.Button btn_DocToXps;
    }
}

