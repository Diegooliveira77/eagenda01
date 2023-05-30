using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
    public partial class ListagemCompromissoControl1 : UserControl
    {
        public ListagemCompromissoControl1()
        {
            InitializeComponent();
        }
        public void AtualizarRegistro(List<Compromisso>compromissos)
        {
            
            listCompromissos.Items.Clear();
            foreach (Compromisso compromisso in compromissos) 
            {
                listCompromissos.Items.Add(compromisso);
            }
        }
        public Compromisso ObterCompromissoSelecionado()
        {
            return (Compromisso)listCompromissos.SelectedItem;
        }
    }
}
