using Microsoft.AspNetCore.Mvc;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]

    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>(){
            new Book{
                ID= 1,
                Title = "Lean Startup",
                GenreId=1, //Personal Growth
                PageCount=200,
                PublishDate = new DateTime(2001,6,16)
            },
            new Book{
                ID= 2,
                Title = "Herland",
                GenreId=2, //Science Fiction
                PageCount=250,
                PublishDate = new DateTime(2010,5,10)
            },
            new Book{
                ID= 3,
                Title = "Dune",
                GenreId=1, //Personal Growth
                PageCount=540,
                PublishDate = new DateTime(2001,12,21)
            }
        };

    [HttpGet]

    public List<Book> GetBooks()
    {
        var bookList= BookList.OrderBy(x=> x.ID).ToList<Book>();
        return bookList;
    }

    }
}