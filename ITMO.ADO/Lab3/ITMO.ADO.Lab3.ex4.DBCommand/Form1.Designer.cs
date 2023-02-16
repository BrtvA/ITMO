namespace ITMO.ADO.Lab3.ex4.DBCommand
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.queryBtn = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.procedureBtn = new System.Windows.Forms.Button();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.createTableBtn = new System.Windows.Forms.Button();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.queryParamBtn = new System.Windows.Forms.Button();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.procedureParamBtn = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.ordYearTextBox = new System.Windows.Forms.TextBox();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(13, 109);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(85, 39);
            this.queryBtn.TabIndex = 0;
            this.queryBtn.Text = "Запрос данных";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(104, 109);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(282, 180);
            this.resultsTextBox.TabIndex = 2;
            this.resultsTextBox.Text = "";
            // 
            // procedureBtn
            // 
            this.procedureBtn.Location = new System.Drawing.Point(13, 154);
            this.procedureBtn.Name = "procedureBtn";
            this.procedureBtn.Size = new System.Drawing.Size(85, 36);
            this.procedureBtn.TabIndex = 3;
            this.procedureBtn.Text = "Вызов процедуры";
            this.procedureBtn.UseVisualStyleBackColor = true;
            this.procedureBtn.Click += new System.EventHandler(this.procedureBtn_Click);
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.Connection = this.sqlConnection1;
            // 
            // createTableBtn
            // 
            this.createTableBtn.Location = new System.Drawing.Point(13, 196);
            this.createTableBtn.Name = "createTableBtn";
            this.createTableBtn.Size = new System.Drawing.Size(85, 37);
            this.createTableBtn.TabIndex = 4;
            this.createTableBtn.Text = "Создание таблицы";
            this.createTableBtn.UseVisualStyleBackColor = true;
            this.createTableBtn.Click += new System.EventHandler(this.createTableBtn_Click);
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.Connection = this.sqlConnection1;
            // 
            // queryParamBtn
            // 
            this.queryParamBtn.Location = new System.Drawing.Point(12, 12);
            this.queryParamBtn.Name = "queryParamBtn";
            this.queryParamBtn.Size = new System.Drawing.Size(85, 39);
            this.queryParamBtn.TabIndex = 5;
            this.queryParamBtn.Text = "Запрос с параметром";
            this.queryParamBtn.UseVisualStyleBackColor = true;
            this.queryParamBtn.Click += new System.EventHandler(this.queryParamBtn_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(104, 22);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(282, 20);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.Text = "London";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT CustomerID, CompanyName, City FROM Customers WHERE City = @City";
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City")});
            // 
            // procedureParamBtn
            // 
            this.procedureParamBtn.Location = new System.Drawing.Point(13, 57);
            this.procedureParamBtn.Name = "procedureParamBtn";
            this.procedureParamBtn.Size = new System.Drawing.Size(84, 46);
            this.procedureParamBtn.TabIndex = 7;
            this.procedureParamBtn.Text = "Процедура с параметром";
            this.procedureParamBtn.UseVisualStyleBackColor = true;
            this.procedureParamBtn.Click += new System.EventHandler(this.procedureParamBtn_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(104, 57);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.categoryNameTextBox.TabIndex = 8;
            this.categoryNameTextBox.Text = "Beverages";
            // 
            // ordYearTextBox
            // 
            this.ordYearTextBox.Location = new System.Drawing.Point(104, 83);
            this.ordYearTextBox.Name = "ordYearTextBox";
            this.ordYearTextBox.Size = new System.Drawing.Size(282, 20);
            this.ordYearTextBox.TabIndex = 9;
            this.ordYearTextBox.Text = "1997";
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SalesByCategory";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NVarChar, 4)});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 300);
            this.Controls.Add(this.ordYearTextBox);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.procedureParamBtn);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.queryParamBtn);
            this.Controls.Add(this.createTableBtn);
            this.Controls.Add(this.procedureBtn);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.queryBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Button procedureBtn;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Button createTableBtn;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Button queryParamBtn;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Button procedureParamBtn;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox ordYearTextBox;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}

