using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormConsultasExames : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly PacienteService _pacienteService;
    private readonly MedicoService _medicoService;
    private readonly MedicoRepository _medicoRepository;
    private readonly ExameService _exameService;

    private List<Consulta> _consultasCarregadas = new();
    private Paciente? _paciente;
    private Medico? _medico;

    public FormConsultasExames(Usuario usuario)
    {
        InitializeComponent();

        _usuarioLogado = usuario;

        _pacienteService = new PacienteService(
            new PacienteRepository(),
            new ConsultaRepository(),
            new ExameRepository());

        _medicoService = new MedicoService(
            new MedicoRepository(),
            new ConsultaRepository(),
            new ExameRepository());

        _medicoRepository = new MedicoRepository();
        _exameService = new ExameService(new ExameRepository());

        ConfigurarTela();
        Load += FormConsultasExames_Load;
    }

    private void ConfigurarTela()
    {
        BackColor = Color.FromArgb(245, 246, 250);
        Text = "Consultas e Exames";
    }

    private async void FormConsultasExames_Load(object? sender, EventArgs e)
    {
        await InicializarDados();
    }

    private async Task InicializarDados()
    {
        AjustarPermissoes();

        await CarregarUsuarioRelacionado();
        await CarregarMedicos();
        await CarregarConsultas();
        await CarregarExames();
    }

    private void AjustarPermissoes()
    {
        btnAgendarConsulta.Enabled = _usuarioLogado.Tipo == "Paciente";
        btnAdicionarExame.Enabled = _usuarioLogado.Tipo == "Medico";

        cmbMedico.Enabled = _usuarioLogado.Tipo == "Paciente";
        dtpDataConsulta.Enabled = _usuarioLogado.Tipo == "Paciente";

        cmbConsultaRelacionada.Enabled = _usuarioLogado.Tipo == "Medico";
        dtpDataExame.Enabled = _usuarioLogado.Tipo == "Medico";
        txtResultado.Enabled = _usuarioLogado.Tipo == "Medico";
    }

    private async Task CarregarUsuarioRelacionado()
    {
        if (_usuarioLogado.Tipo == "Paciente")
        {
            _paciente = await _pacienteService.ObterPorUsuarioId(_usuarioLogado.Id);

            if (_paciente == null)
            {
                MessageBox.Show("Paciente não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else if (_usuarioLogado.Tipo == "Medico")
        {
            _medico = await _medicoService.ObterPorUsuarioId(_usuarioLogado.Id);

            if (_medico == null)
            {
                MessageBox.Show("Médico não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async Task CarregarMedicos()
    {
        var medicos = await _medicoRepository.ListarAsync();

        cmbMedico.DataSource = null;
        cmbMedico.DataSource = medicos;
        cmbMedico.DisplayMember = "Nome";
        cmbMedico.ValueMember = "Id";
        cmbMedico.SelectedIndex = -1;
    }

    private async Task CarregarConsultas()
    {
        try
        {
            List<Consulta> lista;

            if (_usuarioLogado.Tipo == "Paciente")
            {
                lista = await _pacienteService.ObterConsultasPorUsuarioId(_usuarioLogado.Id);
            }
            else if (_usuarioLogado.Tipo == "Medico")
            {
                lista = await _medicoService.ObterConsultasPorUsuarioId(_usuarioLogado.Id);
            }
            else
            {
                lista = new List<Consulta>();
            }

            _consultasCarregadas = lista;

            dgvConsultasLista.DataSource = null;
            dgvConsultasLista.DataSource = lista.Select(c => new
            {
                Id = c.Id,
                PacienteId = c.PacienteId,
                MedicoId = c.MedicoId,
                DataHora = c.Data.ToString("dd/MM/yyyy HH:mm"),
                Diagnostico = c.Diagnostico
            }).ToList();

            if (dgvConsultasLista.Columns["Id"] != null)
                dgvConsultasLista.Columns["Id"].Visible = false;

            cmbConsultaRelacionada.DataSource = null;
            cmbConsultaRelacionada.DataSource = lista.Select(c => new
            {
                c.Id,
                Descricao = $"Consulta #{c.Id} - {c.Data:dd/MM/yyyy HH:mm}"
            }).ToList();

            cmbConsultaRelacionada.DisplayMember = "Descricao";
            cmbConsultaRelacionada.ValueMember = "Id";
            cmbConsultaRelacionada.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar consultas: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task CarregarExames()
    {
        try
        {
            List<Exame> exames;

            if (_usuarioLogado.Tipo == "Paciente")
            {
                exames = await _pacienteService.ObterExamesPorUsuarioId(_usuarioLogado.Id);
            }
            else if (_usuarioLogado.Tipo == "Medico")
            {
                if (_medico == null)
                {
                    dgvExames.DataSource = null;
                    return;
                }

                var consultas = await _medicoService.ObterConsultasPorUsuarioId(_usuarioLogado.Id);
                var examesTemp = new List<Exame>();

                foreach (var consulta in consultas)
                {
                    var examesPaciente = await _exameService.ObterPorPaciente(consulta.PacienteId);

                    examesTemp.AddRange(
                        examesPaciente.Where(e => e.MedicoId == _medico.Id));
                }

                exames = examesTemp
                    .GroupBy(e => e.Id)
                    .Select(g => g.First())
                    .ToList();
            }
            else
            {
                exames = new List<Exame>();
            }

            dgvExames.DataSource = null;
            dgvExames.DataSource = exames.Select(e => new
            {
                Id = e.Id,
                PacienteId = e.PacienteId,
                MedicoId = e.MedicoId,
                Data = e.Data.ToString("dd/MM/yyyy"),
                Resultado = e.Resultado
            }).ToList();

            if (dgvExames.Columns["Id"] != null)
                dgvExames.Columns["Id"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar exames: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnAgendarConsulta_Click(object sender, EventArgs e)
    {
        if (_usuarioLogado.Tipo != "Paciente")
        {
            MessageBox.Show("Apenas pacientes podem agendar consultas.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbMedico.SelectedValue == null)
        {
            MessageBox.Show("Selecione um médico.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int medicoId = (int)cmbMedico.SelectedValue;

            await _pacienteService.AgendarConsulta(
                _usuarioLogado.Id,
                medicoId,
                dtpDataConsulta.Value);

            MessageBox.Show("Consulta agendada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            await CarregarConsultas();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao agendar consulta: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnAdicionarExame_Click(object sender, EventArgs e)
    {
        if (_usuarioLogado.Tipo != "Medico")
        {
            MessageBox.Show("Apenas médicos podem adicionar exames.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbConsultaRelacionada.SelectedValue == null)
        {
            MessageBox.Show("Selecione uma consulta.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int consultaId = (int)cmbConsultaRelacionada.SelectedValue;

            await _medicoService.AdicionarExame(
                _usuarioLogado.Id,
                consultaId,
                dtpDataExame.Value,
                txtResultado.Text);

            MessageBox.Show("Exame adicionado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtResultado.Clear();
            await CarregarExames();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao adicionar exame: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}