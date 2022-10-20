using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace MovieAssignment
{
    public class CustomerView: INotifyPropertyChanged
    {
        private string mtitle;

        public string mTitle
        {
            get
            {
                return mtitle;
            }
            set
            {
                mtitle = value;
                OnPropertyChanged("Title");
            }
        }
        private string genres;

        public string Genres
        {
            get
            {
                return genres;
            }
            set
            {
                genres = value;
                OnPropertyChanged("Genres");
            }

        }
        private string runtime;

        public string Runtime
        {
            get
            {
                return runtime;
            }
            set
            {
                runtime = value;
                OnPropertyChanged("Runtime");
            }
        }

        private string imageName;

        public string ImageName
        {
            get
            {
                return imageName;
            }
            set
            {
                imageName = value;
                OnPropertyChanged("ImageName");
            }
        }

       private string releaseDate;
        public string ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
               releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        private string cast;
        public string Cast
        {
            get
            {
                return cast;
            }
            set
            {
                cast = value;
                OnPropertyChanged("Cast");
            }
        }
       private string dailyfee;
        public string DailyFee
        {
            get
            {
                return dailyfee;
            }
            set
            {
                dailyfee = value;
                OnPropertyChanged("DailyFee");
            }
        }



        public void Load(Movie cust)
        {
            mTitle = cust.mTitle;
            Genres = cust.Genres;

            //ImageTitle = cust.ImageTitle;

            Runtime = cust.Runtime;
            ReleaseDate = cust.ReleaseDate;
            Cast = cust.Cast;
            DailyFee = cust.DailyFee;

            ImageName = cust.ImageName;
        }

        public void Save(ref Movie cust)
        {
            cust.mTitle = mTitle;
            cust.Genres = Genres;
            //cust.ImageTitle = ImageTitle;
            cust.Runtime = Runtime;
            cust.ReleaseDate = ReleaseDate;
            cust.Cast = Cast;
            cust.DailyFee = DailyFee;
            cust.ImageName = ImageName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyTitle)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyTitle));
            }
        }
    }
}
