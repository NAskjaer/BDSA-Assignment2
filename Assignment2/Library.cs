using System;

namespace Assignment2 {

    public static class Library{

        public class Student {

            public int Id { get; } 
            public string GivenName { get; set; }
            public string Surname { get; set; }
            public Status Status {
                get => getStatus();
            }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime GraduationDate { get; set; }


            Status getStatus() {
                var currentTime = DateTime.Now;

                /* Rules 
                - New students are only new until their first day starts.
                */
                if (currentTime > EndDate && EndDate == GraduationDate) {
                    return Status.Graduated;
                } else if (currentTime >= EndDate && EndDate < GraduationDate){
                    return Status.Dropout;            
                } else if (currentTime > StartDate && currentTime < EndDate) {
                    return Status.Active;
                } else {
                    return Status.New;
                }
            }

            public Student (int id, string givenname, string surname, DateTime start, DateTime end, DateTime graduation){
                Id = id;
                GivenName = givenname;
                Surname = surname;
                StartDate = start;
                EndDate = end;
                GraduationDate = graduation;
            }

            public override string ToString(){
                return $"Id: {Id}, {GivenName} {Surname} - {getStatus()}, Start Date: {StartDate}, End Date: {EndDate}, Graduation Date: {GraduationDate}";
            }

        }

        public record ImmutableStudent {
            public int Id { get; init; } 
            public string GivenName { get; init; }
            public string Surname { get; init; }
            public Status Status {get; init; }
            public DateTime StartDate { get; init; }
            public DateTime EndDate { get; init; }
            public DateTime GraduationDate { get; init; }
            


            public ImmutableStudent(int id, string givenname, string surname, DateTime start, DateTime end, DateTime graduation){
                this.Id = id;
                this.GivenName = givenname;
                this.Surname = surname;
                this.StartDate = start;
                this.EndDate = end;
                this.GraduationDate = graduation;

                var currentTime = DateTime.Now;

                /* Rules 
                - New students are only new until their first day starts.
                */
                if (currentTime > EndDate && EndDate == GraduationDate) {
                    Status = Status.Graduated;
                } else if (currentTime >= EndDate && EndDate < GraduationDate){
                    Status = Status.Dropout;            
                } else if (currentTime > StartDate && currentTime < EndDate) {
                    Status = Status.Active;
                } else {
                    Status = Status.New;
                }
            }
            
            public override string ToString(){
                return $"Id: {Id}, {GivenName} {Surname} - {Status}, Start Date: {StartDate}, End Date: {EndDate}, Graduation Date: {GraduationDate}";
            }
        }
        
        public enum Status {
            New, Active, Dropout, Graduated
        }
    }
}
