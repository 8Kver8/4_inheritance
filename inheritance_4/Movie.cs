using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_4
{
    internal class Movie
    {
        public int Rating;

        public virtual String GetInfo()
        {
            var str = String.Format("\nРейтинг: {0}", this.Rating);
            return str;
        }
    }
}
