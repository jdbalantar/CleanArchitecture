using AutoFixture;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CleanArchitecture.Application.UnitTests.Mocks
{
    public static class MockVideoRepository
    {
        public static void AddDataVideoRepository(StreamerDbContext streamerDbContextFake)
        {
            var fixture = new Fixture();

            //! Evitar error AutoFixture.ObjectCreationExceptionWithPath : AutoFixture was unable to create an instance of type AutoFixture.Kernel.FiniteSequenceRequest because the traversed object graph contains a circular reference. Information about the circular path follows below. This is the correct behavior when a Fixture is equipped with a ThrowingRecursionBehavior, which is the default. This ensures that you are being made aware of circular references in your code. Your first reaction should be to redesign your API in order to get rid of all circular references. However, if this is not possible (most likely because parts or all of the API is delivered by a third party), you can replace this default behavior with a different behavior: on the Fixture instance, remove the ThrowingRecursionBehavior from Fixture.Behaviors, and instead add an instance of OmitOnRecursionBehavior:

            //Esta caracteristica omite la recursion y omite la referencia circular al 
            //momento de generar la data
            //Esta referencia circular es causada por las relaciones entre tablas y objetos (EF)
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            //En esta linea generamos la data
            var videos = fixture.CreateMany<Video>().ToList();
            videos.Add(fixture.Build<Video>().With(x => x.CreatedBy, "jdbalanta").Create());

            streamerDbContextFake.Videos!.AddRange(videos);
            streamerDbContextFake.SaveChanges();
        }
    }
}
