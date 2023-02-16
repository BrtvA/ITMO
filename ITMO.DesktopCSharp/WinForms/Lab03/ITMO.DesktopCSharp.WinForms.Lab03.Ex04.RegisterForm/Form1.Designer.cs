namespace ITMO.DesktopCSharp.WinForms.Lab03.Ex04.RegisterForm
{
    partial class Form1
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.loginRegisterBox = new ITMO.DesktopCSharp.WinForms.Lab03.Ex04.LibControl2.RegisterBox();
            this.pinRegisterBox = new ITMO.DesktopCSharp.WinForms.Lab03.Ex04.LibControl2.RegisterBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(83, 114);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(195, 24);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "Регистрация";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(31, 153);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(113, 62);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "Показать всех пользователей";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // loginRegisterBox
            // 
            this.loginRegisterBox.Location = new System.Drawing.Point(12, 12);
            this.loginRegisterBox.Name = "loginRegisterBox";
            this.loginRegisterBox.Size = new System.Drawing.Size(354, 40);
            this.loginRegisterBox.TabIndex = 4;
            this.loginRegisterBox.TextField = "";
            this.loginRegisterBox.TextTitle = "Логин";
            // 
            // pinRegisterBox
            // 
            this.pinRegisterBox.JustNumber = true;
            this.pinRegisterBox.Location = new System.Drawing.Point(12, 58);
            this.pinRegisterBox.Name = "pinRegisterBox";
            this.pinRegisterBox.Size = new System.Drawing.Size(354, 34);
            this.pinRegisterBox.TabIndex = 5;
            this.pinRegisterBox.TextField = "";
            this.pinRegisterBox.TextTitle = "PIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.pinRegisterBox);
            this.Controls.Add(this.loginRegisterBox);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.registerBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";
            this.ResumeLayout(false);

        }

        #endregion
        private Button registerBtn;
        private Button showBtn;
        private LibControl2.RegisterBox loginRegisterBox;
        private LibControl2.RegisterBox pinRegisterBox;
    }
}