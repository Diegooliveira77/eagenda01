using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
  public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> compromissos) 
        {
        this.listaRegistros = compromissos; 
        }

        internal List<Compromisso> SelecionarCompromissoPassado(DateTime now)
        {
            throw new NotImplementedException();
        }
    }
}
