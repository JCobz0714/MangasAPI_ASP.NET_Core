namespace MangasAPI.DTOs

public record class CreateGameDto(
    string Name,
    string Author,
    string Genre,
    DateOnly PublishedDate
);
