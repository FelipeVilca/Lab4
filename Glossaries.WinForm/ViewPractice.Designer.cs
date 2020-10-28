namespace Glossaries.WinForm
{
    partial class ViewPractice
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWrong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please translate word";
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbWord.Location = new System.Drawing.Point(226, 16);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(55, 23);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "Word";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbFrom.Location = new System.Drawing.Point(226, 49);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(55, 23);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "From language";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTo.Location = new System.Drawing.Point(226, 81);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(55, 23);
            this.lbTo.TabIndex = 5;
            this.lbTo.Text = "Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "To language";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(130, 125);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(205, 20);
            this.txtWord.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(341, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrect.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbCorrect.Location = new System.Drawing.Point(191, 161);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(20, 23);
            this.lbCorrect.TabIndex = 9;
            this.lbCorrect.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correct:";
            // 
            // lbWrong
            // 
            this.lbWrong.AutoSize = true;
            this.lbWrong.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrong.ForeColor = System.Drawing.Color.Red;
            this.lbWrong.Location = new System.Drawing.Point(309, 163);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(20, 23);
            this.lbWrong.TabIndex = 11;
            this.lbWrong.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wrong:";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(13, 209);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(491, 225);
            this.lbResults.TabIndex = 12;
            // 
            // ViewPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.lbWrong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbCorrect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ViewPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPractice";
            this.Load += new System.EventHandler(this.ViewPractice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWrong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbResults;
    }
}