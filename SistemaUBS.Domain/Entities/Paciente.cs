namespace SistemaUBS.Domain.Entities;

public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int UsuarioId { get; set; }


    public Paciente() { }
    public Paciente(string nome, int usuarioId)
    {
        Nome = nome;
        UsuarioId = usuarioId;
    }

    private List<string> Validar()
    {
        var erros = new List<string>();

        if (string.IsNullOrEmpty(Nome))
            erros.Add("Login é obrigatório");

        return erros;
    }
    public bool EhValido()
    {
        return Validar().Count == 0;
    }
}