namespace MauiApp1.Models
{
    public class SubjectMark
    {
        public string Subject { get; set; }
        public int TheoryMarks { get; set; }
        public int PracticalMarks { get; set; }
        public int Total => TheoryMarks + PracticalMarks;
        public string Grade { get; set; }
    }
}
