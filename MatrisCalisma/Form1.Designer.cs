namespace MatrisCalisma
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
            this.tbxRow = new System.Windows.Forms.TextBox();
            this.tbxColumn = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.tbxResult2 = new System.Windows.Forms.TextBox();
            this.tbxResult3 = new System.Windows.Forms.TextBox();
            this.lblResultMatrix2 = new System.Windows.Forms.Label();
            this.lblResultMatrix3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxRow
            // 
            this.tbxRow.Location = new System.Drawing.Point(145, 81);
            this.tbxRow.Name = "tbxRow";
            this.tbxRow.Size = new System.Drawing.Size(131, 22);
            this.tbxRow.TabIndex = 0;
            // 
            // tbxColumn
            // 
            this.tbxColumn.Location = new System.Drawing.Point(145, 161);
            this.tbxColumn.Name = "tbxColumn";
            this.tbxColumn.Size = new System.Drawing.Size(131, 22);
            this.tbxColumn.TabIndex = 1;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(89, 81);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(34, 16);
            this.lblRow.TabIndex = 2;
            this.lblRow.Text = "Satır";
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(145, 258);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(131, 54);
            this.btnMatrix.TabIndex = 3;
            this.btnMatrix.Text = "Matris";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(89, 161);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(40, 16);
            this.lblColumn.TabIndex = 4;
            this.lblColumn.Text = "Sütun";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(353, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result Matrix 1";
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(306, 81);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(194, 194);
            this.tbxResult.TabIndex = 6;
            // 
            // tbxResult2
            // 
            this.tbxResult2.Location = new System.Drawing.Point(530, 81);
            this.tbxResult2.Multiline = true;
            this.tbxResult2.Name = "tbxResult2";
            this.tbxResult2.Size = new System.Drawing.Size(194, 194);
            this.tbxResult2.TabIndex = 7;
            // 
            // tbxResult3
            // 
            this.tbxResult3.Location = new System.Drawing.Point(750, 78);
            this.tbxResult3.Multiline = true;
            this.tbxResult3.Name = "tbxResult3";
            this.tbxResult3.Size = new System.Drawing.Size(194, 194);
            this.tbxResult3.TabIndex = 8;
            // 
            // lblResultMatrix2
            // 
            this.lblResultMatrix2.AutoSize = true;
            this.lblResultMatrix2.Location = new System.Drawing.Point(579, 62);
            this.lblResultMatrix2.Name = "lblResultMatrix2";
            this.lblResultMatrix2.Size = new System.Drawing.Size(93, 16);
            this.lblResultMatrix2.TabIndex = 9;
            this.lblResultMatrix2.Text = "Result Matrix 2";
            // 
            // lblResultMatrix3
            // 
            this.lblResultMatrix3.AutoSize = true;
            this.lblResultMatrix3.Location = new System.Drawing.Point(796, 59);
            this.lblResultMatrix3.Name = "lblResultMatrix3";
            this.lblResultMatrix3.Size = new System.Drawing.Size(92, 16);
            this.lblResultMatrix3.TabIndex = 10;
            this.lblResultMatrix3.Text = "Toplam Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.lblResultMatrix3);
            this.Controls.Add(this.lblResultMatrix2);
            this.Controls.Add(this.tbxResult3);
            this.Controls.Add(this.tbxResult2);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.tbxColumn);
            this.Controls.Add(this.tbxRow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRow;
        private System.Windows.Forms.TextBox tbxColumn;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.TextBox tbxResult2;
        private System.Windows.Forms.TextBox tbxResult3;
        private System.Windows.Forms.Label lblResultMatrix2;
        private System.Windows.Forms.Label lblResultMatrix3;
    }
}

