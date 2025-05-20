class Episodio
{
    public int NumeroEpisodio { get; }
    public string Titulo { get; }
    public int Duracao { get; }

    private List<string>Convidados = new List<string>();

    public Episodio(int numeroEpisodio, string titulo, int duracao)
    {
        NumeroEpisodio = numeroEpisodio;
        Titulo = titulo;
        Duracao = duracao;

    }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }

    public void ResumEpisodio()
    {
        Console.WriteLine("O resumo do episódio é: \n ");
        Console.WriteLine($"Episódio N{NumeroEpisodio} - {Titulo}\nDuração de {Duracao}s");
        Console.WriteLine($"");
        if (Convidados.Count() > 0)
        {
            Console.WriteLine($"com os convidados:");
            foreach (string convidado in Convidados)
            {
                Console.WriteLine(convidado);
            }
        }

    }
}