using Event.DAL;
using Event.DAL.Repository;
using Event.DOM;
using Microsoft.AspNetCore.Mvc;

namespace EventManagProj.Controllers
{
    public class VenueController : Controller
    {
        private readonly IVenueRepository _venue_repos;
        public VenueController(IVenueRepository venue_repos)
        {
            _venue_repos = venue_repos;
        }





        public IActionResult Index()
        {
            List<Venue> data = _venue_repos.ShowVenue();
            return View(data);
        }
    }
}
