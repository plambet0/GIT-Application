

using SUS.HTTP;
using SUS.MvcFramework;

namespace Git.Controllers
{
    public class RepositoriesController : Controller
    {
        public HttpResponse All()
        {
            return this.View();
        }

    }
}
