using Api.Controllers;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Entity;

namespace Api.Controllers{
    [ApiController]
    [Route("/movies")]
    public class MovieController : AController<Movie> {
        
        public MovieController(IRepository<Movie> repository, ILogger<MovieController> logger) : base(repository, logger) {
        }
    }
}