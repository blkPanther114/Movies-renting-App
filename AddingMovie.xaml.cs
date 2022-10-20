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
    public partial class AddingMovie : ContentPage
    {
        private List<string> imageList;
        private string selectedImage = "";

        public AddingMovie()
        {
            InitializeComponent();

            imageList = new List<string>();

            imageList.Add("world.png");
            imageList.Add("robot.jpg");
            imageList.Add("Atonement.jpg");
            imageList.Add("duff.jpg");
            imageList.Add("beauty.jpg");
            imageList.Add("pp.jpg");


            this.pckChangeImage.ItemsSource = imageList;
        }

        private void pckChangeImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker imgPicker = sender as Picker;

            int index = imgPicker.SelectedIndex;

            if (index >= 0)
            {
                this.selectedImage = imageList[index];
                this.imgCustomerImage.Source = imageList[index];
            }
            else
            {
                this.imgCustomerImage.Source = null;
            }
        }

        private void btnAddCustomer_Clicked(object sender, EventArgs e)
        {
            string mtitle = this.txtNameCustomer.Text;
            string genres = this.txtGenres.Text;
            string runtime = this.txtRT.Text;
            string releasedate = this.txtRD.Text;
            string cast = this.txtCast.Text;
            string dailyfee = this.txtFee.Text;

            //mTitle = inTitle;
            //         Genres = inGenres;
            //         Runtime = inRuntime;
            //         ReleaseDate = inReleaseD;
            //         Cast = inCast;
            //         DailyFee = inDailyfee;


            Movie newCust = new Movie(mtitle, genres, runtime, releasedate, cast, dailyfee, /*Movies.ID++,*/ selectedImage);
            MainPage.ActiveCustomerList.MovieList.Add(newCust);
        }
    }
}