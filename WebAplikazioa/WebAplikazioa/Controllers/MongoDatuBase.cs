using static System.Net.Mime.MediaTypeNames;
using WebAplikazioa.Services;
using Microsoft.Web.Administration;

namespace WebAplikazioa.Controllers
{
    public class MongoDatuBase
    {
        public string Get(string _id)
        {
            var connection = WebConfigurationManager.ConnectionStrings["MongoDB"].ToString();
            MongoDataService dataService = new MongoDataService(connection);

            return dataService.findOne("test", "people", String.Format("{ { _id: ObjectId("{0}") } }", _id));
        }
    }
}
