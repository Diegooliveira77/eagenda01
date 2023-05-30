using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;

namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    public class Contato : EntidadeBase<Contato>
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

        public override void AtualizarInformacoes(Contato registroAtualizado)
        {
            
            this.nome = registroAtualizado.nome;
            this.empresa = registroAtualizado.empresa;
            this.telefone = registroAtualizado.telefone;
            this.email = registroAtualizado.email;
            this.cargo = registroAtualizado.cargo;
        }

        public override string ToString()
        {
            return "Id" + id + "," + nome + "," + empresa + "," + telefone + "," + email + "," + cargo;
        }

        public override string[] Validar()
        {
            List<string> erro = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erro.Add("Campo 'nome ' é obrigatorio");

            if (string.IsNullOrEmpty(email))
                erro.Add("Campo 'email ' é obrigatorio");

            if (string.IsNullOrEmpty(telefone))
                erro.Add("Campo 'telefone ' é obrigatorio");

            return erro.ToArray();
        }
    }
}
