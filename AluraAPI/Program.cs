using System.Text.Json;
using AluraAPI.Filtros;
using System.Security.Cryptography.X509Certificates;
using AluraAPI.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFiltro.FiltrarMusicasEmCsharp(musicas);
        //musicas[1988].ExibirDetalhesDaMusica();
        //LinqFiltro.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        //var musicasPreferidasDoDionatan = new MusicasPreferidas("Dionatan");
        //musicasPreferidasDoDionatan.AdicionarMusicaFavorita(musicas[1]);
        //musicasPreferidasDoDionatan.AdicionarMusicaFavorita(musicas[165]);
        //musicasPreferidasDoDionatan.AdicionarMusicaFavorita(musicas[288]);
        //musicasPreferidasDoDionatan.AdicionarMusicaFavorita(musicas[1405]);
        //musicasPreferidasDoDionatan.AdicionarMusicaFavorita(musicas[443]);

        //musicasPreferidasDoDionatan.ExibirMusicasFavoritas();
        Console.WriteLine();

        //var musicasPreferidasDaEduarda = new MusicasPreferidas("Eduarda");
        //musicasPreferidasDaEduarda.AdicionarMusicaFavorita(musicas[222]);
        //musicasPreferidasDaEduarda.AdicionarMusicaFavorita(musicas[1666]);
        //musicasPreferidasDaEduarda.AdicionarMusicaFavorita(musicas[420]);
        //musicasPreferidasDaEduarda.AdicionarMusicaFavorita(musicas[110]);
        //musicasPreferidasDaEduarda.AdicionarMusicaFavorita(musicas[20]);

        //musicasPreferidasDaEduarda.ExibirMusicasFavoritas();

        //musicasPreferidasDaEduarda.GerarArquivosJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
