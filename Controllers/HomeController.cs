using System;
using System.Web.Mvc;
using MvcYoutube.Models;

public class HomeController : Controller
{
    private readonly VideoEntities _context;

    public HomeController()
    {
        _context = new VideoEntities();
    }

    [HttpPost] //
    public ActionResult TrackAnalytics(Analytic analytics)
    {
        if (ModelState.IsValid)
        {
            // Calculate the watched time as a float, for example:
            float watchedTimeInSeconds = (float)(DateTime.UtcNow.ToOADate() - analytics.Timestamp.ToOADate());
            analytics.WatchedTime = watchedTimeInSeconds;
            analytics.Timestamp = DateTime.UtcNow;

            _context.Analytics.Add(analytics);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200); // OK
        }
        return new HttpStatusCodeResult(400); // Bad Request
    }


    public ActionResult Index()
    {
        ViewBag.Title = "YouTube Video Player";
        return View();
    }
}
