using SistemaUBS.Domain.Entities;
using System.Runtime.InteropServices;

namespace SistemaUBS.UI.Forms;

public partial class FormPrincipal : Form
{
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private readonly Form _formLoginRef;
    private readonly Usuario _usuarioLogado;
    private Form? _activeForm;

    public FormPrincipal(Form loginForm, Usuario usuario)
    {
        InitializeComponent();

        _formLoginRef = loginForm;
        _usuarioLogado = usuario;

        ConfigurarJanela();
        ConfigurarMenuUsuario();
    }

    private void ConfigurarJanela()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(1000, 600);
    }

    private void ConfigurarMenuUsuario()
    {
        lblUserName.Text = $"Olá, {_usuarioLogado.Login}";

        btnAreaPaciente.Visible = false;
        btnAreaMedico.Visible = false;
        btnConsultasExames.Visible = false;

        if (_usuarioLogado.Tipo == "Paciente")
        {
            btnAreaPaciente.Visible = true;
            btnConsultasExames.Visible = true;
            AbrirFormFilho(new FormPaciente(_usuarioLogado));
        }
        else if (_usuarioLogado.Tipo == "Medico")
        {
            btnAreaMedico.Visible = true;
            btnConsultasExames.Visible = true;
            AbrirFormFilho(new FormMedico(_usuarioLogado));
        }
    }

    private void AbrirFormFilho(Form childForm)
    {
        if (_activeForm != null)
            _activeForm.Close();

        _activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        panelDesktop.Controls.Clear();
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();

        lblTitle.Text = childForm.Text;
    }

    private void btnAreaPaciente_Click(object sender, EventArgs e)
    {
        AbrirFormFilho(new FormPaciente(_usuarioLogado));
    }

    private void btnAreaMedico_Click(object sender, EventArgs e)
    {
        AbrirFormFilho(new FormMedico(_usuarioLogado));
    }

    private void btnConsultasExames_Click(object sender, EventArgs e)
    {
        AbrirFormFilho(new FormConsultasExames(_usuarioLogado));
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
        _formLoginRef.Show();
    }

    private void panelTop_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }
}