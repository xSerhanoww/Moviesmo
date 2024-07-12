namespace movie_catalog_beta
{
    public partial class Form1 : Form
    {
        public HomeScreen homeScreenInstance;
        public AllMoviesForm allMoviesFormInstance;

        public Form activeForm;
        public Form1()
        {
            InitializeComponent();
            CallHomeScreen();
        }

        private void exitLbl_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            
            CallHomeScreen();
        }

        private void movies_btn_Click(object sender, EventArgs e)
        {
            CallMoviesForm();
            
        }
        private void CallHomeScreen()
        {
            SidePanel.Width = home_btn.Width;
            SidePanel.Left = home_btn.Left;
            HomeScreen homeScreen = new HomeScreen();
            homeScreenInstance = homeScreen;
            activeForm = homeScreen;
            homeScreen.TopLevel = false;
            homeScreen.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(homeScreen);
            homeScreen.Show();
            AllMoviesForm.instance = null;

        }
        private void CallMoviesForm()
        {
            SidePanel.Width = movies_btn.Width;
            SidePanel.Left = movies_btn.Left;
            AllMoviesForm allMoviesForm = new AllMoviesForm();
            allMoviesFormInstance = allMoviesForm;
            activeForm = allMoviesForm;
            allMoviesForm.TopLevel = false;
            allMoviesForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(allMoviesForm);
            allMoviesForm.Show();
            HomeScreen.instance = null;

        }
        public static string SetImage(string imageName)
        {
            return $@"..\..\..\Images\{imageName}.jpg";
        }
    }
}
