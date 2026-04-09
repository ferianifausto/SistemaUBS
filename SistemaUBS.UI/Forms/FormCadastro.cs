using SistemaUBS.Application.Services;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormCadastro : Form
{
    private readonly FormLogin _formLogin;
    private readonly UsuarioService _usuarioService;
    private readonly UsuarioRepository _usuarioRepository;
    private readonly PacienteRepository _pacienteRepository;
    private readonly MedicoRepository _medicoRepository;

    public FormCadastro(FormLogin formLogin)
    {
        InitializeComponent();

        _formLogin = formLogin;
        _usuarioService = new UsuarioService(new UsuarioRepository());
        _usuarioRepository = new UsuarioRepository();
        _pacienteRepository = new PacienteRepository();
        _medicoRepository = new MedicoRepository();

        ConfigurarTela();
        ConfigurarComboTipo();
    }

    private void ConfigurarTela()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(400, 500);
        BackColor = Color.FromArgb(245, 246, 250);
    }

    private void ConfigurarComboTipo()
    {
        cmbTipo.Items.Clear();
        cmbTipo.Items.Add("Paciente");
        cmbTipo.Items.Add("Medico");
        cmbTipo.SelectedIndex = 0;

        AtualizarCamposTipo();
    }

    private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        AtualizarCamposTipo();
    }

    private void AtualizarCamposTipo()
    {
        bool ehMedico = cmbTipo.SelectedItem?.ToString() == "Medico";

        lblEspecialidade.Visible = ehMedico;
        txtEspecialidade.Visible = ehMedico;

        if (!ehMedico)
            txtEspecialidade.Clear();
    }

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text.Trim();
        string login = txtEmail.Text.Trim();
        string senha = txtSenha.Text.Trim();
        string tipo = cmbTipo.SelectedItem?.ToString() ?? "";
        string especialidade = txtEspecialidade.Text.Trim();

        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(login) ||
            string.IsNullOrWhiteSpace(senha) ||
            string.IsNullOrWhiteSpace(tipo))
        {
            MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (tipo == "Medico" && string.IsNullOrWhiteSpace(especialidade))
        {
            MessageBox.Show("Informe a especialidade do médico.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var usuario = new Usuario(login, senha, tipo);

            await _usuarioService.CadastrarAsync(usuario);

            var usuarioCriado = await _usuarioRepository.ObterPorLoginAsync(login);

            if (usuarioCriado == null)
            {
                MessageBox.Show("Usuário cadastrado, mas não foi possível recuperar os dados.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipo == "Paciente")
            {
                await _pacienteRepository.InserirAsync(new Paciente
                {
                    Nome = nome,
                    UsuarioId = usuarioCriado.Id
                });
            }
            else
            {
                await _medicoRepository.InserirAsync(new Medico
                {
                    Nome = nome,
                    Especialidade = especialidade,
                    UsuarioId = usuarioCriado.Id
                });
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
            _formLogin.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        Close();
        _formLogin.Show();
    }
}