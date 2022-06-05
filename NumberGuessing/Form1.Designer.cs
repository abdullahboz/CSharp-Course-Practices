namespace NumberGuessing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCharSum = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStepSum = new System.Windows.Forms.Button();
            this.btnSteps = new System.Windows.Forms.Button();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNumberOperation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGuessingResult = new System.Windows.Forms.Label();
            this.lblNumber6 = new System.Windows.Forms.Label();
            this.lblNumber5 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.btnGuessing = new System.Windows.Forms.Button();
            this.tbxNumber6 = new System.Windows.Forms.TextBox();
            this.tbxNumber5 = new System.Windows.Forms.TextBox();
            this.tbxNumber4 = new System.Windows.Forms.TextBox();
            this.tbxNumber3 = new System.Windows.Forms.TextBox();
            this.tbxNumber2 = new System.Windows.Forms.TextBox();
            this.tbxNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumberGuessing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lbxResult);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 306);
            this.panel1.TabIndex = 0;
            // 
            // lbxResult
            // 
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.ItemHeight = 16;
            this.lbxResult.Location = new System.Drawing.Point(398, 68);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.Size = new System.Drawing.Size(383, 212);
            this.lbxResult.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.Location = new System.Drawing.Point(550, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Sonuç";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.btnCharSum);
            this.panel4.Controls.Add(this.btnChar);
            this.panel4.Controls.Add(this.tbxWord);
            this.panel4.Controls.Add(this.lblWord);
            this.panel4.Controls.Add(this.lblCharacter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(843, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 306);
            this.panel4.TabIndex = 1;
            // 
            // btnCharSum
            // 
            this.btnCharSum.Location = new System.Drawing.Point(72, 206);
            this.btnCharSum.Name = "btnCharSum";
            this.btnCharSum.Size = new System.Drawing.Size(185, 23);
            this.btnCharSum.TabIndex = 5;
            this.btnCharSum.Text = "Karakterleri Topla";
            this.btnCharSum.UseVisualStyleBackColor = true;
            this.btnCharSum.Click += new System.EventHandler(this.btnCharSum_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(72, 135);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(185, 23);
            this.btnChar.TabIndex = 4;
            this.btnChar.Text = "Karakterlere Ayır";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(72, 71);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(185, 22);
            this.tbxWord.TabIndex = 3;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 71);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(54, 16);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Kelime: ";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCharacter.Location = new System.Drawing.Point(108, 9);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(137, 25);
            this.lblCharacter.TabIndex = 1;
            this.lblCharacter.Text = "Karakter İşlem";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.btnStepSum);
            this.panel3.Controls.Add(this.btnSteps);
            this.panel3.Controls.Add(this.tbxNumber);
            this.panel3.Controls.Add(this.lblNumber);
            this.panel3.Controls.Add(this.lblNumberOperation);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 306);
            this.panel3.TabIndex = 0;
            // 
            // btnStepSum
            // 
            this.btnStepSum.Location = new System.Drawing.Point(59, 206);
            this.btnStepSum.Name = "btnStepSum";
            this.btnStepSum.Size = new System.Drawing.Size(185, 23);
            this.btnStepSum.TabIndex = 4;
            this.btnStepSum.Text = "Basamakları Topla";
            this.btnStepSum.UseVisualStyleBackColor = true;
            this.btnStepSum.Click += new System.EventHandler(this.btnStepSum_Click);
            // 
            // btnSteps
            // 
            this.btnSteps.Location = new System.Drawing.Point(59, 135);
            this.btnSteps.Name = "btnSteps";
            this.btnSteps.Size = new System.Drawing.Size(185, 23);
            this.btnSteps.TabIndex = 3;
            this.btnSteps.Text = "Basamaklara Ayır";
            this.btnSteps.UseVisualStyleBackColor = true;
            this.btnSteps.Click += new System.EventHandler(this.btnSteps_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(59, 68);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(185, 22);
            this.tbxNumber.TabIndex = 2;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 68);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(40, 16);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Sayı: ";
            // 
            // lblNumberOperation
            // 
            this.lblNumberOperation.AutoSize = true;
            this.lblNumberOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOperation.Location = new System.Drawing.Point(82, 9);
            this.lblNumberOperation.Name = "lblNumberOperation";
            this.lblNumberOperation.Size = new System.Drawing.Size(102, 25);
            this.lblNumberOperation.TabIndex = 0;
            this.lblNumberOperation.Text = "Sayı İşlem";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblGuessingResult);
            this.panel2.Controls.Add(this.lblNumber6);
            this.panel2.Controls.Add(this.lblNumber5);
            this.panel2.Controls.Add(this.lblNumber4);
            this.panel2.Controls.Add(this.lblNumber3);
            this.panel2.Controls.Add(this.lblNumber2);
            this.panel2.Controls.Add(this.lblNumber1);
            this.panel2.Controls.Add(this.btnGuessing);
            this.panel2.Controls.Add(this.tbxNumber6);
            this.panel2.Controls.Add(this.tbxNumber5);
            this.panel2.Controls.Add(this.tbxNumber4);
            this.panel2.Controls.Add(this.tbxNumber3);
            this.panel2.Controls.Add(this.tbxNumber2);
            this.panel2.Controls.Add(this.tbxNumber1);
            this.panel2.Controls.Add(this.lblNumberGuessing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 369);
            this.panel2.TabIndex = 1;
            // 
            // lblGuessingResult
            // 
            this.lblGuessingResult.AutoSize = true;
            this.lblGuessingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuessingResult.Location = new System.Drawing.Point(758, 258);
            this.lblGuessingResult.Name = "lblGuessingResult";
            this.lblGuessingResult.Size = new System.Drawing.Size(151, 25);
            this.lblGuessingResult.TabIndex = 15;
            this.lblGuessingResult.Text = "Tahmin Sonucu";
            // 
            // lblNumber6
            // 
            this.lblNumber6.AutoSize = true;
            this.lblNumber6.Location = new System.Drawing.Point(732, 187);
            this.lblNumber6.Name = "lblNumber6";
            this.lblNumber6.Size = new System.Drawing.Size(41, 16);
            this.lblNumber6.TabIndex = 14;
            this.lblNumber6.Text = "Sayı6";
            // 
            // lblNumber5
            // 
            this.lblNumber5.AutoSize = true;
            this.lblNumber5.Location = new System.Drawing.Point(605, 187);
            this.lblNumber5.Name = "lblNumber5";
            this.lblNumber5.Size = new System.Drawing.Size(41, 16);
            this.lblNumber5.TabIndex = 13;
            this.lblNumber5.Text = "Sayı5";
            // 
            // lblNumber4
            // 
            this.lblNumber4.AutoSize = true;
            this.lblNumber4.Location = new System.Drawing.Point(474, 187);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(41, 16);
            this.lblNumber4.TabIndex = 12;
            this.lblNumber4.Text = "Sayı4";
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.Location = new System.Drawing.Point(341, 187);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(41, 16);
            this.lblNumber3.TabIndex = 11;
            this.lblNumber3.Text = "Sayı3";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(206, 187);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(41, 16);
            this.lblNumber2.TabIndex = 10;
            this.lblNumber2.Text = "Sayı2";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(70, 187);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(41, 16);
            this.lblNumber1.TabIndex = 9;
            this.lblNumber1.Text = "Sayı1";
            // 
            // btnGuessing
            // 
            this.btnGuessing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuessing.Location = new System.Drawing.Point(868, 115);
            this.btnGuessing.Name = "btnGuessing";
            this.btnGuessing.Size = new System.Drawing.Size(155, 53);
            this.btnGuessing.TabIndex = 8;
            this.btnGuessing.Text = "Tahmin";
            this.btnGuessing.UseVisualStyleBackColor = false;
            this.btnGuessing.Click += new System.EventHandler(this.btnGuessing_Click);
            // 
            // tbxNumber6
            // 
            this.tbxNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber6.Location = new System.Drawing.Point(735, 115);
            this.tbxNumber6.Name = "tbxNumber6";
            this.tbxNumber6.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber6.TabIndex = 7;
            // 
            // tbxNumber5
            // 
            this.tbxNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber5.Location = new System.Drawing.Point(608, 115);
            this.tbxNumber5.Name = "tbxNumber5";
            this.tbxNumber5.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber5.TabIndex = 6;
            // 
            // tbxNumber4
            // 
            this.tbxNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber4.Location = new System.Drawing.Point(477, 115);
            this.tbxNumber4.Name = "tbxNumber4";
            this.tbxNumber4.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber4.TabIndex = 5;
            // 
            // tbxNumber3
            // 
            this.tbxNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber3.Location = new System.Drawing.Point(344, 115);
            this.tbxNumber3.Name = "tbxNumber3";
            this.tbxNumber3.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber3.TabIndex = 4;
            // 
            // tbxNumber2
            // 
            this.tbxNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber2.Location = new System.Drawing.Point(209, 115);
            this.tbxNumber2.Name = "tbxNumber2";
            this.tbxNumber2.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber2.TabIndex = 3;
            // 
            // tbxNumber1
            // 
            this.tbxNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumber1.Location = new System.Drawing.Point(73, 115);
            this.tbxNumber1.Name = "tbxNumber1";
            this.tbxNumber1.Size = new System.Drawing.Size(79, 24);
            this.tbxNumber1.TabIndex = 2;
            // 
            // lblNumberGuessing
            // 
            this.lblNumberGuessing.AutoSize = true;
            this.lblNumberGuessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberGuessing.Location = new System.Drawing.Point(488, 9);
            this.lblNumberGuessing.Name = "lblNumberGuessing";
            this.lblNumberGuessing.Size = new System.Drawing.Size(186, 25);
            this.lblNumberGuessing.TabIndex = 1;
            this.lblNumberGuessing.Text = "Sayı Tahmin Oyunu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lütfen Kutucuklara 1 ile 50 Arasında Sayı Giriniz!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCharSum;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStepSum;
        private System.Windows.Forms.Button btnSteps;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumberOperation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGuessingResult;
        private System.Windows.Forms.Label lblNumber6;
        private System.Windows.Forms.Label lblNumber5;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Button btnGuessing;
        private System.Windows.Forms.TextBox tbxNumber6;
        private System.Windows.Forms.TextBox tbxNumber5;
        private System.Windows.Forms.TextBox tbxNumber4;
        private System.Windows.Forms.TextBox tbxNumber3;
        private System.Windows.Forms.TextBox tbxNumber2;
        private System.Windows.Forms.TextBox tbxNumber1;
        private System.Windows.Forms.Label lblNumberGuessing;
        private System.Windows.Forms.Label label1;
    }
}

