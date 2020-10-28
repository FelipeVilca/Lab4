namespace Glossaries.WinForm
{
    partial class ViewWords
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
            this.btnShowWords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShowWords
            // 
            this.btnShowWords.Location = new System.Drawing.Point(210, 66);
            this.btnShowWords.Name = "btnShowWords";
            this.btnShowWords.Size = new System.Drawing.Size(107, 23);
            this.btnShowWords.TabIndex = 20;
            this.btnShowWords.Text = "Show Words";
            this.btnShowWords.UseVisualStyleBackColor = true;
            this.btnShowWords.Click += new System.EventHandler(this.btnShowWords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Please choose list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLists
            // 
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Location = new System.Drawing.Point(139, 12);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(178, 21);
            this.cmbLists.TabIndex = 18;
            this.cmbLists.SelectedIndexChanged += new System.EventHandler(this.cmbLists_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Please choose language";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(139, 39);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(178, 21);
            this.cmbLanguage.TabIndex = 21;
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(139, 96);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(177, 316);
            this.lbWords.TabIndex = 23;
            // 
            // ViewWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 422);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnShowWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLists);
            this.MaximizeBox = false;
            this.Name = "ViewWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewWords";
            this.Load += new System.EventHandler(this.ViewWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.ListBox lbWords;
    }
}