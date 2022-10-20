using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public RentingInfo myRent;
        public ProfilePage()
        {
            InitializeComponent();          
            myRent = new RentingInfo();
        }
        private async void btnclicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new MainPage(), true);
        }

        public void passRentCarInfo()
        {
            this.getTitle.Text = myRent.receiveTitle;
            this.getGenres.Text = myRent.receiveGenres;
            this.getRunTime.Text = myRent.receiveRunTime;
            this.getCast.Text = myRent.receiveCast;
            this.getRD.Text = myRent.receiveRD;
            this.getDF.Text = myRent.receiveDailyfee;

            this.getUsername.Text = myRent.receiveUserName;
            this.getEmail.Text = myRent.receiveEmail;
            this.getAddress.Text = myRent.receiveAddress;         
            this.getLoanDate.Text = myRent.receiveStartDate;
            this.getReturnDate.Text = myRent.receiveReturnDate;
            this.getType.Text = myRent.receiveType;
            this.getTotalDays.Text = myRent.receiveTotalDays;
            

        }
    }
}