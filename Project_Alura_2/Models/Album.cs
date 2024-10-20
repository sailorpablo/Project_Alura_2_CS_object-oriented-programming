namespace Project_Alura_2.Models;

class Album
{
    
    public string NomeAlbum { get; set; }
    public int DuracaoAlbum { get; set; }

    public List<Musica> Musicas = new List<Musica>();

  
    public void AdicionarMusicaAlbum(Musica musica)
    {

        Musicas.Add(musica);
        
    }



}
