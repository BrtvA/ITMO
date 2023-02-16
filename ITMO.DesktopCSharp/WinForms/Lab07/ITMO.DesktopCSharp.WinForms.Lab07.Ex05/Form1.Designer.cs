namespace ITMO.DesktopCSharp.WinForms.Lab07.Ex05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.caclBtn = new System.Windows.Forms.Button();
            this.maxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимально возможное число в последовательности:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Последовательность простых чисел:";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox.Location = new System.Drawing.Point(0, 141);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(341, 281);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // caclBtn
            // 
            this.caclBtn.Location = new System.Drawing.Point(12, 76);
            this.caclBtn.Name = "caclBtn";
            this.caclBtn.Size = new System.Drawing.Size(86, 23);
            this.caclBtn.TabIndex = 4;
            this.caclBtn.Text = "Определить";
            this.caclBtn.UseVisualStyleBackColor = true;
            this.caclBtn.Click += new System.EventHandler(this.caclBtn_Click);
            // 
            // maxNumber
            // 
            this.maxNumber.Location = new System.Drawing.Point(46, 36);
            this.maxNumber.Name = "maxNumber";
            this.maxNumber.Size = new System.Drawing.Size(100, 23);
            this.maxNumber.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 422);
            this.Controls.Add(this.maxNumber);
            this.Controls.Add(this.caclBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Алгоритм Эратосфена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox;
        private Button caclBtn;
        private TextBox maxNumber;
    }
}