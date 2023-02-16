namespace ITMO.ADO.Lab6.ex2.LoadDataSetXml
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.loadSchemaButton = new System.Windows.Forms.Button();
            this.loadDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGrid
            // 
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersGrid.Location = new System.Drawing.Point(0, 0);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.Size = new System.Drawing.Size(349, 450);
            this.customersGrid.TabIndex = 0;
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.ordersGrid.Location = new System.Drawing.Point(466, 0);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.Size = new System.Drawing.Size(334, 450);
            this.ordersGrid.TabIndex = 1;
            // 
            // loadSchemaButton
            // 
            this.loadSchemaButton.Location = new System.Drawing.Point(370, 12);
            this.loadSchemaButton.Name = "loadSchemaButton";
            this.loadSchemaButton.Size = new System.Drawing.Size(75, 41);
            this.loadSchemaButton.TabIndex = 2;
            this.loadSchemaButton.Text = "Load Schema";
            this.loadSchemaButton.UseVisualStyleBackColor = true;
            this.loadSchemaButton.Click += new System.EventHandler(this.loadSchemaButton_Click);
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(370, 78);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(75, 23);
            this.loadDataButton.TabIndex = 3;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.loadSchemaButton);
            this.Controls.Add(this.ordersGrid);
            this.Controls.Add(this.customersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.Button loadSchemaButton;
        private System.Windows.Forms.Button loadDataButton;
    }
}

