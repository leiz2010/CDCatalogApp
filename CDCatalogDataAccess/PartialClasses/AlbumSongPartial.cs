using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalogDataAccess
{
    public partial class AlbumSong
    {
        //Rate a specific song or Album
        public bool RateAlbumSong(string itemType, string title, int rating)
        { 
            bool Rated = false; 
            //assign rating to the title
            if (itemType == "song")
            { 
                //search db for the itemID in Song entity
                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    try
                    {
                        Song o = new Song();
                        o = db.Songs.Where(s => s.SongTitle == title).FirstOrDefault();
                        if (o != null)
                        {
                            o.SongRating = rating;
                            db.SaveChanges();
                            Rated = true;
                            return Rated;
                        }
                        else
                        {
                            Rated = false;
                            throw new Exception("This song is not in the collection!");
                        }
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show(ex.Message);
                    }
                }
                

            }
            if (itemType == "album")
            {
                //search db for the itemID in Song entity
                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    try
                    {
                        Album o = new Album();
                        o = db.Albums.Where(s => s.AlbumTitle== title).FirstOrDefault();
                        if (o != null)
                        {
                            o.AlbumRating = rating;
                            db.SaveChanges();
                            Rated = true;
                            return Rated;
                        }
                        else
                        {
                            Rated = false;
                            throw new Exception("This album is not in the collection!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

            //return true if assigned rating successfully, else return false
            return false;


        }

        //Search title
        public List<AlbumSong> SearchAlbumSongTitle(string title)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                    return db.AlbumSongs.Where(s => s.AlbumTitle.ToUpper().Contains(title.ToUpper().Trim())
                                                    || s.SongTitle.ToUpper().Contains(title.ToUpper().Trim())).ToList();
            }
        }

        //Search genre
        public List<Genre> SearchAlbumSongGenre(string genreName)
        {
            
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                return db.Genres.Where(s => s.GenreName.ToUpper().Contains(genreName.ToUpper().Trim())).ToList();
               
            }
        }

        //Search artist
        public List<Artist> SearchAlbumSongArtist(string artistName)
        {

            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                return db.Artists.Where(s => s.ArtistName.ToUpper().Contains(artistName.ToUpper().Trim())).ToList();
               
            }
        }

        //Searh songs by genre
        public List<Song> SearchSongByGenre(string genreName)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                int genreID = db.Genres.Where(s => s.GenreName == genreName).FirstOrDefault().GenreID;
                return db.Songs.Where(s => s.GenreID == genreID).ToList();
            }
        }


        //Search albums by genre
        public List<Album> SearchAlbumByGenre(string genreName)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                List<AlbumByGenre> albumGenres = new List<AlbumByGenre>();
                List<Album> albums = new List<Album>();
                albumGenres = db.AlbumByGenres.Where(s => s.GenreName == genreName).ToList();

                foreach (AlbumByGenre o in albumGenres)
                {
                    albums.Add(db.Albums.Where(s => s.AlbumID == o.AlbumID).FirstOrDefault());
                }

                return albums;
            }
        }

        //Search songs by artist
        public List<Song> SearchSongByArtist(string artistName)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                int artistID = db.Artists.Where(s => s.ArtistName == artistName).FirstOrDefault().ArtistID;
                return db.Songs.Where(s => s.ArtistID == artistID).ToList();
            }
        }


        //Search albums by artist
        public List<Album> SearchAlbumByArtist(string artistName)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                int artistID = db.Artists.Where(s => s.ArtistName == artistName).FirstOrDefault().ArtistID;
                return db.Albums.Where(s => s.ArtistID == artistID).ToList();
            }
        
        }


        // Create a playlist with a specific duration
        public List<Song> CreatePlayList(int duration)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                int listLength = 0;
                int idMax = -1;
                int idMin = -1;
                List<Song> songs = new List<Song>();
                try
                {
                    //get the last song in the db.
                    var lastSong = db.Songs.ToList().LastOrDefault();
                    var firstSong = db.Songs.ToList().FirstOrDefault();
                    if (lastSong != null && firstSong != null)
                    {
                        idMax = lastSong.SongID;
                        idMin = firstSong.SongID;
                    }
                    else
                    {
                        throw new Exception("There is no song!");
                    }
                    //Create random object for random song id.
                    Random random = new Random();
                
                
                    //Flag to stop adding song to the playlist.
                    bool addSong = true;
                    int nextID;

                    while (addSong)
                    {
                        //Get a random song id within the max song id nubmer in the db.
                        if (idMax == -1)
                        {
                            throw new Exception("There is no song!");
                        }
                        else
                        {
                            nextID = random.Next(idMin, idMax + 1);
                            Song song = new Song();
                            song = db.Songs.Where(s => s.SongID == nextID).FirstOrDefault();

                            string albumTitle = "";
                            string artistName = "";
                            string genreName = ""; 

                            //Get albumTitle, artistName, genreName using song's AlbumID, ArtistID, GenreID
                            albumTitle = db.Albums.Where(s => s.AlbumID == song.AlbumID).FirstOrDefault().AlbumTitle;
                            song.Album.AlbumTitle = albumTitle;
                            artistName = db.Artists.Where(s => s.ArtistID == song.ArtistID).FirstOrDefault().ArtistName;
                            song.Artist.ArtistName = artistName; 
                            genreName = db.Genres.Where(s => s.GenreID == song.GenreID).FirstOrDefault().GenreName;
                            song.Genre.GenreName = genreName;
                            
                            //add the song to song length
                            listLength += song.SongTrackLength;
                   

                            // Condition to add the last song
                            if (Math.Abs(duration - listLength) == 1 || duration - listLength == 0) 
                            {
                                songs.Add(song);
                                addSong = false;
                            }
                            else if (listLength - duration > 1)
                            {
                                // If the listLength is longer than duration the take the current songTrackLength off listLength
                                listLength -= song.SongTrackLength;
                            }
                            else
                            { 
                                //Add song
                                songs.Add(song);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return songs;
            }
        }

    }
}
