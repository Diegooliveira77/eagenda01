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
        List<Contato> contatos = new List<Contato>();
        public ListagemContatosUserControl1()
        {
            InitializeComponent();

            contatos.Add(new Contato(1, "diego", "Academia do Programador"));

            contatos.Add(new Contato(2, "bruna", "Personal"));

            foreach (Contato item in contatos)
            {
                listContatos.Items.Add(item);
            }
            
        }
    }
}
