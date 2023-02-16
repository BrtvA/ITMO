namespace ITMO.DesktopCSharp.WinForms.Lab04.Ex05
{
    partial class Form2
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
            this.intervalBoundaryLabel = new System.Windows.Forms.Label();
            this.transferDataBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.boundary2TextBox = new System.Windows.Forms.TextBox();
            this.boundary1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // intervalBoundaryLabel
            // 
            this.intervalBoundaryLabel.AutoSize = true;
            this.intervalBoundaryLabel.Location = new System.Drawing.Point(12, 18);
            this.intervalBoundaryLabel.Name = "intervalBoundaryLabel";
            this.intervalBoundaryLabel.Size = new System.Drawing.Size(116, 15);
            this.intervalBoundaryLabel.TabIndex = 0;
            this.intervalBoundaryLabel.Text = "Границы интервала";
            // 
            // transferDataBtn
            // 
            this.transferDataBtn.Location = new System.Drawing.Point(12, 106);
            this.transferDataBtn.Name = "transferDataBtn";
            this.transferDataBtn.Size = new System.Drawing.Size(116, 23);
            this.transferDataBtn.TabIndex = 3;
            this.transferDataBtn.Text = "Передать данные";
            this.transferDataBtn.UseVisualStyleBackColor = true;
            this.transferDataBtn.Click += new System.EventHandler(this.transferDataBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(150, 106);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отменить передачу";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // boundary2TextBox
            // 
            this.boundary2TextBox.Location = new System.Drawing.Point(150, 56);
            this.boundary2TextBox.Name = "boundary2TextBox";
            this.boundary2TextBox.Size = new System.Drawing.Size(116, 23);
            this.boundary2TextBox.TabIndex = 2;
            this.boundary2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boundaryTextBox_KeyPress);
            // 
            // boundary1TextBox
            // 
            this.boundary1TextBox.Location = new System.Drawing.Point(12, 56);
            this.boundary1TextBox.Name = "boundary1TextBox";
            this.boundary1TextBox.Size = new System.Drawing.Size(116, 23);
            this.boundary1TextBox.TabIndex = 1;
            this.boundary1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boundaryTextBox_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 144);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.transferDataBtn);
            this.Controls.Add(this.boundary2TextBox);
            this.Controls.Add(this.boundary1TextBox);
            this.Controls.Add(this.intervalBoundaryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "FormRange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label intervalBoundaryLabel;
        private Button transferDataBtn;
        private Button cancelBtn;
        private TextBox boundary2TextBox;
        private TextBox boundary1TextBox;
    }
}