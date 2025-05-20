class Podcast
{
    public string Nome { get; }
    public string Host { get; }

    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} - {Host}");
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Titulo}");
        }
        Console.WriteLine($"Total de episódios: {episodios.Count()}");
    }
}