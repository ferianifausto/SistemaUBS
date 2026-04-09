namespace SistemaUBS.UI;

using System;
using System.Windows.Forms;
using SistemaUBS.Application.Services;
using SistemaUBS.Infrastructure.Repositories;
using SistemaUBS.UI.Forms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var usuarioRepository = new UsuarioRepository();
        var pacienteRepository = new PacienteRepository();
        var medicoRepository = new MedicoRepository();
        var consultaRepository = new ConsultaRepository();
        var exameRepository = new ExameRepository();

        var usuarioService = new UsuarioService(usuarioRepository);
        var pacienteService = new PacienteService(
            pacienteRepository,
            consultaRepository,
            exameRepository);

        var medicoService = new MedicoService(
            medicoRepository,
            consultaRepository,
            exameRepository);

        Application.Run(new FormLogin());
    }
}