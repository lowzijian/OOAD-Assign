using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment_1._1
{
    public class Movie
    {
        // instance variables i.e. attributes for Movie entity
        private string name;
        private string genre;
        private string cast;
        private decimal ticketPrice;
        private string rating;
        private string showTime;
        private int duration;
        private int numOfSeatsAvailable;
        private string hall;
        private bool[,] seats;
        private int movieIndex;// which is used to refer to the movie object created

        // properties for instance variables
        public string Name
        {
            get { return name; }
        }

        public string Genre
        {
            get { return genre; }
        }

        public string Cast
        {
            get { return cast; }
        }

        public decimal TicketPrice
        {
            get { return ticketPrice; }
        }

        public string Rating
        {
            get { return rating; }
        }

        public string ShowTime
        {
            get { return showTime; }
        }

        public int Duration
        {
            get { return duration; }
        }

        public int NumOfSeats
        {
            get { return numOfSeatsAvailable; }
            set { numOfSeatsAvailable = value; }
        }

        public string Hall
        {
            get { return hall; }
        }

        public bool[,] Seats
        {
            get { return seats; }
        }

        public int MovieIndex
        {
            get { return movieIndex; }
        }

        // constructor
        public Movie(string name, string genre, string cast, decimal ticketPrice, string rating, string showTime, int duration, int numOfSeatsAvailable, string hall, bool[,] seats, int movieIndex)
        {
            this.name = name;
            this.genre = genre;
            this.cast = cast;
            this.ticketPrice = ticketPrice;
            this.rating = rating;
            this.showTime = showTime;
            this.duration = duration;
            this.numOfSeatsAvailable = numOfSeatsAvailable;
            this.hall = hall;
            this.seats = seats;
            this.movieIndex = movieIndex;
        }
    }
}
