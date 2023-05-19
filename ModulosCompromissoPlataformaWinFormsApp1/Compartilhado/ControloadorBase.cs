using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.Compartilhado
{
    public abstract class ControloadorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();

        public abstract UserControl ObterListagem();
        

        
    }
}
