namespace GLManager.Frontend.Models;

public class Evento
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DateOnly DataEvento { get; set; }

    public Evento(int id, string nome, DateOnly dataEvento)
    {
        this.Id = id;
        this.Nome = nome;
        this.DataEvento = dataEvento;
    }
}
