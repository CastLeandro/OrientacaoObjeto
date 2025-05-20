/*Album albumDoQueen = new Album("A night at the opera");
Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhpsody")
{
    Duracao = 354,
    Disponivel = true,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);


Playlist playlist1 = new Playlist("Rock PL ");
playlist1.AdicionarMusica(musica1);
playlist1.AdicionarMusica(musica2);

playlist1.ExibirPlaylist();

Usuario user1 = new Usuario("usuari123", "123456");
user1.AdicionarPlaylistUsuario(playlist1);
user1.ExibirPlaylist();
*/

Episodio episodio1 = new Episodio(1, "Xispiritagem", 350);
episodio1.AdicionarConvidado("Xisp Master");
episodio1.ResumEpisodio();

Episodio ep2 = new Episodio(2, "Xispiritagem o Retorno", 4000);
ep2.AdicionarConvidado("Leandro");

Episodio ep3 = new Episodio(3, "Xispiritagem o inimigo agora é outro", 2500);

Podcast xisps = new Podcast("Xispers", "Nagao");
xisps.AdicionarEpisodio(episodio1);
xisps.AdicionarEpisodio(ep2);
xisps.AdicionarEpisodio(ep3);

xisps.ExibirDetalhes();

