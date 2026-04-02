using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Entities;

public class Exame
{
    public int Id { get; private set; }
    public int PacienteId { get; private set; }
    public int MedicoId { get; private set; }
    public string Descricao { get; private set; }
    public string? Resultado { get; private set; }
    public DateTime Data { get; private set; }

    private Exame() { }

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


}
