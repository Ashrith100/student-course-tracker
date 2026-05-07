using Microsoft.AspNetCore.Mvc;

public class GpaController : Controller
{
    public static List<GpaCourse> Courses = new List<GpaCourse>();

    public IActionResult Index()
    {
        ViewBag.Gpa = CalculateGpa();
        return View(Courses);
    }

    [HttpPost]
    public IActionResult Add(int credits, double grade)
    {
        Courses.Add(new GpaCourse
        {
            Credits = credits,
            Grade = grade
        });

        return RedirectToAction("Index");
    }

    private double CalculateGpa()
    {
        if (Courses.Count == 0) return 0;

        double totalPoints = Courses.Sum(c => c.Credits * c.Grade);
        int totalCredits = Courses.Sum(c => c.Credits);

        return totalPoints / totalCredits;
    }
}

public class GpaCourse
{
    public int Credits { get; set; }
    public double Grade { get; set; }
}