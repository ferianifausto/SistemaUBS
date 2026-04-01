namespace SistemaUBS.Domain.Entities;

public class Paciente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public int UsuarioId { get; private set; }

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
}