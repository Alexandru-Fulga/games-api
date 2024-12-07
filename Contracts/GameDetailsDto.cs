namespace games_api.Contracts;

public record class GameDetailsDto(int Id, string Name, int GenreId, decimal Price, DateOnly ReleaseDate);