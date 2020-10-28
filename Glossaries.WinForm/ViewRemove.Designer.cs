namespace Glossaries.WinForm
{
    partial class ViewRemove
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
            this.lbWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnShowWords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(144, 95);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(177, 316);
            this.lbWords.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Please choose language";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(144, 38);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(178, 21);
            this.cmbLanguage.TabIndex = 27;
            // 
            // btnShowWords
            // 
            this.btnShowWords.Location = new System.Drawing.Point(215, 65);
            this.btnShowWords.Name = "btnShowWords";
            this.btnShowWords.Size = new System.Drawing.Size(107, 23);
            this.btnShowWords.TabIndex = 26;
            this.btnShowWords.Text = "Show Words";
            this.btnShowWords.UseVisualStyleBackColor = true;
            this.btnShowWords.Click += new System.EventHandler(this.btnShowWords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Please choose list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbLists
            // 
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Location = new System.Drawing.Point(144, 11);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(178, 21);
            this.cmbLists.TabIndex = 24;
            this.cmbLists.SelectedIndexChanged += new System.EventHandler(this.cmbLists_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(144, 417);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(177, 23);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove Selected Word";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ViewRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 456);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnShowWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLists);
            this.MaximizeBox = false;
            this.Name = "ViewRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRemove";
            this.Load += new System.EventHandler(this.ViewRemove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnShowWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLists;
        private System.Windows.Forms.Button btnRemove;
    }
}