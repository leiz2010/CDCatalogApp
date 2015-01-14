using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDCatalogDataAccess;

namespace CDCatalogWinFormsApp
{
    public partial class SearchForm : Form
    {
        string searchType = null;
        private string SearchType
        {
            get { return this.searchType;}
            set { this.searchType = value; }
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(string searchType)
        {
            InitializeComponent();
            SearchType = searchType;
            searchBarLabel.Text = "Please enter the " + searchType.ToString().ToLower() + " of the song your are looking for.";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            AlbumSong albumSong = new AlbumSong();
           
            try
            {
                if (searchType == "Title")
                {
                    List<string> albumTitles = new List<string>();
                    List<string> songTitles = new List<string>();
                    string title = null;
                    if (searchTextBox.Text.Trim() == "")
                    {
                        throw new Exception("Please enter a song title!");
                    }
                    else
                    { 
                        title = searchTextBox.Text.Trim();
                    }

                    List<AlbumSong> albumsSongs = albumSong.SearchAlbumSongTitle(title);
                    if (albumsSongs.Count > 0)
                    {
                        foreach (AlbumSong s in albumsSongs)
                        {
                            if (s.AlbumTitle.ToUpper().Contains(title.ToUpper()))
                            {
                                albumTitles.Add(s.AlbumTitle);
                            }
                            if (s.SongTitle.ToUpper().Contains(title.ToUpper()))
                            {
                                songTitles.Add(s.SongTitle);
                            }
                        }
                        AlbumListBox.DataSource = albumTitles.Distinct().ToList();
                        SongListBox.DataSource = songTitles;
                    }
                    else
                    {
                        throw new Exception("Could not find the title.");
                    }
                }
                if (searchType == "Genre")
                {
                    List<string> genreNameList = new List<string>();
                    List<int> genreIDList = new List<int>();
                    string genreName = null;
                    if (searchTextBox.Text.Trim() == "")
                    {
                        throw new Exception("Please enter the genre!");
                    }
                    else
                    {
                        genreName = searchTextBox.Text.Trim();
                    }

                    //Get a list of genres that is related to the search term
                    List<Genre>genres = albumSong.SearchAlbumSongGenre(genreName);
                    if (genres.Count > 0)
                    {
                        foreach (Genre s in genres)
                        {
                            if (s.GenreName.ToUpper().Contains(genreName.ToUpper()))
                            {
                                genreNameList.Add(s.GenreName);
                            }
                        }

                        //Display the results in the resultsListForm
                        ResultsListForm resultsForm = new ResultsListForm();
                        resultsForm.ResultsListBox.DataSource = genreNameList;
                        resultsForm.ShowDialog();

                        string gName = resultsForm.SelectedResult;
                        
                        //Change the label text
                        albumListLabel.Text = gName + " album";
                        songListLabel.Text = gName + " song";

                        //Get lists of songs and albums
                        List<Album> albums= albumSong.SearchAlbumByGenre(gName).ToList();
                        List<Song> songs = albumSong.SearchSongByGenre(gName).ToList();

                        //Get lists of song titles and album titles
                        List<string> albumTitles = new List<string>();
                        List<string> songTitles = new List<string>();

                        foreach (Album a in albums)
                        {
                            albumTitles.Add(a.AlbumTitle);
                        }

                        foreach (Song s in songs)
                        {
                            songTitles.Add(s.SongTitle);   
                        }

                        //Display the list in the ListBox
                        SongListBox.DataSource = songTitles.ToList();
                        AlbumListBox.DataSource = albumTitles.Distinct().ToList();
                    }
                    else
                    {
                        throw new Exception("Could not find the genre.");
                    }
                }
                if (searchType == "Artist")
                {
                    List<string> artistNameList = new List<string>();
                    string artistName = null;
                    if (searchTextBox.Text.Trim() == "")
                    {
                        throw new Exception("Please enter the artist's name!");
                    }
                    else
                    {
                        artistName = searchTextBox.Text.Trim();

                    }
                    //Get a list of artists that is related to the search term. 
                    List<Artist> artists = albumSong.SearchAlbumSongArtist(artistName);
                    if (artists.Count > 0)
                    {
                        foreach (Artist s in artists)
                        {
                            if (s.ArtistName.ToUpper().Contains(artistName.ToUpper()))
                            {
                                artistNameList.Add(s.ArtistName);
                            }
                        }

                        //Display the results in the resultsListForm
                        ResultsListForm resultsForm = new ResultsListForm();
                        resultsForm.ResultsListBox.DataSource = artistNameList;
                        resultsForm.ShowDialog();

                        //Change the label text
                        string aName = resultsForm.SelectedResult;
                        albumListLabel.Text = "Albums by " + aName;
                        songListLabel.Text = "Songs by " + aName;

                        //Get lists of songs and albums
                        List<Album> albums = albumSong.SearchAlbumByArtist(aName).ToList();
                        List<Song> songs = albumSong.SearchSongByArtist(aName).ToList();
                        
                        //Get a list of song titles and album titles
                        List<string> albumTitles = new List<string>();
                        List<string> songTitles = new List<string>();

                        foreach (Album a in albums)
                        {
                            albumTitles.Add(a.AlbumTitle);
                        }

                        foreach (Song s in songs)
                        {
                            songTitles.Add(s.SongTitle);
                        }

                        //Display the list in the ListBox
                        SongListBox.DataSource = songTitles.ToList();
                        AlbumListBox.DataSource = albumTitles.Distinct().ToList();
                    }
                    else
                    {
                        throw new Exception("Could not find the artist.");
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            //clear searh textbox
            searchTextBox.Text = "";
        }


        private void showAblumDetialButton_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            string albumTitle = AlbumListBox.SelectedItem.ToString();
            AlbumDetailForm albumDetailForm = new AlbumDetailForm(album.AlbumDetail(albumTitle));
            albumDetailForm.SongsOnAlbum(albumTitle);
            albumDetailForm.ShowDialog();
            

        }

        private void showSongDetailButton_Click(object sender, EventArgs e)
        {
            Song song = new Song();
            string songTitle = SongListBox.SelectedItem.ToString();
            SongDetialForm songDetailForm = new SongDetialForm(song.SongDetail(songTitle));
            songDetailForm.ShowDialog();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
