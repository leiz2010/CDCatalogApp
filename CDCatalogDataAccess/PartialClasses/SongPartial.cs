using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalogDataAccess
{
    public partial class Song
    {
        // Add song to the db
        public void AddSong(string title, string artistName, string albumTitle, int trackNumber, int songRating, int trackLength, string genreName)
        {
            Artist artist;
            int artistID;
            Album album;
            int albumID;
            Genre genre;
            int genreID;

            Song song = new Song();

            try
            {
                
                //song.SongTrackNumber = trackNumber;
                song.SongTrackLength = trackLength;
                song.SongRating = songRating;

                using (CDCatalogEntities db = new CDCatalogEntities())
                {
                    Song songInDB = new Song();
                    //Search the db for the song title, if exists then throw an exception
                    songInDB = db.Songs.Where(s => s.SongTitle.ToUpper() == title.ToUpper().Trim()).FirstOrDefault();
                    if (songInDB != null)
                    {
                        throw new Exception("This song is already in the collection!");
                    }
                    else
                    {
                        song.SongTitle = title;
                    }

                    //Search the DB for the artist name, if exists then set artist ID to this song, else add a new artist
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

                    //Search the DB for the ablum name, if exists then set album ID to this song, else add a new album
                    Album resultAlbum = db.Albums.Where(s => s.AlbumTitle == albumTitle).FirstOrDefault();
                    if (resultAlbum != null)
                    {
                        albumID = resultAlbum.AlbumID;
                    }
                    else
                    {
                        //Add a new album
                        album = new Album
                        {
                            ArtistID = artistID,
                            AlbumTitle = albumTitle,
                        };
                        db.Albums.Add(album);
                        db.SaveChanges();
                        albumID = album.AlbumID;
                    }

                    //Search the DB for the genre name, if exists then set genre to this song, else add a new genre
                    Genre resultGenre = db.Genres.Where(s => s.GenreName == genreName).FirstOrDefault();
                    if (resultGenre != null)
                    {
                        genreID = resultGenre.GenreID;
                    }
                    else
                    { 
                        //Add a new genre
                        genre = new Genre
                        {
                            GenreName = genreName
                        };
                        db.Genres.Add(genre);
                        db.SaveChanges();
                        genreID = genre.GenreID;
                    }

                    //Search the DB for the track number, if exists then display an error messag, else add a new track
                    //Get the album and find out which track numbers are used already
                    List<Song> songs = db.Songs.Where(s => s.AlbumID == albumID).ToList();
                    if (songs != null)
                    {
                        bool trackExist = false;
                        //Get the track numbers which are already on this album. 
                        foreach (Song s in songs)
                        {
                            if (s.SongTrackNumber == trackNumber)
                            {
                                trackExist = true;
                            }
                        }

                        if (trackExist == false)
                        {
                            song.SongTrackNumber = trackNumber;
                        }
                        else
                        {
                            //Display an error message.
                            throw new Exception("This track number already exists on this album!"); 
                        }
                    }
                    song.AlbumID = albumID;
                    song.ArtistID = artistID;
                    song.GenreID = genreID;

                    db.Songs.Add(song);
                    int resultCount = db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Song SearchSongTitle(string title)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                Song song = new Song();
                //search db for this title
                song = db.Songs.Where(s => s.SongTitle.ToUpper() == title.Trim().ToUpper()).FirstOrDefault();
                return song;
            }
        }

        public void SetSongRating(string title, int rating)
        {
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                Song song = new Song();
                //search db for this title
                song = db.Songs.Where(s => s.SongTitle.ToUpper() == title.Trim().ToUpper()).FirstOrDefault();

                //assign new rating value
                song.SongRating = rating;
                db.SaveChanges();
            }
        }

        public string SongDetail(string title)
        {
            string songDetial;
            Song song = new Song();
            song = song.SearchSongTitle(title);
            using (CDCatalogEntities db = new CDCatalogEntities())
            {
                //get artist name
                Artist artist = new Artist();
                artist = db.Artists.Where(s => s.ArtistID == song.ArtistID).FirstOrDefault();
               
                string artistName = artist.ArtistName;
                //get album title
                Album album = new Album();
                album = db.Albums.Where(s => s.AlbumID == song.AlbumID).FirstOrDefault();
                
                //get genre name
                Genre genre = new Genre();
                genre = db.Genres.Where(s => s.GenreID == song.GenreID).FirstOrDefault();

                songDetial = String.Format("Song Title: {0} \n\nArtist name: {1} \n\nAlbum title: {2} \n\nGenre: {3} \n\nTrack number: {4} \n\nTrack length: {5}",
                                     song.SongTitle, artist.ArtistName, album.AlbumTitle, genre.GenreName, song.SongTrackNumber, song.SongTrackLength);
                return songDetial;
            }
        }

    }
}
