class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista.Nome}";

    public void ExibirFicha()
    {
        Console.WriteLine($"Descrição: {DescricaoResumida}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adqura o plano");
        }
    }
    public void exibirArtistaNome()
    {
        Console.WriteLine($"O nome do artista é {Artista}, e o nome da música: {Nome}");
    }

}
