using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary.Services.Models;

namespace VideoLibrary.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public List<DirectorDTO> Directors { get; set; }
        public List<DirectorDTO> Actors { get; set; }
    }
}

