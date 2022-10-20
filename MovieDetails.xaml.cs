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
    public partial class MovieDetails : ContentPage
    {
        //private Customer SelectedCustomer;
        private CustomerView view;

        public MovieDetails(Movie c)
        {
            InitializeComponent();

            //SelectedCustomer = c;
            view = new CustomerView();
            view.Load(c);

            //tblCustomerDetails.BindingContext = SelectedCustomer;
            tblCustomerDetails.BindingContext = view;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            App thisApp = Application.Current as App;
            // Copy the data from the viewmodel into the active customer
            view.Save(ref thisApp.ActiveCustomer);

            // Find the customer in the list
            int pos = MainPage.ActiveCustomerList.MovieList.IndexOf(thisApp.ActiveCustomer);
            // Remove it
            MainPage.ActiveCustomerList.MovieList.RemoveAt(pos);

            // Put it back again - to force a change
            MainPage.ActiveCustomerList.MovieList.Insert(pos, thisApp.ActiveCustomer);


            await Navigation.PushAsync(new rentPage());
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }





    }
}

