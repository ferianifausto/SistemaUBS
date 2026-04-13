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
    private readonly ConsultaService _consultaService;

    private List<Consulta> _consultasCarregadas = new();
    private List<Exame> _examesCarregados = new();

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
        _consultaService = new ConsultaService(new ConsultaRepository());

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
        txtDescricao.Enabled = _usuarioLogado.Tipo == "Medico";
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

            _examesCarregados = exames;

            dgvExames.AutoGenerateColumns = true;

            dgvExames.DataSource = null;
            dgvExames.DataSource = exames.Select(e => new
            {
                Id = e.Id,
                PacienteId = e.PacienteId,
                MedicoId = e.MedicoId,
                Data = e.Data.ToString("dd/MM/yyyy"),
                Resultado = e.Resultado,
                Descricao = e.Descricao
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

            MessageBox.Show($"Descrição digitada: {txtDescricao.Text}");

            await _medicoService.AdicionarExame(
                _usuarioLogado.Id,
                consultaId,
                dtpDataExame.Value,
                txtResultado.Text,
                txtDescricao.Text);

            MessageBox.Show("Exame adicionado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtResultado.Clear();
            txtDescricao.Clear();
            await CarregarExames();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao adicionar exame: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private Consulta? ObterConsultaSelecionada()
    {
        if (dgvConsultasLista.SelectedRows.Count == 0)
            return null;

        var valorId = dgvConsultasLista.SelectedRows[0].Cells["Id"].Value;

        if (valorId == null)
            return null;

        int consultaId = (int)valorId;

        return _consultasCarregadas.FirstOrDefault(c => c.Id == consultaId);
    }

    private async void btnExcluirConsulta_Click(object sender, EventArgs e)
    {
        var consultaSelecionada = ObterConsultaSelecionada();

        if (consultaSelecionada == null)
        {
            MessageBox.Show("Selecione uma consulta!",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var resultado = MessageBox.Show(
            $"Deseja realmente excluir a consulta de ID {consultaSelecionada.Id}?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (resultado == DialogResult.Yes)
        {
            try
            {
                await _consultaService.Remover(consultaSelecionada.Id);

                MessageBox.Show("Consulta excluída com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CarregarConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir consulta: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

    private Exame? ObterExameSelecionado()
    {
        if (dgvExames.SelectedRows.Count == 0)
            return null;

        var valorId = dgvExames.SelectedRows[0].Cells["Id"].Value;

        if (valorId == null)
            return null;

        int exameId = (int)valorId;

        return _examesCarregados.FirstOrDefault(e => e.Id == exameId);
    }

    private Exame? _exameEmEdicao;
    private void btnEditarExame_Click(object sender, EventArgs e)
    {
        var exameSelecionado = ObterExameSelecionado();

        if (exameSelecionado == null)
        {
            MessageBox.Show("Selecione um exame para editar.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        _exameEmEdicao = exameSelecionado;

        txtResultado.Text = exameSelecionado.Resultado;
        txtDescricao.Text = exameSelecionado.Descricao;
        dtpDataExame.Value = exameSelecionado.Data;

        MessageBox.Show("Exame carregado para edição.",
            "Sucesso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private async void btnSalvarExame_Click(object sender, EventArgs e)
    {
        if (_exameEmEdicao == null)
        {
            MessageBox.Show("Nenhum exame foi carregado para edição.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        try
        {
            await _exameService.Atualizar(

                _exameEmEdicao.Id,
                _exameEmEdicao.NomeExame,
                _exameEmEdicao.PacienteId,
                _exameEmEdicao.MedicoId,
                dtpDataExame.Value,
                txtResultado.Text,
                txtDescricao.Text);

            MessageBox.Show("Exame atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            _exameEmEdicao = null;

            txtResultado.Clear();
            txtDescricao.Clear();

            await CarregarExames();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar edição: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    
}