namespace Lesson32._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double MILLS = 1.62;
            double mark;
            double.TryParse(tbMark.Text, out mark);
            if (chbMark.Checked)
            {
                lbResult.Text = $"{mark} км={mark / MILLS:F2} миль";
            }
            else
            {
                lbResult.Text = $"{mark} миль ={mark * MILLS:F2} км";
            }
            tbMark.Focus();
        }

        private void chbMark_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMark.Checked)
            {
                chbMark.Text = "километры->мили";
                lbMark.Text = "километры";
            }
            else
            {
                chbMark.Text = "мили->километры";
                lbMark.Text = "мили";
            }
        }

        private void tbMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbMark.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btMark.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void tbMark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbMark.Text.Length > 0)
                {
                    if (double.Parse(tbMark.Text) > double.MaxValue)
                        throw new Exception("Число выходит за границы");
                    else button1_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}