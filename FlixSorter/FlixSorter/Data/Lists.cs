using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixSorter.Data
{
    public class List
    {
        public List<MovieTV> All { get; set; }
        public List<MovieTV> Movies { get; set; }
        public List<MovieTV> TV { get; set; }
    }

    public class MovieTV
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string Rated { get; set; }
        public string Genres { get; set; }
        public string Languages { get; set; }
    }
}
