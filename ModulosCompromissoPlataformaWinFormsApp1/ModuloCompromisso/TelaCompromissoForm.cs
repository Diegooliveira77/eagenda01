using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
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
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm(List<Contato> contatos)
        {


            InitializeComponent();

            foreach (Contato contato in contatos)
            {
                cmbContaos.Items.Add(contato);
            }
        }

        public Compromisso ObterCompromisso()
        {
            int id = Convert.ToInt32(txtId.Text);
            string assunto = txtAssunto.Text;
            DateTime date = txtData.Value; /* Value ele vai trazer a data */
            TimeSpan horarioInicio = txtHorarioInicio.Value.TimeOfDay;
            TimeSpan horarioFinal = txtHorarioFinal.Value.TimeOfDay;

            TipoLocalEnum tipo = rdbOline.Checked ? TipoLocalEnum.Online : TipoLocalEnum.Presencial;
            Contato contato = (Contato)cmbContaos.SelectedItem;

            string local;
            if (rdbOline.Checked)
                local = rdbOline.Text;

            else
                local = rdbPresencial.Text;

            return new Compromisso(assunto, date, horarioInicio, horarioFinal, local, tipo);
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bpnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            string[] erro = compromisso.Validar();

            if (erro.Length > 0)
            {
                TelaPrincipalForm1 principal = TelaPrincipalForm1.Instancia;

                principal.AtualizarRodape(erro[0]);

                DialogResult = DialogResult.None;
                return;
            }
        }

        public void ConfigurarTela(Compromisso compromissoSlecionado)
        {
            txtId.Text = compromissoSlecionado.id.ToString();
            txtAssunto.Text = compromissoSlecionado.Assunto;
            txtData.Value = compromissoSlecionado.data;
            txtHorarioInicio.Value = compromissoSlecionado.data + compromissoSlecionado.horarioInicio;
            txtHorarioFinal.Value = compromissoSlecionado.data + compromissoSlecionado.horarioFinal;
            cmbContaos.SelectedItem = compromissoSlecionado.contato;

            if (compromissoSlecionado.tipoLocal == TipoLocalEnum.Presencial)
            {
                rdbPresencial.Checked = true;
                txtPrencial.Text = compromissoSlecionado.localPresencial;
            }


            else
            {
                rdbOline.Checked = true;
                txtOnline.Text = compromissoSlecionado.localOnline;
            }
            
        }
    }
}
