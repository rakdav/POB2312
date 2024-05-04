namespace Lesson35._3
{
    public partial class Form1 : Form
    {
        private Converter converter; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Genaration genaration = new Genaration(int.Parse(tbFrom.Text),
                    int.Parse(tbUntil.Text));
                tbResult.Text = genaration.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter = new Converter(double.Parse(tbNumber.Text));
            switch (cbxLong.SelectedIndex)
            {
                case 0:lbResult.Text = converter.toSm().ToString("F5")+" сантиметр"; break;
                case 1:lbResult.Text = converter.toDm().ToString("F5") + " дециметр"; break;
                case 2: lbResult.Text = converter.toMetr().ToString("F5") + " метр"; break;
                case 3: lbResult.Text = converter.toKm().ToString("F5") + " километр"; break;
            }
        }
    }
}