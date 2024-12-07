namespace games_api.Contracts;

public record class GameSummaryDto(int Id, string Name, string Genre, decimal Price, DateOnly ReleaseDate);