using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa;
using ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso;

namespace ModulosCompromissoPlataformaWinFormsApp1
{
    public partial class TelaPrincipalForm1 : Form
    {
        private ControloadorBase controlador;

        private RepositorioContato repositorioContato = new RepositorioContato(new List<Contato>());
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());

        private static TelaPrincipalForm1 telaPrincipal;
        public TelaPrincipalForm1()
        {
            InitializeComponent();
            telaPrincipal = this;
        }

        //singleton
        public void AtualizarRodape(string mensagem)
        {
            labelRodaPe.Text = mensagem;
            toolStripStatusLabel1.Text = "Rodape";
        }

        public static TelaPrincipalForm1 Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm1();

                return telaPrincipal;
            }
        }
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);


        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {



            controlador = new ControladorTarefa();

            ConfigurarTelaPrincipal(controlador);



        }

        private void ConfigurarTelaPrincipal(ControloadorBase controladorBase)
        {
            lblTipoCadastro.Text = controladorBase.ObterTipoCadastro();




            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControloadorBase controloadorBase)
        {
            UserControl listagem = controloadorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistro.Controls.Clear();

            panelRegistro.Controls.Add(listagem);
        }


        private void ConfigurarToolTips(ControloadorBase controlador)
        {
            bpnInserir.ToolTipText = controlador.ToolTipInserir;
            bpnEditar.ToolTipText = controlador.ToolTipEditar;
            bpnExcluir.ToolTipText = controlador.ToolTipExcluir;

        }

        private void bpnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();

        }



        private void bpnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void bpnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioContato);
            ConfigurarTelaPrincipal(controlador);
        }

        private void bpnFiltrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }
    }
}