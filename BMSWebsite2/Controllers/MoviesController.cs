using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BMSDataAccess;

namespace BMSWebsite2.Controllers
{
    public class MoviesController : ApiController
    {   
        [HttpGet]
        [Route("api/movies")]
        public IHttpActionResult GetMovies()
        {
            using (BMSApplicationEntities entities  = new BMSApplicationEntities())
            {
                return Ok(entities.MOVIEs.ToList());
            }
        }
        [HttpGet]
        [Route("api/movies/{id?}")]
        public IHttpActionResult GetMovies(int id)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                return Ok(entities.MOVIEs.FirstOrDefault(c => c.MovieID == id));
            }
        }
        [HttpPost]
        [Route("api/movies")]
        public HttpResponseMessage PostMovies([FromBody] MOVIE movie)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                try
                {
                    entities.MOVIEs.Add(movie);
                    entities.SaveChanges();
                    var message = Request.CreateResponse(HttpStatusCode.Created, movie);
                    message.Headers.Location = new Uri(Request.RequestUri + movie.MovieID.ToString());
                    return message;
                }
                catch (Exception ex)
                {
                    return
                       Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);


                }
            }
        }

        [HttpDelete]
        [Route("api/movies/{id?}")]
        public void DeleteMovies(int id)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                entities.MOVIEs.Remove(entities.MOVIEs.FirstOrDefault(c => c.MovieID == id));
                entities.SaveChanges();
            }
        }

        [HttpPut]
        [Route("api/movies/{id?}")]
        public void PutMovies(int id, [FromBody] MOVIE movie)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                var entity = entities.MOVIEs.FirstOrDefault(c => c.MovieID == id);
                entity.MovieName = movie.MovieName;
                entity.Synopsis = movie.Synopsis;
                entity.CastingID = movie.CastingID;
                entity.GenreID = movie.GenreID;
                entity.DirectorID = movie.DirectorID;
                entities.SaveChanges();
            }
        }
    }
}
