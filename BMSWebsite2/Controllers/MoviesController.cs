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

        public IEnumerable<MOVIE> Get()
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                return entities.MOVIEs.ToList();
            }
        }

        public MOVIE Get(int id)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                return entities.MOVIEs.FirstOrDefault(m => m.MovieID == id);
            }
        }

    }
}
