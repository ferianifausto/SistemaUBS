using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.UI.Models;

public class Exame
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Consulta ConsultaRelacionada { get; set; } = null!;
    public string NomeExame { get; set; } = string.Empty;
    public string Resultado { get; set; } = string.Empty;
    public DateTime DataRealizacao { get; set; }
}
