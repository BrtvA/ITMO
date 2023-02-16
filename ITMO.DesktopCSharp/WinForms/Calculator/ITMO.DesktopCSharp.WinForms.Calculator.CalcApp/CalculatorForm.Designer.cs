namespace ITMO.DesktopCSharp.WinForms.Calculator.CalcApp
{
    partial class CalculatorForm
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
            this.components = new System.ComponentModel.Container();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyPow = new System.Windows.Forms.Button();
            this.KeySquare = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyCubrt = new System.Windows.Forms.Button();
            this.KeyInverse = new System.Windows.Forms.Button();
            this.KeyQuadraticEquation = new System.Windows.Forms.Button();
            this.KeyFactorial = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.Black;
            this.VersionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.VersionInfo.Enabled = false;
            this.VersionInfo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.VersionInfo.ForeColor = System.Drawing.Color.White;
            this.VersionInfo.Location = new System.Drawing.Point(0, 24);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(329, 29);
            this.VersionInfo.TabIndex = 1;
            this.VersionInfo.Text = "Version";
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.Black;
            this.OutputDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputDisplay.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputDisplay.ForeColor = System.Drawing.Color.White;
            this.OutputDisplay.Location = new System.Drawing.Point(0, 53);
            this.OutputDisplay.Multiline = true;
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputDisplay.Size = new System.Drawing.Size(329, 68);
            this.OutputDisplay.TabIndex = 2;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.Text = "123";
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OutputDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutputDisplay_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.KeyDate);
            this.flowLayoutPanel1.Controls.Add(this.KeyClear);
            this.flowLayoutPanel1.Controls.Add(this.KeyDivide);
            this.flowLayoutPanel1.Controls.Add(this.KeySeven);
            this.flowLayoutPanel1.Controls.Add(this.KeyEight);
            this.flowLayoutPanel1.Controls.Add(this.KeyNine);
            this.flowLayoutPanel1.Controls.Add(this.KeyMultiply);
            this.flowLayoutPanel1.Controls.Add(this.KeyFour);
            this.flowLayoutPanel1.Controls.Add(this.KeyFive);
            this.flowLayoutPanel1.Controls.Add(this.KeySix);
            this.flowLayoutPanel1.Controls.Add(this.KeyMinus);
            this.flowLayoutPanel1.Controls.Add(this.KeyOne);
            this.flowLayoutPanel1.Controls.Add(this.KeyTwo);
            this.flowLayoutPanel1.Controls.Add(this.KeyThree);
            this.flowLayoutPanel1.Controls.Add(this.KeyPlus);
            this.flowLayoutPanel1.Controls.Add(this.KeyZero);
            this.flowLayoutPanel1.Controls.Add(this.KeyPoint);
            this.flowLayoutPanel1.Controls.Add(this.KeySign);
            this.flowLayoutPanel1.Controls.Add(this.KeyEqual);
            this.flowLayoutPanel1.Controls.Add(this.KeyPow);
            this.flowLayoutPanel1.Controls.Add(this.KeySquare);
            this.flowLayoutPanel1.Controls.Add(this.KeySqrt);
            this.flowLayoutPanel1.Controls.Add(this.KeyCubrt);
            this.flowLayoutPanel1.Controls.Add(this.KeyInverse);
            this.flowLayoutPanel1.Controls.Add(this.KeyQuadraticEquation);
            this.flowLayoutPanel1.Controls.Add(this.KeyFactorial);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 411);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // KeyDate
            // 
            this.KeyDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyDate.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyDate.ForeColor = System.Drawing.Color.White;
            this.KeyDate.Location = new System.Drawing.Point(3, 3);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(156, 75);
            this.KeyDate.TabIndex = 1;
            this.KeyDate.Tag = "1";
            this.KeyDate.Text = "Date";
            this.toolTip.SetToolTip(this.KeyDate, "Show current date and time");
            this.KeyDate.UseVisualStyleBackColor = false;
            this.KeyDate.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyClear.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyClear.ForeColor = System.Drawing.Color.White;
            this.KeyClear.Location = new System.Drawing.Point(165, 3);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(75, 75);
            this.KeyClear.TabIndex = 2;
            this.KeyClear.Tag = "2";
            this.KeyClear.Text = "C";
            this.toolTip.SetToolTip(this.KeyClear, "Clear display");
            this.KeyClear.UseVisualStyleBackColor = false;
            this.KeyClear.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyDivide.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyDivide.ForeColor = System.Drawing.Color.White;
            this.KeyDivide.Location = new System.Drawing.Point(246, 3);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(75, 75);
            this.KeyDivide.TabIndex = 3;
            this.KeyDivide.Tag = "3";
            this.KeyDivide.Text = "/";
            this.toolTip.SetToolTip(this.KeyDivide, "Division");
            this.KeyDivide.UseVisualStyleBackColor = false;
            this.KeyDivide.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.BackColor = System.Drawing.Color.Gray;
            this.KeySeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySeven.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySeven.ForeColor = System.Drawing.Color.White;
            this.KeySeven.Location = new System.Drawing.Point(3, 84);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(75, 75);
            this.KeySeven.TabIndex = 4;
            this.KeySeven.Tag = "4";
            this.KeySeven.Text = "7";
            this.KeySeven.UseVisualStyleBackColor = false;
            this.KeySeven.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.BackColor = System.Drawing.Color.Gray;
            this.KeyEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyEight.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyEight.ForeColor = System.Drawing.Color.White;
            this.KeyEight.Location = new System.Drawing.Point(84, 84);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(75, 75);
            this.KeyEight.TabIndex = 5;
            this.KeyEight.Tag = "5";
            this.KeyEight.Text = "8";
            this.KeyEight.UseVisualStyleBackColor = false;
            this.KeyEight.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.BackColor = System.Drawing.Color.Gray;
            this.KeyNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyNine.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyNine.ForeColor = System.Drawing.Color.White;
            this.KeyNine.Location = new System.Drawing.Point(165, 84);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(75, 75);
            this.KeyNine.TabIndex = 6;
            this.KeyNine.Tag = "6";
            this.KeyNine.Text = "9";
            this.KeyNine.UseVisualStyleBackColor = false;
            this.KeyNine.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyMultiply.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyMultiply.ForeColor = System.Drawing.Color.White;
            this.KeyMultiply.Location = new System.Drawing.Point(246, 84);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(75, 75);
            this.KeyMultiply.TabIndex = 7;
            this.KeyMultiply.Tag = "7";
            this.KeyMultiply.Text = "X";
            this.toolTip.SetToolTip(this.KeyMultiply, "Multiplication");
            this.KeyMultiply.UseVisualStyleBackColor = false;
            this.KeyMultiply.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.BackColor = System.Drawing.Color.Gray;
            this.KeyFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyFour.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyFour.ForeColor = System.Drawing.Color.White;
            this.KeyFour.Location = new System.Drawing.Point(3, 165);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(75, 75);
            this.KeyFour.TabIndex = 8;
            this.KeyFour.Tag = "8";
            this.KeyFour.Text = "4";
            this.KeyFour.UseVisualStyleBackColor = false;
            this.KeyFour.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.BackColor = System.Drawing.Color.Gray;
            this.KeyFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyFive.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyFive.ForeColor = System.Drawing.Color.White;
            this.KeyFive.Location = new System.Drawing.Point(84, 165);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(75, 75);
            this.KeyFive.TabIndex = 9;
            this.KeyFive.Tag = "9";
            this.KeyFive.Text = "5";
            this.KeyFive.UseVisualStyleBackColor = false;
            this.KeyFive.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeySix
            // 
            this.KeySix.BackColor = System.Drawing.Color.Gray;
            this.KeySix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySix.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySix.ForeColor = System.Drawing.Color.White;
            this.KeySix.Location = new System.Drawing.Point(165, 165);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(75, 75);
            this.KeySix.TabIndex = 10;
            this.KeySix.Tag = "10";
            this.KeySix.Text = "6";
            this.KeySix.UseVisualStyleBackColor = false;
            this.KeySix.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyMinus
            // 
            this.KeyMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyMinus.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyMinus.ForeColor = System.Drawing.Color.White;
            this.KeyMinus.Location = new System.Drawing.Point(246, 165);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(75, 75);
            this.KeyMinus.TabIndex = 11;
            this.KeyMinus.Tag = "11";
            this.KeyMinus.Text = "-";
            this.toolTip.SetToolTip(this.KeyMinus, "Subtraction");
            this.KeyMinus.UseVisualStyleBackColor = false;
            this.KeyMinus.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.BackColor = System.Drawing.Color.Gray;
            this.KeyOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyOne.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyOne.ForeColor = System.Drawing.Color.White;
            this.KeyOne.Location = new System.Drawing.Point(3, 246);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(75, 75);
            this.KeyOne.TabIndex = 12;
            this.KeyOne.Tag = "12";
            this.KeyOne.Text = "1";
            this.KeyOne.UseVisualStyleBackColor = false;
            this.KeyOne.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.BackColor = System.Drawing.Color.Gray;
            this.KeyTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyTwo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyTwo.ForeColor = System.Drawing.Color.White;
            this.KeyTwo.Location = new System.Drawing.Point(84, 246);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(75, 75);
            this.KeyTwo.TabIndex = 13;
            this.KeyTwo.Tag = "13";
            this.KeyTwo.Text = "2";
            this.KeyTwo.UseVisualStyleBackColor = false;
            this.KeyTwo.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.BackColor = System.Drawing.Color.Gray;
            this.KeyThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyThree.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyThree.ForeColor = System.Drawing.Color.White;
            this.KeyThree.Location = new System.Drawing.Point(165, 246);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(75, 75);
            this.KeyThree.TabIndex = 14;
            this.KeyThree.Tag = "14";
            this.KeyThree.Text = "3";
            this.KeyThree.UseVisualStyleBackColor = false;
            this.KeyThree.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyPlus.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPlus.ForeColor = System.Drawing.Color.White;
            this.KeyPlus.Location = new System.Drawing.Point(246, 246);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(75, 75);
            this.KeyPlus.TabIndex = 15;
            this.KeyPlus.Tag = "15";
            this.KeyPlus.Text = "+";
            this.toolTip.SetToolTip(this.KeyPlus, "Addition");
            this.KeyPlus.UseVisualStyleBackColor = false;
            this.KeyPlus.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.BackColor = System.Drawing.Color.Gray;
            this.KeyZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyZero.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyZero.ForeColor = System.Drawing.Color.White;
            this.KeyZero.Location = new System.Drawing.Point(3, 327);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(75, 75);
            this.KeyZero.TabIndex = 16;
            this.KeyZero.Tag = "16";
            this.KeyZero.Text = "0";
            this.KeyZero.UseVisualStyleBackColor = false;
            this.KeyZero.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.BackColor = System.Drawing.Color.Gray;
            this.KeyPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyPoint.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPoint.ForeColor = System.Drawing.Color.White;
            this.KeyPoint.Location = new System.Drawing.Point(84, 327);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(75, 75);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.Tag = "17";
            this.KeyPoint.Text = ".";
            this.toolTip.SetToolTip(this.KeyPoint, "Decimal separator");
            this.KeyPoint.UseVisualStyleBackColor = false;
            this.KeyPoint.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeySign
            // 
            this.KeySign.BackColor = System.Drawing.Color.Gray;
            this.KeySign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySign.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySign.ForeColor = System.Drawing.Color.White;
            this.KeySign.Location = new System.Drawing.Point(165, 327);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(75, 75);
            this.KeySign.TabIndex = 18;
            this.KeySign.Tag = "18";
            this.KeySign.Text = "+/-";
            this.toolTip.SetToolTip(this.KeySign, " Sign change");
            this.KeySign.UseVisualStyleBackColor = false;
            this.KeySign.Click += new System.EventHandler(this.KeyStandart_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.KeyEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyEqual.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyEqual.ForeColor = System.Drawing.Color.White;
            this.KeyEqual.Location = new System.Drawing.Point(246, 327);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(75, 75);
            this.KeyEqual.TabIndex = 19;
            this.KeyEqual.Tag = "19";
            this.KeyEqual.Text = "=";
            this.toolTip.SetToolTip(this.KeyEqual, "Get result");
            this.KeyEqual.UseVisualStyleBackColor = false;
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_ClickAsync);
            // 
            // KeyPow
            // 
            this.KeyPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyPow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyPow.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPow.ForeColor = System.Drawing.Color.White;
            this.KeyPow.Location = new System.Drawing.Point(3, 408);
            this.KeyPow.Name = "KeyPow";
            this.KeyPow.Size = new System.Drawing.Size(75, 75);
            this.KeyPow.TabIndex = 20;
            this.KeyPow.Tag = "20";
            this.KeyPow.Text = "^";
            this.toolTip.SetToolTip(this.KeyPow, "Raising a number to a power");
            this.KeyPow.UseVisualStyleBackColor = false;
            this.KeyPow.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeySquare
            // 
            this.KeySquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeySquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySquare.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySquare.ForeColor = System.Drawing.Color.White;
            this.KeySquare.Location = new System.Drawing.Point(84, 408);
            this.KeySquare.Name = "KeySquare";
            this.KeySquare.Size = new System.Drawing.Size(75, 75);
            this.KeySquare.TabIndex = 21;
            this.KeySquare.Tag = "21";
            this.KeySquare.Text = "^2";
            this.toolTip.SetToolTip(this.KeySquare, "Raising a number to a power of 2");
            this.KeySquare.UseVisualStyleBackColor = false;
            this.KeySquare.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeySqrt
            // 
            this.KeySqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeySqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySqrt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeySqrt.ForeColor = System.Drawing.Color.White;
            this.KeySqrt.Location = new System.Drawing.Point(165, 408);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(75, 75);
            this.KeySqrt.TabIndex = 22;
            this.KeySqrt.Tag = "22";
            this.KeySqrt.Text = "√";
            this.toolTip.SetToolTip(this.KeySqrt, "Get the square root of a number");
            this.KeySqrt.UseVisualStyleBackColor = false;
            this.KeySqrt.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeyCubrt
            // 
            this.KeyCubrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyCubrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyCubrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyCubrt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyCubrt.ForeColor = System.Drawing.Color.White;
            this.KeyCubrt.Location = new System.Drawing.Point(246, 408);
            this.KeyCubrt.Name = "KeyCubrt";
            this.KeyCubrt.Size = new System.Drawing.Size(75, 75);
            this.KeyCubrt.TabIndex = 23;
            this.KeyCubrt.Tag = "23";
            this.KeyCubrt.Text = "∛";
            this.toolTip.SetToolTip(this.KeyCubrt, "Get the cube root of a number");
            this.KeyCubrt.UseVisualStyleBackColor = false;
            this.KeyCubrt.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeyInverse
            // 
            this.KeyInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyInverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyInverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyInverse.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyInverse.ForeColor = System.Drawing.Color.White;
            this.KeyInverse.Location = new System.Drawing.Point(3, 489);
            this.KeyInverse.Name = "KeyInverse";
            this.KeyInverse.Size = new System.Drawing.Size(75, 75);
            this.KeyInverse.TabIndex = 24;
            this.KeyInverse.Tag = "24";
            this.KeyInverse.Text = "1/x";
            this.toolTip.SetToolTip(this.KeyInverse, "Get the inversion");
            this.KeyInverse.UseVisualStyleBackColor = false;
            this.KeyInverse.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeyQuadraticEquation
            // 
            this.KeyQuadraticEquation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyQuadraticEquation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyQuadraticEquation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyQuadraticEquation.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyQuadraticEquation.ForeColor = System.Drawing.Color.White;
            this.KeyQuadraticEquation.Location = new System.Drawing.Point(84, 489);
            this.KeyQuadraticEquation.Name = "KeyQuadraticEquation";
            this.KeyQuadraticEquation.Size = new System.Drawing.Size(156, 75);
            this.KeyQuadraticEquation.TabIndex = 25;
            this.KeyQuadraticEquation.Tag = "25";
            this.KeyQuadraticEquation.Text = "QE";
            this.toolTip.SetToolTip(this.KeyQuadraticEquation, "Open the dialog result for solving a quadratic equation");
            this.KeyQuadraticEquation.UseVisualStyleBackColor = false;
            this.KeyQuadraticEquation.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // KeyFactorial
            // 
            this.KeyFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyFactorial.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyFactorial.ForeColor = System.Drawing.Color.White;
            this.KeyFactorial.Location = new System.Drawing.Point(246, 489);
            this.KeyFactorial.Name = "KeyFactorial";
            this.KeyFactorial.Size = new System.Drawing.Size(75, 75);
            this.KeyFactorial.TabIndex = 26;
            this.KeyFactorial.Tag = "26";
            this.KeyFactorial.Text = "!";
            this.toolTip.SetToolTip(this.KeyFactorial, "Get the factorial of a number");
            this.KeyFactorial.UseVisualStyleBackColor = false;
            this.KeyFactorial.Click += new System.EventHandler(this.KeyAdditional_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.ExtensionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(329, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ExitToolStripMenuItem.Tag = "27";
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ExtensionToolStripMenuItem
            // 
            this.ExtensionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandartToolStripMenuItem,
            this.AdditionalToolStripMenuItem});
            this.ExtensionToolStripMenuItem.Name = "ExtensionToolStripMenuItem";
            this.ExtensionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ExtensionToolStripMenuItem.Text = "&Extension";
            // 
            // StandartToolStripMenuItem
            // 
            this.StandartToolStripMenuItem.Name = "StandartToolStripMenuItem";
            this.StandartToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.StandartToolStripMenuItem.Tag = "28";
            this.StandartToolStripMenuItem.Text = "Standart";
            this.StandartToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // AdditionalToolStripMenuItem
            // 
            this.AdditionalToolStripMenuItem.Name = "AdditionalToolStripMenuItem";
            this.AdditionalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.AdditionalToolStripMenuItem.Tag = "29";
            this.AdditionalToolStripMenuItem.Text = "Additional";
            this.AdditionalToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(329, 532);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox VersionInfo;
        private TextBox OutputDisplay;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button KeyDate;
        private Button KeyClear;
        private Button KeyDivide;
        private Button KeySeven;
        private Button KeyEight;
        private Button KeyNine;
        private Button KeyMultiply;
        private Button KeyFour;
        private Button KeyFive;
        private Button KeySix;
        private Button KeyMinus;
        private Button KeyOne;
        private Button KeyTwo;
        private Button KeyThree;
        private Button KeyPlus;
        private Button KeyZero;
        private Button KeyPoint;
        private Button KeySign;
        private Button KeyEqual;
        private Button KeyPow;
        private Button KeySquare;
        private Button KeySqrt;
        private Button KeyCubrt;
        private Button KeyInverse;
        private Button KeyQuadraticEquation;
        private Button KeyFactorial;
        private MenuStrip menuStrip;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ExtensionToolStripMenuItem;
        private ToolStripMenuItem StandartToolStripMenuItem;
        private ToolStripMenuItem AdditionalToolStripMenuItem;
        private ToolTip toolTip;
    }
}