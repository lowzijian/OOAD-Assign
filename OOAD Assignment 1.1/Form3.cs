using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing.Printing;
using Microsoft.VisualBasic;


namespace OOAD_Assignment_1._1
{
    public partial class MainMenuForm : Form
    {
        // instance variables
        private Cinema cinema;
        private User currentUser;
        private Movie[] movieList;
        private Movie theMovie;
        private Member[] memberList;
        private int numOfTickets;
        private string receiptDetails = ""; //to store receipt details


        // string array used to store movies' datails
        private string[] movieDetails = new string[6];
        // string array used to store the movies' halls
        private string[] hall = new string[6];

        // create two array list to store the rows and seatNum temporarily (int type)
        private ArrayList rows = new ArrayList();
        private ArrayList seatsNum = new ArrayList();

        Button[,] seatsMovie1 = new Button[5, 6];
        Button[,] seatsMovie2 = new Button[5, 6];
        Button[,] seatsMovie3 = new Button[5, 6];
        Button[,] seatsSelectedMovie = new Button[5, 6];
        Button[,] seatsSelectedMovie1 = new Button[5, 6];

        public MainMenuForm(Cinema cinema, User currentUser)
        {
            InitializeComponent();

            this.cinema = cinema;
            this.currentUser = currentUser;
            movieList = cinema.GetMovieList();
            memberList = cinema.GetMemberList();
            numOfTickets = 0;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
            axWindowsMediaPlayer3.Visible = false;

            //intialize tool tip
            ToolTip t1 = new ToolTip();
            
            // Set up the delays for the ToolTip.
            t1.AutoPopDelay = 5000;
            t1.InitialDelay = 1000;
            t1.ReshowDelay = 1000;

            // Force the ToolTip text to be displayed whether or not the form is active.
            t1.ShowAlways = true;

            t1.SetToolTip(this.pBoxShowing1, "Iron Man, Thor, the Hulk and the rest of the Avengers\nunite to battle their most powerful enemy yet -- the evil Thanos.\nOn a mission to collect all six Infinity Stones,\nThanos plans to use the artifacts to inflict his twisted will on reality.\n The fate of the planet and existence itself\n has never been more uncertain as everything\nthe Avengers have fought for has led up to this moment.");
            t1.SetToolTip(this.pBoxShowing2, "Jake Pentecost is a once-promising Jaeger pilot\nwhose legendary father gave his life to secure humanity's victory against the monstrous Kaiju.\nJake has since abandoned his training only to become caught up in a criminal underworld.\nBut when an even more unstoppable threat is unleashed to tear through cities\nand bring the world to its knees,\nJake is given one last chance by his estranged sister, \nMako Mori, to live up to his father's legacy.");
            t1.SetToolTip(this.pBoxShowing3, "Ethan Hunt and his IMF team find themselves in a race against time after a mission goes wrong.");


            // check if the currentUser is a Member or Staff
            if (currentUser is Member)
            {
                // loop through the movieList and get the movies' details
                for (int i = 0; i < movieList.Length; i++)
                {
                    movieDetails[i] = "Movie Name: " + movieList[i].Name + "\nGenre: " + movieList[i].Genre + "\nCast: " + movieList[i].Cast
                                        + "\nTicket Price: RM" + movieList[i].TicketPrice + "\nRating: " + movieList[i].Rating + "\nShow Time: "
                                        + movieList[i].ShowTime + "\nDuration: " + movieList[i].Duration + "\nMovie Hall: " + movieList[i].Hall;
                }

                // *********to show the movie seats for all three movies
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        // switch statement to decide on the seat to dsiplay
                        string seat = ((char)(65 + i)).ToString() + (j + 1);

                        Button b = new Button();
                        b.Name = "btn" + seat.ToString();
                        b.Width = 30;
                        b.Height = 20;
                        b.Text = seat;
                        b.Font = new Font(b.Font.FontFamily, 8);

                        seatsMovie1[i, j] = b;

                        FLPanelSeats1.Controls.Add(seatsMovie1[i, j]);
                    }

                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        // switch statement to decide on the seat to dsiplay
                        string seat = ((char)(65 + i)).ToString() + (j + 1);

                        Button b = new Button();
                        b.Name = "btn" + seat.ToString();
                        b.Width = 30;
                        b.Height = 20;
                        b.Text = seat;
                        b.Font = new Font(b.Font.FontFamily, 8);

                        seatsMovie2[i, j] = b;

                        FLPanelSeats2.Controls.Add(seatsMovie2[i, j]);
                    }

                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        // switch statement to decide on the seat to dsiplay
                        string seat = ((char)(65 + i)).ToString() + (j + 1);

                        Button b = new Button();
                        b.Name = "btn" + seat.ToString();
                        b.Width = 30;
                        b.Height = 20;
                        b.Text = seat;
                        b.Font = new Font(b.Font.FontFamily, 8);

                        seatsMovie3[i, j] = b;

                        FLPanelSeats3.Controls.Add(seatsMovie3[i, j]);
                    }

                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        // switch statement to decide on the seat to dsiplay
                        string seat = ((char)(65 + i)).ToString() + (j + 1);

                        Button b = new Button();
                        b.Name = "btn" + seat.ToString();
                        b.Width = 30;
                        b.Height = 20;
                        b.Text = seat;
                        b.Font = new Font(b.Font.FontFamily, 8);

                        seatsSelectedMovie[i, j] = b;

                        FLPanelSelectedMovieSeats.Controls.Add(seatsSelectedMovie[i, j]);
                    }


                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        // switch statement to decide on the seat to dsiplay
                        string seat = ((char)(65 + i)).ToString() + (j + 1);

                        Button b = new Button();
                        b.Name = "btn" + seat.ToString();
                        b.Width = 30;
                        b.Height = 20;
                        b.Text = seat;
                        b.Font = new Font(b.Font.FontFamily, 8);

                        seatsSelectedMovie1[i, j] = b;

                        FLPanelSelectedMovieSeats1.Controls.Add(seatsSelectedMovie1[i, j]);
                    }

                // to set the Checked property to true for all of the first radio button in the group boxes
                rbnMovie1ShowTime1.Checked = true;
                rbnMovie2ShowTime1.Checked = true;
                rbnMovie3ShowTime1.Checked = true;

                // add this item into the lbxSelectedSeats when the form loads
                lbxSelectedSeats.Items.Add("Seats Selected:");

               
                //intialize the redeem bonus tickets controls
                tbxShowName.Text = currentUser.Name;
                tbxShowLoginID.Text = currentUser.Id;
                tbxCurrentBP.Text = ((Member)currentUser).BonusPoints.ToString();
                tbxShowName.Enabled = false;
                tbxShowLoginID.Enabled = false;
                tbxCurrentBP.Enabled = false;
                picDisplay2.Visible = false;
                picDisplay1.Visible = false;
                picDisplay3.Visible = false;
                rbnMovie1.Checked = true;

                // intialize the column and row of purchase
                cmbRow.Enabled = true;
                cmbSeatNum.Enabled = true;

                //initialize the payment method of purchase
                rbnCash.Visible = true;
                rbnCredit.Visible = true;
                rbnCash.Checked = true;

                if (Convert.ToInt32(tbxCurrentBP.Text) < 20)
                {
                    btnRedeemTicket.Enabled = false;
                }
                else
                {
                    btnRedeemTicket.Enabled = true;
                }

                // display seats owned by the current member into list box lbxSeatsOwned
                lbxSeatsOwned.Items.Add("Seat(s) Owned:");
                lbxSeatsOwned.Items.Add(string.Format("{0,-3}|{1,-27}|{2,-8}|{3}","No", "Movie Name", "Show Time", "Seat"));

                Member thisMember = (Member)currentUser;

                // get the seat(s) owned by current member
                for (int i = 0; i < thisMember.SeatsOwned.Count; i++)
                {
                    string seatInIndexFormat = thisMember.SeatsOwned[i].ToString();

                    // retrieve the movie index from the seatInIndexFormat
                    int movieIndex = Convert.ToInt32(seatInIndexFormat.Substring(0, 1));

                    string movieName = movieList[movieIndex].Name;
                    string showTime = movieList[movieIndex].ShowTime;

                    // retrieve the seat (represented by row and seatNum) from the seatInIndexFormat
                    int row = Convert.ToInt32(seatInIndexFormat.Substring(1, 1));
                    int seatNum = Convert.ToInt32(seatInIndexFormat.Substring(2));

                    string seat = cmbRow1.Items[row].ToString() + cmbSeatNum1.Items[seatNum].ToString();

                    // add the movieName, showTime and seat into list box lbxSeatsOwned
                    lbxSeatsOwned.Items.Add(string.Format("{0,-3}|{1,-27}|{2,-9}|{3}", (i + 1) + "", movieName, showTime, seat));
                }

                // load the payment histories of current user
                for (int i = 0; i < ((Member)currentUser).PaymentHistories.Count; i++)
                {
                    PaymentHistory aPaymentHistory = (PaymentHistory)((Member)currentUser).PaymentHistories[i];

                    // add the payment code into the combo box
                    cmbPayment.Items.Add(aPaymentHistory.Code);

                    // display the payment histories for current user using list box
                    lbxPaymentHistories.Items.Add("Payment Code: " + aPaymentHistory.Code);
                    lbxPaymentHistories.Items.Add("Movie Name: " + aPaymentHistory.MovieName);
                    lbxPaymentHistories.Items.Add("Movie Showtime: " + aPaymentHistory.MovieShowTime);
                    lbxPaymentHistories.Items.Add("Seats Chosen: " + aPaymentHistory.SeatsChosen);
                    lbxPaymentHistories.Items.Add("Price per Ticket: RM" + aPaymentHistory.PricePerTicket);
                    lbxPaymentHistories.Items.Add("Number of Tickets: " + aPaymentHistory.NumOfTickets);
                    lbxPaymentHistories.Items.Add("Total Price: RM" + aPaymentHistory.TotalPrice);
                    lbxPaymentHistories.Items.Add("Date of Purchase " + aPaymentHistory.DateOfPurchase);
                    lbxPaymentHistories.Items.Add("Time of Purchase: " + aPaymentHistory.TimeOfPurchase);
                    lbxPaymentHistories.Items.Add("Original Bonus Points: " + aPaymentHistory.OriginalBonusPoints);
                    lbxPaymentHistories.Items.Add("Bonus Points Gained: " + aPaymentHistory.BonusPointsGained);
                    lbxPaymentHistories.Items.Add("New Bonus Points: " + aPaymentHistory.NewBonusPoints);
                    lbxPaymentHistories.Items.Add("");
                }
            }
            else// currentUser is a Staff
            {
                rtbxViewMemberList.Enabled = true;
                rtbxViewMovieList.Enabled = true;

                string outputFormat1 = "|{0,-18}|{1,-4}|{2,-15}|{3,-13}|{4,-8}|{5,-9}|{6,-19}|";
                string outputFormat2 = "|{0,-28}|{1,-6}|{2,-16}|{3,-15}|";

                rtbxViewMemberList.Text = string.Format(outputFormat1, "Name", "Age", "IC", "Phone Number", "ID", "Password", "Current Bonus Point");
                rtbxViewMemberList.Text += "\n";
                rtbxViewMemberList.Text += "-----------------------------------------------------------------------------------------------";
                for (int i = 0; i < memberList.Length; i++)
                {
                    rtbxViewMemberList.Text += ("\n" + string.Format(outputFormat1,  memberList[i].Name, memberList[i].Age, memberList[i].Ic,
                                                memberList[i].PhoneNum, memberList[i].Id, memberList[i].Password, memberList[i].BonusPoints));
                }

                rtbxViewMovieList.Text = string.Format(outputFormat2, "Movie Name", "Hall", "Showtime", "Number of seats");
                rtbxViewMovieList.Text += "\n";
                rtbxViewMovieList.Text  += "---------------------------------------------------------------------";
                for (int i = 0; i < movieList.Length; i++)
                {
                    rtbxViewMovieList.Text += ("\n" + string.Format(outputFormat2, movieList[i].Name,movieList[i].Hall, movieList[i].ShowTime,movieList[i].NumOfSeats));
                }
            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            MoviesTabCtrl.SelectedTab = tPageMovie2;
        }

        private void btnPrevious1_Click(object sender, EventArgs e)
        {
            MoviesTabCtrl.SelectedTab = tPageMovie1;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            MoviesTabCtrl.SelectedTab = tPageMovie3;
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            MoviesTabCtrl.SelectedTab = tPageMovie2;
        }

        private void rbnMovie1_CheckedChanged(object sender, EventArgs e)
        {
            picDisplay2.Visible = false;
            picDisplay3.Visible = false;

            
            if (rbnMovie1.Checked)
                picDisplay1.Visible = true;
        }

        private void rbnMovie2_CheckedChanged(object sender, EventArgs e)
        {
            picDisplay1.Visible = false;
            picDisplay3.Visible = false;

            if (rbnMovie2.Checked)
                picDisplay2.Visible = true;
        }

        private void rbnMovie3_CheckedChanged(object sender, EventArgs e)
        {
            picDisplay2.Visible = false;
            picDisplay1.Visible = false;

            if (rbnMovie3.Checked)
                picDisplay3.Visible = true;
        }

        private void rbnMovie1ShowTime1_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie1.Text = movieDetails[0];

            // to display the movie seats using rich text box
            theMovie = movieList[0];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie1[i, j].BackColor = Color.Red;
                    else
                        seatsMovie1[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void rbnMovie1ShowTime2_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie1.Text = movieDetails[1];

            // to display the movie seats using rich text box
            theMovie = movieList[1];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie1[i, j].BackColor = Color.Red;
                    else
                        seatsMovie1[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void rbnMovie2ShowTime1_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie2.Text = movieDetails[2];

            // to display the movie seats using rich text box
            theMovie = movieList[2];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie2[i, j].BackColor = Color.Red;
                    else
                        seatsMovie2[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void rbnMovie2ShowTime2_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie2.Text = movieDetails[3];

            // to display the movie seats using rich text box
            theMovie = movieList[3];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie2[i, j].BackColor = Color.Red;
                    else
                        seatsMovie2[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void rbnMovie3ShowTime1_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie3.Text = movieDetails[4];

            // to display the movie seats using rich text box
            theMovie = movieList[4];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie3[i, j].BackColor = Color.Red;
                    else
                        seatsMovie3[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void rbnMovie3ShowTime2_CheckedChanged(object sender, EventArgs e)
        {
            // show the movies' details using rich text box
            rtbxMovie3.Text = movieDetails[5];

            // to display the movie seats using rich text box
            theMovie = movieList[5];

            // to display the movie seats 
            for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                {
                    if (theMovie.Seats[i, j] == true)
                        seatsMovie3[i, j].BackColor = Color.Red;
                    else
                        seatsMovie3[i, j].BackColor = Color.GreenYellow;
                }
        }

        private void btnPurchase1_Click(object sender, EventArgs e)
        {
            pBoxMovie1Selected.Visible = true;
            pBoxMovie2Selected.Visible = false;
            pBoxMovie3Selected.Visible = false;
            btnAddSeatRedeem.Visible = false;
            btnRedeemSelectedMovie.Visible = false;

            if (rbnMovie1ShowTime1.Checked == true)
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[0];

                // to display the movie seats
                theMovie = movieList[0];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }
            else
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[1];

                // to display the movie seats
                theMovie = movieList[1];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }

            // switch to tPagePurchase
            MoviesTabCtrl.SelectedTab = tPagePurchase;
        }
        // purchase button for movie 2
        private void btnPurchase2_Click(object sender, EventArgs e)
        {
            pBoxMovie2Selected.Visible = true;
            pBoxMovie1Selected.Visible = false;
            pBoxMovie3Selected.Visible = false;
            btnAddSeatRedeem.Visible = false;
            btnRedeemSelectedMovie.Visible = false;

            if (rbnMovie2ShowTime1.Checked == true)
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[2];

                // to display the movie seats
                theMovie = movieList[2];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }
            else
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[3];

                // to display the movie seats
                theMovie = movieList[3];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }

            // switch to tPagePurchase
            MoviesTabCtrl.SelectedTab = tPagePurchase;
        }
        // purchase button for movie 3
        private void btnPurchase3_Click(object sender, EventArgs e)
        {
            try
            {
                pBoxMovie3Selected.Visible = true;
                pBoxMovie1Selected.Visible = false;
                pBoxMovie2Selected.Visible = false;
                btnAddSeatRedeem.Visible = false;
                btnRedeemSelectedMovie.Visible = false;

                if (rbnMovie3ShowTime1.Checked == true)
                {
                    // show the movies' details using rich text box
                    rtbxSelectedMovieDetails.Text = movieDetails[4];

                    // to display the movie seats
                    theMovie = movieList[4];

                    // to display the movie seats 
                    for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                        for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                        {
                            if (theMovie.Seats[i, j] == true)
                                seatsSelectedMovie[i, j].BackColor = Color.Red;
                            else
                                seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                        }

                    // set the label pricePerTicket, noOfTickets and totalPrice
                    pricePerTicket.Text += theMovie.TicketPrice.ToString();
                    noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                    totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
                }
                else
                {
                    // show the movies' details using rich text box
                    rtbxSelectedMovieDetails.Text = movieDetails[5];

                    // to display the movie seats
                    theMovie = movieList[5];

                    // to display the movie seats 
                    for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                        for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                        {
                            if (theMovie.Seats[i, j] == true)
                                seatsSelectedMovie[i, j].BackColor = Color.Red;
                            else
                                seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                        }

                    // set the label pricePerTicket, noOfTickets and totalPrice
                    pricePerTicket.Text += theMovie.TicketPrice.ToString();
                    noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                    totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
                }

                // switch to tPagePurchase
                MoviesTabCtrl.SelectedTab = tPagePurchase;
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            try
            {
                // to check if user actually select an item in the combo box

                // cmbRow.SelectedIndex & cmbSeatNum.SelectedIndex are -1 if no item in the combo box is selected
                if (cmbRow.SelectedIndex != -1 && cmbSeatNum.SelectedIndex != -1)
                {
                    // to check if the seat is available
                    if (theMovie.Seats[cmbRow.SelectedIndex, cmbSeatNum.SelectedIndex] != true)
                    {
                        // store the seats selected into the array list before they are confirmed by user
                        rows.Add(cmbRow.SelectedIndex);
                        seatsNum.Add(cmbSeatNum.SelectedIndex);
                        // store the seats selected into the lbxSelectedSeats
                        lbxSelectedSeats.Items.Add(cmbRow.Items[cmbRow.SelectedIndex].ToString() + cmbSeatNum.Items[cmbSeatNum.SelectedIndex].ToString());

                        // set the seat's status to true to indicate that it is booked
                        theMovie.Seats[cmbRow.SelectedIndex, cmbSeatNum.SelectedIndex] = true;

                        // increase the numOfTickets by 1
                        numOfTickets++;

                        // decrease the NumOfSeats by 1 
                        theMovie.NumOfSeats--;
                    }
                    else
                    {
                        // display message to inform user that the seat is not available
                        MessageBox.Show("The seat selected is not available. Please try other seats.", "Oops!!!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    // display error message
                    MessageBox.Show("Please ensure row and seat number are selected.", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // refresh the hall
                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }


                // set the label noOfTickets and totalPrice
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (rows.Count == 0 && seatsNum.Count == 0)
                    MessageBox.Show("No Seats Chosen!");
                else
                {
                    //local variable
                    receiptDetails = "";
                    string payment = "";

                    if (rbnCredit.Checked)
                    {
                        payment = "credit";
                    }
                    if (rbnCash.Checked)
                    {
                        payment = "cash";
                    }

                    // dertemine the price and bonus points gained using numOfTickets
                    decimal totalPrice = numOfTickets * 18.00m;
                    int bonusPointsGained = 2 * numOfTickets;

                    // add the bonus points gained to the currentUser's bonus points
                    ((Member)currentUser).BonusPoints += bonusPointsGained;

                    // add the seats bought to the currentUser's seatsOwned
                    for (int i = 0; i < rows.Count; i++)
                        ((Member)currentUser).SeatsOwned.Add(theMovie.MovieIndex.ToString() + rows[i].ToString() + seatsNum[i].ToString());

                    // minus the numOfTickets from the numOfSeatsAvailable 
                    theMovie.NumOfSeats -= numOfTickets;

                    // get the seats bought
                    string seats = "";
                    for (int i = 1; i < lbxSelectedSeats.Items.Count; i++)
                        seats += (lbxSelectedSeats.Items[i] + " ");

                    // to store the receipt's details which will be printed later

                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToString("hh:mm:ss tt");

                    receiptDetails = "Movie Name: " + theMovie.Name + "\nShowtime: " + theMovie.ShowTime + "\nSeats Chosen: "
                    + seats + "\nPrice per Ticket: RM" + theMovie.TicketPrice + "\nNo. of Tickets Purchased: " +
                    numOfTickets + "\nTotal Price: RM" + totalPrice + "\nDate of Purchase: " + date
                    + "\nTime of Purchase: " + time + "\nPayment method: " + payment + "\nOriginal Bonus Point: " + (((Member)currentUser).BonusPoints - bonusPointsGained) +
                    "\nBonus Point Gain: " + bonusPointsGained + "\nNew Bonus Point: " + (((Member)currentUser).BonusPoints);

                    // update the current member's number of payment histories
                    ((Member)currentUser).NumOfPaymentHistories++;

                    // create a payment code
                    string code = "";
                    code = ((Member)currentUser).Id + "#" + (((Member)currentUser).NumOfPaymentHistories);

                    // add the payment history to the current member's paymentHistories
                    ((Member)currentUser).PaymentHistories.Add(new PaymentHistory(code, theMovie.Name, theMovie.ShowTime, seats, theMovie.TicketPrice,
                                            numOfTickets, totalPrice, date, time, (((Member)currentUser).BonusPoints - bonusPointsGained), bonusPointsGained,
                                            (((Member)currentUser).BonusPoints)));

                    //display receipt via Messagebox
                    lblReceiptDetails.Text = receiptDetails + "\n\n Thank You!\nEnjoy your Movie!!!";
                    //MessageBox.Show(receiptDetails + "\n\nThank You!\nEnjoy Your Movie!!!", "RECEIPT", );

                    // clear the elements inside rows and seatsNum array lists
                    rows.Clear();
                    seatsNum.Clear();

                    MoviesTabCtrl.SelectedTab = tPagePrintReceipt;
                }
            }
            catch (IOException ioExc)
            {
                MessageBox.Show("File error: " + ioExc.Message);
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
            // close the MainMenuForm
            //this.Close();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // turn on back the combobox for seat selection!
                cmbRow.Enabled = true;
                cmbSeatNum.Enabled = true;
                btnAddSeatRedeem.Enabled = true;

                // clear the items inside lbxSelectedSeats
                lbxSelectedSeats.Items.Clear();
                lbxSelectedSeats.Items.Add("Selected Seats: ");

                // set the seats back to back to false to indicate they are available
                for (int i = 0; i < rows.Count; i++)
                    for (int j = 0; j < seatsNum.Count; j++)
                        theMovie.Seats[(int)rows[i], (int)seatsNum[j]] = false;

                // clear the elements inside rows and seatsNum array lists
                rows.Clear();
                seatsNum.Clear();

                // set the numOfTickets to 0
                numOfTickets = 0;

                // refresh the hall
                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label noOfTickets and totalPrice
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // set the seats back to back to false to indicate they are available
            for (int i = 0; i < rows.Count; i++)
                for (int j = 0; j < seatsNum.Count; j++)
                    theMovie.Seats[(int)rows[i], (int)seatsNum[j]] = false;

            // close the MainMenuForm
            this.Close();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // set the seats back to back to false to indicate they are available
            for (int i = 0; i < rows.Count; i++)
                for (int j = 0; j < seatsNum.Count; j++)
                    theMovie.Seats[(int)rows[i], (int)seatsNum[j]] = false;
        }

        private void btnChooseSpecificMovie_Click(object sender, EventArgs e)
        {
            // switch statement to dertemine which tab page to go
            switch (cmbSpecificMovie.SelectedIndex)
            {
                case 0:
                    // set the Visible property of btnNext1 to false
                    btnNext1.Visible = false;
                    btnRedeem1.Visible = false;
                    btnPurchase1.Visible = true;
                    //switch to tPageMovie1
                    MoviesTabCtrl.SelectedTab = tPageMovie1;
                    break;
                case 1:
                    // set the Visible property of btnPrevious1 and btnNext2 to false
                    btnPrevious1.Visible = false;
                    btnNext2.Visible = false;
                    btnRedeem2.Visible = false;
                    btnPurchase2.Visible = true;
                    //switch to tPageMovie2
                    MoviesTabCtrl.SelectedTab = tPageMovie2;
                    break;
                case 2:
                    // set the Visible property of btnPrevious2 to false
                    btnPrevious2.Visible = false;
                    btnRedeem3.Visible = false;
                    btnPurchase3.Visible = true;
                    //switch to tPageMovie3
                    MoviesTabCtrl.SelectedTab = tPageMovie3;
                    break;
                default:
                    MessageBox.Show("Please select a movie.", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnRedeemTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbxCurrentBP.Text) >= 20)
                {
                    if (rbnMovie1.Checked == true)
                    {
                        MoviesTabCtrl.SelectedTab = tPageMovie1;
                        btnNext1.Visible = false;
                        btnPurchase1.Visible = false;
                        btnRedeem1.Visible = true;
                    }
                    if (rbnMovie2.Checked == true)
                    {
                        MoviesTabCtrl.SelectedTab = tPageMovie2;
                        btnPrevious1.Visible = false;
                        btnNext2.Visible = false;
                        btnPurchase2.Visible = false;
                        btnRedeem2.Visible = true;

                    }
                    if (rbnMovie3.Checked == true)
                    {
                        MoviesTabCtrl.SelectedTab = tPageMovie3;
                        btnPrevious2.Visible = false;
                        btnPurchase3.Visible = false;
                        btnRedeem3.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient bonus point to redeem tickets");
                }    
            }
            catch (FormatException fExc)
            {
                MessageBox.Show(fExc.Message);

            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        // Button for redeem movie 1
        private void btnRedeem1_Click(object sender, EventArgs e)
        {
            pBoxMovie1Selected.Visible = true;
            pBoxMovie2Selected.Visible = false;
            pBoxMovie3Selected.Visible = false;
            btnConfirm.Visible = false;
            btnRedeemSelectedMovie.Visible = true;
            btnAddSeat.Visible = false;
            btnAddSeatRedeem.Visible = true;
            rbnCash.Visible = false;
            rbnCredit.Visible = false;

            if (rbnMovie1ShowTime1.Checked == true)
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[0];

                // to display the movie seats
                theMovie = movieList[0];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }
            else
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[1];

                // to display the movie seats
                theMovie = movieList[1];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    };

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }

            // switch to tPagePurchase
            MoviesTabCtrl.SelectedTab = tPagePurchase;
        }

        // Button for redeem movie 2
        private void btnRedeem2_Click(object sender, EventArgs e)
        {
            pBoxMovie2Selected.Visible = true;
            pBoxMovie1Selected.Visible = false;
            pBoxMovie3Selected.Visible = false;
            btnConfirm.Visible = false;
            btnRedeemSelectedMovie.Visible = true;
            btnAddSeat.Visible = false;
            btnAddSeatRedeem.Visible = true;
            rbnCash.Visible = false;
            rbnCredit.Visible = false;


            if (rbnMovie2ShowTime1.Checked == true)
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[2];

                // to display the movie seats
                theMovie = movieList[2];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }
            else
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[3];

                // to display the movie seats
                theMovie = movieList[3];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }

            // switch to tPagePurchase
            MoviesTabCtrl.SelectedTab = tPagePurchase;
        }

        // Button for redeem movie 3
        private void btnRedeem3_Click(object sender, EventArgs e)
        {
           
            pBoxMovie3Selected.Visible = true;
            pBoxMovie1Selected.Visible = false;
            pBoxMovie2Selected.Visible = false;
            btnConfirm.Visible = false;
            btnRedeemSelectedMovie.Visible = true;
            btnAddSeat.Visible = false;
            btnAddSeatRedeem.Visible = true;
            rbnCash.Visible = false;
            rbnCredit.Visible = false;

            if (rbnMovie3ShowTime1.Checked == true)
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[4];

                // to display the movie seats
                theMovie = movieList[4];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }
            else
            {
                // show the movies' details using rich text box
                rtbxSelectedMovieDetails.Text = movieDetails[5];

                // to display the movie seats
                theMovie = movieList[5];

                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label pricePerTicket, noOfTickets and totalPrice
                pricePerTicket.Text += theMovie.TicketPrice.ToString();
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + 0.00;
            }
            // switch to tPagePurchase
            MoviesTabCtrl.SelectedTab = tPagePurchase;
        }

        private void btnRedeemSelectedMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (rows.Count == 0 && seatsNum.Count == 0)
                    MessageBox.Show("No Seats Chosen!");
                else
                {
                    // to store the receipt's details which will be printed later
                    receiptDetails = "";


                    // use 20 points to redeem 1 ticket
                    ((Member)currentUser).BonusPoints -= (20);

                    // minus the numOfTickets from the numOfSeatsAvailable 
                    theMovie.NumOfSeats -= numOfTickets;

                    // get the seats bought
                    string seats = "";
                    for (int i = 1; i < lbxSelectedSeats.Items.Count; i++)
                        seats += (lbxSelectedSeats.Items[i] + " ");

                    receiptDetails = "Movie Name: " + theMovie.Name + "\nShowtime: " + theMovie.ShowTime +  "\nSeats Chosen: " +
                     seats + "\nDate of Redemption: " + DateTime.Now.ToShortDateString() + "\nCurrent Bonus Point : " + ((Member)currentUser).BonusPoints.ToString()
                        + "\nTime of Purchase: " + DateTime.Now.ToString("hh:mm:ss tt") + "\nNo Bonus Points gained!"
                        + "\n\nSuccessfully redeemed ticket!!";

                    //MessageBox.Show(receiptDetails, "RECEIPT");

                    // clear the elements inside rows and seatsNum array lists
                    rows.Clear();
                    seatsNum.Clear();


                    lblReceiptDetails.Text = receiptDetails;

                    MoviesTabCtrl.SelectedTab = tPagePrintReceipt;
                    // close the MainMenuForm
                    //this.Close();
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnAddSeatRedeem_Click(object sender, EventArgs e)
        {
            try {
                // to check if user actually select an item in the combo box


                // cmbRow.SelectedIndex & cmbSeatNum.SelectedIndex are -1 if no item in the combo box is selected
                if (cmbRow.SelectedIndex != -1 && cmbSeatNum.SelectedIndex != -1)
                {
                    // to check if the seat is available
                    if (theMovie.Seats[cmbRow.SelectedIndex, cmbSeatNum.SelectedIndex] != true)
                    {
                        // store the seats selected into the array list before they are confirmed by user
                        rows.Add(cmbRow.SelectedIndex);
                        seatsNum.Add(cmbSeatNum.SelectedIndex);
                        // store the seats selected into the lbxSelectedSeats
                        lbxSelectedSeats.Items.Add(cmbRow.Items[cmbRow.SelectedIndex].ToString() + cmbSeatNum.Items[cmbSeatNum.SelectedIndex].ToString());

                        // set the seat's status to true to indicate that it is booked
                        theMovie.Seats[cmbRow.SelectedIndex, cmbSeatNum.SelectedIndex] = true;

                        // increase the numOfTickets by 1
                        numOfTickets++;

                        // decrease the NumOfSeats by 1 
                        theMovie.NumOfSeats--;
                    }
                    else
                        // display message to inform user that the seat is not available
                        MessageBox.Show("The seat selected is not available. Please try other seats.", "Oops!!!", MessageBoxButtons.OK);
                }
                else
                {
                    // display error message
                    MessageBox.Show("Please ensure row and seat number are selected.", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (numOfTickets == 1)
                {
                    cmbRow.Enabled = false;
                    cmbSeatNum.Enabled = false;
                    btnAddSeatRedeem.Enabled = false;
                }

                // refresh the hall
                // to display the movie seats 
                for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                    for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                    {
                        if (theMovie.Seats[i, j] == true)
                            seatsSelectedMovie[i, j].BackColor = Color.Red;
                        else
                            seatsSelectedMovie[i, j].BackColor = Color.GreenYellow;
                    }

                // set the label noOfTickets and totalPrice
                noOfTickets.Text = "No. of Tickets: " + numOfTickets.ToString();
                totalPrice.Text = "Total Price: RM" + (numOfTickets * theMovie.TicketPrice).ToString();
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnChangeSeat_Click(object sender, EventArgs e)
        {
            try {
                // to validate that the user select the appropriate column
                if (lbxSeatsOwned.SelectedIndex != -1 && lbxSeatsOwned.SelectedIndex > 1)
                {
                    // set the Enabled property of btnConfirmChangeSeat and btnDiscardChangeSeat to true
                    btnConfirmChangeSeat.Enabled = true;
                    btnDiscardChangeSeat.Enabled = true;
                    cmbRow1.Enabled = true;
                    cmbSeatNum1.Enabled = true;

                    // set the Enabled property of btnChangeSeat to false
                    btnChangeSeat.Enabled = false;
                    lbxSeatsOwned.Enabled = false;

                    // retrieve the seat in index format
                    string seatInIndexFormat = ((Member)currentUser).SeatsOwned[lbxSeatsOwned.SelectedIndex - 2].ToString();

                    // retrieve the movie index from the seatInIndexFormat
                    int movieIndex = Convert.ToInt32(seatInIndexFormat.Substring(0, 1));

                    // retrieve the seat (represented by row and seatNum) from the seatInIndexFormat
                    int row = Convert.ToInt32(seatInIndexFormat.Substring(1, 1));
                    int seatNum = Convert.ToInt32(seatInIndexFormat.Substring(2));

                    // set theMovie to reference of movieList[movieIndex] (to refer the object referred by movieList[movieIndex])
                    theMovie = movieList[movieIndex];

                    if (theMovie.Name == "Avenger: Infinity War")
                        pMovie1.Visible = true;
                    else if (theMovie.Name == "Pacific Rim: Uprising")
                        pMovie2.Visible = true;
                    else
                        pMovie3.Visible = true;

                    // display the original seat
                    string seat = cmbRow1.Items[row].ToString() + cmbSeatNum1.Items[seatNum].ToString();
                    lblOriginalSeat.Text += " " + seat;

                    rtbxSelectedMovieDetails1.Text = movieDetails[movieIndex];

                    // to display the movie seats 
                    for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                        for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                        {
                            if (theMovie.Seats[i, j] == true)
                            {
                                if (i == row && j == seatNum)
                                    seatsSelectedMovie1[i, j].BackColor = Color.Aqua;
                                else
                                    seatsSelectedMovie1[i, j].BackColor = Color.Red;
                            }
                            else
                                seatsSelectedMovie1[i, j].BackColor = Color.GreenYellow; 
                        }
                }
                else
                {
                    MessageBox.Show("Please ensure that appropriate seat to change.", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void cmbRow1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                // to ensure that both an element in each combo box is selected
                if (cmbRow1.SelectedIndex != -1 && cmbSeatNum1.SelectedIndex != -1)
                {
                    // check if the selected seat is available
                    if (theMovie.Seats[cmbRow1.SelectedIndex, cmbSeatNum1.SelectedIndex] != true)
                    {
                        // retrieve the seat in index format
                        string seatInIndexFormat = ((Member)currentUser).SeatsOwned[lbxSeatsOwned.SelectedIndex - 2].ToString();

                        // retrieve the seat (represented by row and seatNum) from the seatInIndexFormat
                        int row = Convert.ToInt32(seatInIndexFormat.Substring(1, 1));
                        int seatNum = Convert.ToInt32(seatInIndexFormat.Substring(2));

                        // display the original seat
                        string newSeat = cmbRow1.Items[cmbRow1.SelectedIndex].ToString() + cmbSeatNum1.Items[cmbSeatNum1.SelectedIndex].ToString();
                        lblNewSeat.Text = "New Seat: " + newSeat;

                        // to display the movie seats 
                        for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                            for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                            {
                                if (theMovie.Seats[i, j] == true)
                                {
                                    if (i == row && j == seatNum)
                                        seatsSelectedMovie1[i, j].BackColor = Color.Aqua;
                                    else
                                        seatsSelectedMovie1[i, j].BackColor = Color.Red;
                                }
                                else
                                {
                                    if (i == cmbRow1.SelectedIndex && j == cmbSeatNum1.SelectedIndex)
                                        seatsSelectedMovie1[i, j].BackColor = Color.LemonChiffon;
                                    else
                                        seatsSelectedMovie1[i, j].BackColor = Color.GreenYellow;
                                }
                            }
                    }
                    else
                        MessageBox.Show("The seat selected is not available. Please try other seats.", "Oops!!!", MessageBoxButtons.OK);
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void cmbSeatNum1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                // to ensure that both an element in each combo box is selected
                if (cmbRow1.SelectedIndex != -1 && cmbSeatNum1.SelectedIndex != -1)
                {
                    // check if the selected seat is available
                    if (theMovie.Seats[cmbRow1.SelectedIndex, cmbSeatNum1.SelectedIndex] != true)
                    {
                        // retrieve the seat in index format
                        string seatInIndexFormat = ((Member)currentUser).SeatsOwned[lbxSeatsOwned.SelectedIndex - 2].ToString();

                        // retrieve the seat (represented by row and seatNum) from the seatInIndexFormat
                        int row = Convert.ToInt32(seatInIndexFormat.Substring(1, 1));
                        int seatNum = Convert.ToInt32(seatInIndexFormat.Substring(2));

                        // display the original seat
                        string newSeat = cmbRow1.Items[cmbRow1.SelectedIndex].ToString() + cmbSeatNum1.Items[cmbSeatNum1.SelectedIndex].ToString();
                        lblNewSeat.Text = "New Seat: " + newSeat;

                        // to display the movie seats 
                        for (int i = 0; i < theMovie.Seats.GetLength(0); i++)
                            for (int j = 0; j < theMovie.Seats.GetLength(1); j++)
                            {
                                if (theMovie.Seats[i, j] == true)
                                {
                                    if (i == row && j == seatNum)
                                        seatsSelectedMovie1[i, j].BackColor = Color.Aqua;
                                    else
                                        seatsSelectedMovie1[i, j].BackColor = Color.Red;
                                }
                                else
                                {
                                    if (i == cmbRow1.SelectedIndex && j == cmbSeatNum1.SelectedIndex)
                                        seatsSelectedMovie1[i, j].BackColor = Color.LemonChiffon;
                                    else
                                        seatsSelectedMovie1[i, j].BackColor = Color.GreenYellow;
                                }
                            }
                    }
                    else
                        MessageBox.Show("The seat selected is not available. Please try other seats.", "Oops!!!", MessageBoxButtons.OK);
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnConfirmChangeSeat_Click(object sender, EventArgs e)
        {
            try
            {
                // retrieve the seat in index format
                string seatInIndexFormat = ((Member)currentUser).SeatsOwned[lbxSeatsOwned.SelectedIndex - 2].ToString();

                // retrieve the seat (represented by row and seatNum) from the seatInIndexFormat
                int row = Convert.ToInt32(seatInIndexFormat.Substring(1, 1));
                int seatNum = Convert.ToInt32(seatInIndexFormat.Substring(2));

                // set the seat to false to indicate it is available again (using row and seatNum)
                theMovie.Seats[row, seatNum] = false;

                // set the selected seat to true to indicate it is bought
                theMovie.Seats[cmbRow1.SelectedIndex, cmbSeatNum1.SelectedIndex] = true;

                // update the seatsOwned for the current member
                ((Member)currentUser).SeatsOwned.RemoveAt(lbxSeatsOwned.SelectedIndex - 2);
                //(Member)currentUser).SeatsOwned.Add(theMovie.MovieIndex.ToString() + cmbRow1.SelectedIndex.ToString() + cmbSeatNum1.SelectedIndex.ToString());

                // update the bonusPoints for the current member
                ((Member)currentUser).BonusPoints -= 2;

                // to store the receipt's details which will be printed later
                string receiptDetails = "";

                // display receipt
                receiptDetails = "Seat Changed Successfuly!!!" + "\n\nMovie Name: " + theMovie.Name + "\nShowtime: " + theMovie.ShowTime + "\nOriginal Seat: "
                    + (cmbRow1.Items[row].ToString() + cmbSeatNum1.Items[seatNum].ToString()) + "\nNew Seat: " + (cmbRow1.Items[cmbRow1.SelectedIndex].ToString() +
                    cmbSeatNum1.Items[cmbSeatNum1.SelectedIndex].ToString()) + "\nDate: " + DateTime.Now.ToShortDateString() + "\nTime: " + DateTime.Now.ToString("hh:mm:ss tt") +
                    "\nMember Name: " + ((Member)currentUser).Name + "\nOriginal Bonus Points: " + (((Member)currentUser).BonusPoints + 2) + "\nBonus Point Forfeit: 2" +
                    "\nNew Bonus Points: " + ((Member)currentUser).BonusPoints + "\n\nThank You!\nEnjoy Your Movie!!!";

                MessageBox.Show(receiptDetails, "RECEIPT");
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }

            // close the current form
            this.Close();
        }

        private void btnDiscardChangeSeat_Click(object sender, EventArgs e)
        {
            // close the current form
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Sans Serif", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" TGK Cinema", new Font("Sans Serif", 18), new SolidBrush(Color.Red), startX, startY);
            graphic.DrawString(receiptDetails, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset += 270;
            graphic.DrawString("Thank You For Your Purchase!\nPlease come Again!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitPaymentHistories_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintPayment_Click(object sender, EventArgs e)
        {
            try
            {
                // to check if the an item in cmbPayment is selected
                if (cmbPayment.SelectedIndex != -1)
                {
                    // to store the receipt details
                    receiptDetails = "";

                    PaymentHistory aPaymentHistory = (PaymentHistory)((Member)currentUser).PaymentHistories[cmbPayment.SelectedIndex];

                    receiptDetails += "Payment Code: " + aPaymentHistory.Code + "\nMovie Name: " + aPaymentHistory.MovieName + "\nMovie Showtime: " + aPaymentHistory.MovieShowTime
                        + "\nSeats Chosen: " + aPaymentHistory.SeatsChosen + "\nPrice per Ticket: RM" + aPaymentHistory.PricePerTicket + "\nNumber of Tickets: " + aPaymentHistory.NumOfTickets
                        + "\nTotal Price: RM" + aPaymentHistory.TotalPrice + "\nDate of Purchase " + aPaymentHistory.DateOfPurchase + "\nTime of Purchase: " + aPaymentHistory.TimeOfPurchase
                        + "\nOriginal Bonus Points: " + aPaymentHistory.OriginalBonusPoints + "\nBonus Points Gained: " + aPaymentHistory.BonusPointsGained
                        + "\nNew Bonus Points: " + aPaymentHistory.NewBonusPoints;

                    lblReceiptDetails.Text = receiptDetails;

                    MoviesTabCtrl.SelectedTab = tPagePrintReceipt;
                }
                else
                    MessageBox.Show("Please ensure a code is selected before printing.", "Oops!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }

        }

        private void btnWatchTrailer1_Click(object sender, EventArgs e)
        {
            //Directory may vary due to different pc user
            textBox1.Text += "C:\\Users\\Wilson Loo\\Desktop\\OOAD Assignment 10.0\\OOAD Assignment 9.0\\OOAD Assignment 1.1\\OOAD Assignment 1.1\\bin\\Debug\\Avengers.mp4";
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnWatchTrailer2_Click(object sender, EventArgs e)
        {
            //Directory may vary due to different pc user
            textBox2.Text += "C:\\Users\\Wilson Loo\\Desktop\\OOAD Assignment 10.0\\OOAD Assignment 9.0\\OOAD Assignment 1.1\\OOAD Assignment 1.1\\bin\\Debug\\PacificRim.mp4";
            axWindowsMediaPlayer2.URL = textBox2.Text;
            axWindowsMediaPlayer2.Visible = true;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void btnWatchTrailer3_Click(object sender, EventArgs e)
        {
            //Directory may vary due to different pc user
            textBox3.Text += "C:\\Users\\Wilson Loo\\Desktop\\OOAD Assignment 10.0\\OOAD Assignment 9.0\\OOAD Assignment 1.1\\OOAD Assignment 1.1\\bin\\Debug\\MissionImpossible.mp4";
            axWindowsMediaPlayer3.URL = textBox3.Text;
            axWindowsMediaPlayer3.Visible = true;
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying) //if playing
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }

            if (e.newState == 1) //if stopped
            {
                axWindowsMediaPlayer1.Visible = false;
                textBox1.Clear();
            }
        }

        private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying) //If playing
            {
                axWindowsMediaPlayer2.fullScreen = true;
            }

            if (e.newState == 1) // If stopped
            {
                axWindowsMediaPlayer2.Visible = false;
                textBox2.Clear();
            }
        }

        private void axWindowsMediaPlayer3_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying) //if playing
            {
                axWindowsMediaPlayer3.fullScreen = true;
            }

            if (e.newState == 1) // if stopped
            {
                axWindowsMediaPlayer3.Visible = false;
                textBox3.Clear();
            }
        }
    }
}
