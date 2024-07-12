using movie_catalog_beta.Data;
using System.Data;


namespace movie_catalog_beta
{
    public partial class MovieInformationForm : Form
    {
        public static string currentTitle { get; set; }
        public MovieInformationForm()
        {
            InitializeComponent();
            usercontrikPoster.Image = MoviePoster.tempMoviePoster.movieImage.Image;
            usercontrikPoster.SizeMode = PictureBoxSizeMode.Zoom;
            currentTitle = MoviePoster.tempMoviePoster.movieTitle.Text;
            title_lbl.Text = currentTitle;
            LoadContent();
        }
        private void LoadContent()
        {
            using (var db = new MoviesDbContext())
            {
                int currentActorId = 0;
                var currentMovie = db.Movies.Where(x => x.Title == currentTitle).FirstOrDefault();
                descriptionText.Text = currentMovie.Description;
                var director = db.Directors.Where(x => x.DirectorId == currentMovie.DirectorId);
                foreach (var item in director) director_lbl.Text = item.Name;
                var country = db.Countries.Where(x => x.CountryId == currentMovie.CountryId);
                foreach (var item in country) country_lbl.Text = item.Name;
                var genre = db.Genres.Where(x => x.GenreId == currentMovie.GenreId);
                foreach (var item in genre) genre_lbl.Text = item.Name;
                length_lbl.Text = currentMovie.Length.ToString() + " min";
                var relation = db.movieactors.Where(x=> x.MovieId == currentMovie.MovieId);
                foreach (var item in relation) currentActorId = item.ActorId;
                var actor = db.Actors.Where(x => x.ActorId == currentActorId);
                foreach(var item in actor) actor_lbl.Text = item.Name;


            }
        }
    }
}
