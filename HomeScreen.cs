using movie_catalog_beta.Data;


namespace movie_catalog_beta
{
    public partial class HomeScreen : Form
    {
        public static HomeScreen instance;
        private List<Image> images;
        private int currentImageIndex;

        public HomeScreen()
        {
            instance = this;
            InitializeComponent();
            LoadImages();   
            LoadTopPicks();
        }
        private void LoadTopPicks()
        {
            using (var db = new MoviesDbContext())
            {
                var movies = db.Movies.Take(5).ToList();

                int totalControls = movies.Count;
                int controlWidth = 176;
                int controlHeight = 310;
                int panelWidth = topPicksPanel.Width;
                int panelHeight = topPicksPanel.Height;
                int totalControlsWidth = totalControls * controlWidth;
                int remainingWidth = panelWidth - totalControlsWidth;
                int margin = remainingWidth / (totalControls + 1);

                for (int i = 0; i < movies.Count; i++)
                {
                    MoviePoster moviePoster = new MoviePoster(Image.FromFile((Form1.SetImage(movies[i].Title))), movies[i].Title);
                    moviePoster.Width = controlWidth;
                    moviePoster.Height = controlHeight;
                    int xPos = margin + i * (controlWidth + margin);
                    moviePoster.Location = new Point(xPos, (panelHeight - controlHeight) / 2);
                    topPicksPanel.Controls.Add(moviePoster);




                }

            }



        }
        private void LoadImages()
        {
            
            images = new List<Image>
            {
                Properties.Resources.advert1,
                Properties.Resources.advert2,
                Properties.Resources.advert3
            };

            currentImageIndex = 0;
            PosterPanel.BackgroundImage = images[currentImageIndex];
            PosterPanel.BackgroundImageLayout = ImageLayout.Stretch;

            label3.Click += new EventHandler(label3_Click);

            
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ControlLight;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            currentImageIndex = (currentImageIndex + 1) % images.Count;         
            PosterPanel.BackgroundImage = images[currentImageIndex];
        }
       
    }
}
