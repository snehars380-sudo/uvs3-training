namespace StudentApp.Models;

public class Student
{
    public string Name { get; set; }
    public int Mark1 { get; set; }
    public int Mark2 { get; set; }
    public int Mark3 { get; set; }

    public int Total => Mark1 + Mark2 + Mark3;
}