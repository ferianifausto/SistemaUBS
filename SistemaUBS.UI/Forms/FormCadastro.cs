using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure.Repositories;
using SistemaUBS.Application.Services;

namespace SistemaUBS.UI.Forms;

public partial class FormCadastro : Form
{
    private Form formLoginRef;
    private readonly UsuarioService _usuarioService;

    public FormCadastro(Form loginForm)
    {
        InitializeComponent();

        formLoginRef = loginForm;
        _usuarioService = new UsuarioService(new UsuarioRepository());

        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(400, 500);
        this.BackColor = Color.FromArgb(245, 246, 250);

        cmbTipo.Items.Add("Paciente");
        cmbTipo.Items.Add("Medico");
        cmbTipo.SelectedIndex = 0;
    }

    private async void btnCadastrar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text;
        string login = txtEmail.Text;
        string senha = txtSenha.Text;
        string tipo = cmbTipo.SelectedItem?.ToString() ?? "";

        if (string.IsNullOrWhiteSpace(nome) ||
            string.IsNullOrWhiteSpace(login) ||
            string.IsNullOrWhiteSpace(senha))
        {
            MessageBox.Show("Preencha todos os campos.", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var usuario = new Usuario(login, senha, tipo);

        try
        {
            await _usuarioService.CadastrarAsync(usuario);

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            formLoginRef.Show();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        this.Close();
        formLoginRef.Show();
    }
}