namespace MangasAPI.DTOs;

public record class MangaDto(
    int Id,
    string Name,
    string Author,
    string Genre,
    DateOnly PublishedDate
)