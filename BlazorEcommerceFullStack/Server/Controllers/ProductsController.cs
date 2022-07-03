using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorEcommerceFullStack.Shared.Models;
namespace BlazorEcommerceFullStack.Server.Controllers
{
    // basically this is the endpoint that we will be accessing
    // so like instead of  doing 
    //  app.get("/api/products") we do [Route("api/[controller]")];
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        // so basically we use the model that we made (the Product class)
        // to make a list of Products ,which we can render
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id=1,
            Title="something",
            Description="lorem loremloremloremloremloremloremloremlorem orem ",
            ImageUrl="https://images.unsplash.com/photo-1589998059171-988d887df646?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8b3BlbiUyMGJvb2t8ZW58MHx8MHx8&w=1000&q=80",
            Price=9.99m
        },
         new Product
        {
            Id=2,
            Title="something2",
            Description="lorem loremloremloremloremloremloremloremlorem orem ",
            ImageUrl="https://images.unsplash.com/photo-1589998059171-988d887df646?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8b3BlbiUyMGJvb2t8ZW58MHx8MHx8&w=1000&q=80",
            Price=11.99m
        },
         new Product
        {
            Id=3,
            Title="something3",
            Description="lorem loremloremloremloremloremloremloremlorem orem ",
            ImageUrl="https://images.unsplash.com/photo-1589998059171-988d887df646?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8b3BlbiUyMGJvb2t8ZW58MHx8MHx8&w=1000&q=80",
            Price=13.99m
        }
    };
        [HttpGet]

        // swapped IAction   from Task<IAction>  with ActionResult<List<Product>>
        // b/c of this we can now see the schema 


        //  All public methods of  controller class are called action methods
        // https://www.tutorialsteacher.com/mvc/action-method-in-mvc
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            // 200 status - OK method gets called
            return Ok(Products);
        }
    } 
}
