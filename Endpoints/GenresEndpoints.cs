using games_api.Data;
using games_api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace games_api.Endpoints;

public static class GenresEndpoints
{
    public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("genres").WithParameterValidation();

        group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Genres
            .Select(genre => genre.ToDto())
            .AsNoTracking()
            .ToListAsync()
        );

        return group;
    }
}
