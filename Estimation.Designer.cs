
namespace GoldEstimationApp
{
    partial class Estimation
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
            this.btnPrintFile = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtGoldPrice = new System.Windows.Forms.TextBox();
            this.lblGoldPrice = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblDiscnt = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnPrinttoScreen = new System.Windows.Forms.Button();
            this.bnPrintPapr = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintFile
            // 
            this.btnPrintFile.Location = new System.Drawing.Point(259, 290);
            this.btnPrintFile.Name = "btnPrintFile";
            this.btnPrintFile.Size = new System.Drawing.Size(75, 23);
            this.btnPrintFile.TabIndex = 0;
            this.btnPrintFile.Text = "Print to File";
            this.btnPrintFile.UseVisualStyleBackColor = true;
            this.btnPrintFile.Click += new System.EventHandler(this.btnPrintFile_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(259, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "label1";
            // 
            // txtGoldPrice
            // 
            this.txtGoldPrice.Location = new System.Drawing.Point(162, 60);
            this.txtGoldPrice.Name = "txtGoldPrice";
            this.txtGoldPrice.Size = new System.Drawing.Size(100, 23);
            this.txtGoldPrice.TabIndex = 2;
            this.txtGoldPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoldPrice_KeyPress);
            // 
            // lblGoldPrice
            // 
            this.lblGoldPrice.AutoSize = true;
            this.lblGoldPrice.Location = new System.Drawing.Point(29, 63);
            this.lblGoldPrice.Name = "lblGoldPrice";
            this.lblGoldPrice.Size = new System.Drawing.Size(129, 15);
            this.lblGoldPrice.TabIndex = 3;
            this.lblGoldPrice.Text = "Gold Price ( Per Grams)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(40, 121);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(89, 15);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight (grams)";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(54, 179);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(79, 15);
            this.lblAmt.TabIndex = 5;
            this.lblAmt.Text = "Total Amount";
            // 
            // lblDiscnt
            // 
            this.lblDiscnt.AutoSize = true;
            this.lblDiscnt.Location = new System.Drawing.Point(113, 227);
            this.lblDiscnt.Name = "lblDiscnt";
            this.lblDiscnt.Size = new System.Drawing.Size(67, 15);
            this.lblDiscnt.TabIndex = 6;
            this.lblDiscnt.Text = "Discount %";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(162, 113);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 23);
            this.txtWeight.TabIndex = 7;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(162, 171);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(100, 23);
            this.txtAmt.TabIndex = 8;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(186, 224);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscount.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 290);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnPrinttoScreen
            // 
            this.btnPrinttoScreen.Location = new System.Drawing.Point(132, 290);
            this.btnPrinttoScreen.Name = "btnPrinttoScreen";
            this.btnPrinttoScreen.Size = new System.Drawing.Size(95, 23);
            this.btnPrinttoScreen.TabIndex = 11;
            this.btnPrinttoScreen.Text = "Print to Screen";
            this.btnPrinttoScreen.UseVisualStyleBackColor = true;
            this.btnPrinttoScreen.Click += new System.EventHandler(this.btnPrinttoScreen_Click);
            // 
            // bnPrintPapr
            // 
            this.bnPrintPapr.Location = new System.Drawing.Point(360, 290);
            this.bnPrintPapr.Name = "bnPrintPapr";
            this.bnPrintPapr.Size = new System.Drawing.Size(87, 23);
            this.bnPrintPapr.TabIndex = 12;
            this.bnPrintPapr.Text = "Print to Paper";
            this.bnPrintPapr.UseVisualStyleBackColor = true;
            this.bnPrintPapr.Click += new System.EventHandler(this.bnPrintPapr_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Estimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bnPrintPapr);
            this.Controls.Add(this.btnPrinttoScreen);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblDiscnt);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblGoldPrice);
            this.Controls.Add(this.txtGoldPrice);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnPrintFile);
            this.Name = "Estimation";
            this.Text = "Estimation";
            this.Load += new System.EventHandler(this.Estimation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintFile;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtGoldPrice;
        private System.Windows.Forms.Label lblGoldPrice;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblDiscnt;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnPrinttoScreen;
        private System.Windows.Forms.Button bnPrintPapr;
        private System.Windows.Forms.Button btnCancel;
    }
}