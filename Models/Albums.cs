using System;
using System.Collections.Generic;

namespace arqui.Models
{
    public partial class Albums
    {
        public Albums()
        {

        }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

    }
}
