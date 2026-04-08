using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.UI.Models;

public enum StatusConsulta
{
    Agendada,
    Realizada,
    Cancelada
}

public class Consulta
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Paciente Paciente { get; set; } = null!;
    public Medico Medico { get; set; } = null!;
    public DateTime DataHora { get; set; }
    public StatusConsulta Status { get; set; } = StatusConsulta.Agendada;
    public string Diagnostico { get; set; } = string.Empty;
}
