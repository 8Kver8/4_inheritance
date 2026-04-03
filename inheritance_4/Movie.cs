namespace inheritance_4
{
    public class Movie
    {
        public int Rating;

        public virtual String GetInfo()
        {
            var str = String.Format("\nРейтинг: {0}", this.Rating);
            return str;
        }
    }

    public enum FilmGenre
    {
        action, comedy, drama, horror, thriller,
        fantasy, adventure, crime, animation,
        documentary, musical, western
    };

    public class Film : Movie
    {
        public int Timekeeping;
        public FilmGenre Genre;

        public override String GetInfo()
        {
            var str = "Фильм";
            str += base.GetInfo();

            str += String.Format("\nХронометраж (в минутах): {0}", this.Timekeeping);
            str += String.Format("\nЖанр: {0}", this.Genre);
            return str;
        }
    }

    public class Serial : Movie
    {
        public int TotalNumberOfEpisodes;
        public int NumberOfSeasons;

        public override String GetInfo()
        {
            var str = "Сериал";
            str += base.GetInfo();

            str += String.Format("\nОбщее количество серий: {0}", this.TotalNumberOfEpisodes);
            str += String.Format("\nКоличество сезонов: {0}", this.NumberOfSeasons);
            return str;
        }
    }

    public class Television : Movie
    {
        public int Duration;
        public int Airtime;

        public override String GetInfo()
        {
            var str = "Телепередача";
            str += base.GetInfo();

            str += String.Format("\nПродолжительность (в днях): {0}", this.Duration);
            str += String.Format("\nЭфирное время (в минутах): {0}", this.Airtime);
            return str;
        }
    }
}
