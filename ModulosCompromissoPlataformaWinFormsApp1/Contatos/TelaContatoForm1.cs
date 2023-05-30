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
    public partial class TelaContatoForm1 : Form
    {
        private Contato contato;
        public TelaContatoForm1()
        {
            InitializeComponent();
            
        }
        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtEmail.Text = value.email;
                txtEmpresa.Text = value.empresa;
                txtCargo.Text = value.cargo;
            }
            get
            {
                return contato;
            }
        }
        private void bpnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            string[] erros = contato.Validar();

            if (erros.Length > 0 )
            {
                TelaPrincipalForm1 principal = TelaPrincipalForm1.Instancia;

                principal.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
                return;
            }

            if (txtId.Text != "0")
                Contato.id = Convert.ToInt32(txtId.Text);

        }
    }
}
