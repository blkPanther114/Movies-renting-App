
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieAssignment
{
    public partial class MainPage : ContentPage
    {
        public rentPage p1 = new rentPage();

        public static Movies ActiveCustomerList;

        

        public MainPage()
        {
            InitializeComponent();

            // Create a customer list to work with
            ActiveCustomerList = Movies.MakeMovies();

            this.lstCustomerList.ItemsSource = ActiveCustomerList.MovieList;
        }

        //private async void lstCustomerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null) return;

        //    Movie selectedCustomer = e.SelectedItem as Movie;

        //    //keep track the selected item and store it at App class
        //    App thisApp = Application.Current as App;
        //    thisApp.ActiveCustomer = selectedCustomer;

        //    await Navigation.PushAsync(new MovieDetails(selectedCustomer));

        //    ((ListView)sender).SelectedItem = null; // clears the 'selected' background
        //}


        private async void lstCustomerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            Movie selectedCustomer = e.SelectedItem as Movie;
            p1.cr.movTitle = selectedCustomer.mTitle;
            p1.cr.movGenres = selectedCustomer.Genres;
            p1.cr.movRuntime = selectedCustomer.Runtime;
            p1.cr.movRD= selectedCustomer.ReleaseDate;
            p1.cr.movCast= selectedCustomer.Cast;
            p1.cr.movFee= selectedCustomer.DailyFee;
            p1.displayData();
            await Navigation.PushModalAsync(p1);
            ((ListView)sender).SelectedItem = null;
        }


        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddingMovie());
        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            string searchedName = this.txtSearchBox.Text;

            var selectedCustomers = from Movie cust in ActiveCustomerList.MovieList
                                    where cust.mTitle.Contains(searchedName)
                                    select cust;

            this.lstCustomerList.ItemsSource = selectedCustomers;
        }

        public List<Movie> FindCustomer(string custName)
        {
            List<Movie> result = new List<Movie>();

            foreach (Movie cust in ActiveCustomerList.MovieList)
            {
                if (cust.mTitle.Contains(custName))
                {
                    result.Add(cust);
                }
            }
            return result;
        }

        private void lstCustomerList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}





        
        