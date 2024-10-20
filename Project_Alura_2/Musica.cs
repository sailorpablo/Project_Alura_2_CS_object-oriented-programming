class Musica
{
    public string? Nome { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }

    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à BANDA {Artista} e tem duração de: {Duracao}";
    public void ExibirFichaTecnica()
      {

          Console.WriteLine($"Nome: {Nome}");
          Console.WriteLine($"Artista: {Artista}");
          Console.WriteLine($"Duração: {Duracao}");
          if (Disponivel)
          {
              Console.WriteLine("Música disponível no plano.\n");
          }
          else
          {
              Console.WriteLine("Música não disponível no plano.\n");
          }

      }

    public void AddMusica()
    {
        Console.Clear();
        Console.WriteLine("Vamos adicionar musicas a um album ok? \n");

        Console.WriteLine("Nome da música: ");
        string nomeMusica = Console.ReadLine()!;

        Console.WriteLine("Duração da música: ");
        int duracaoMusica = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Nome do artista: ");
        string nomeDoArtista = Console.ReadLine()!;

        Musica musica = new Musica();

        musica.Nome = nomeMusica;
        musica.Duracao = duracaoMusica;
        musica.Artista = nomeDoArtista;


        Console.WriteLine($"Antes de continuar, segue as informações inputadas: Musica: {musica.Nome}, Duracao: {musica.Duracao}, Artista: {musica.Artista} \n\n");

        Console.Write("A qual album essa música pertence? ");
        string nomeAlbum = Console.ReadLine()!;

        Album album = new Album();

        album.AdicionarMusicaAlbum(nomeAlbum, nomeMusica);

        Console.WriteLine($"Segue as informações inputadas: Album: {nomeAlbum}\n\n");

        Thread.Sleep(2500);


    }
}


