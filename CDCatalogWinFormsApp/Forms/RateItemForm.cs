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
    public partial class RateItemForm : Form
    {

        string title;
        string searchType;
        Song song;
        Album album;


        private string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        private string SearchType
        {
            get { return this.searchType; }
            set { this.searchType = value; }
        }

        public RateItemForm()
        {
            InitializeComponent();
        }

        // get user input on the form
        public RateItemForm(string title, string searchType)
        {
            InitializeComponent();
            Title = title;
            SearchType = searchType;
            ratingLabel.Text = "Give a rating to " + " " + searchType + " " + Title;
            if (searchType == "Song")
            {
                song = new Song();
                song = song.SearchSongTitle(title);
            }
            if (searchType == "Album")
            {
                album = new Album();
                album = album.SearchAlbumTitle(title);
            }
        }

        // get rating value then assign new rating value
        private void okButton_Click(object sender, EventArgs e)
        {
            int rating = 0;
            //get rating value
            if (ratingRadioButtonOne.Checked)
            {
                rating = 1; 
            }
            if (ratingRadioButtonTwo.Checked)
            {
                rating = 2;
            }
            if (ratingRadioButtonThree.Checked)
            {
                rating = 3;
            }
            if (ratingRadioButtonFour.Checked)
            {
                rating = 4;
            }
            if (ratingRadioButtonFive.Checked)
            {
                rating = 5;
            }

            //set rating
            if (searchType == "Album")
            {
                album.SetAlbumRating(album.AlbumTitle, rating);

            }
            if (searchType == "Song")
            {
                song.SetSongRating(song.SongTitle, rating);
            }

            //reload mainform's datagridview to reflect the change in rating
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            mainForm.LoadData();

            this.Close();
        }




        
    }
}
