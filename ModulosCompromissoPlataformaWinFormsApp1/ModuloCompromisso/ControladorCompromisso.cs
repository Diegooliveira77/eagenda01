using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
   public class ControladorCompromisso : ControloadorBase
    {
        private RepositorioContato repositorioContato;
        
        ListagemCompromissoControl1 listagemCompromisso;
        


        private RepositorioCompromisso repositorioCompromisso;
        private object listagemContato;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public ControladorCompromisso(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso Existente";

        public override string ToolTipExcluir => "Excluir Compromisso";


        public override void Inserir()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida== DialogResult.OK)
            {

             Compromisso compromisso =   telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromisso();
            }
        }


        public override void Editar()
        {
            Compromisso compromissoSlecionado = listagemCompromisso.ObterCompromissoSelecionado();

            if (compromissoSlecionado == null)
            {
                MessageBox.Show($"Selecione compromisso primeiro!",
                    "Edição de Compromisso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm(contatos);

            telaCompromisso.ConfigurarTela(compromissoSlecionado);

           DialogResult opcaoEcolhida= telaCompromisso.ShowDialog();

            if (opcaoEcolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Editar(compromisso.id , compromisso);

                CarregarCompromisso();
            }
        }

        public override void Excluir()
        {
           Compromisso compromissoSelecionado= listagemCompromisso.ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de compromisso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso " +
                                                   $"{compromissoSelecionado.Assunto}?",
                                                   "Exclusão de compromissos",

                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);

                CarregarCompromisso();
            }
        }

        public override void Filtrar()
        {
            FiltroCompromissosForm1 telaFiltro = new FiltroCompromissosForm1();
            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK )
            {
                StatusCompromissoEnum status = telaFiltro.ObterStatus();
                

                if (status == StatusCompromissoEnum.Todos)
                    CarregarCompromisso();

                else if (status == StatusCompromissoEnum.Passados)
                {
                    List<Compromisso> compromissosPassados = 
                        repositorioCompromisso.SelecionarCompromissoPassado(DateTime.Now);
                    CarregarCompromisso(compromissosPassados); 
                
                }
                else if ( status== StatusCompromissoEnum.Futuros)
                {
                    DateTime dataInicio = telaFiltro.ObterDataInicio();
                    DateTime dataFinal = telaFiltro.ObterDataFinal();

                    List<Compromisso> compromissosFuturos =
                        repositorioCompromisso.SelecionarCompromissoFuturos(dataInicio,dataFinal);
                    CarregarCompromisso(compromissosFuturos);
                }
            }
        }

        private void CarregarCompromisso(List<Compromisso> compromissosPassados)
        {
            listagemCompromisso.AtualizarRegistro(compromissosPassados);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null) 
            { 
            listagemCompromisso = new ListagemCompromissoControl1();
            }
            CarregarCompromisso();
            return listagemCompromisso; 
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }


        private void CarregarCompromisso()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistro(compromissos);
        }
    }
}
