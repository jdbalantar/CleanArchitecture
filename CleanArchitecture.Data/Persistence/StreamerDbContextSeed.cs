using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed> logger)
        {
            if (!context!.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos reacords al db {_context}", typeof(StreamerDbContext).Name);
            }
        }

        private static IEnumerable<Streamer> GetPreconfiguredStreamer()
        {
            return new List<Streamer>()
            {
                new Streamer(){CreatedBy = "jdbalanta", Name = "Maxi HBP", Url = "http://hbp.com"},
                new Streamer(){CreatedBy = "jdbalanta", Name = "Amazon VIP", Url = "http://amazonvip.com"},
            };
        }
    }
}
