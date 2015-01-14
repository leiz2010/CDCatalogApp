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
using System.Data.Entity;

namespace CDCatalogWinFormsApp
{
    public partial class MainForm : Form
    {
        //variable for which search buttons is clicked

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load data to the datagridviews
            LoadData();
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            AddSongForm addSongForm = new AddSongForm();
            addSongForm.ShowDialog();
            // Load data after new song is added
            LoadData();
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            AddAlbumForm addAlbumForm = new AddAlbumForm();
            addAlbumForm.ShowDialog();
            // Load data after new album is added
            LoadData();
        }

        private void searchTitleButton_Click(object sender, EventArgs e)
        {
            
            SearchForm SearchForm = new SearchForm("Title");
            SearchForm.ShowDialog();
        }

        private void searchGenreButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm("Genre");
            searchForm.ShowDialog();
        }

        private void searchArtistButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm("Artist");
            searchForm.ShowDialog();
        }

        private void playListButton_Click(object sender, EventArgs e)
        {
            PlayListForm playListFrom = new PlayListForm();
            playListFrom.ShowDialog();
        }


        private void rateAlbumSongButton_Click(object sender, EventArgs e)
        {
            RateForm rateForm = new RateForm();
            rateForm.ShowDialog();
        }



        //Display songs for the currently selected album
        private void albumDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string albumTitle = albumDataGridView.CurrentRow.Cells[0].Value.ToString();
            using (CDCatalogEntities context = new CDCatalogEntities())
            {

                var songs = from s in context.Songs
                            where s.Album.AlbumTitle == albumTitle
                            orderby s.SongTrackNumber
                            select new
                            {
                                s.SongTitle,
                                s.Artist.ArtistName,
                                s.Genre.GenreName,
                                s.SongRating,
                                s.Album.AlbumTitle,
                                s.SongTrackNumber,
                                s.SongTrackLength
                            };

                songDataGridView.DataSource = songs.ToList();
            }
        }


        //Exit the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //helper function for loading data to the DataGridViews
        public void LoadData()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {

                var albums = from a in context.Albums
                             orderby a.AlbumTitle ascending
                             select new
                             {
                                 a.AlbumTitle,
                                 a.Artist.ArtistName,
                                 a.AlbumYear,
                                 a.AlbumRating
                             };



                var songs = from s in context.Songs
                            orderby s.SongTrackNumber ascending
                            select new
                            {
                                s.SongTitle,
                                s.Artist.ArtistName,
                                s.Genre.GenreName,
                                s.SongRating,
                                s.Album.AlbumTitle,
                                s.SongTrackNumber,
                                s.SongTrackLength
                            };

                albumDataGridView.DataSource = albums.ToList();
                songDataGridView.DataSource = songs.ToList();
            }
        }

        private void allSongButton_Click(object sender, EventArgs e)
        {
            //Reload the dataGridViews with all songs and albums by rating
            using (CDCatalogEntities context = new CDCatalogEntities())
            {

                var albums = from a in context.Albums
                             orderby a.AlbumRating descending
                             select new
                             {
                                 a.AlbumTitle,
                                 a.Artist.ArtistName,
                                 a.AlbumYear,
                                 a.AlbumRating
                             };



                var songs = from s in context.Songs
                            orderby s.SongRating descending
                            select new
                            {
                                s.SongTitle,
                                s.Artist.ArtistName,
                                s.Genre.GenreName,
                                s.SongRating,
                                s.Album.AlbumTitle,
                                s.SongTrackNumber,
                                s.SongTrackLength
                            };

                albumDataGridView.DataSource = albums.ToList();
                songDataGridView.DataSource = songs.ToList();
            }
        }



    }
}
