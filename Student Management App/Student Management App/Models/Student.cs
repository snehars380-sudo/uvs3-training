namespace Student_Management_App.Models
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Grade { get; set; } = string.Empty;

        public int Tamil { get; set; }
        public int English { get; set; }
        public int Math { get; set; }


        public int  Mark => Tamil + English + Math;

    }
}
