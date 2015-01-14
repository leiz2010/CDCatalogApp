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
    public partial class AlbumDetailForm : Form
    {
        public AlbumDetailForm()
        {
            InitializeComponent();
        }

        public AlbumDetailForm(string albumDetial)
        {
            InitializeComponent();
            albumDetialLabel.Text = albumDetial; 
        }

        public void SongsOnAlbum(string albumTitle)
        {
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
