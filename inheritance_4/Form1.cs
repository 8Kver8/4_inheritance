namespace inheritance_4
{
    public partial class Form1 : Form
    {
        List<Movie> moviesList = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.moviesList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.moviesList.Add(Film.Generate());
                        break;
                    case 1:
                        this.moviesList.Add(Serial.Generate());
                        break;
                    case 2:
                        this.moviesList.Add(Television.Generate());
                        break;
                }
            }
        }
    }
}
