using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MovieAssignment
{
    public class Movies
    {
        public string mTitle { get; set; }
        public Movies(string inTitle/*, string inGenres, string inRuntime, string inReleaseD, string inCast, string inDailyfee*//*, int inID*/)
        {
            mTitle = inTitle;


            MovieList = new List<Movie>();
        }

        public List<Movie> MovieList;

        public static Movies MakeMovies()
        {
            string[] mTitle = new string[] { "the world is not enough", "Enthiran","Atonement","The Duff","American Beauty",
            "Pride & Prejudice" };
            string[] Genres = new string[] { "Action", "Sci-fition", "Romantic,War", "Comedy", "Drama", "Romance" };
            string[] Runtime = new string[] { "125 mins", "166 mins", "123 mins", "101 mins", "122 mins", "127 mins" };
            string[] Releasedate = new string[] { "1999", "2010", "2007", "2015", "1999", "2005" };
            string[] Cast = new string[] { "Pierce Brendan Brosnan", "Aishwarya Rai" , "Keira Knightley"," Robbie Amell",
          " Kevin Spacey","Matthew Macfadyen" };

            string[] Dailyfee = new string[] { "0.50", "0.80", "0.90", "0.70", "1.00", "1.50" };

            string[] ImageName = new string[] { "world.png", "robot.jpg", "Atonement.jpg","duff.jpg","beauty.jpg",
            "pp.jpg"};


            Movies result = new Movies("test movie");

            Random sessionRand = new Random(1);

            for (int i = 0; i < mTitle.Length; i++)
            {
                var m = mTitle[i];
                var g = Genres[i];
                var run = Runtime[i];
                var Release = Releasedate[i];
                var c = Cast[i];
                var fee = Dailyfee[i];
                var img = ImageName[i];

                Movie newMovie = new Movie(m,g,run,Release,c,fee,img);

                result.MovieList.Add(newMovie);
            }
            return result;



            //            int imgIndex = 0;

            //            //int id = 0;
            //            // Use a fixed squence of random numbers to make the same data each time
            //            Random sessionRand = new Random(1);
            //            foreach (string mTitle in inTitle)
            //            {
            //                foreach (string Genres in inGenres)
            //                {
            //                    foreach (string Runtime in inRuntime)
            //                    {
            //                        foreach (string ReleaseDate in inReleasedate)
            //                        {
            //                            foreach (string Cast in inCast)
            //                            {
            //                                foreach (string DailyFee in inDailyfee)
            //                                {

            //                                    // Make a new movie
            //                                    //        Movie newMovie = new Movie(name, name + "'s House", IdCustomer, imageNames[imgIndex]);
            //                                    Movie newMovie = new Movie(mTitle, Genres, Runtime, ReleaseDate, Cast, DailyFee, ID, imageNames[imgIndex]);
            //                                    imgIndex++;


            //                                    if (imgIndex == imageNames.Length)
            //                                    {
            //                                        imgIndex = 0;
            //                                    }
            //                                    ID++;
            //                                    result.MovieList.Add(newMovie);
            //                                    //IdCustomer++;


            //            }
            //        }
            //    }
            //}
            //                }
            //            }
            //            return result;
            //        }
            //    }

        }


    }
}

