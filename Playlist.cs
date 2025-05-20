class Playlist
{
    public string Nome { get; }
    private List<Musica> musicas = new List<Musica>();
    private bool Favorita;

    public Playlist(string nome)
    {
        Nome = nome;
        Favorita = false;
    }

    public void FavoritarPlaylist(bool favorita)
    {
        Favorita = favorita;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirPlaylist()
    {
        int i = 0;
        Console.WriteLine("As músicas na sua playlist são: ");
        foreach(var musica in musicas)
        {
            i++;
            Console.WriteLine($"Música {i}: {musica.Nome}");
        }
    }

}