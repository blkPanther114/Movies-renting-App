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
    public partial class rentPage : ContentPage
    {
        public RentMovie cr;
        public ProfilePage p2;

        private async void lstCustomerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            Movie selectedCustomer = e.SelectedItem as Movie;

            //keep track the selected item and store it at App class
            App thisApp = Application.Current as App;
            thisApp.ActiveCustomer = selectedCustomer;

            await Navigation.PushAsync(new MovieDetails(selectedCustomer));

            ((ListView)sender).SelectedItem = null; // clears the 'selected' background
        }



        public rentPage()
        {
            cr = new RentMovie();
            InitializeComponent();

        }
        private async void PrevPage_clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        public void displayData()
        {
            this.mTitle.Text = cr.movTitle;
            this.Genres.Text = cr.movGenres;
            this.Runtime.Text = cr.movRuntime;
            this.Cast.Text = cr.movCast;
            this.ReleaseDate.Text = cr.movRD;
            this.DailyFee.Text = cr.movFee;

        }
        private async void submitClicked(object sender, EventArgs e)
        {
            p2 = new ProfilePage();
            DateTime d1 = datepick.Date;
            DateTime d2 = pcikDate.Date;
            TimeSpan t = d1 - d2;
            try
            {
                if (t.TotalDays < 0)
                {
                    await DisplayAlert("caution", "start date must be earlier than return date", "ok");

                }

                else
                {
                    if (this.enterName.Text == null /*|| this.enterAddress.Text == null*/ || this.pickerType.SelectedItem == null)
                    {
                        await DisplayAlert("caution!", "please fill in all the informations", "ok");
                    }
                    else
                    {
                        var pickD = pcikDate.Date.ToString();
                        var pickT = timep.Time.ToString();
                        var returnD = datepick.Date.ToString();
                        var returnT = timepicker.Time.ToString();
                        string loanDateTime = string.Format("Date:{0} Time:{1}", pickD, pickT);
                        string returnDateTime = string.Format("Date:{0} Time:{1}", returnD, returnT);
                        p2.myRent.receiveTitle = this.mTitle.Text;
                        p2.myRent.receiveGenres = this.Genres.Text;
                        p2.myRent.receiveRunTime = this.Runtime.Text;
                        p2.myRent.receiveCast = this.Cast.Text;
                        p2.myRent.receiveRunTime = this.ReleaseDate.Text;
                        p2.myRent.receiveDailyfee = this.DailyFee.Text;

                        p2.myRent.receiveUserName = this.enterName.Text;
                        p2.myRent.receiveAddress = this.enterAddress.Text;
                        p2.myRent.receiveEmail = this.enterEmail.Text;
                        p2.myRent.receiveStartDate = loanDateTime;
                        p2.myRent.receiveReturnDate = returnDateTime;
                        p2.myRent.receiveType = this.pickerType.SelectedItem.ToString(); ;
                        p2.myRent.receiveTotalDays = Convert.ToString(t.TotalDays);

                       // p2.myRent.receiveTotalPrice = Convert.ToString(Convert.ToInt32(this.DailyFee.Text) * (t.TotalDays));
                        p2.passRentCarInfo();

                        await DisplayAlert("Congratulation", "Your order has been accepet successfully! ", "OK");
                        await Navigation.PushModalAsync(p2);

                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ok", "ok", Convert.ToString(ex));
            }
        }


        private async void textChange(object sender, TextChangedEventArgs e)
        {
            string s = enterName.Text;
            if (s.All(char.IsLetter))
                return;
            await DisplayAlert("caution!", "entered text is not letter", "ok");


        }
    }
}




