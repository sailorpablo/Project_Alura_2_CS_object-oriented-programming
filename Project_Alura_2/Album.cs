
class Album
{
    
    //public string NomeAlbum { get; set; }

    public int DuracaoAlbum { get; set; }

    public Dictionary <string,string> Musicas { get; set; } = new Dictionary<string,string>();



    public void AdicionarMusicaAlbum(string nomeAlbum, string nomeMusica) { 
        
        Musicas.Add(nomeAlbum,nomeMusica);

    }

    public void MostrarAlbuns()
    {
        Console.WriteLine("Segue lista com todos os albuns e suas respectivas informações: ");


    }

}
