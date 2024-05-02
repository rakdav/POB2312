namespace Lesson35._2
{
    public partial class Form1 : Form
    {
        private bool fd = true;//ждем первого числа
        private double ac;
        private string op;
        public Form1()
        {
            InitializeComponent();
            ac = 0;
            op = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Del")
            {
                lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1, 1);
                if (lbResult.Text.Length == 0)
                {
                    lbResult.Text = "0";
                    fd = true;
                }
                return;
            }
            if (char.Parse(btn.Text) >= '1' && char.Parse(btn.Text) <= '9')
            {
                if (op != "") lbResult.Text = "";
                if (fd)
                {
                    lbResult.Text = btn.Text;
                    fd = false;
                }
                else lbResult.Text += btn.Text;
                return;
            }
            if (char.Parse(btn.Text) == '0')
            {
                if (op != "") lbResult.Text = "";
                if (fd) lbResult.Text = btn.Text;
                if (lbResult.Text != "0") lbResult.Text += btn.Text;
                return;
            }
            if (btn.Text == ",")
            {
                if (op != "") lbResult.Text = "";
                if (fd)
                {
                    lbResult.Text = "0,";
                    fd = false;
                }
                else
                {
                    if (lbResult.Text.IndexOf(",") == -1)
                        lbResult.Text += btn.Text;
                }
                return;
            }
            if (char.Parse(btn.Text) == 'C')
            {
                ac = 0;
                fd = true;
                lbResult.Text = "0";
                return;
            }
            if (char.Parse(btn.Text) == '+'||
                char.Parse(btn.Text) == '-'||
                char.Parse(btn.Text) == '*'||
                char.Parse(btn.Text) == '/'||
                char.Parse(btn.Text) == '=')
            {
                double n=0;
                if(fd==false) n = double.Parse(lbResult.Text);
                if (ac == 0)
                {
                    ac = n;
                }
                else
                {
                    switch (char.Parse(btn.Text))
                    {
                        case '+': { ac += n; op = "+"; } break;
                        case '-': { ac -= n; op = "-"; } break;
                        case '=':
                            {
                                switch (op)
                                {
                                    case "+": { ac += n; } break;
                                    case "-": { ac -= n; } break;
                                }
                                op = "";
                            }
                            break;
                    }
                    lbResult.Text = ac.ToString("N");
                }
                fd = true;
            }
        }
    }
}