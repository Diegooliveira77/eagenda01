namespace ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa
{
    public class Tarefa
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefa(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;

        }

        public override string? ToString()
        {
            return "Id" + id + "," + titulo + "," + prioridade;
        }

    }
}
