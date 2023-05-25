using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa;

namespace ModulosCompromissoPlataformaWinFormsApp1
{
    public partial class TelaPrincipalForm1 : Form
    {
        private ControloadorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
       
        public TelaPrincipalForm1()
        {
            InitializeComponent();
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

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipalForm1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bpnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void bpnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void lblTipoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}