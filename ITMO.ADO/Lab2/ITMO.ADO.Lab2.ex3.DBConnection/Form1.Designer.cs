namespace ITMO.ADO.Lab2.ex3.DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listConnectionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productCountBtn = new System.Windows.Forms.Button();
            this.productCountLbl = new System.Windows.Forms.Label();
            this.productListBtn = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenu,
            this.disconnectMenu,
            this.listConnectionMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectMenu
            // 
            this.connectMenu.Name = "connectMenu";
            this.connectMenu.Size = new System.Drawing.Size(128, 20);
            this.connectMenu.Text = "Подключиться к БД";
            this.connectMenu.Click += new System.EventHandler(this.connectMenu_Click);
            // 
            // disconnectMenu
            // 
            this.disconnectMenu.Name = "disconnectMenu";
            this.disconnectMenu.Size = new System.Drawing.Size(126, 20);
            this.disconnectMenu.Text = "Отключиться от БД";
            this.disconnectMenu.Click += new System.EventHandler(this.disconnectMenu_Click);
            // 
            // listConnectionMenu
            // 
            this.listConnectionMenu.Name = "listConnectionMenu";
            this.listConnectionMenu.Size = new System.Drawing.Size(140, 20);
            this.listConnectionMenu.Text = "Список подключений";
            this.listConnectionMenu.Click += new System.EventHandler(this.listConnectionMenu_Click);
            // 
            // productCountBtn
            // 
            this.productCountBtn.Location = new System.Drawing.Point(12, 36);
            this.productCountBtn.Name = "productCountBtn";
            this.productCountBtn.Size = new System.Drawing.Size(78, 41);
            this.productCountBtn.TabIndex = 1;
            this.productCountBtn.Text = "Сколько продуктов";
            this.productCountBtn.UseVisualStyleBackColor = true;
            this.productCountBtn.Click += new System.EventHandler(this.productCountBtn_Click);
            // 
            // productCountLbl
            // 
            this.productCountLbl.AutoSize = true;
            this.productCountLbl.Location = new System.Drawing.Point(109, 49);
            this.productCountLbl.Name = "productCountLbl";
            this.productCountLbl.Size = new System.Drawing.Size(114, 15);
            this.productCountLbl.TabIndex = 2;
            this.productCountLbl.Text = "Сколько продуктов";
            // 
            // productListBtn
            // 
            this.productListBtn.Location = new System.Drawing.Point(15, 83);
            this.productListBtn.Name = "productListBtn";
            this.productListBtn.Size = new System.Drawing.Size(75, 42);
            this.productListBtn.TabIndex = 3;
            this.productListBtn.Text = "Список продуктов";
            this.productListBtn.UseVisualStyleBackColor = true;
            this.productListBtn.Click += new System.EventHandler(this.productListBtn_Click);
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.productListView.Location = new System.Drawing.Point(109, 83);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(180, 170);
            this.productListView.TabIndex = 4;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 120;
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(305, 41);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(88, 23);
            this.transactionBtn.TabIndex = 5;
            this.transactionBtn.Text = "Транзакция";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 271);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.productListBtn);
            this.Controls.Add(this.productCountLbl);
            this.Controls.Add(this.productCountBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectMenu;
        private ToolStripMenuItem disconnectMenu;
        private ToolStripMenuItem listConnectionMenu;
        private Button productCountBtn;
        private Label productCountLbl;
        private Button productListBtn;
        private ListView productListView;
        private ColumnHeader columnHeader1;
        private Button transactionBtn;
    }
}