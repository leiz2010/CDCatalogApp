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
    public partial class AddAlbumForm : Form
    {
        public AddAlbumForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string albumTitle = titleTextBox.Text.Trim();
            int year;
            int.TryParse(albumYearTextBox.Text, out year);
            string artistName = ArtistTextBox.Text.Trim();
            int albumRating = 0;
            if (albumRatingRadioButton1.Checked)
            {
                albumRating = 1;
            }
            else if (albumRatingRadioButton2.Checked)
            {
                albumRating = 2;
            }
            else if (albumRatingRadioButton3.Checked)
            {
                albumRating = 3;
            }
            else if (albumRatingRadioButton4.Checked)
            {
                albumRating = 4;
            }
            else if (albumRatingRadioButton5.Checked)
            {
                albumRating = 5;
            }
            else
            {
                albumRating = -1;
            }

            //Add album
            Album album = new Album();
            album.AddAlbum(year, artistName, albumTitle, albumRating);
            
            //Display the AddSongForm to add song to the album
            AddSongForm addSongForm = new AddSongForm();

            while (addSongForm.CancelClicked == false)
            {
                addSongForm.AlbumTextBox.Text = albumTitle;
                addSongForm.AlbumTextBox.ReadOnly = true;
                addSongForm.ShowDialog();
                //Close the form
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
