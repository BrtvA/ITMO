namespace ITMO.DesktopCSharp.WinForms.Lab01.Ex01
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
            this.borderBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.opacityBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borderBtn
            // 
            this.borderBtn.Location = new System.Drawing.Point(12, 12);
            this.borderBtn.Name = "borderBtn";
            this.borderBtn.Size = new System.Drawing.Size(75, 46);
            this.borderBtn.TabIndex = 0;
            this.borderBtn.Text = "Border Style";
            this.borderBtn.UseVisualStyleBackColor = true;
            this.borderBtn.Click += new System.EventHandler(this.borderBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Location = new System.Drawing.Point(122, 12);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(75, 23);
            this.resizeBtn.TabIndex = 1;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // opacityBtn
            // 
            this.opacityBtn.Location = new System.Drawing.Point(122, 56);
            this.opacityBtn.Name = "opacityBtn";
            this.opacityBtn.Size = new System.Drawing.Size(75, 23);
            this.opacityBtn.TabIndex = 2;
            this.opacityBtn.Text = "Opacity";
            this.opacityBtn.UseVisualStyleBackColor = true;
            this.opacityBtn.Click += new System.EventHandler(this.opacityBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 104);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Open Form";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.opacityBtn);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.borderBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private Button borderBtn;
        private Button resizeBtn;
        private Button opacityBtn;
        private Button openBtn;
    }
}