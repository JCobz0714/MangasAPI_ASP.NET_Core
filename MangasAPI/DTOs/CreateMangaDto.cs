namespace MangasAPI.DTOs;

public record class CreateMangaDto(
    string Name,
    string Author,
    string Genre,
    DateOnly PublishedDate
);
