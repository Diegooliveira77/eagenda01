using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa;

namespace ModulosCompromissoPlataformaWinFormsApp1
{
    public partial class TelaPrincipalForm1 : Form
    {
        private ControloadorBase controlador;

        public TelaPrincipalForm1()
        {
            InitializeComponent();
        }



        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            lblTipoCadastro.Text = "Cadastro de Contatos";

            controlador = new ControladorContato();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {

            lblTipoCadastro.Text = "Cadastro de Tarefas";

            controlador = new ControladorTarefa();

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

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipalForm1_Load(object sender, EventArgs e)
        {

        }
    }
}