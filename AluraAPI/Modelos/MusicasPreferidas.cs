using System.Text.Json;
namespace AluraAPI.Modelos;
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; } 


        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicaFavorita(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Músicas favoritas de {Nome}:");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivosJson() {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"\nO arquivo JSON gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
      
}

