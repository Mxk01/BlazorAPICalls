using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorEcommerceFullStack.Shared.Models;
namespace BlazorEcommerceFullStack.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private static List<Anime> anime = new List<Anime>{
        new Anime{
            Id=1,
            Name="Kimetsu No Yaiba",
            Genre="Drama",
            Rating=9,
            ImageUrl="https://pics.filmaffinity.com/Demon_Slayer_Kimetsu_no_Yaiba_TV_Series-565420400-large.jpg"

        },
         new Anime{
            Id=2,
            Name="Naruto",
            Genre="Action,Comedy",
            Rating=8,
            ImageUrl="https://pics.filmaffinity.com/Demon_Slayer_Kimetsu_no_Yaiba_TV_Series-565420400-large.jpg"


        },
         new Anime{
            Id=3,
            Name="Kimetsu No Yaiba",
            Genre="Drama",
            Rating=9,
            ImageUrl="https://pics.filmaffinity.com/Demon_Slayer_Kimetsu_no_Yaiba_TV_Series-565420400-large.jpg"


        }

    };

        [HttpGet]
        public async Task<IActionResult>TestStuff()
        {
            return Ok(anime);
        }
    }
}
