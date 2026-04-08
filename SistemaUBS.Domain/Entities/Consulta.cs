using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Entities;

public class Consulta
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public int MedicoId { get; set; }
    public string? Diagnostico { get; set; }
    public DateTime Data { get; set; }

    public Consulta() { }

    public Consulta(int pacienteId, int medicoId, DateTime data)
    {
        PacienteId = pacienteId;
        MedicoId = medicoId;
        Data = data;
    }

    private List<string> Validar()
    {
        var erros = new List<string>();

        if (PacienteId <= 0)
            erros.Add("Paciente inválido");

        if (MedicoId <= 0)
            erros.Add("Médico inválido");

        if (Data > DateTime.Now)
            erros.Add("A data de cadastro não pode ser futura");

        return erros;
    }

    public bool EhValido()
    {
        return Validar().Count == 0;
    }
}