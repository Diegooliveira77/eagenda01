using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    public partial class ListagemContatosUserControl1 : UserControl
    {
       
        public ListagemContatosUserControl1()
        {
            InitializeComponent();
                                    
        }
        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContatos.Items.Clear();
            foreach (Contato item in contatos)
            {
                listContatos.Items.Add(item);
            }
        }
        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContatos.SelectedItem;
        }
    }
}
