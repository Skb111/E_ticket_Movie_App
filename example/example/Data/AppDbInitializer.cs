using example.Models;

namespace example.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationbuilder)
        {
            using (var serviceScope = applicationbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                 {

                    new Cinema()
                    {
                        Name = "Cinema 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Description = "Elegushi Cinema"
                    },
                     new Cinema()
                    {
                         Name = "Cinema 2",
                         Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                         Description = "Maryland Cinema"

                    },
                     new Cinema()
                    {
                          Name = "Cinema 3",
                          Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                          Description = "Ikeja Cinema"

                     },
                       new Cinema()
                       {
                           Name = "Cinema 4",
                           Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                           Description = "Spotlight Cinema"
                       },
                       new Cinema()
                      {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Ikoyi Cinema"

                       },
                    });

                    context.SaveChanges();                
                }


                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                 {
                new Producer()
                {
                    FullName = "Producer 1",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg",

                },
                new Producer()
                {
                    FullName = "Producer 2",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg",

                },
                new Producer()
                {
                    FullName = "Producer 3",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg",

                },
                new Producer()
                {
                    FullName = "Producer 4",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg",

                },
                new Producer()
                {
                    FullName = "Producer 5",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg",

                },
                });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                 {
                new Actor()
                {
                    FullName = "Actor 1",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                    CinemaId =1,
                    ProducerId=1
                },
                new Actor()
                {
                    FullName = "Actor 2",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                    CinemaId=2,
                    ProducerId=2
                },
                new Actor()
                {
                    FullName = "Actor 3",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                    CinemaId=3,
                    ProducerId=3
                },
                new Actor()
                {
                    FullName = "Actor 4",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                    CinemaId=4,
                    ProducerId=4
                },
                new Actor()
                {
                    FullName = "Actor 5",
                    Bio = "Biography",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                    CinemaId=5,
                    ProducerId=5
                },
                });
                    context.SaveChanges();
                }


                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                 {
                new Movie()
                {
                    Name = "Judge of the Jungle",
                    Description = "Jungle Movie",
                    Price = 39.98,
                    ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    CinemaId = 1,
                    ProducerId = 3,
                    MovieCategory = Enums.MovieCategory.Comedy

                },
                 new Movie()
                {
                    Name = "Sonic",
                    Description = "Sonic Movie",
                    Price = 22.56,
                    ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(-4),
                    CinemaId = 3,
                    ProducerId = 4,
                    MovieCategory = Enums.MovieCategory.Horror

                },
                  new Movie()
                {
                    Name = "Tom and Jerry",
                    Description = "Cartoon",
                    Price = 28,
                    ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(-2),
                    CinemaId = 3,
                    ProducerId = 4,
                    MovieCategory = Enums.MovieCategory.Action

                },
                   new Movie()
                {
                    Name = "Prince of Persia",
                    Description = "Action Movie",
                    Price = 45,
                    ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now,
                    CinemaId = 1,
                    ProducerId = 1,
                    MovieCategory = Enums.MovieCategory.Drama

                },
                    new Movie()
                {
                    Name = "Mortal Kombat",
                    Description = "Kombat Movie",
                    Price = 98,
                    ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(-2),
                    CinemaId = 2,
                    ProducerId = 3,
                    MovieCategory = Enums.MovieCategory.Documentary

                },
            });
                    context.SaveChanges();
                }


                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                 {
                new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 1

                },
                 new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 2

                },
                  new Actor_Movie()
                {
                    ActorId = 2,
                    MovieId = 3

                },
                   new Actor_Movie()
                {
                    ActorId = 2,
                    MovieId = 5

                },
                    new Actor_Movie()
                {
                    ActorId = 3,
                    MovieId = 1

                },
                });
                    context.SaveChanges();
                }

            }
        }
    }   
}
