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
    public partial class PlayListForm : Form
    {
        public PlayListForm()
        {
            InitializeComponent();
        }

        private void durationButton_Click(object sender, EventArgs e)
        {
            //Get the input for playlist length
            try
            {
                int listLength;
                int.TryParse(lengthTextBox.Text.Trim(), out listLength);
                if (listLength <= 0)
                {
                    lengthTextBox.Text = "";
                    throw new Exception("Please enter a number bigger than 0!");
                }
                else
                {
                    lengthTextBox.Text = "";
                    //Generate a playlist
                    AlbumSong o = new AlbumSong();
                    List<Song> playList =  o.CreatePlayList(listLength);

                    var songs = (from s in playList.ToList()
                                 select new
                                 {
                                     s.SongTitle,
                                     s.Album.AlbumTitle,
                                     s.Artist.ArtistName,
                                     s.Genre.GenreName,
                                     s.SongRating,
                                     s.SongTrackLength
                                 });


                    //Display the list in dataGridView
                    playListDataGridView.DataSource = songs.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
