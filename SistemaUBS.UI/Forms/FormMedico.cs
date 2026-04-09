using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormMedico : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly MedicoService _medicoService;

    private Medico? _medico;

    public FormMedico(Usuario usuario)
    {
        InitializeComponent();

        _usuarioLogado = usuario;
        _medicoService = new MedicoService(
            new MedicoRepository(),
            new ConsultaRepository(),
            new ExameRepository());

        ConfigurarTela();
        Load += FormMedico_Load;
    }

    private void ConfigurarTela()
    {
        BackColor = Color.FromArgb(245, 246, 250);
        Text = "Área do Médico";
    }

    private async void FormMedico_Load(object? sender, EventArgs e)
    {
        await InicializarDados();
    }

    private async Task InicializarDados()
    {
        if (_usuarioLogado.Tipo != "Medico")
            return;

        _medico = await _medicoService.ObterPorUsuarioId(_usuarioLogado.Id);

        if (_medico == null)
        {
            MessageBox.Show("Médico não encontrado.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lblNome.Text = _medico.Nome;
        await CarregarConsultas();
    }

    private async Task CarregarConsultas()
    {
        try
        {
            var consultas = await _medicoService.ObterConsultasPorUsuarioId(_usuarioLogado.Id);

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = consultas.Select(c => new
            {
                IdConsulta = c.Id,
                PacienteId = c.PacienteId,
                DataHora = c.Data.ToString("dd/MM/yyyy HH:mm"),
                Diagnostico = c.Diagnostico
            }).ToList();

            if (dgvPacientes.Columns["IdConsulta"] != null)
                dgvPacientes.Columns["IdConsulta"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDarDiagnostico_Click(object sender, EventArgs e)
    {
        if (dgvPacientes.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecione uma consulta primeiro.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int consultaId = (int)dgvPacientes.SelectedRows[0].Cells["IdConsulta"].Value;

            string diagnostico = Microsoft.VisualBasic.Interaction.InputBox(
                "Digite o diagnóstico para esta consulta:",
                "Diagnóstico",
                "");

            if (string.IsNullOrWhiteSpace(diagnostico))
                return;

            await _medicoService.AtualizarDiagnostico(_usuarioLogado.Id, consultaId, diagnostico);

            await CarregarConsultas();

            MessageBox.Show("Diagnóstico salvo com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar diagnóstico: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}