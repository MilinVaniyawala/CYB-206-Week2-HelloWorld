using Microsoft.AspNetCore.Mvc; 
using System.Text.Encodings.Web;

namespace Week2_Hello_World.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld
        public string Index()
        {
            return "This is default's action...";
        }

        //
        // GET: /HelloWorld/Welcome
        // REQUIRES 'using System.Text.Encodings.Web;'
        public string Welcome(string name,int ID = 1)
        {
            // return "Welcome method..";
            // return HtmlEncoder.Default.Encode($"Hello {name}, Number of Times is: {numTimes}");
            return HtmlEncoder.Default.Encode($"Hello {name},ID: {ID}");
        }
    }
}
