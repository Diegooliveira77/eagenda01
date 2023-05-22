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
            RepositorioContato = repositorioContato;
        }
        public override string ToolTipInserir { get { return "inserir novo contato"; } }

        public override string ToolTipEditar { get { return "editar  contato existente "; } }

        public override string ToolTipExcluir { get { return "Excluir contato"; } }

        public RepositorioContato RepositorioContato { get; }

        public override void Editar()
        {
            TelaContatoForm1 telaContato = new TelaContatoForm1();

            telaContato.Contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Editar(contato);

                
            }
        }

        public override void Excluir()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show("Deseja exculir o contato   ");

            if (opcaoEscolhida == DialogResult.OK) 
            {
                repositorioContato.Excluir(contato);
            }
        }

        public override void Inserir()
        {
            TelaContatoForm1 telaContato = new TelaContatoForm1();

           DialogResult opcaoEscolhida = telaContato.ShowDialog();//essa função showDialog ele abre o formulario

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);
            }
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
