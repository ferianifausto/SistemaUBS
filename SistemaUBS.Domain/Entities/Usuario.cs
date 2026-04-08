using SistemaUBS.Domain.Constants;

namespace SistemaUBS.Domain.Entities;

public class Usuario //Classe usuário
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string SenhaHash { get; set; }
    public string Tipo { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }

    public Usuario() { }
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

    public bool EhValido()
    {
        return Validar().Count == 0;
    }

    public bool ValidarSenha(string senhaDigitada)
    {
        return SenhaHash == senhaDigitada;
    }
}