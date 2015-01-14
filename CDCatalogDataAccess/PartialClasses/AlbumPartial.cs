using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalogDataAccess
{
    public partial class Album
    {
        // Add a new album
        public void AddAlbum(int albumYear, string artistName, string title, int rating)
        {
            Artist artist;
            int artistID;
            Album album;

            try
            {
                //If the the title is empty then throw an exception, else instanicate a new album object
                if (title == "")
                {
                    throw new Exception("Please enter the album title!");
                }
                else
                {
                    album = new Album();
                }

                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    //If the album title already exist then throw an exception
                    Album albumInDB = new Album();
                    //Search the db for the song title, if exists then throw an exception
                    albumInDB = db.Albums.Where(s => s.AlbumTitle.ToUpper() == title.ToUpper().Trim()).FirstOrDefault();
                    if (albumInDB != null)
                    {
                        throw new Exception("This album is already in the collection!");
                    }
                    else
                    {
                        album.AlbumTitle = title;
                    }


                    //If the artist already exist then get the artist ID, else add a new artist
                    Artist resultArtist = db.Artists.Where(s => s.ArtistName == artistName).FirstOrDefault();
                    if (resultArtist != null)
                    {
                        artistID = resultArtist.ArtistID;
                    }
                    else
                    {
                        artist = new Artist
                        {
                            ArtistName = artistName
                        };
                        db.Artists.Add(artist);
                        db.SaveChanges();
                        artistID = artist.ArtistID;
                    }


                    //Search the DB for the ablum name, if exists then update the info than throw an exception, else add a new album
                    Album resultAlbum = db.Albums.Where(s => s.AlbumTitle == title).FirstOrDefault();
                    if (resultAlbum != null)
                    {
                        resultAlbum.ArtistID = artistID;
                        resultAlbum.AlbumYear = albumYear;
                        resultAlbum.AlbumRating = rating;
                        db.SaveChanges();
                        throw new Exception("This album already exists!");
                    }
                    else
                    {
                        album.AlbumTitle = title;
                        album.ArtistID = artistID;
                        album.AlbumYear = albumYear;
                        album.AlbumRating = rating;
                        db.Albums.Add(album);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                //Display the custom message. 
                MessageBox.Show(ex.Message);
            }
        }

        public Album SearchAlbumTitle(string title)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                 Album album = new Album();
                 //search db for this title
                 album = db.Albums.Where(s => s.AlbumTitle.ToUpper() == title.Trim().ToUpper()).FirstOrDefault();
                 return album;
            }
        }

        public void SetAlbumRating(string title, int rating)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                Album album = new Album();
                //search db for this title
                album = db.Albums.Where(s => s.AlbumTitle.ToUpper() == title.Trim().ToUpper()).FirstOrDefault();
                
                //assign new rating value
                album.AlbumRating = rating;
                db.SaveChanges();
            }
        }

        public string AlbumDetail(string title)
        {
            string albumDetial;
            Album album = new Album();
            album = album.SearchAlbumTitle(title);
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
               
                //get artist name
                Artist artist = new Artist();
                artist = db.Artists.Where(s => s.ArtistID ==album.ArtistID).FirstOrDefault();

                albumDetial = String.Format("Album Title: {0} \t\tArtist name: {1} \t\tYear: {2} \t\tRating: {3}",
                                     album.AlbumTitle, artist.ArtistName, album.AlbumYear, album.AlbumRating);
                return albumDetial;
            }
        }
    }
}
