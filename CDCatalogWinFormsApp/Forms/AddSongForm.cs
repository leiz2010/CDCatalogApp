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
    public partial class AddSongForm : Form
    {
        bool cancelClicked = false;
        bool addClicked = false;

        public TextBox AlbumTextBox
        {
            get { return this.albumTextBox;}
        }

        public bool CancelClicked
        {
            get { return this.cancelClicked; }
            private set { this.cancelClicked = value; }
        }

        public bool AddClicked
        {
            get { return this.addClicked; }
            private set { this.addClicked = value; }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelClicked = true;
            this.Close();
        }


        public AddSongForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string songTitle = null;
            string albumTitle = null;
            string artistName = null;
            string genreName = null;
            int trackNumber = 0;
            int trackLength = 0;
            

            try
            {
                //Get the song title
                
                if (titleTextBox.Text.Trim() == "")
                {
                    throw new Exception("Please enter a song title!");
                }
                else
                {
                    songTitle = titleTextBox.Text.Trim();
                }

                //Get the album title
                if (titleTextBox.Text.Trim() == "")
                {
                    throw new Exception("Please enter the album title!");
                }
                else
                {
                    albumTitle = AlbumTextBox.Text.Trim();
                }

                //Get the artist's name
                if (artistTextBox.Text.Trim() == "")
                {
                    throw new Exception("Please enter the artist's name!");
                }
                else
                {
                    artistName = artistTextBox.Text.Trim();
                }

                //Get the genre name
                if (genreTextBox.Text.Trim() == "")
                {
                    throw new Exception("Please enter the genre!");
                }
                else
                {
                    genreName = genreTextBox.Text.Trim();
                }

                //Get the track number from the form
                bool isNumber = int.TryParse(trackNumberTextBox.Text.Trim(), out trackNumber);
                if (!isNumber)
                {
                    throw new Exception("Please enter a number!");
                }

                //Get the track length from the form
                isNumber = int.TryParse(trackLengthTextBox.Text.Trim(), out trackLength);
                if (!isNumber)
                {
                    throw new Exception("Please enter a number!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Get the song rating
            int songRating;
            if (songRatingRadioButton1.Checked)
            {
                songRating = 1;
            }
            else if (songRatingRadioButton2.Checked)
            {
                songRating = 2;
            }
            else if (songRatingRadioButton3.Checked)
            {
                songRating = 3;
            }
            else if (songRatingRadioButton4.Checked)
            {
                songRating = 4;
            }
            else if (songRatingRadioButton5.Checked)
            {
                songRating = 5;
            }
            else
            {
                songRating = 0;
            }

            // Add song to DB only all values are valid
            if (songTitle != null && artistName != null && albumTitle != null && trackNumber != 0 && trackLength != 0 && genreName != null)
            {
                Song song = new Song();
                song.AddSong(songTitle, artistName, albumTitle, trackNumber, songRating, trackLength, genreName);

                // Clear the form
                titleTextBox.Text = "";
                AlbumTextBox.Text = "";
                artistTextBox.Text = "";
                genreTextBox.Text = "";
                trackNumberTextBox.Text = "";
                trackLengthTextBox.Text = "";
                songRatingRadioButton1.Checked = false;
                songRatingRadioButton2.Checked = false;
                songRatingRadioButton3.Checked = false;
                songRatingRadioButton4.Checked = false;
                songRatingRadioButton5.Checked = false;

                // Close the form
                this.Close();
            }
            else
            {
                // Clear the form
                titleTextBox.Text = "";
                AlbumTextBox.Text = "";
                artistTextBox.Text = "";
                genreTextBox.Text = "";
                trackNumberTextBox.Text = "";
                trackLengthTextBox.Text = "";
                songRatingRadioButton1.Checked = false;
                songRatingRadioButton2.Checked = false;
                songRatingRadioButton3.Checked = false;
                songRatingRadioButton4.Checked = false;
                songRatingRadioButton5.Checked = false;
            }
        }

    }
}
