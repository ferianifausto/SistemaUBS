using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormConsultasExames : Form
{
    private readonly Usuario _usuarioLogado;
    private readonly ConsultaService _consultaService;
    private readonly ExameService _exameService;
    private readonly UsuarioRepository _usuarioRepository;

    public FormConsultasExames(Usuario usuario)
    {
        InitializeComponent();

        _usuarioLogado = usuario;
        _consultaService = new ConsultaService(new ConsultaRepository());
        _exameService = new ExameService(new ExameRepository());
        _usuarioRepository = new UsuarioRepository();

        this.BackColor = Color.FromArgb(245, 246, 250);
        this.Text = "Consultas e Exames";

        CarregarMedicos();
        CarregarConsultas();
        CarregarExames();
    }

    private async void CarregarMedicos()
    {
        var usuarios = await _usuarioRepository.ListarAsync();
        var medicos = usuarios.Where(u => u.Tipo == "Medico").ToList();

        cmbMedico.DataSource = medicos;
        cmbMedico.DisplayMember = "Login";
        cmbMedico.ValueMember = "Id";
    }

    private async void CarregarConsultas()
    {
        List<Consulta> lista;

        if (_usuarioLogado.Tipo == "Paciente")
            lista = await _consultaService.ObterPorPaciente(_usuarioLogado.Id);
        else
            lista = await _consultaService.ObterPorMedico(_usuarioLogado.Id);

        dgvConsultasLista.DataSource = null;
        dgvConsultasLista.DataSource = lista.Select(c => new
        {
            Id = c.Id,
            PacienteId = c.PacienteId,
            MedicoId = c.MedicoId,
            DataHora = c.Data.ToString("dd/MM/yyyy HH:mm"),
            Diagnostico = c.Diagnostico
        }).ToList();

        dgvConsultasLista.Columns["Id"].Visible = false;

        cmbConsultaRelacionada.DataSource = lista;
        cmbConsultaRelacionada.DisplayMember = "Data";
        cmbConsultaRelacionada.ValueMember = "Id";
    }

    private async void CarregarExames()
    {
        var exames = await _exameService.ObterPorPaciente(_usuarioLogado.Id);

        dgvExames.DataSource = null;
        dgvExames.DataSource = exames.Select(e => new
        {
            Id = e.Id,
            PacienteId = e.PacienteId,
            MedicoId = e.MedicoId,
            Data = e.Data.ToString("dd/MM/yyyy"),
            Resultado = e.Resultado
        }).ToList();
    }

    private async void btnAgendarConsulta_Click(object sender, EventArgs e)
    {
        if (_usuarioLogado.Tipo != "Paciente")
        {
            MessageBox.Show("Apenas pacientes podem agendar consultas.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var medicoId = (int)cmbMedico.SelectedValue;

        var consulta = new Consulta
        {
            PacienteId = _usuarioLogado.Id,
            MedicoId = medicoId,
            Data = dtpDataConsulta.Value
        };

        await _consultaService.Inserir(consulta);

        MessageBox.Show("Consulta agendada com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        CarregarConsultas();
    }

    private async void btnAdicionarExame_Click(object sender, EventArgs e)
    {
        if (cmbConsultaRelacionada.SelectedValue == null)
        {
            MessageBox.Show("Selecione uma consulta.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var exame = new Exame
        {
            PacienteId = _usuarioLogado.Id,
            MedicoId = _usuarioLogado.Id, // ajuste se quiser pegar da consulta depois
            Data = dtpDataExame.Value,
            Resultado = txtResultado.Text
        };

        await _exameService.Inserir(exame);

        MessageBox.Show("Exame adicionado com sucesso!", "Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        CarregarExames();
    }
}