using System;
using System.Collections.ObjectModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<SubjectMark> Marks { get; set; }

        public StudentViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            Students = new ObservableCollection<Student>
            {
                new Student
                {
                    RollNumber="3160011",
                    Name="Raman Kumar",
                    FatherName="Sohan Kumar",
                    MotherName="Babita Kumari",
                    DateOfBirth=new DateTime(2002,1,1),
                    Class="XII",
                    School="ABC School"
                }
            };

            Marks = new ObservableCollection<SubjectMark>
            {
                new SubjectMark{Subject="Math", TheoryMarks=55, PracticalMarks=22, Grade="B1"},
                new SubjectMark{Subject="Physics", TheoryMarks=61, PracticalMarks=23, Grade="A2"},
                new SubjectMark{Subject="Chemistry", TheoryMarks=45, PracticalMarks=25, Grade="B1"},
                new SubjectMark{Subject="Biology", TheoryMarks=65, PracticalMarks=20, Grade="A2"},
            };
        }
    }
}
