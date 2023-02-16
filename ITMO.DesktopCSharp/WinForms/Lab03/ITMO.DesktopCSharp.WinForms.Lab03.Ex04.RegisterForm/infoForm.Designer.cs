namespace ITMO.DesktopCSharp.WinForms.Lab03.Ex04.RegisterForm
{
    partial class infoForm
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
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(384, 261);
            this.infoRichTextBox.TabIndex = 0;
            this.infoRichTextBox.Text = "";
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.infoRichTextBox);
            this.Name = "infoForm";
            this.Text = "Информация о пользователях";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox infoRichTextBox;
    }
}