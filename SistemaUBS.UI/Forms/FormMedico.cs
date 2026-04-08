using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using System.Data;

namespace SistemaUBS.UI.Forms;

public partial class FormMedico : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly ConsultaService _consultaService;

    public FormMedico(Usuario usuario)
    {
        InitializeComponent();

        _usuarioLogado = usuario;
        _consultaService = new ConsultaService(new ConsultaRepository());

        this.BackColor = Color.FromArgb(245, 246, 250);
        this.Text = "Área do Médico";

        CarregarDados();
    }

    private async void CarregarDados()
    {
        if (_usuarioLogado.Tipo != "Medico") return;

        // Aqui você pode ajustar se tiver entidade Medico separada
        lblNome.Text = _usuarioLogado.Login;

        // 🔥 Buscar consultas do banco
        var consultas = await _consultaService.ObterPorMedico(_usuarioLogado.Id);

        dgvPacientes.DataSource = null;
        dgvPacientes.DataSource = consultas.Select(c => new
        {
            IdConsulta = c.Id,
            PacienteId = c.PacienteId,
            DataHora = c.Data.ToString("dd/MM/yyyy HH:mm")
        }).ToList();
    }

    private async void btnDarDiagnostico_Click(object sender, EventArgs e)
    {
        if (dgvPacientes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione uma consulta primeiro.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var idSelecionado = (int)dgvPacientes.SelectedRows[0].Cells["IdConsulta"].Value;

        var consulta = await _consultaService.ObterPorId(idSelecionado);

        if (consulta != null)
        {
            string diagn = Microsoft.VisualBasic.Interaction.InputBox(
                "Digite o diagnóstico para esta consulta:",
                "Diagnóstico",
                "");

            if (!string.IsNullOrWhiteSpace(diagn))
            {
                consulta.Diagnostico = diagn;

                await _consultaService.Atualizar(consulta);

                CarregarDados();

                MessageBox.Show("Diagnóstico salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}