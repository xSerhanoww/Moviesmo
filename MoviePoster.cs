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
    public partial class MoviePoster : UserControl
    {
        public static MoviePoster tempMoviePoster { get; set; }
        public MoviePoster(Image image, string title)
        {
            InitializeComponent();
            this.movieImage.Image = image;
            this.movieTitle.Text = title;
            this.movieImage.SizeMode = PictureBoxSizeMode.Zoom;


            this.MouseEnter += new EventHandler(MoviePoster_MouseEnter);
            this.MouseLeave += new EventHandler(MoviePoster_MouseLeave);
            this.movieImage.MouseEnter += new EventHandler(MoviePoster_MouseEnter);
            this.movieImage.MouseLeave += new EventHandler(MoviePoster_MouseLeave);
            this.movieTitle.MouseEnter += new EventHandler(MoviePoster_MouseEnter);
            this.movieTitle.MouseLeave += new EventHandler(MoviePoster_MouseLeave);
        }

        private void MoviePoster_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void MoviePoster_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void MoviePoster_Click(object sender, EventArgs e)
        {

            if (AllMoviesForm.instance != null)
            {
                AllMoviesForm.instance.mainPanel.Controls.Clear();
                tempMoviePoster = this;
                MovieInformationForm mvForm = new MovieInformationForm();
                mvForm.TopLevel = false;
                AllMoviesForm.instance.mainPanel.Controls.Add(mvForm);
                mvForm.Show();
            }
            else
            {
                HomeScreen.instance.Controls.Clear();
                tempMoviePoster = this;
                MovieInformationForm mvForm = new MovieInformationForm();
                mvForm.TopLevel = false;
                HomeScreen.instance.Controls.Add(mvForm);
                mvForm.Show();
            }
                
            
               
           
        }
    }
}
