using _30SecondsNambiaStyle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _30SecondsNambiaStyle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetNamibianCards()
        {
            try
            {

                // Namibian-themed words
                var words = new List<string>
                   {
                        "Fishrot", "Windhoek Lager", "Tafel Lager", "Kapana", "Fat Cakes","Ohole",
                         "The Dogg", "King TeeDee", "Sam Nujoma", "Namib Desert", "Etosha",
                        "Fish River Canyon", "Skeleton Coast", "Spitzkoppe", "Quiver Tree", "Oshakati",
                         "Herero Dress", "Himba Women", "Bushmen", "NAMAs", "Ricardo Mannetti",
                        "Brave Warriors", "Independence Day", "March 21", "Mealie Pap", "Matangara","Donkey Festival",
                         "Oshikundu", "Biltong", "Droëwors", "Meatco", "Bank Windhoek",
                         "German Colonial Rule", "Caprivi Strip", "UNAM", "NUST", "Okahandja","Swapo","Nxa","Sharp", "Aweh",
                         "Gobabis", "Namib Wild Horses", "Oryx", "Springbok", "Dune 45","Taxi",
                        "Deadvlei", "Epupa Falls", "Kolmanskop", "Otjikoto Lake", "Hoba Meteorite",
                         "Sam Shivute", "Air Namibia", "Ongwediva Trade Fair", "Hage Geingob", "Land of the Brave",
                        "NBC", "Namibian Sun", "Road Fund Administration", "TransNamib", "Sunburn",
                     "Sandwich Harbour", "Desert Adapted Elephants", "Windhoek Showgrounds", "Okavango Delta",
                      "Gondwana Lodges", "Safari", "NamibRand Nature Reserve", "Katutura", "Namport",
                    "Old Mutual", "NAMDEB", "Rundu", "Warm Land", "African Time","Chula Chula","Mahangu", "Oshiwambo", "Damara Punch",
                     "Friendly People", "Fat Cakes Vendor", "Sacky Shanghala", "Namibian Dollar", "Okavango River", "African Stars","Mjolo", "Ke December","Samuel Nujoma","Swakop"
                    };


                // Shuffle words and group into lists of 5
                var random = new Random();
                var shuffledWords = words.OrderBy(x => random.Next()).ToList();
                var cards = new List<List<string>>();

                for (int i = 0; i < shuffledWords.Count; i += 5)
                {
                    cards.Add(shuffledWords.Skip(i).Take(5).ToList());
                }

                return Json(cards); // Return the randomized cards as JSON
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
