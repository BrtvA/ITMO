namespace ITMO.DesktopCSharp.WinForms.Calculator.CalcApp
{
    partial class QuadraticEquationForm
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
            this.eq1Label = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.eq2Label = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.qe3Label = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.titleQELabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eq1Label
            // 
            this.eq1Label.AutoSize = true;
            this.eq1Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eq1Label.ForeColor = System.Drawing.Color.White;
            this.eq1Label.Location = new System.Drawing.Point(113, 47);
            this.eq1Label.Name = "eq1Label";
            this.eq1Label.Size = new System.Drawing.Size(59, 23);
            this.eq1Label.TabIndex = 0;
            this.eq1Label.Text = "*x^2 +";
            // 
            // aTextBox
            // 
            this.aTextBox.BackColor = System.Drawing.Color.Black;
            this.aTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aTextBox.ForeColor = System.Drawing.Color.White;
            this.aTextBox.Location = new System.Drawing.Point(8, 44);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 31);
            this.aTextBox.TabIndex = 1;
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.сoefficientTextBox_KeyPress);
            // 
            // eq2Label
            // 
            this.eq2Label.AutoSize = true;
            this.eq2Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eq2Label.ForeColor = System.Drawing.Color.White;
            this.eq2Label.Location = new System.Drawing.Point(284, 47);
            this.eq2Label.Name = "eq2Label";
            this.eq2Label.Size = new System.Drawing.Size(40, 23);
            this.eq2Label.TabIndex = 2;
            this.eq2Label.Text = "*x +";
            // 
            // bTextBox
            // 
            this.bTextBox.BackColor = System.Drawing.Color.Black;
            this.bTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTextBox.ForeColor = System.Drawing.Color.White;
            this.bTextBox.Location = new System.Drawing.Point(178, 44);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 31);
            this.bTextBox.TabIndex = 3;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.сoefficientTextBox_KeyPress);
            // 
            // qe3Label
            // 
            this.qe3Label.AutoSize = true;
            this.qe3Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qe3Label.ForeColor = System.Drawing.Color.White;
            this.qe3Label.Location = new System.Drawing.Point(436, 47);
            this.qe3Label.Name = "qe3Label";
            this.qe3Label.Size = new System.Drawing.Size(37, 23);
            this.qe3Label.TabIndex = 4;
            this.qe3Label.Text = " = 0";
            // 
            // cTextBox
            // 
            this.cTextBox.BackColor = System.Drawing.Color.Black;
            this.cTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cTextBox.ForeColor = System.Drawing.Color.White;
            this.cTextBox.Location = new System.Drawing.Point(330, 44);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 31);
            this.cTextBox.TabIndex = 5;
            this.cTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.сoefficientTextBox_KeyPress);
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcBtn.ForeColor = System.Drawing.Color.White;
            this.calcBtn.Location = new System.Drawing.Point(52, 86);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(103, 35);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Solve";
            this.calcBtn.UseVisualStyleBackColor = false;
            // 
            // titleQELabel
            // 
            this.titleQELabel.AutoSize = true;
            this.titleQELabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleQELabel.ForeColor = System.Drawing.Color.White;
            this.titleQELabel.Location = new System.Drawing.Point(12, 9);
            this.titleQELabel.Name = "titleQELabel";
            this.titleQELabel.Size = new System.Drawing.Size(376, 23);
            this.titleQELabel.TabIndex = 7;
            this.titleQELabel.Text = "Enter the coefficients of the quadratic equation:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(330, 86);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 35);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // QuadraticEquationForm
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 134);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.titleQELabel);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.qe3Label);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.eq2Label);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.eq1Label);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuadraticEquationForm";
            this.ShowInTaskbar = false;
            this.Text = "Quadratic equation";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label eq1Label;
        private TextBox aTextBox;
        private Label eq2Label;
        private TextBox bTextBox;
        private Label qe3Label;
        private TextBox cTextBox;
        private Button calcBtn;
        private Label titleQELabel;
        private Button cancelBtn;
    }
}