using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;

namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    public class Contato : EntidaddeBase
    {
        public int id;
        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato( string nome,string telefone, string email,
                       string cargo, string empresa)
        {
           
            this.nome = nome;
            this.empresa = empresa;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
        }

        public override string ToString()
        {
            return "Id" + id + "," + nome + "," + empresa;
        }
    }
}
