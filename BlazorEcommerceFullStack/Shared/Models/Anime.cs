using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerceFullStack.Shared.Models
{
    public class Anime
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Rating { get; set; }

        public string Genre { get; set; }
        public string ImageUrl { get; set; } = "";
    }
}
