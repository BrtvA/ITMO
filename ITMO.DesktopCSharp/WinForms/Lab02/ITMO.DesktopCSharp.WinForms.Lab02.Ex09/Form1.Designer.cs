﻿namespace ITMO.DesktopCSharp.WinForms.Lab02.Ex09
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bookPage = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.backCheckBox = new System.Windows.Forms.CheckBox();
            this.availabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.periodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.periodLabel = new System.Windows.Forms.Label();
            this.inventoryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberPagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.numberPagesLabel = new System.Windows.Forms.Label();
            this.publishingTextBox = new System.Windows.Forms.TextBox();
            this.publishingLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.magazinePage = new System.Windows.Forms.TabPage();
            this.numberMagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.volumeMagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addMagBtn = new System.Windows.Forms.Button();
            this.availabilityMagCheckBox = new System.Windows.Forms.CheckBox();
            this.subMagCheckBox = new System.Windows.Forms.CheckBox();
            this.inventoryMagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventoryMagLabel = new System.Windows.Forms.Label();
            this.yearMagNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearMagLabel = new System.Windows.Forms.Label();
            this.titleMagTextBox = new System.Windows.Forms.TextBox();
            this.titleMagLabel = new System.Windows.Forms.Label();
            this.numberMagLabel = new System.Windows.Forms.Label();
            this.volumeMagLabel = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.watchBtn = new System.Windows.Forms.Button();
            this.sortCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPagesNumericUpDown)).BeginInit();
            this.magazinePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMagNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeMagNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMagNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearMagNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bookPage);
            this.tabControl.Controls.Add(this.magazinePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(273, 411);
            this.tabControl.TabIndex = 0;
            // 
            // bookPage
            // 
            this.bookPage.Controls.Add(this.addBtn);
            this.bookPage.Controls.Add(this.backCheckBox);
            this.bookPage.Controls.Add(this.availabilityCheckBox);
            this.bookPage.Controls.Add(this.periodNumericUpDown);
            this.bookPage.Controls.Add(this.periodLabel);
            this.bookPage.Controls.Add(this.inventoryNumericUpDown);
            this.bookPage.Controls.Add(this.inventoryLabel);
            this.bookPage.Controls.Add(this.yearNumericUpDown);
            this.bookPage.Controls.Add(this.numberPagesNumericUpDown);
            this.bookPage.Controls.Add(this.yearLabel);
            this.bookPage.Controls.Add(this.numberPagesLabel);
            this.bookPage.Controls.Add(this.publishingTextBox);
            this.bookPage.Controls.Add(this.publishingLabel);
            this.bookPage.Controls.Add(this.titleTextBox);
            this.bookPage.Controls.Add(this.titleLabel);
            this.bookPage.Controls.Add(this.authorTextBox);
            this.bookPage.Controls.Add(this.authorLabel);
            this.bookPage.Location = new System.Drawing.Point(4, 24);
            this.bookPage.Name = "bookPage";
            this.bookPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookPage.Size = new System.Drawing.Size(265, 383);
            this.bookPage.TabIndex = 0;
            this.bookPage.Text = "Книги";
            this.bookPage.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 352);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(245, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backCheckBox
            // 
            this.backCheckBox.AutoSize = true;
            this.backCheckBox.Location = new System.Drawing.Point(125, 311);
            this.backCheckBox.Name = "backCheckBox";
            this.backCheckBox.Size = new System.Drawing.Size(130, 19);
            this.backCheckBox.TabIndex = 16;
            this.backCheckBox.Text = "Возвращает в срок";
            this.backCheckBox.UseVisualStyleBackColor = true;
            // 
            // availabilityCheckBox
            // 
            this.availabilityCheckBox.AutoSize = true;
            this.availabilityCheckBox.Location = new System.Drawing.Point(10, 311);
            this.availabilityCheckBox.Name = "availabilityCheckBox";
            this.availabilityCheckBox.Size = new System.Drawing.Size(75, 19);
            this.availabilityCheckBox.TabIndex = 15;
            this.availabilityCheckBox.Text = "Наличие";
            this.availabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // periodNumericUpDown
            // 
            this.periodNumericUpDown.Location = new System.Drawing.Point(125, 275);
            this.periodNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periodNumericUpDown.Name = "periodNumericUpDown";
            this.periodNumericUpDown.Size = new System.Drawing.Size(134, 23);
            this.periodNumericUpDown.TabIndex = 14;
            this.periodNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(10, 277);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(109, 15);
            this.periodLabel.TabIndex = 13;
            this.periodLabel.Text = "Срок пользования";
            // 
            // inventoryNumericUpDown
            // 
            this.inventoryNumericUpDown.Location = new System.Drawing.Point(108, 233);
            this.inventoryNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.inventoryNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventoryNumericUpDown.Name = "inventoryNumericUpDown";
            this.inventoryNumericUpDown.Size = new System.Drawing.Size(151, 23);
            this.inventoryNumericUpDown.TabIndex = 12;
            this.inventoryNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(10, 235);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(83, 15);
            this.inventoryLabel.TabIndex = 11;
            this.inventoryLabel.Text = "Инвертарный";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(108, 192);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(151, 23);
            this.yearNumericUpDown.TabIndex = 10;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // numberPagesNumericUpDown
            // 
            this.numberPagesNumericUpDown.Location = new System.Drawing.Point(108, 145);
            this.numberPagesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberPagesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPagesNumericUpDown.Name = "numberPagesNumericUpDown";
            this.numberPagesNumericUpDown.Size = new System.Drawing.Size(151, 23);
            this.numberPagesNumericUpDown.TabIndex = 9;
            this.numberPagesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(8, 194);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(73, 15);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Год издания";
            // 
            // numberPagesLabel
            // 
            this.numberPagesLabel.AutoSize = true;
            this.numberPagesLabel.Location = new System.Drawing.Point(8, 147);
            this.numberPagesLabel.Name = "numberPagesLabel";
            this.numberPagesLabel.Size = new System.Drawing.Size(54, 15);
            this.numberPagesLabel.TabIndex = 6;
            this.numberPagesLabel.Text = "Страниц";
            // 
            // publishingTextBox
            // 
            this.publishingTextBox.Location = new System.Drawing.Point(108, 98);
            this.publishingTextBox.Name = "publishingTextBox";
            this.publishingTextBox.Size = new System.Drawing.Size(151, 23);
            this.publishingTextBox.TabIndex = 5;
            // 
            // publishingLabel
            // 
            this.publishingLabel.AutoSize = true;
            this.publishingLabel.Location = new System.Drawing.Point(8, 101);
            this.publishingLabel.Name = "publishingLabel";
            this.publishingLabel.Size = new System.Drawing.Size(81, 15);
            this.publishingLabel.TabIndex = 4;
            this.publishingLabel.Text = "Издательство";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(108, 54);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(151, 23);
            this.titleTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(8, 57);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 15);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Название";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(108, 10);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(151, 23);
            this.authorTextBox.TabIndex = 1;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(8, 13);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(40, 15);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Автор";
            // 
            // magazinePage
            // 
            this.magazinePage.Controls.Add(this.numberMagNumericUpDown);
            this.magazinePage.Controls.Add(this.volumeMagNumericUpDown);
            this.magazinePage.Controls.Add(this.addMagBtn);
            this.magazinePage.Controls.Add(this.availabilityMagCheckBox);
            this.magazinePage.Controls.Add(this.subMagCheckBox);
            this.magazinePage.Controls.Add(this.inventoryMagNumericUpDown);
            this.magazinePage.Controls.Add(this.inventoryMagLabel);
            this.magazinePage.Controls.Add(this.yearMagNumericUpDown);
            this.magazinePage.Controls.Add(this.yearMagLabel);
            this.magazinePage.Controls.Add(this.titleMagTextBox);
            this.magazinePage.Controls.Add(this.titleMagLabel);
            this.magazinePage.Controls.Add(this.numberMagLabel);
            this.magazinePage.Controls.Add(this.volumeMagLabel);
            this.magazinePage.Location = new System.Drawing.Point(4, 24);
            this.magazinePage.Name = "magazinePage";
            this.magazinePage.Padding = new System.Windows.Forms.Padding(3);
            this.magazinePage.Size = new System.Drawing.Size(265, 383);
            this.magazinePage.TabIndex = 1;
            this.magazinePage.Text = "Журналы";
            this.magazinePage.UseVisualStyleBackColor = true;
            // 
            // numberMagNumericUpDown
            // 
            this.numberMagNumericUpDown.Location = new System.Drawing.Point(110, 51);
            this.numberMagNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberMagNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberMagNumericUpDown.Name = "numberMagNumericUpDown";
            this.numberMagNumericUpDown.Size = new System.Drawing.Size(149, 23);
            this.numberMagNumericUpDown.TabIndex = 14;
            this.numberMagNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // volumeMagNumericUpDown
            // 
            this.volumeMagNumericUpDown.Location = new System.Drawing.Point(110, 12);
            this.volumeMagNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.volumeMagNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeMagNumericUpDown.Name = "volumeMagNumericUpDown";
            this.volumeMagNumericUpDown.Size = new System.Drawing.Size(149, 23);
            this.volumeMagNumericUpDown.TabIndex = 13;
            this.volumeMagNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addMagBtn
            // 
            this.addMagBtn.Location = new System.Drawing.Point(25, 296);
            this.addMagBtn.Name = "addMagBtn";
            this.addMagBtn.Size = new System.Drawing.Size(216, 23);
            this.addMagBtn.TabIndex = 12;
            this.addMagBtn.Text = "Добавить";
            this.addMagBtn.UseVisualStyleBackColor = true;
            this.addMagBtn.Click += new System.EventHandler(this.addMagBtn_Click);
            // 
            // availabilityMagCheckBox
            // 
            this.availabilityMagCheckBox.AutoSize = true;
            this.availabilityMagCheckBox.Location = new System.Drawing.Point(8, 251);
            this.availabilityMagCheckBox.Name = "availabilityMagCheckBox";
            this.availabilityMagCheckBox.Size = new System.Drawing.Size(75, 19);
            this.availabilityMagCheckBox.TabIndex = 11;
            this.availabilityMagCheckBox.Text = "Наличие";
            this.availabilityMagCheckBox.UseVisualStyleBackColor = true;
            // 
            // subMagCheckBox
            // 
            this.subMagCheckBox.AutoSize = true;
            this.subMagCheckBox.Location = new System.Drawing.Point(8, 217);
            this.subMagCheckBox.Name = "subMagCheckBox";
            this.subMagCheckBox.Size = new System.Drawing.Size(192, 19);
            this.subMagCheckBox.TabIndex = 10;
            this.subMagCheckBox.Text = "Наличие подписки на журнал";
            this.subMagCheckBox.UseVisualStyleBackColor = true;
            // 
            // inventoryMagNumericUpDown
            // 
            this.inventoryMagNumericUpDown.Location = new System.Drawing.Point(110, 171);
            this.inventoryMagNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.inventoryMagNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inventoryMagNumericUpDown.Name = "inventoryMagNumericUpDown";
            this.inventoryMagNumericUpDown.Size = new System.Drawing.Size(149, 23);
            this.inventoryMagNumericUpDown.TabIndex = 9;
            this.inventoryMagNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inventoryMagLabel
            // 
            this.inventoryMagLabel.AutoSize = true;
            this.inventoryMagLabel.Location = new System.Drawing.Point(8, 173);
            this.inventoryMagLabel.Name = "inventoryMagLabel";
            this.inventoryMagLabel.Size = new System.Drawing.Size(83, 15);
            this.inventoryMagLabel.TabIndex = 8;
            this.inventoryMagLabel.Text = "Инвентарный";
            // 
            // yearMagNumericUpDown
            // 
            this.yearMagNumericUpDown.Location = new System.Drawing.Point(110, 132);
            this.yearMagNumericUpDown.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearMagNumericUpDown.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearMagNumericUpDown.Name = "yearMagNumericUpDown";
            this.yearMagNumericUpDown.Size = new System.Drawing.Size(149, 23);
            this.yearMagNumericUpDown.TabIndex = 7;
            this.yearMagNumericUpDown.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // yearMagLabel
            // 
            this.yearMagLabel.AutoSize = true;
            this.yearMagLabel.Location = new System.Drawing.Point(8, 134);
            this.yearMagLabel.Name = "yearMagLabel";
            this.yearMagLabel.Size = new System.Drawing.Size(81, 15);
            this.yearMagLabel.TabIndex = 6;
            this.yearMagLabel.Text = "Дата выпуска";
            // 
            // titleMagTextBox
            // 
            this.titleMagTextBox.Location = new System.Drawing.Point(110, 94);
            this.titleMagTextBox.Name = "titleMagTextBox";
            this.titleMagTextBox.Size = new System.Drawing.Size(149, 23);
            this.titleMagTextBox.TabIndex = 5;
            // 
            // titleMagLabel
            // 
            this.titleMagLabel.AutoSize = true;
            this.titleMagLabel.Location = new System.Drawing.Point(8, 97);
            this.titleMagLabel.Name = "titleMagLabel";
            this.titleMagLabel.Size = new System.Drawing.Size(59, 15);
            this.titleMagLabel.TabIndex = 4;
            this.titleMagLabel.Text = "Название";
            // 
            // numberMagLabel
            // 
            this.numberMagLabel.AutoSize = true;
            this.numberMagLabel.Location = new System.Drawing.Point(8, 53);
            this.numberMagLabel.Name = "numberMagLabel";
            this.numberMagLabel.Size = new System.Drawing.Size(45, 15);
            this.numberMagLabel.TabIndex = 2;
            this.numberMagLabel.Text = "Номер";
            // 
            // volumeMagLabel
            // 
            this.volumeMagLabel.AutoSize = true;
            this.volumeMagLabel.Location = new System.Drawing.Point(8, 14);
            this.volumeMagLabel.Name = "volumeMagLabel";
            this.volumeMagLabel.Size = new System.Drawing.Size(29, 15);
            this.volumeMagLabel.TabIndex = 0;
            this.volumeMagLabel.Text = "Том";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(279, 24);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(363, 337);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // watchBtn
            // 
            this.watchBtn.Location = new System.Drawing.Point(279, 376);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(103, 23);
            this.watchBtn.TabIndex = 2;
            this.watchBtn.Text = "Посмотреть";
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // sortCheckBox
            // 
            this.sortCheckBox.AutoSize = true;
            this.sortCheckBox.Location = new System.Drawing.Point(426, 379);
            this.sortCheckBox.Name = "sortCheckBox";
            this.sortCheckBox.Size = new System.Drawing.Size(197, 19);
            this.sortCheckBox.TabIndex = 3;
            this.sortCheckBox.Text = "Сортировать по инвентарному";
            this.sortCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 411);
            this.Controls.Add(this.sortCheckBox);
            this.Controls.Add(this.watchBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.tabControl.ResumeLayout(false);
            this.bookPage.ResumeLayout(false);
            this.bookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPagesNumericUpDown)).EndInit();
            this.magazinePage.ResumeLayout(false);
            this.magazinePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMagNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeMagNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMagNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearMagNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl;
        private TabPage bookPage;
        private Button addBtn;
        private CheckBox backCheckBox;
        private CheckBox availabilityCheckBox;
        private NumericUpDown periodNumericUpDown;
        private Label periodLabel;
        private NumericUpDown inventoryNumericUpDown;
        private Label inventoryLabel;
        private NumericUpDown yearNumericUpDown;
        private NumericUpDown numberPagesNumericUpDown;
        private Label yearLabel;
        private Label numberPagesLabel;
        private TextBox publishingTextBox;
        private Label publishingLabel;
        private TextBox titleTextBox;
        private Label titleLabel;
        private TextBox authorTextBox;
        private Label authorLabel;
        private TabPage magazinePage;
        private RichTextBox richTextBox;
        private Button watchBtn;
        private CheckBox sortCheckBox;
        private Label volumeMagLabel;
        private Label numberMagLabel;
        private TextBox titleMagTextBox;
        private Label titleMagLabel;
        private NumericUpDown yearMagNumericUpDown;
        private Label yearMagLabel;
        private NumericUpDown inventoryMagNumericUpDown;
        private Label inventoryMagLabel;
        private CheckBox subMagCheckBox;
        private CheckBox availabilityMagCheckBox;
        private Button addMagBtn;
        private NumericUpDown numberMagNumericUpDown;
        private NumericUpDown volumeMagNumericUpDown;
    }
}