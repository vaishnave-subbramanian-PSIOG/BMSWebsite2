using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMSDataAccess;

namespace BMSWebsite2.ViewModels
{
    public class MoviesViewModel
    {
        public CASTING castings { get; set; }
        public GENRE genres { get; set; }
        public DIRECTOR directors { get; set; }

        public List<MOVIE> Movies { get; set; }
    }
}