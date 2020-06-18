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
    public partial class UserForm : Form
    {
        public Cinema cinema;
        Member[] memberList;
        Staff[] staffList;
        public User currentUser;
        ToolTip toolTip1 = new ToolTip();
        public UserForm(Cinema cinema)
        {
            InitializeComponent();
            this.cinema = cinema;
            memberList = cinema.GetMemberList();
            staffList = cinema.GetStaffList();
        }

        private void btnLoginAsMember_Click(object sender, EventArgs e)
        {
            // ****try-catch****
            try
            {
                // local variables
                string loginID = tbxLoginID.Text;
                string password = tbxPassword.Text;

                // for loop => loop through the memberList and staffList to find if the member or staff exists
                bool validLogin = false;

                for (int i = 0; i < memberList.Length; i++)
                {
                    if (loginID == memberList[i].Id && password == memberList[i].Password)
                    {
                        MessageBox.Show("Login successfully.");
                        validLogin = true;
                        currentUser = memberList[i];
                        this.Close();// close the form after this event handler method finished execution
                    }
                }

                // if the code reached here => it means member ID or password or both are invalid
                if (validLogin == false)
                    MessageBox.Show("Invalid Login");

                // reset the texts of tbxLogin and tbxPassword
                tbxLoginID.Text = "";
                tbxPassword.Text = "";
            }
            catch (FormatException fExc)
            {
                MessageBox.Show("Invalid Input. Re-enter again !\n" + fExc.Message);
                tbxLoginID.Clear();
                tbxPassword.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ****try-catch****

            try
            {
                // create temporary variables to store texts of text boxes
                string name = tbxName.Text;
                int age = Convert.ToInt32(tbxAge.Text);
                string ic = tbxIC.Text;
                string phoneNum = tbxPhoneNum.Text;

                // create a new member ID
                string id = memberList[memberList.Length - 1].Id;
                int number = Convert.ToInt32(id.Substring(1));
                number++;
                id = "M" + number;

                // create an char array that holds all possible characters to create
                //random string
                // convert the string into a char array using ToCharArray() method
                char[] letters = "1234567890".ToCharArray();

                // create an instance of Random class
                //=> generate a random no. to represent the index of char to be used
                Random randNumGenerator = new Random();

                // create a random string i.e. password
                string randomPassword = "";
                for (int i = 0; i < 6; i++)
                {
                    randomPassword += letters[randNumGenerator.Next(0, 9)].ToString();
                }

                // to check if the password generated is duplicated
                while (IsDuplicate(memberList, randomPassword))
                {
                    randomPassword = "";
                    for (int i = 0; i < 6; i++)
                    {
                        randomPassword += letters[randNumGenerator.Next(0, 9)].ToString();
                    }
                }

                if (tbxName.Text != "" && tbxAge.Text != "" && tbxIC.Text != "" && tbxPhoneNum.Text != "")
                {
                    MessageBox.Show("Registered Successfully.\n" + "Member ID: " + id
                                    + "\nPassword: " + randomPassword);
                    currentUser = new Member(name, age, ic, phoneNum, id, randomPassword, 0);// create a new array list for new user which used to store seats owned

                    this.Close();// close the form after this event handler method finished execution
                }
                else
                    MessageBox.Show("Invalid registration!!!\nPlease ensure all fields are filled correctly.");
            }
            catch (FormatException fExc)
            {
                MessageBox.Show("Invalid Input. Reenter again !\n" + fExc.Message);
                tbxLoginID.Clear();
                tbxPassword.Clear();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxLoginID.Clear();
            tbxPassword.Clear();
            tbxName.Clear();
            tbxAge.Clear();
            tbxIC.Clear();
            tbxPhoneNum.Clear();
        }

        public bool IsDuplicate(Member[] memberList, string randomPassword)
        {
            // loop through the arraylist to check if the 
            for (int i = 0; i < memberList.Length; i++)
            {
                if (memberList[i].Password == randomPassword)
                    return true;
            }
            return false;
        }

        //encrypt password input with asterisk
        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '\u25CF';
        }

        // decrypt password input with characters
        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
                tbxPassword.PasswordChar = '\0';
            else
                tbxPassword.PasswordChar = '\u25CF';
        }

        //close button for login
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //close button for register
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //intiliaze the mouse position
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void pnlInfo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pnlInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void btnLoginAsStaff_Click(object sender, EventArgs e)
        {

            // ****try-catch****
            try
            {
                // local variables
                string loginID = tbxLoginID.Text;
                string password = tbxPassword.Text;

                // for loop => loop through the memberList and staffList to find if the member or staff exists
                bool validLogin = false;


                for (int i = 0; i < staffList.Length; i++)
                {
                    if (loginID == staffList[i].Id && password == staffList[i].Password)
                    {
                        MessageBox.Show("Login successfully.");
                        validLogin = true;
                        currentUser = staffList[i];
                        this.Close();// close the form after this event handler method finished execution
                    }
                }

                // if the code reached here => it means member ID or password or both are invalid
                if (validLogin == false)
                    MessageBox.Show("Invalid Login");

                // reset the texts of tbxLogin and tbxPassword
                tbxLoginID.Text = "";
                tbxPassword.Text = "";
            }
            catch (FormatException fExc)
            {
                MessageBox.Show("Invalid Input. Reenter again !\n" + fExc.Message);
                tbxLoginID.Clear();
                tbxPassword.Clear();

            }
        }

        private void tbxPassword_MouseHover(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                toolTip1.ToolTipTitle = "Caps Lock Is On";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(tbxPassword, "Having Caps Lock on may cause you to enter your password incorrectly.\n\nYou should press Caps Lock to turn it off before entering your password.");
                toolTip1.Show("Having Caps Lock on may cause you to enter your password incorrectly.\n\nYou should press Caps Lock to turn it off before entering your password.", tbxPassword, 5, tbxPassword.Height - 5);
            }
        }

        private void tbxPassword_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(tbxPassword);
        }

        private void pnlInfo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
