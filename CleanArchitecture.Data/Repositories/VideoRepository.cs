using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(StreamerDbContext context) : base(context)
        {
        }

        public async Task<Video?> GetVideoByNombre(string nombreVideo)
        {
            return await context.Videos!.FirstOrDefaultAsync(x => x.Nombre!.Equals(nombreVideo));
        }

        public async Task<IEnumerable<Video>?> GetVideoByUserName(string username)
        {
            return await context.Videos!.Where(x => x.CreatedBy.Equals(username)).ToListAsync();
        }
    }
}
