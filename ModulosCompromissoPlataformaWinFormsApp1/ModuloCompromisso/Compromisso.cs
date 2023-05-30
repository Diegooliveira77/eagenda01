using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ModulosCompromissoPlataformaWinFormsApp1.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public string Assunto;

        public DateTime data;

        public TimeSpan horarioInicio;

        public TimeSpan horarioFinal;

        public string localPresencial;

        public string localOnline;

        public TipoLocalEnum tipoLocal;
        internal object contato;

        public Compromisso(string assunto, DateTime data, TimeSpan horarioInicio,
               TimeSpan horarioFinal, string local, TipoLocalEnum tipoLocal)
        {
            Assunto = assunto;
            this.data = data;
            this.horarioInicio = horarioInicio;
            this.horarioFinal = horarioFinal;
            this.tipoLocal = tipoLocal;

            if (tipoLocal == TipoLocalEnum.Online)
                this.localOnline = local;
            else
                this.localPresencial = local;
            
        }
        public override string ToString()
        {
            return "Id" + id + "," + Assunto + "Data" + data; 
                
        }
        public override void AtualizarInformacoes(Compromisso registroAtualizado)
        {
            Assunto = registroAtualizado.Assunto;
            this.data = registroAtualizado.data;
            this.horarioInicio = registroAtualizado.horarioInicio;
            this.horarioFinal = registroAtualizado.horarioFinal;
            this.tipoLocal = registroAtualizado.tipoLocal;

            if (registroAtualizado.tipoLocal == TipoLocalEnum.Online)
                this.localOnline = registroAtualizado.localOnline;
            else
                this.localPresencial = registroAtualizado.localPresencial;

        }

        public override string[] Validar()
        {
            List<string> erro = new List<string>();

            if (string.IsNullOrEmpty(Assunto))
                erro.Add("Campo 'assunto ' é obrigatorio");
          
            
              return erro.ToArray();
        }

    }
}
