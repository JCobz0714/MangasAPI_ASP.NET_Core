using MangasAPI.DTOs;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

const string getGameEndpointName = "GetManga";

List<MangaDto> mangas = [
    new (1,
        "One Piece",
        "Eiichiro Oda",
        "Action, Adventure, Fantasy",
        new(1999, 7, 22)
    ),
    new (2,
        "Naruto",
        "Masashi Kishimoto",
        "Action, Adventure, Fantasy",
        new(2002, 9, 20)
    ),
    new (3,
        "Dragon Ball",
        "Akira Toriyama",
        "Action, Adventure, Fantasy",
        new(1984, 2, 29)
    )
];

//GET /games
app.MapGet("mangas", () => mangas);

//GET /games/{id}
app.MapGet("mangas/{id}", (int id) => mangas.Find(manga => manga.Id == id)).WithName(getGameEndpointName);

//POST /games
app.MapPost("mangas", (CreateMangaDto newManga) => 
{
    MangaDto manga = new (
        mangas.Count + 1,
        newManga.Name,
        newManga.Author,
        newManga.Genre,
        newManga.PublishedDate
    );

    mangas.Add(manga);
    return Results.CreatedAtRoute(getGameEndpointName, new { id = manga.Id }, manga);
});

app.Run();
