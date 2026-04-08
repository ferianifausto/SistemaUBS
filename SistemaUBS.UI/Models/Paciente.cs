using SistemaUBS.Domain.Constants;
using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.UI.Models;

public class Paciente : Usuario
{
    public string NumSus { get; set; } = string.Empty;
    public string DataNascimento { get; set; } = string.Empty;

    public Paciente()
    {
        Tipo = TipoUsuario.Paciente;
    }
}
