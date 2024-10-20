using Project_Alura_2.Models;


List<Album> listaAlbum = new List<Album>();

void Principal()
{

    Console.WriteLine("Bem vindo, selecione uma das opções:\n");

    Console.WriteLine("(1) - Adicionar música a àlbum\n(2) - Exibir todos albuns\n");

    int escolha = int.Parse(Console.ReadLine()!);



    switch (escolha)
    {
        case 1:
            AdicionarMusica();
            break;

        case 2:
            MostrarAlbuns();
            break;
    }


}

void MostrarAlbuns()
{
    Console.WriteLine("Segue lista com todos os albuns e suas respectivas informações: ");

    foreach (var album in listaAlbum) {

        foreach ( var musica in album.Musicas )
        {
            Console.WriteLine(album.NomeAlbum + " - " + musica.NomeMusica + " - " + musica.Artista);
        }

    
    }


    Thread.Sleep(2500);
    Principal();

}

void AdicionarMusica()
{
    Album album = new Album();
    Musica musica = new Musica();

    Console.Clear();
    Console.WriteLine("Vamos adicionar musicas a um album ok? \n");

    Console.WriteLine("Nome da música: ");
    string nomeMusica = Console.ReadLine()!;

    Console.WriteLine("Duração da música: ");
    int duracaoMusica = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Nome do artista: ");
    string nomeDoArtista = Console.ReadLine()!;

    

    musica.NomeMusica = nomeMusica;
    musica.Duracao = duracaoMusica;
    musica.Artista = nomeDoArtista;


    Console.WriteLine($"Antes de continuar, segue as informações inputadas: Musica: {musica.NomeMusica}, Duracao: {musica.Duracao}, Artista: {musica.Artista} \n\n");

    Console.Write("A qual album essa música pertence? ");
    string nomeAlbum = Console.ReadLine()!;

    album.NomeAlbum = nomeAlbum;
   
    album.AdicionarMusicaAlbum( musica );
    listaAlbum.Add(album);


    Console.WriteLine($"Segue as informações inputadas: Album: {nomeAlbum}\n\n");

    Thread.Sleep(2500);
    Principal();

}


Principal();

