namespace ITMO.DesktopCSharp.WinForms.Lab02.Ex08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(16, 96);
                lbl.Size = new System.Drawing.Size(32, 23);
                lbl.Name = "labelll";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBox.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox.Controls.Add(txt);

                txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinTextBox_KeyPress);
            }
            else
            {
                int lcv;
                lcv = groupBox.Controls.Count;// определяется количество элементов
                while (lcv > 4)
                {
                    groupBox.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(nameTextBox, "Must be letter");
                MessageBox.Show("Поле Name не может содержать цифры");
            }
        }

        private void pinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }
        }

        private void pinTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (pinTextBox.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(pinTextBox.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Поле PIN не может содержать буквы");
                }
            }
        }
    }
}