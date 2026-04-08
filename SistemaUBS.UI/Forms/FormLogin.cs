using SistemaUBS.Application.Services;

namespace SistemaUBS.UI.Forms;

public partial class FormLogin : Form
{
    private readonly UsuarioService _usuarioService;

    public FormLogin()
    {
        InitializeComponent();

        _usuarioService = new UsuarioService(new UsuarioRepository());

        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(400, 500);
        this.BackColor = Color.FromArgb(245, 246, 250);
    }

    private async void btnEntrar_Click(object sender, EventArgs e)
    {
        string login = txtEmail.Text;
        string senha = txtSenha.Text;

        var (usuario, erros) = await _usuarioService.LoginAsync(login, senha);

        if (erros.Any())
        {
            MessageBox.Show(string.Join("\n", erros), "Erro de Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show($"Bem-vindo, {usuario!.Login}!", "Login",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        this.Hide();

        var formPrincipal = new FormPrincipal(this, usuario);
        formPrincipal.Show();
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        this.Hide();
        var formCadastro = new FormCadastro(this);
        formCadastro.Show();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }
}