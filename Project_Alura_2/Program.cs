
void Principal()
{

    Console.WriteLine("Bem vindo, selecione uma das opções:\n");

    Console.WriteLine("(1) - Adicionar música a àlbum\n(2) - Exibir todos albuns\n");

    int escolha = int.Parse(Console.ReadLine()!);

    Musica musica = new Musica();
    Album album = new Album();

    switch (escolha)
    {
        case 1:
            musica.AddMusica();
            Principal();

            break;
        case 2:
            album.MostrarAlbuns();
            Principal();

            break;
    }


}


Principal();

