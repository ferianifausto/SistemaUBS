using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Entities;

public class Medico
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Especialidade { get; private set; }
    public int UsuarioId { get; private set; }

    private Medico() { }

    public Medico(string nome, string especialidade, int usuarioId)
    {
        Nome = nome;
        Especialidade = especialidade;
        UsuarioId = usuarioId;
    }

    private List<string> Validar()
    {
        var erros = new List<string>();

        if (string.IsNullOrEmpty(Nome))
            erros.Add("Login é obrigatório");

        if (string.IsNullOrEmpty(Especialidade))
            erros.Add("A especialidade é obrigatória");

        return erros;
    }
}
