using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Entities;

public class Exame
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public int MedicoId { get; set; }
    public string Descricao { get; set; }
    public string? Resultado { get; set; }
    public DateTime Data { get; set; }

    public Exame() { }
    public Exame(int pacienteId, int medicoId, string descricao, DateTime data)
    {
        PacienteId = pacienteId;
        MedicoId = medicoId;
        Descricao = descricao;
        Data = data;
    }


    public void DefinirResultado(string resultado)
    {
        Resultado = resultado;
    }
    private List<string> Validar()
    {
        var erros = new List<string>();

        if (PacienteId <= 0)
            erros.Add("Paciente inválido");

        if (MedicoId <= 0)
            erros.Add("Médico inválido");

        if (string.IsNullOrEmpty(Descricao))
            erros.Add("Descrição inválida");

        if (string.IsNullOrEmpty(Resultado))
            erros.Add("Resultado inválido");

        return erros;
    }

    public bool EhValido()
    {
        return Validar().Count == 0;
    }

}
