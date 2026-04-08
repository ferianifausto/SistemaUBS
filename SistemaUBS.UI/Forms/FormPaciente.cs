using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.UI.Forms;

public partial class FormPaciente : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly PacienteService _pacienteService;
    private readonly ConsultaService _consultaService;

    public FormPaciente(
        Usuario usuario,
        PacienteService pacienteService,
        ConsultaService consultaService)
    {
        InitializeComponent();

        _usuarioLogado = usuario;
        _pacienteService = pacienteService;
        _consultaService = consultaService;

        BackColor = Color.FromArgb(245, 246, 250);
        Text = "Área do Paciente";

        CarregarDados();
    }

    private async void CarregarDados()
    {
        var paciente = await _pacienteService.ObterPorUsuarioId(_usuarioLogado.Id);

        if (paciente == null)
        {
            MessageBox.Show("Paciente não encontrado.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lblNome.Text = paciente.Nome;
        lblEmail.Text = _usuarioLogado.Login;

        var consultas = await _consultaService.ObterPorPaciente(paciente.Id);

        dgvConsultas.DataSource = null;
        dgvConsultas.DataSource = consultas.Select(c => new
        {
            MedicoId = c.MedicoId,
            DataHora = c.Data.ToString("dd/MM/yyyy HH:mm"),
            Diagnostico = c.Diagnostico
        }).ToList();
    }
}