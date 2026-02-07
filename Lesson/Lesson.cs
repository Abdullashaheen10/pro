namespace WebApplication4.Lesson
{
    public class Lesson
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public string TrackName { get; set; } = "";
        public string Title { get; set; } = "";
        public string DriveUrl { get; set; } = "";
    }

    public static class LessonStore
    {
        public static List<Lesson> Lessons = new List<Lesson>
        {
            new Lesson
            {
                Id = 1,
                TrackId = 1,
                TrackName = "Backend .NET",
                Title = "Introduction to .NET",
                DriveUrl = "https://drive.google.com/your-drive-link-here"
            },
            new Lesson
            {
                Id = 2,
                TrackId = 1,
                TrackName = "Backend .NET",
                Title = "Entity Framework Basics",
                DriveUrl = "https://drive.google.com/your-drive-link-here"
            },
            new Lesson
            {
                Id = 3,
                TrackId = 2,
                TrackName = "Frontend",
                Title = "HTML & CSS",
                DriveUrl = "https://drive.google.com/your-drive-link-here"
            }
        };
    }
}
