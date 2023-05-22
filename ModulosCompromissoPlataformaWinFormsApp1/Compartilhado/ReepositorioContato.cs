using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.Compartilhado
{
    public class RepositorioContato
    {

        List<Contato> contatos = new List<Contato>();
        private static int contador;
        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }
        public List<Contato> SelecionarTodos() 
        {
        return contatos;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSlecionado = SelecionarPorId(contato.id);
            
            contatoSlecionado.id = contato.id;
            contatoSlecionado.telefone = contato.telefone;
            contatoSlecionado.email = contato.email;
            contatoSlecionado.empresa = contato.empresa;
            contatoSlecionado.cargo = contato.cargo;
        }

        private Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato contato)
        {
           contatos.Remove(contato);
        }
    } 
}
