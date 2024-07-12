using movie_catalog_beta.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_catalog_beta
{
    public partial class AllMoviesForm : Form
    {
        public static AllMoviesForm instance;
        public AllMoviesForm()
        {
            instance = this;
            InitializeComponent();
            PopulateMenus();
            LoadMovies();

        }

        private void menuLabel_MouseHover(object sender, EventArgs e)
        {
            menuLabel.ForeColor = Color.LightBlue;
            menuStrip.Show(menuLabel, new Point(0, menuLabel.Height));
        }
        private void LoadMovies()
        {
            using (var db = new MoviesDbContext())
            {
                var movies = db.Movies.ToList();

                int controlWidth = 176;  
                int controlHeight = 310; 
                int spacing = 11;         
                int controlsPerRow = 7;  

                int panelWidth = moviesCatalog.Width;
                int panelHeight = moviesCatalog.Height;

                int totalGridWidth = controlsPerRow * controlWidth + (controlsPerRow - 1) * spacing;
                int rows = (int)Math.Ceiling((double)movies.Count / controlsPerRow);
                int totalGridHeight = rows * controlHeight + (rows - 1) * spacing;

                int xOffset = (panelWidth - totalGridWidth) / 2;
                int yOffset = (panelHeight - totalGridHeight) / 2;

                xOffset = Math.Max(0, xOffset);
                yOffset = Math.Max(0, yOffset);
             

                for (int i = 0; i < movies.Count; i++)
                {
                    int x = xOffset + (i % controlsPerRow) * (controlWidth + spacing);
                    int y = yOffset + (i / controlsPerRow) * (controlHeight + spacing);

                    MoviePoster moviePoster = new MoviePoster(Image.FromFile(Form1.SetImage(movies[i].Title)), movies[i].Title);

                    moviePoster.Location = new Point(x, y);
                    moviesCatalog.Controls.Add(moviePoster);

                }


            }
            

        }
        private void PopulateMenus()
        {
            menuStrip.Items.Clear();
            countryStrip.Items.Clear();
            directorsStrip.Items.Clear();

            menuStrip.ForeColor = Color.White;
            countryStrip.ForeColor = Color.White;
            directorsStrip.ForeColor = Color.White;

            using (var db = new MoviesDbContext())
            {
                foreach (var genre in db.Genres)
                {
                    menuStrip.Items.Add(genre.Name);
                }
                foreach (var director in db.Directors)
                {
                    directorsStrip.Items.Add(director.Name);
                }
                foreach (var country in db.Countries)
                {
                    countryStrip.Items.Add(country.Name);
                }


            }
        }

        private void menuLabel_MouseLeave(object sender, EventArgs e)
        {
            menuLabel.ForeColor = Color.White;


        }

        private void menuCountry_MouseHover(object sender, EventArgs e)
        {
            menuCountry.ForeColor = Color.LightBlue;
            countryStrip.Show(menuCountry, new Point(0, menuCountry.Height));
        }
        private void menuCountry_MouseLeave(object sender,EventArgs e)
        {
            menuCountry.ForeColor = Color.White;
        }
        private void menuDirectors_MouseHover(Object sender, EventArgs e)
        {
            menuDirectors.ForeColor = Color.LightBlue;
            directorsStrip.Show(menuDirectors, new Point(0, menuDirectors.Height));
        }
        private void menuDirectors_MouseLeave(Object sender, EventArgs e)
        {
           menuDirectors.ForeColor = Color.White;
        }

    }
}
