namespace CalculadoraWinApp
{
    public partial class Form1 : Form
    {
        delegate void Adicionador(string num);
        private Adicionador adicionadorNum, adicionadorOp;
        private string num1, num2, operador;

        public Form1()
        {
            InitializeComponent();
            adicionadorNum = AdicionarAsVariaveis;
            adicionadorOp = AdicionarOperadores;
            Desabilitador();
        }

        public void Desabilitador()
        {
            bt_mais.Enabled = false;
            bt_menos.Enabled = false;
            bt_vezes.Enabled = false;
            bt_div.Enabled = false;
            bt_igual.Enabled = false;
        }

        private void AdicionarOperadores(string op)
        {
            tb_resultado.Text = tb_resultado.Text + op;
            operador = op;
        }

        private void AdicionarAsVariaveis(string num)
        {
            if (operador == null)
            {
                num1 = num1 + num;
                tb_resultado.Text = num1;

                bt_mais.Enabled = true;
                bt_menos.Enabled = true;
                bt_vezes.Enabled = true;
                bt_div.Enabled = true;

            }
            else
            {
                num2 = num2 + num;
                tb_resultado.Text = tb_resultado.Text + num;
                Desabilitador();
                bt_igual.Enabled = true;
            }
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            adicionadorNum("0");
        }

        private void bt_1_MouseClick(object sender, MouseEventArgs e)
        {
            adicionadorNum("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            adicionadorNum("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            adicionadorNum("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            adicionadorNum("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            adicionadorNum("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            adicionadorNum("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            adicionadorNum("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            adicionadorNum("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            adicionadorNum("9");
        }

        private void bt_menos_Click(object sender, EventArgs e)
        {
            adicionadorOp(" - ");
            Desabilitador();
        }

        private void bt_mais_Click(object sender, EventArgs e)
        {
            adicionadorOp(" + ");
            Desabilitador();
        }

        private void bt_vezes_Click(object sender, EventArgs e)
        {
            adicionadorOp(" X ");
            Desabilitador();
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            adicionadorOp(" / ");
            Desabilitador();
        }

        private void LimparCampos()
        {
            tb_resultado.Text = null;
            num1 = null;
            num2 = null;
            operador = null;
            Desabilitador();
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            int numConta1 = Convert.ToInt32(num1);
            int numConta2 = Convert.ToInt32(num2);

            switch (operador)
            {
                case " + ":
                    int soma = (numConta1 + numConta2);
                    tb_resultado.Text = tb_resultado.Text + " = " + Convert.ToString(soma);
                    break;

                case " - ":
                    int sub = (numConta1 - numConta2);
                    tb_resultado.Text = tb_resultado.Text + " = " + Convert.ToString(sub);
                    break;

                case " X ":
                    int mult = (numConta1 * numConta2);
                    tb_resultado.Text = tb_resultado.Text + " = " + Convert.ToString(mult);
                    break;

                case " / ":
                    int div = (numConta1 / numConta2);
                    tb_resultado.Text = tb_resultado.Text + " = " + Convert.ToString(div);
                    break;

            }

            lbox_historico.Items.Add(tb_resultado.Text);
            LimparCampos();
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}