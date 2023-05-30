using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    public class ControladorContato : ControloadorBase
    {
        private RepositorioContato repositorioContato;

        private ListagemContatosUserControl1 listagemContato;
        public ControladorContato(RepositorioContato repositorioContato) 
        {

           this.repositorioContato = repositorioContato;
        }
        public override string ToolTipInserir { get { return "inserir novo contato"; } }

        public override string ToolTipEditar { get { return "editar  contato existente "; } }

        public override string ToolTipExcluir { get { return "Excluir contato"; } }

              public override void Inserir()
        {
            TelaContatoForm1 telaContato = new TelaContatoForm1();

           DialogResult opcaoEscolhida = telaContato.ShowDialog();//essa função showDialog ele abre o formulario

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);

                CarregarContatos();

                
            }
        }

        public override void Editar()
        {
            TelaContatoForm1 telaContato = new TelaContatoForm1();

            telaContato.Contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
               MessageBox.Show($"Selecione um contato primeiro!", 
                    "Edição de Contatos",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);

                return;
                
            }
        }

        public override void Excluir()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato " +
                                                     $"{contato.nome}?", "Exclusão de Contatos",
                                              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
           listagemContato.AtualizarRegistros(contatos);
        }




        public override UserControl ObterListagem()
        {
            if (listagemContato == null)

                listagemContato = new ListagemContatosUserControl1();

            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro  de Contatos";
        }
    }

    }
