using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOAD_Assignment_1._1
{
    public class Cinema
    {
        // instance variables i.e. attributes for Cinema entity
        private string name;
        ArrayList memberList;
        ArrayList movieList;
        ArrayList staffList;

        // properties for instance variables
        public string Name
        {
            get { return name; }
        }

        // constructor
        public Cinema(string name)
        {
            this.name = name;
            memberList = new ArrayList();
            movieList = new ArrayList();
            staffList = new ArrayList();
        }

        // instance methods
        
        public void AddMovie(string movieName, string genre, string cast, decimal ticketPrice, string rating, string movieShowTime, int duration, int numOfSeatsAvailable, string hall, bool[,] seats, int movieIndex)
        {
            // create an Movie object and add it into the array list
            movieList.Add(new Movie(movieName, genre, cast, ticketPrice, rating, movieShowTime, duration, numOfSeatsAvailable, hall, seats, movieIndex));
        }
        
        public void AddMember(string name, int age, string ic, string phoneNum, string id,
                                string password, int bonusPoints)
        {
            memberList.Add(new Member(name, age, ic, phoneNum, id, password, bonusPoints));
        }

        public void AddStaff(string name, int age, string ic, string phoneNum, string id, string password)
        {
            staffList.Add(new Staff(name, age, ic, phoneNum, id, password));
        }

        // to get the current movieList
        public Movie[] GetMovieList()
        {
            // copy the elements of the movieList ArrayList to the movies Array
            Movie[] movies = (Movie[])movieList.ToArray(typeof(Movie));

            return movies;
        }

        // to get the current memberList
        public Member[] GetMemberList()
        {
            // Array object name is members whereas ArrayList object name is memberList

            // copy the elements of the memberList ArrayList to the memebrs Array
            Member[] members = (Member[])memberList.ToArray(typeof(Member));

            return members;
        }

        // to get the current staffList
        public Staff[] GetStaffList()
        {
            // copy the elements of the staffList ArrayList to the staff Array
            Staff[] staff = (Staff[])staffList.ToArray(typeof(Staff));

            return staff;
        }
    }
}
