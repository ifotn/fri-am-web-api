using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace fri_am_api.Models
{
    [Table("Album")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Range(0,10000)]
        public decimal Price { get; set; }

        [Required]
        public int ArtistId { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
