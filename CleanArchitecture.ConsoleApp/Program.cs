using CleanArchitecture.Data;
using CleanArchitecture.Domain;




StreamerDbContext dbContext = new();
await AddNewStreamerWithVideoId();


async Task AddNewStreamerWithVideoId()
{
    var hungertGames = new Video
    {
        Nombre = "Batman forever",
        StreamerId = 3
    };

    await dbContext.AddAsync(hungertGames);
    await dbContext.SaveChangesAsync();
}

Streamer streamer = new()
{
    Name = "Amazon Prime",
    Url = "https://www.amazonprime.com"
};

await dbContext!.Streamers!.AddAsync(streamer);
await dbContext!.SaveChangesAsync();

var movies = new List<Video>()
{
    new Video(){Nombre = "Mad max",StreamerId = streamer.Id},
    new Video(){Nombre = "Batman",StreamerId = streamer.Id},
    new Video(){Nombre = "Superman",StreamerId = streamer.Id},
    new Video(){Nombre = "Crepúsculo",StreamerId = streamer.Id},
};

await dbContext!.AddRangeAsync(movies);
await dbContext!.SaveChangesAsync();

