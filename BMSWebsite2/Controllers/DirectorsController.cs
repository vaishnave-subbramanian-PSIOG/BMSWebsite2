using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BMSDataAccess;

namespace BMSWebsite2.Controllers
{
    public class DirectorsController : ApiController
    {
        public IEnumerable<DIRECTOR> Get()
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                return entities.DIRECTORs.Include("MOVIEs").ToList();
            }
        }

        public DIRECTOR Get(int id)
        {
            using (BMSApplicationEntities entities = new BMSApplicationEntities())
            {
                return entities.DIRECTORs.FirstOrDefault(director => director.DirectorID==id);
            }
        }
    }
}
