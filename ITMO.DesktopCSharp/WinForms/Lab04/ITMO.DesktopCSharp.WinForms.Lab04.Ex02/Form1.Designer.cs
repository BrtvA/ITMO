﻿namespace ITMO.DesktopCSharp.WinForms.Lab04.Ex02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personsListView = new System.Windows.Forms.ListView();
            this.firstNameHeader = new System.Windows.Forms.ColumnHeader();
            this.lastNameHeader = new System.Windows.Forms.ColumnHeader();
            this.ageHeader = new System.Windows.Forms.ColumnHeader();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameHeader,
            this.lastNameHeader,
            this.ageHeader});
            this.personsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsListView.Location = new System.Drawing.Point(0, 0);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(484, 223);
            this.personsListView.TabIndex = 0;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameHeader
            // 
            this.firstNameHeader.Text = "Имя";
            this.firstNameHeader.Width = 166;
            // 
            // lastNameHeader
            // 
            this.lastNameHeader.Text = "Фамилия";
            this.lastNameHeader.Width = 166;
            // 
            // ageHeader
            // 
            this.ageHeader.Text = "Возраст";
            this.ageHeader.Width = 168;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(76, 279);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(270, 279);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(98, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Редактировать";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.personsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Список сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView personsListView;
        private ColumnHeader firstNameHeader;
        private ColumnHeader lastNameHeader;
        private ColumnHeader ageHeader;
        private Button addBtn;
        private Button editBtn;
    }
}