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

    private readonly Form formLoginRef;
    private Form? activeForm = null;
    private readonly Usuario _usuarioLogado;

    public FormPrincipal(Form loginForm, Usuario usuario)
    {
        InitializeComponent();

        formLoginRef = loginForm;
        _usuarioLogado = usuario;

        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;
        Size = new Size(1000, 600);

        SetupUserMenu();
    }

    private void SetupUserMenu()
    {
        lblUserName.Text = $"Olá, {_usuarioLogado.Login}";

        btnAreaPaciente.Visible = false;
        btnAreaMedico.Visible = false;
        btnConsultasExames.Visible = false;

        if (_usuarioLogado.Tipo == "Paciente")
        {
            btnAreaPaciente.Visible = true;
            btnConsultasExames.Visible = true;
            OpenChildForm(new FormPaciente(_usuarioLogado));
        }
        else if (_usuarioLogado.Tipo == "Medico")
        {
            btnAreaMedico.Visible = true;
            btnConsultasExames.Visible = true;
            OpenChildForm(new FormMedico(_usuarioLogado));
        }
    }

    private void OpenChildForm(Form childForm)
    {
        if (activeForm != null)
            activeForm.Close();

        activeForm = childForm;
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
        OpenChildForm(new FormPaciente(_usuarioLogado));
    }

    private void btnAreaMedico_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormMedico(_usuarioLogado));
    }

    private void btnConsultasExames_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormConsultasExames(_usuarioLogado));
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        Close();
        formLoginRef.Show();
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