using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace OOAD_Assignment_1._1
{
    public partial class TGKForm : Form
    {
        public Cinema cinema;
        public User currentUser;

        public TGKForm()
        {
            InitializeComponent();

            // initialize object variable cinema
            cinema = new Cinema("TGK");
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //display time
            timer1.Start();
            timer2.Start();
            lblDisplayTime.Text = "Time" + DateTime.Now.ToLongTimeString() +" "+ DateTime.Now.ToLongDateString();

            //local variable
            int numOfSeatsAvailable;
            bool[,] seats;
            string[] rows;

            //hide the movie poster
            picSlide3.Visible = false;
            picSlide2.Visible = false;

            // to read movies' details from file
            if (File.Exists("Movie.txt"))
            {
                try
                {
                    // create an instance of StreamReader
                    StreamReader reader = new StreamReader("Movie.txt");

                    // read the name of the first movie from the text file
                    string movieName = reader.ReadLine();
                    string genre;
                    string cast;
                    decimal ticketPrice;
                    string rating;
                    string showTime;
                    int duration;
                    string hall;
                    int movieIndex = 0;

                    while (movieName != null)
                    { 
                        // create local variables and assign them with the values read from the file
                        genre = reader.ReadLine();

                        cast = reader.ReadLine();

                        ticketPrice = Convert.ToDecimal(reader.ReadLine());

                        rating = reader.ReadLine();

                        showTime = reader.ReadLine();

                        duration = Convert.ToInt32(reader.ReadLine());

                        hall = reader.ReadLine();
                        
                        // initialize the variables needed to create seats
                        numOfSeatsAvailable = 0;
                        seats = new bool[5, 6];
                        rows = new string[5];

                        // to read the movie seats row by row
                        for (int i = 0; i < 5; i++)
                            rows[i] = reader.ReadLine();

                        // create seats of Boolean type
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < rows[i].Length; j++)
                            {
                                if (rows[i][j] == 'X')
                                { 
                                    seats[i, j] = true;
                                }
                                else// (rows[i][j] == 'O')
                                { 
                                    seats[i, j] = false;
                                    numOfSeatsAvailable++;
                                }
                            }
                        }

                        // add movies to the arraylist called movieList of Cinema object
                        cinema.AddMovie(movieName, genre, cast, ticketPrice, rating, showTime, duration, numOfSeatsAvailable, hall, seats, movieIndex);

                        // increase the movieIndex by one
                        movieIndex++;

                        // read the name of the next movie from the text file
                        movieName = reader.ReadLine();
                    }

                    // close the file after finish reading
                    reader.Close();
                }
                catch (IOException ioExc)
                {
                    MessageBox.Show("File error: " + ioExc.Message);
                }
                catch (SystemException sysExc)
                {
                    MessageBox.Show(sysExc.Message);
                }
            }

            // to read members' details from file
            if (File.Exists("Member.txt") && File.Exists("Seats Owned by Members.txt"))
            {
                try
                {
                    // create an instance of StreamReader
                    StreamReader reader = new StreamReader("Member.txt");

                    // read the name of the first member from the file
                    string name = reader.ReadLine();
                    int age;
                    string ic;
                    string phoneNum;
                    string id;
                    string password;
                    int bonusPoints;

                    while (name != null)
                    {
                        // create local variables and assign them with the values read from the file
                        age = Convert.ToInt32(reader.ReadLine());

                        ic = reader.ReadLine();

                        phoneNum = reader.ReadLine();

                        id = reader.ReadLine();

                        password = reader.ReadLine();

                        bonusPoints = Convert.ToInt32(reader.ReadLine());

                        // testing
                        //string aMember = name + " " + age + " " + ic + " " + phoneNum + " " + id
                        //                    + " " + password + " " + bonusPoints;
                        //MessageBox.Show(aMember);

                        // add members to the arraylist called memberList of Cinema object 
                        cinema.AddMember(name, age, ic, phoneNum, id, password, bonusPoints);

                        // read the name of the next member from the file
                        name = reader.ReadLine();
                    }

                    // close the file after finish reading
                    reader.Close();

                    // this section is for putting seats owned by user into the array list

                    // get the memberList
                    Member[] memberList = cinema.GetMemberList();

                    for (int i = 0; i < memberList.Length; i++)
                    {
                        StreamReader reader1 = new StreamReader("Seats Owned by Members.txt");

                        string line = reader1.ReadLine();

                        while (line != null)
                        { 
                            // read the first line
                            string tempId = line.Substring(0, 7);
                            
                            if (tempId == memberList[i].Id)
                            {
                                memberList[i].SeatsOwned.Add(line.Substring(8));
                            }

                            // read the next line
                            line = reader1.ReadLine();
                        }

                        // close the file after finish reading
                        reader1.Close();
                    }

                    // load the payment histories for the current member
                    for (int i = 0; i < memberList.Length; i++)
                    {
                        StreamReader reader2 = new StreamReader("Payment Histories.txt");

                        // read the first line
                        string code = reader2.ReadLine();

                        while (code != null)
                        {
                            string movieName = reader2.ReadLine();
                            string movieShowtime = reader2.ReadLine();
                            string seatsChosen = reader2.ReadLine();
                            decimal pricePerTicket = Convert.ToDecimal(reader2.ReadLine());
                            int numOfTickets = Convert.ToInt32(reader2.ReadLine());
                            decimal totalPrice = Convert.ToDecimal(reader2.ReadLine());
                            string dateOfPurchase = reader2.ReadLine();
                            string timeOfPurchase = reader2.ReadLine();
                            int originalBonusPoints = Convert.ToInt32(reader2.ReadLine());
                            int bonusPointsGained = Convert.ToInt32(reader2.ReadLine());
                            int newBonusPoints = Convert.ToInt32(reader2.ReadLine());

                            string tempId = code.Substring(0, 7);
                            // to determine if this payment history belongs to this member
                            if (tempId == memberList[i].Id)
                            {
                                memberList[i].PaymentHistories.Add(new PaymentHistory(code, movieName, movieShowtime, seatsChosen, pricePerTicket,
                                                numOfTickets, totalPrice, dateOfPurchase, timeOfPurchase, originalBonusPoints, bonusPointsGained,
                                                newBonusPoints));
                                memberList[i].NumOfPaymentHistories++;
                            }

                            // read the next line
                            code = reader2.ReadLine();
                        }

                        reader2.Close();
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
            }

            // to read staff's details from file
            if (File.Exists("Staff.txt"))
            {
                try
                {
                    // create an instance of StreamReader
                    StreamReader reader = new StreamReader("Staff.txt");

                    // read the name of the first staff from the file
                    string name = reader.ReadLine();
                    int age;
                    string ic;
                    string phoneNum;
                    string id;
                    string password;

                    while (name != null)
                    {
                        // create local variables and assign them with the values read from the file
                        age = Convert.ToInt32(reader.ReadLine());

                        ic = reader.ReadLine();

                        phoneNum = reader.ReadLine();

                        id = reader.ReadLine();

                        password = reader.ReadLine();

                        // add staff to the arraylist called staffList of Cinema object 
                        cinema.AddStaff(name, age, ic, phoneNum, id, password);

                        // read the name of the next staff from the file
                        name = reader.ReadLine();
                    }

                    // close the file after finish reading
                    reader.Close();
                }
                catch (IOException ioExc)
                {
                    MessageBox.Show("File error: " + ioExc.Message);
                }
                catch (SystemException sysExc)
                {
                    MessageBox.Show(sysExc.Message);
                }
            }
        }
        private void btnLoginMember_Click(object sender, EventArgs e)
        {
            try
            {
                // create an instance of Member class so that we can use the Login() method of Member class
                Member tempMember = new Member(cinema);

                // use the Login() method of Member object
                User theUser = tempMember.Login();

                if (theUser != null)
                {
                    // to initialize currentUser to refer to the User object referred by theUser
                    currentUser = theUser;

                    Member member = (Member)currentUser;

                    // switch to tPageMenu
                    TGKTabCtrl.SelectedTab = tPageMenu;
                    menuStrip1.Visible = true;
                    menuStrip2.Visible = false;
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        private void btnLoginStaff_Click(object sender, EventArgs e)
        {
            try {
                // create an instance of Staff class so that we can use the Login() method of Staff class
                Staff tempStaff = new Staff(cinema);

                // use the Login() method of Staff object
                User theUser = tempStaff.Login();

                if (theUser != null)
                {
                    // to initialize currentUser to refer to the User object referred by theUser
                    currentUser = theUser;

                    // switch to tPageMenu
                    TGKTabCtrl.SelectedTab = tPageMenu;
                    menuStrip1.Visible = false;
                    menuStrip2.Visible = true;
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                // create an instance of Member class so that we can use the Register() method of Member class
                Member tempMember = new Member(cinema);

                // use the Register() method of Member object
                User theUser = tempMember.Register();

                if (theUser != null)
                {
                    Member m = (Member)theUser;
                    cinema.AddMember(m.Name, m.Age, m.Ic, m.PhoneNum, m.Id, m.Password, m.BonusPoints);

                    // set the currentUser to refer the the last Member object in the memberList
                    currentUser = (cinema.GetMemberList())[(cinema.GetMemberList()).Length - 1];

                    // switch to tPageMenu
                    TGKTabCtrl.SelectedTab = tPageMenu;
                    menuStrip1.Visible = true;
                }
            }
            catch (SystemException sysExc)
            {
                MessageBox.Show(sysExc.Message);
            }
        }

        // view all movie menu strip
        private void allMoviesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the ViewSeatsForAllMovies() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.ViewSeatsForAllMovies();
        }

        // redeem bonus point menu strip
        private void redeemBonusPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the redeemBonus()method of Member class
            Member tempMember = new Member(cinema, currentUser);
            
            //user Redeem Bonus Point
            tempMember.RedeemBonus();    
        }

        // specific movie menu strip
        private void specificMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the ViewSeatsForSpecificMovie() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.ViewSeatsForSpecificMovie();
        }
        // purchase movie menu strip
        private void purchaseMovieTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the PurchaseSeats() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.PurchaseSeats();
        }

        //member logout menu strip for menu for staff
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // switch to tPageLogin
            TGKTabCtrl.SelectedTab = tPageLogin;
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
        }

        // view member details menu strip
        private void viewMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member theMember = (Member)currentUser;

            // this string is used to store and then display member's details
            string memberDetails;

            memberDetails = "Name: " + theMember.Name + "\nAge: " + theMember.Age + "\nIC: " + theMember.Ic
                            + "\nTel. No.: " + theMember.PhoneNum + "\nLogin ID: " + theMember.Id
                            + "\nPassword: " + theMember.Password + "\nCurrent Bonus Point: " + theMember.BonusPoints;

            MessageBox.Show(memberDetails, "Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // member redeem bonus point menu strip
        private void redeemBonusPointsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the RedeemBonus() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.RedeemBonus();
        }

        // staff view members list menu strip
        private void viewMemberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff stf = new Staff(cinema, currentUser);
            stf.ShowMemberList();
        }

        //staff view movie list menu strip
        private void viewMovieListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff stf = new Staff(cinema, currentUser);
            stf.ShowMovieList();
        }

        //staff logout menu strip
        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            // switch to tPageLogin
            TGKTabCtrl.SelectedTab = tPageLogin;
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
        }

        //time and date display timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplayTime.Text = "Time: " + DateTime.Now.ToLongTimeString() + "\nDate: " + DateTime.Now.ToLongDateString();

           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //slide show of movie images
            if (picSlide1.Visible == true)
            {
                picSlide1.Visible = false;
                picSlide2.Visible = true;
            }
            else if (picSlide2.Visible == true)
            {
                picSlide2.Visible = false;
                picSlide3.Visible = true;
            }
            else if (picSlide3.Visible == true)
            {
                picSlide3.Visible = false;
                picSlide1.Visible = true;
            }
        }

        private void changeSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the ChangeSeat() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.ChangeSeat();
        }

        private void viewPaymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of Member class so that we can use the ViewPaymentHistories() method of Member class
            Member tempMember = new Member(cinema, currentUser);
            tempMember.ViewPaymentHistory();
        }

        private void TGKForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // write all the things into text file (save changes)

            Movie[] movies = cinema.GetMovieList();
            Member[] members = cinema.GetMemberList();

            if (File.Exists("Movie.txt") && File.Exists("Member.txt") && File.Exists("Seats Owned by Members.txt"))
            {
                // write all movies to the text file
                try
                {
                    // create an instance of StreamWriter for file writing
                    StreamWriter writer = new StreamWriter("Movie.txt");

                    for (int i = 0; i < movies.Length; i++)
                    {
                        // write movie's details to the text file
                        writer.WriteLine(movies[i].Name);
                        writer.WriteLine(movies[i].Genre);
                        writer.WriteLine(movies[i].Cast);
                        writer.WriteLine(movies[i].TicketPrice);
                        writer.WriteLine(movies[i].Rating);
                        writer.WriteLine(movies[i].ShowTime);
                        writer.WriteLine(movies[i].Duration);
                        writer.WriteLine(movies[i].Hall);

                        // write movie's seats to the text file
                        bool[,] seats = movies[i].Seats;

                        for (int row = 0; row < seats.GetLength(0); row++)
                        {
                            for (int seatNum = 0; seatNum < seats.GetLength(1); seatNum++)
                            {
                                if (seats[row, seatNum] == false)
                                    writer.Write("O");
                                else
                                    writer.Write("X");
                            }
                            writer.WriteLine();
                        }
                    }

                    // close the file after finish writing
                    writer.Close();
                }
                catch (IOException ioExc)
                {
                    MessageBox.Show(ioExc.Message);
                }
                catch (SystemException sysExc)
                {
                    MessageBox.Show(sysExc.Message);
                }


                // write all members to the text file
                try
                {
                    // create an instance of StreamWriter for file writing
                    StreamWriter writer = new StreamWriter("Member.txt");

                    // create another instance of StreamWriter class for writing to another file
                    StreamWriter writer1 = new StreamWriter("Seats Owned by Members.txt");

                    StreamWriter writer2 = new StreamWriter("Payment Histories.txt");

                    for (int i = 0; i < members.Length; i++)
                    {
                        // write member's details to the text file
                        writer.WriteLine(members[i].Name);
                        writer.WriteLine(members[i].Age);
                        writer.WriteLine(members[i].Ic);
                        writer.WriteLine(members[i].PhoneNum);
                        writer.WriteLine(members[i].Id);
                        writer.WriteLine(members[i].Password);
                        writer.WriteLine(members[i].BonusPoints);

                        // write seats owned by member to the text file
                        for (int j = 0; j < members[i].SeatsOwned.Count; j++)
                        {
                            writer1.Write(members[i].Id + " ");
                            writer1.WriteLine(members[i].SeatsOwned[j].ToString());
                        }

                        // write all payment histories of the current member to the text file
                        for (int k = 0; k < members[i].PaymentHistories.Count; k++)
                        {
                            PaymentHistory aPaymentHistory = (PaymentHistory)members[i].PaymentHistories[k];

                            writer2.WriteLine(aPaymentHistory.Code);
                            writer2.WriteLine(aPaymentHistory.MovieName);
                            writer2.WriteLine(aPaymentHistory.MovieShowTime);
                            writer2.WriteLine(aPaymentHistory.SeatsChosen);
                            writer2.WriteLine(aPaymentHistory.PricePerTicket);
                            writer2.WriteLine(aPaymentHistory.NumOfTickets);
                            writer2.WriteLine(aPaymentHistory.TotalPrice);
                            writer2.WriteLine(aPaymentHistory.DateOfPurchase);
                            writer2.WriteLine(aPaymentHistory.TimeOfPurchase);
                            writer2.WriteLine(aPaymentHistory.OriginalBonusPoints);
                            writer2.WriteLine(aPaymentHistory.BonusPointsGained);
                            writer2.WriteLine(aPaymentHistory.NewBonusPoints);
                        }
                    }

                    // close the file after finish writing
                    writer.Close();
                    writer1.Close();
                    writer2.Close();
                }
                catch (IOException ioExc)
                {
                    MessageBox.Show(ioExc.Message);
                }
                catch (SystemException sysExc)
                {
                    MessageBox.Show(sysExc.Message);
                }
            }
            else
                MessageBox.Show("File doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // exit button for member
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //exit button for staff
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //intiliaze the mouse position
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

     

        //move no-border window
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}