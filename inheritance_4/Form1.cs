namespace inheritance_4
{
    public partial class Form1 : Form
    {
        List<Movie> moviesList = new List<Movie>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
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
            ShowInfo();
        }

        private void ShowInfo()
        {
            int filmsCount = 0;
            int serialsCount = 0;
            int televisionsCount = 0;

            foreach (var movie in this.moviesList)
            {
                if (movie is Film)
                {
                    filmsCount += 1;
                }
                else if (movie is Serial)
                {
                    serialsCount += 1;
                }
                else if (movie is Television)
                {
                    televisionsCount += 1;
                }
            }

            txtInfo.Text = "Фильм\tСериал\tТелепередача";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", filmsCount, serialsCount, televisionsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.moviesList.Count == 0)
            {
                txtOut.Text = "Пусто";
                return;
            }

            var movie = this.moviesList[0];
            this.moviesList.RemoveAt(0);

            txtOut.Text = movie.GetInfo();

            ShowInfo();
        }
    }
}
