using Microsoft.AspNetCore.Mvc;

public class StatusController : Controller
{
    public string Read()
    {
        return "Finished";
    }

    public ActionResult<IEnumerable<string>> Dobro(int n)
    {
        return new List<string> {"teste", "teste2"};
    }
}


// StatusController statusCtrl = new StatusController();
// statusCtrl.Read(); // Finished

// http://localhost:1234/Status/Read