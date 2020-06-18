using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Assignment_1._1
{
    public abstract class User
    {
        protected string movieDetails = "| {0,-5} | {1,-30} | {2,-11} | {3,-15} |";

        // instance variables
        protected string name;
        protected int age;
        protected string ic;
        protected string phoneNum;
        protected string id;
        protected string password;
        // not related instance variables
        protected Cinema cinema;
        protected User currentUser;

        // property for instance variables 
        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public string Ic
        {
            get { return ic; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
        }

        public string Id
        {
            get { return id; }
        }

        public string Password
        {
            get { return password; }
        }

        public Cinema Cinema
        {
            get { return cinema; }
        }

        // Overloaded constructors
        public User(Cinema cinema)
        {
            this.cinema = cinema;
        }

        public User(Cinema cinema, User currentUser)
        {
            this.cinema = cinema;
            this.currentUser = currentUser;
        }

        public User(string name, int age, string ic, string phoneNum,
                        string id, string password)
        {
            this.name = name;
            this.age = age;
            this.ic = ic;
            this.phoneNum = phoneNum;
            this.id = id;
            this.password = password;
        }

        // abstract methods
        public abstract User Login();
    }
}