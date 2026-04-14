using SistemaUBS.Application.Services;
using SistemaUBS.Infrastructure.Repositories;

namespace SistemaUBS.UI.Forms;

public partial class FormLogin : Form
{
    private readonly AutenticacaoService _autenticacaoService;

    public FormLogin()
    {
        InitializeComponent();

        _autenticacaoService = new AutenticacaoService(new UsuarioRepository());

        ConfigurarTela();
    }

    private void ConfigurarTela()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(400, 500);
        BackColor = Color.FromArgb(245, 246, 250);
    }

    private async void btnEntrar_Click(object sender, EventArgs e)
    {
        string login = txtEmail.Text.Trim();
        string senha = txtSenha.Text.Trim();

        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
        {
            MessageBox.Show("Preencha login e senha.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var (sucesso, mensagem) = await _autenticacaoService.AutenticarAsync(login, senha);

            if (!sucesso)
            {
                MessageBox.Show(mensagem, "Erro de Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuario = _autenticacaoService.UsuarioLogado;

            if (usuario == null)
            {
                MessageBox.Show("Erro ao recuperar usuário logado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            var formPrincipal = new FormPrincipal(this, usuario);
            formPrincipal.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao fazer login: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        Hide();

        var formCadastro = new FormCadastro(this);
        formCadastro.Show();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }
}