using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormPaciente : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly PacienteService _pacienteService;

    private Paciente? _paciente;

    public FormPaciente(Usuario usuario)
    {
        InitializeComponent();

        _usuarioLogado = usuario;
        _pacienteService = new PacienteService(
            new PacienteRepository(),
            new ConsultaRepository(),
            new ExameRepository());

        ConfigurarTela();
        Load += FormPaciente_Load;
    }

    private void ConfigurarTela()
    {
        BackColor = Color.FromArgb(245, 246, 250);
        Text = "Área do Paciente";
    }

    private async void FormPaciente_Load(object? sender, EventArgs e)
    {
        await InicializarDados();
    }

    private async Task InicializarDados()
    {
        _paciente = await _pacienteService.ObterPorUsuarioId(_usuarioLogado.Id);

        if (_paciente == null)
        {
            MessageBox.Show("Paciente não encontrado.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        lblNome.Text = _paciente.Nome;
        lblEmail.Text = _usuarioLogado.Login;

        await CarregarConsultas();
    }

    private async Task CarregarConsultas()
    {
        try
        {
            var consultas = await _pacienteService.ObterConsultasPorUsuarioId(_usuarioLogado.Id);

            dgvConsultas.DataSource = null;
            dgvConsultas.DataSource = consultas.Select(c => new
            {
                Id = c.Id,
                MedicoId = c.MedicoId,
                DataHora = c.Data.ToString("dd/MM/yyyy HH:mm"),
                Diagnostico = c.Diagnostico
            }).ToList();

            if (dgvConsultas.Columns["Id"] != null)
                dgvConsultas.Columns["Id"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}