using SistemaUBS.Domain.Constants;
using System.Security.Cryptography.X509Certificates;

namespace SistemaUBS.Domain.Entities;

public class Usuario //Classe usuário
{
    public int Id { get; private set; }
    public string Login { get; private set; } 
    public string SenhaHash  { get; private set; }
    public string Tipo { get; private set; }
    public bool Ativo { get; private set; }
    public DateTime DataCadastro { get; private set; }


    // Para o EF
    private Usuario() { }

    public Usuario(string login, string senha, string tipo)
    {
        Login = login;
        SenhaHash = senha;
        Tipo = tipo;
        Ativo = true;
        DataCadastro = DateTime.Now;
    }


    private List<string> Validar()
    {
        var erros = new List<string>();

        if (string.IsNullOrEmpty(Login))
            erros.Add("Login é obrigatório");

        if (string.IsNullOrEmpty(SenhaHash))
            erros.Add("Senha é obrigatória");

        if (Tipo != TipoUsuario.Paciente && Tipo != TipoUsuario.Medico)
            erros.Add("Informe o tipo de usuário");

        if (DataCadastro > DateTime.Now)
            erros.Add("A data de cadastro não pode ser futura");
        

        return erros;
    }

    public bool ValidarSenha(string senhaDigitada)
    {
        return SenhaHash == senhaDigitada;
    }
}