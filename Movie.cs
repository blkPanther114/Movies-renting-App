using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAssignment
{
    public class Movie
    {
        public string mTitle{ get; set; }
        public string Genres { get; set; }
        public string Runtime { get; set; }
        public string ImageName { get; set; }
        public string ReleaseDate { get; set; }
        public string Cast { get; set; }
        public string DailyFee { get; set; }

        //public int ID { get; set; }

        public Movie(string inTitle, string inGenres, string inRuntime, string inReleaseD, string inCast, string inDailyfee,/* int inID,*/ string inImageName)
        {
            mTitle = inTitle;
            Genres = inGenres;
            Runtime = inRuntime;
            ReleaseDate = inReleaseD;
            Cast = inCast;
            DailyFee = inDailyfee;
            ImageName = inImageName;
            //ID = inID;
        }
        public Movie(string inTitle, string inGenres, string inRuntime, string inReleaseD, string inCast, string inDailyfee/*, int inID*/)
        {
            mTitle = inTitle;
            Genres = inGenres;
            Runtime = inRuntime;
            ReleaseDate = inReleaseD;
            Cast = inCast;
            DailyFee = inDailyfee;
            //ID = inID;
        }

     
    }
}
