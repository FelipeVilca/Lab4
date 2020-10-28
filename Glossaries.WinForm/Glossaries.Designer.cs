namespace Glossaries.WinForm
{
    partial class MainGlossaries
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
            this.btnShowLists = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnWords = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowLists
            // 
            this.btnShowLists.Location = new System.Drawing.Point(12, 68);
            this.btnShowLists.Name = "btnShowLists";
            this.btnShowLists.Size = new System.Drawing.Size(270, 39);
            this.btnShowLists.TabIndex = 0;
            this.btnShowLists.Text = "Show All Lists";
            this.btnShowLists.UseVisualStyleBackColor = true;
            this.btnShowLists.Click += new System.EventHandler(this.btnShowLists_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 113);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(270, 39);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New List";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 203);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(270, 39);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Words";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnWords
            // 
            this.btnWords.Location = new System.Drawing.Point(12, 248);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(270, 39);
            this.btnWords.TabIndex = 3;
            this.btnWords.Text = "Show Words";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Words";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 293);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(270, 39);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Words Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(12, 338);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(270, 39);
            this.btnPractice.TabIndex = 6;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Glossaries MENU";
            // 
            // MainGlossaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnWords);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnShowLists);
            this.MaximizeBox = false;
            this.Name = "MainGlossaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glossaries";
            this.Load += new System.EventHandler(this.MainGlossaries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowLists;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnWords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Label label1;
    }
}

