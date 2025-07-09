using MangasAPI.DTOs;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

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
app.MapGet("mangas/{id}", (int id) => mangas.Find(game => game.Id == id));

app.Run();
