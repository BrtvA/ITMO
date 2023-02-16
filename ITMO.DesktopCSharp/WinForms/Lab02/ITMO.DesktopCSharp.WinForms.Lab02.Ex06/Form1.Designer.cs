namespace ITMO.DesktopCSharp.WinForms.Lab02.Ex06
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.watchBtn = new System.Windows.Forms.Button();
            this.sortCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberPagesNumericUpDown)).BeginInit();
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
            this.magazinePage.Location = new System.Drawing.Point(4, 24);
            this.magazinePage.Name = "magazinePage";
            this.magazinePage.Padding = new System.Windows.Forms.Padding(3);
            this.magazinePage.Size = new System.Drawing.Size(265, 383);
            this.magazinePage.TabIndex = 1;
            this.magazinePage.Text = "Журналы";
            this.magazinePage.UseVisualStyleBackColor = true;
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
    }
}