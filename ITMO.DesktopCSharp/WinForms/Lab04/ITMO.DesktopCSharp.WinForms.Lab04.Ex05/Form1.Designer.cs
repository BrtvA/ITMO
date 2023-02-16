namespace ITMO.DesktopCSharp.WinForms.Lab04.Ex05
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.setIntervalBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 21);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(223, 15);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Значение функции sin(x) на интервале:";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 57);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(0, 15);
            this.intervalLabel.TabIndex = 1;
            // 
            // setIntervalBtn
            // 
            this.setIntervalBtn.Location = new System.Drawing.Point(190, 83);
            this.setIntervalBtn.Name = "setIntervalBtn";
            this.setIntervalBtn.Size = new System.Drawing.Size(75, 53);
            this.setIntervalBtn.TabIndex = 2;
            this.setIntervalBtn.Text = "Задать интервал";
            this.setIntervalBtn.UseVisualStyleBackColor = true;
            this.setIntervalBtn.Click += new System.EventHandler(this.setIntervalBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 152);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 247);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.setIntervalBtn);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.descriptionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sin(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label descriptionLabel;
        private Label intervalLabel;
        private Button setIntervalBtn;
        private RichTextBox richTextBox1;
    }
}