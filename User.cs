class Usuario
{
    public string UserName { get; }
    public string Password { get; }
    private List<Playlist> Playlists = new List<Playlist>();

    public Usuario(string username, string password)
    {
        UserName = username;
        Password = password;
    }

    public void AdicionarPlaylistUsuario(Playlist playlist)
    {
        Playlists.Add(playlist);
    }

    public void ExibirPlaylist()
    {
        foreach (var playlist in Playlists)
        {
            Console.WriteLine($"Playlist: {playlist.Nome}");
        }
    }
}