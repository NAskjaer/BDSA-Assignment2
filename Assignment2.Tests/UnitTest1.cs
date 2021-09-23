using System;
using Xunit;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        // Student(id, givenname, surname, start, end, graduation)
        [Fact]
        public void Student_has_status_new()
        {
            Library.Student test = new Library.Student(0, "New", "Student", new DateTime(2021, 9, 24), new DateTime(2024, 9, 24), new DateTime(2024, 9, 24));
            var actual = test.Status;
            var expected = Library.Status.New;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Student_has_status_Active()
        {
            Library.Student test = new Library.Student(0, "New", "Student", new DateTime(2021, 9, 23), new DateTime(2024, 9, 24), new DateTime(2024, 9, 24));
            var actual = test.Status;
            var expected = Library.Status.Active;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Student_has_status_Dropout()
        {
            Library.Student test = new Library.Student(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2020, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.Status;
            var expected = Library.Status.Dropout;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Student_has_status_Graduated()
        {
            Library.Student test = new Library.Student(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.Status;
            var expected = Library.Status.Graduated;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Student_ToString()
        {
            Library.Student test = new Library.Student(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.ToString();
            var expected = "Id: 0, New Student (Graduated), Start Date: 09/22/2018, End Date: 09/22/2021, Graduation Date: 09/22/2021";
            Assert.Equal(expected,actual);
        }


        /*
        ImmutableStudent testing
        - Student(id, givenname, surname, start, end, graduation)
        */
        [Fact]
        public void ImmutableStudent_has_status_new()
        {
            Library.ImmutableStudent test = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2021, 9, 24), new DateTime(2024, 9, 24), new DateTime(2024, 9, 24));
            var actual = test.Status;
            var expected = Library.Status.New;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ImmutableStudent_has_status_Active()
        {
            Library.ImmutableStudent test = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2021, 9, 23), new DateTime(2024, 9, 24), new DateTime(2024, 9, 24));
            var actual = test.Status;
            var expected = Library.Status.Active;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ImmutableStudent_has_status_Dropout()
        {
            Library.ImmutableStudent test = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2020, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.Status;
            var expected = Library.Status.Dropout;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ImmutableStudent_has_status_Graduated()
        {
            Library.ImmutableStudent test = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.Status;
            var expected = Library.Status.Graduated;
            Assert.Equal(expected,actual);
        }


        [Fact]
        public void ImmutableStudents_are_Equal()
        {
            Library.ImmutableStudent test1 = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));
            Library.ImmutableStudent test2 = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));

            Assert.Equal(test1,test2);
        }


        [Fact]
        public void ImmutableStudents_ToString()
        {
            Library.ImmutableStudent test = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2018, 9, 22), new DateTime(2021, 9, 22), new DateTime(2021, 9, 22));
            var actual = test.ToString();
            var expected = "Id: 0, New Student (Graduated), Start Date: 09/22/2018, End Date: 09/22/2021, Graduation Date: 09/22/2021";
            Assert.Equal(expected,actual);
        } 
    }
}
