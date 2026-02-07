using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Lesson
{
    public class LessonsController : Controller
    {
        public IActionResult Index(int trackId = 1)
        {
            var lessons = LessonStore.Lessons.Where(l => l.TrackId == trackId).ToList();
            if (!lessons.Any())
                return NotFound();
            ViewBag.TrackName = lessons.First().TrackName;
            return View(lessons);
        }
    }
}
