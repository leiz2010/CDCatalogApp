using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalogDataAccess
{
    public partial class Genre
    {
        // Add a new genre 
        public Genre AddGenre(string genreName)
        {
            Genre genre = new Genre();

            try
            {
                genre.GenreName = genreName;

                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    db.Genres.Add(genre);
                    int resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            return genre;
        }
    }
}
