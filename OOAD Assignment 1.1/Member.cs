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

namespace OOAD_Assignment_1._1
{
    public class Member : User
    {
        // instance variables i.e. attributes for Customer entity
        private int bonusPoints;
        private ArrayList seatsOwned;
        private ArrayList paymentHistories;
        private int numOfPaymentHistories;

        // property for instance variables 
        public int BonusPoints
        {
            get { return bonusPoints; }
            set { bonusPoints = value; }
        }

        
        public ArrayList SeatsOwned
        {
            get { return seatsOwned; }
        }

        public ArrayList PaymentHistories
        {
            get { return paymentHistories; }
        }

        public int NumOfPaymentHistories
        {
            get { return numOfPaymentHistories; }
            set { numOfPaymentHistories = value; }
        }

        // Overloaded constructors
        public Member(Cinema cinema) : base(cinema)
        {

        }

        public Member(Cinema cinema, User currentUser) : base (cinema, currentUser)
        {

        }

        public Member(string name, int age, string ic, string phoneNum, 
                        string id, string password, int bonusPoints) : 
                            base(name, age, ic, phoneNum, id, password)
        {
            this.bonusPoints = bonusPoints;
            this.numOfPaymentHistories = 0;
            seatsOwned = new ArrayList();
            paymentHistories = new ArrayList();
        }


        // overriding methods
        public override User Login()
        {
            // create an object of UserForm
            UserForm uf = new UserForm(cinema);

            // set the Visible property of btnLogin and panelLogin to true
            uf.btnLoginAsMember.Visible = true;
            uf.panelLogin.Visible = true;
            uf.btnLoginAsStaff.Visible = false;
            uf.btnRegister.Visible = false;

            // display UserForm object created
            uf.ShowDialog();

            // return the currentUser's reference of UserForm object
            return uf.currentUser;
        }

        // instance methods
        public User Register()
        {
            // create an object of UserForm
            UserForm uf = new UserForm(cinema);

            // set the Visible property of btnRegister and panelRegister to true
            uf.btnRegister.Visible = true;
            uf.panelRegister.Visible = true;
            uf.btnLoginAsStaff.Visible = false;
            uf.btnLoginAsMember.Visible = false;

            // display UserForm object created
            uf.ShowDialog();

            // return the currentUser's reference of UserForm object
            return uf.currentUser;
        }

        // instance methods

        // view seat status for specific movie
        public void ViewSeatsForSpecificMovie()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageChooseSpecificMovie
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[0];
            mmf.btnChooseSpecificMovie.Visible = true;// for purchase ticket

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        // view seat status for all movies
        public void ViewSeatsForAllMovies()
        {
            //// get the movieList from the cinema object
            //Movie[] movies = cinema.GetMovieList();

            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // set the Visible property of btnRedeem1, btnRedeem2 and btnRedeem3 to false
            mmf.btnRedeem1.Visible = false;
            mmf.btnRedeem2.Visible = false;
            mmf.btnRedeem3.Visible = false;

            // switch to tPageMovie1
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[1];

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        // purchase and assigning seats
        public void PurchaseSeats()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageChooseSpecificMovie
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[0];
            mmf.btnChooseSpecificMovie.Visible = true;// for purchase ticket

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        // change the seat purchased
        public void ChangeSeat()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageChooseSpecificMovie
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[5];
            mmf.btnChooseSpecificMovie.Visible = false;// for purchase ticket

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        public void RedeemBonus()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageRedeemBonus
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[6];
            mmf.btnChooseSpecificMovie.Visible = false;// for purchase ticket

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        public void ViewPaymentHistory()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageView
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[10];

            // display MainMenuForm object created
            mmf.ShowDialog();
        }
    }
}