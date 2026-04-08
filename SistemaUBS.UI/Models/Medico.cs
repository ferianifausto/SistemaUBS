using SistemaUBS.Domain.Constants;
using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.UI.Models;

public class Medico : Usuario
{
    public string CRM { get; set; } = string.Empty;
    public string Especialidade { get; set; } = string.Empty;

    public Medico()
    {
        Tipo = TipoUsuario.Medico;
    }
}