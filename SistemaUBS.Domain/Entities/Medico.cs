using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Entities;

public class Medico
{
    public int Id { get; set; }
    public string CRM { get; set; }
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public int UsuarioId { get; set; }

    public Medico() { }
    public Medico(string nome, string especialidade, int usuarioId, string crm)
    {
        Nome = nome;
        Especialidade = especialidade;
        UsuarioId = usuarioId;
        CRM = crm;
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

    public bool EhValido()
    {
        return Validar().Count == 0;
    }
}
