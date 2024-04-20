namespace Lesson32._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb15x20.Checked = true;
            tb15x20.Enabled = true;
        }

        private void rb15x20_CheckedChanged(object sender, EventArgs e)
        {
            tb15x20.Enabled = true;
            tb10x15.Enabled = false;
            tb9x13.Enabled = false;
        }

        private void rb10x15_CheckedChanged(object sender, EventArgs e)
        {
            tb15x20.Enabled = false;
            tb10x15.Enabled = true;
            tb9x13.Enabled = false;
        }

        private void rb9x13_CheckedChanged(object sender, EventArgs e)
        {
            tb15x20.Enabled = false;
            tb10x15.Enabled = false;
            tb9x13.Enabled = true;
        }

        private void tb15x20_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb10x15.Clear();
            tb9x13.Clear();
            RadioClick(sender, e, tb15x20);
        }

        private void tb10x15_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb15x20.Clear();
            tb9x13.Clear();
            RadioClick(sender, e, tb10x15);
        }

        private void tb9x13_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb15x20.Clear();
            tb10x15.Clear();
            RadioClick(sender, e, tb9x13);
        }

        private void RadioClick(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tbCount.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void tbCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btOk.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (tb15x20.Enabled) price = double.Parse(tb15x20.Text);
            if (tb10x15.Enabled) price = double.Parse(tb10x15.Text);
            if (tb9x13.Enabled) price = double.Parse(tb9x13.Text);
            double total = price * int.Parse(tbCount.Text);
            lbResult.Text = total.ToString("c");
        }
    }
}