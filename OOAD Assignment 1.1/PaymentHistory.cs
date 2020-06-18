using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment_1._1
{
    public class PaymentHistory
    {
        // instance variables
        private string code;
        private string movieName;
        private string movieShowtime;
        private string seatsChosen;
        private decimal pricePerTicket;
        private int numOfTickets;
        private decimal totalPrice;
        private string dateOfPurchase;
        private string timeOfPurchase;
        private int originalBonusPoints;
        private int bonusPointsGained;
        private int newBonusPoints;

        // properties
        public string Code
        {
            get { return code; }
        }

        public string MovieName
        {
            get { return movieName; }
        }

        public string MovieShowTime
        {
            get { return movieShowtime; }
        }

        public string SeatsChosen
        {
            get { return seatsChosen; }
        }

        public decimal PricePerTicket
        {
            get { return pricePerTicket; }
        }

        public int NumOfTickets
        {
            get { return numOfTickets; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        public string DateOfPurchase
        {
            get { return dateOfPurchase; }
        }

        public string TimeOfPurchase
        {
            get { return timeOfPurchase; }
        }

        public int OriginalBonusPoints
        {
            get { return originalBonusPoints; }
        }

        public int BonusPointsGained
        {
            get { return bonusPointsGained; }
        }

        public int NewBonusPoints
        {
            get { return newBonusPoints; }
        }

        // constructor
        public PaymentHistory(string code, string movieName, string movieShowtime, string seatsChosen, decimal pricePerTicket, int numOfTickets,
                                decimal totalPrice, string dateOfPurchase, string timeOfPurchase, int originalBonusPoints, int bonusPointsGained,
                                int newBonusPoints)
        {
            this.code = code;
            this.movieName = movieName;
            this.movieShowtime = movieShowtime;
            this.seatsChosen = seatsChosen;
            this.pricePerTicket = pricePerTicket;
            this.numOfTickets = numOfTickets;
            this.totalPrice = totalPrice;
            this.dateOfPurchase = dateOfPurchase;
            this.timeOfPurchase = timeOfPurchase;
            this.originalBonusPoints = originalBonusPoints;
            this.bonusPointsGained = bonusPointsGained;
            this.newBonusPoints = newBonusPoints;
        }
    }
}