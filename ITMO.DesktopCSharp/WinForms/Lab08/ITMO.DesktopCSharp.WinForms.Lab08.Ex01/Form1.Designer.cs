namespace ITMO.DesktopCSharp.WinForms.Lab08.Ex01
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
            this.components = new System.ComponentModel.Container();
            this.personsListView = new System.Windows.Forms.ListView();
            this.firstNameHeader = new System.Windows.Forms.ColumnHeader();
            this.lastNameHeader = new System.Windows.Forms.ColumnHeader();
            this.ageHeader = new System.Windows.Forms.ColumnHeader();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.watchBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.toolTip1.SetToolTip(this.personsListView, "Список-таблица всех сотрудников");
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            this.personsListView.VirtualMode = true;
            this.personsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView_RetrieveVirtualItem);
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
            this.addBtn.Location = new System.Drawing.Point(75, 229);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.toolTip1.SetToolTip(this.addBtn, "Открытие формы для добавления сотрудника");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(265, 229);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(98, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Редактировать";
            this.toolTip1.SetToolTip(this.editBtn, "Открыть форму для редактирования данных о сотруднике");
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 315);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.toolTip1.SetToolTip(this.richTextBox1, "Поле для отображения информации о всех сотрудниках");
            // 
            // watchBtn
            // 
            this.watchBtn.Location = new System.Drawing.Point(75, 272);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(288, 23);
            this.watchBtn.TabIndex = 4;
            this.watchBtn.Text = "Посмотреть список";
            this.toolTip1.SetToolTip(this.watchBtn, "Вывести список всех сотрудников");
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.watchBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.personsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Список сотрудников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView personsListView;
        private ColumnHeader firstNameHeader;
        private ColumnHeader lastNameHeader;
        private ColumnHeader ageHeader;
        private Button addBtn;
        private Button editBtn;
        private RichTextBox richTextBox1;
        private Button watchBtn;
        private ToolTip toolTip1;
    }
}