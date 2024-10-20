namespace Project_Alura_2.Models;

class Musica
{   
    public string? NomeMusica { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {NomeMusica} pertence à BANDA {Artista} e tem duração de: {Duracao}";
    public void ExibirFichaTecnica()
      {

          Console.WriteLine($"Nome: {NomeMusica}");
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

}


