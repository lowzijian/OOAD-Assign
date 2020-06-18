using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOAD_Assignment_1._1
{
    public class Staff : User
    {
        // Overloaded constructors
        public Staff(Cinema cinema) : base(cinema)
        {

        }

        public Staff(Cinema cinema, User currentUser) : base(cinema, currentUser)
        {

        }

        public Staff(string name, int age, string ic, string phoneNum,
                        string id, string password)
                        : base(name, age, ic, phoneNum, id, password)
        {

        }

        // overriding methods
        public override User Login()
        {
            // create an object of UserForm
            UserForm uf = new UserForm(cinema);

            // set the Visible property of btnLogin and panelLogin to true
            uf.btnLoginAsStaff.Visible = true;
            uf.btnLoginAsMember.Visible = false;
            uf.panelLogin.Visible = true;
            uf.btnRegister.Visible = false;

            // display UserForm object created
            uf.ShowDialog();

            // return the currentUser's reference of UserForm object
            return uf.currentUser;
        }

        public void ShowMemberList()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageViewMemberList
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[7];

            // display MainMenuForm object created
            mmf.ShowDialog();
        }

        public void ShowMovieList()
        {
            // create an object of MainMenuForm
            MainMenuForm mmf = new MainMenuForm(cinema, currentUser);

            // switch to tPageViewMemberList
            mmf.MoviesTabCtrl.SelectedTab = mmf.MoviesTabCtrl.TabPages[8];

            // display MainMenuForm object created
            mmf.ShowDialog();
        }
    }
}
