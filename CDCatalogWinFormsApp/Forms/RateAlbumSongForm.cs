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
    public partial class RateAlbumSongForm : Form
    {
        string searchType;
        string itemToRate;


        private string SearchType
        {
            get { return this.searchType; }
            set { this.searchType = value; }
        }

        private string ItemToRate
        {
            get { return this.itemToRate; }
            set { this.itemToRate = value; }
        }

        public RateAlbumSongForm()
        {
            InitializeComponent();
        }

        public RateAlbumSongForm(string searchType)
        {
            InitializeComponent();
            SearchType = searchType;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Search album
                if (searchType.ToLower() == "album")
                {
                    string albumName = searchTextBox.Text.Trim();
                    searchTextBox.Text = "";
                    AlbumSong albumSong = new AlbumSong();
                    List<AlbumSong> searchResults = new List<AlbumSong>();
                    List<string> albumNameList = new List<string>();

                    searchResults = albumSong.SearchAlbumSongTitle(albumName).ToList();
                    foreach (AlbumSong s in searchResults)
                    {
                        if (s.AlbumTitle.ToUpper().Contains(albumName.ToUpper()))
                        {
                            albumNameList.Add(s.AlbumTitle);
                            albumNameList = albumNameList.Distinct().ToList();
                        }
                    }
                    if (albumNameList.Count != 0)
                    {
                        resultListBox.DataSource = albumNameList;
                    }
                    else
                    {
                        throw new Exception("Could not find the album " + albumName + " !");
                    }
                }

                //Search song
                if (searchType.ToLower() == "song")
                {
                    string songName = searchTextBox.Text.Trim();
                    searchTextBox.Text = "";
                    AlbumSong albumSong = new AlbumSong();
                    List<AlbumSong> searchResults = new List<AlbumSong>();
                    List<string> songNameList = new List<string>();

                    searchResults = albumSong.SearchAlbumSongTitle(songName).ToList();
                    foreach (AlbumSong s in searchResults)
                    {
                        if (s.SongTitle.ToUpper().Contains(songName.ToUpper()))
                        {
                            songNameList.Add(s.SongTitle);
                        }
                    }
                    if (songNameList.Count != 0)
                    {
                        resultListBox.DataSource = songNameList;
                    }
                    else
                    {
                        throw new Exception("Could not find the song " + songName + " !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Display RateItemForm for the selected item to be rated
        private void rateButton_Click(object sender, EventArgs e)
        {
            string title = resultListBox.SelectedItem.ToString();
            ItemToRate = title;
            this.Close();
            RateItemForm rateItemForm = new RateItemForm(ItemToRate, SearchType);
            rateItemForm.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
