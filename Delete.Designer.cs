﻿namespace Piantoni_Isabella_991392679_Assignment2
{
    partial class Delete
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
            this.playerDeleteList = new System.Windows.Forms.ComboBox();
            this.innerDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a player to delete.";
            // 
            // playerDeleteList
            // 
            this.playerDeleteList.FormattingEnabled = true;
            this.playerDeleteList.Location = new System.Drawing.Point(51, 82);
            this.playerDeleteList.Name = "playerDeleteList";
            this.playerDeleteList.Size = new System.Drawing.Size(211, 21);
            this.playerDeleteList.TabIndex = 1;
            this.playerDeleteList.SelectedIndexChanged += new System.EventHandler(this.PlayerDeleteList_SelectedIndexChanged);
            // 
            // innerDeleteBtn
            // 
            this.innerDeleteBtn.Location = new System.Drawing.Point(114, 130);
            this.innerDeleteBtn.Name = "innerDeleteBtn";
            this.innerDeleteBtn.Size = new System.Drawing.Size(86, 47);
            this.innerDeleteBtn.TabIndex = 2;
            this.innerDeleteBtn.Text = "Delete";
            this.innerDeleteBtn.UseVisualStyleBackColor = true;
            this.innerDeleteBtn.Click += new System.EventHandler(this.InnerDeleteBtn_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 198);
            this.Controls.Add(this.innerDeleteBtn);
            this.Controls.Add(this.playerDeleteList);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox playerDeleteList;
        private System.Windows.Forms.Button innerDeleteBtn;
    }
}