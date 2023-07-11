namespace PedraPapelouTesoura_
{
    public partial class Form1 : Form
    {
        private string escolhaUsuario;
        private string escolhaMaquina;
        private string[] opcoes =
        {
            "pedra",
             "papel",
             "tesoura"
        };
        private int pontosUsuario, pontosMaquina;

        public Form1()
        {
            InitializeComponent();
        }
        private void SalvaSelecao(string selecao)
        {
            escolhaUsuario = selecao;
            txt_usuario.Text = escolhaUsuario;
            SorteioSelecaoComputador();
            Comparacao();
        }
        private void SorteioSelecaoComputador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            escolhaMaquina = opcoes[sorteio];
            txt_maquina.Text = escolhaMaquina;

        }
        private void Comparacao()
        {
            if (escolhaUsuario == escolhaMaquina)
            {
                resultado.Text = "Deu Empate!!!!";
            }
            else if (escolhaUsuario == opcoes[0] && escolhaMaquina == opcoes[2])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            }
            else if (escolhaUsuario == opcoes[1] && escolhaMaquina == opcoes[0])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            }
            else if (escolhaUsuario == opcoes[2] && escolhaMaquina == opcoes[1])
            {
                pontosUsuario++;
                resultado.Text = "Você Venceu!";
            } else
            {
                pontosMaquina++;
                resultado.Text = "Você Perdeu!!";
            }
            placarComputador.Text = pontosMaquina.ToString();
            placarUsuario.Text = pontosUsuario.ToString(); 
        }

        private void btn_pedra_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }

        private void btn_tesoura_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }
    }
}