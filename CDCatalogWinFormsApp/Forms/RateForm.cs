using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalogWinFormsApp
{
    public partial class RateForm : Form
    {
        string searchType;

        public string SearchType
        {
            get { return this.searchType; }
            set { this.searchType = value; }
        }


        public RateForm()
        {
            InitializeComponent();
        }

        private void rateAlbumButton_Click(object sender, EventArgs e)
        {
            searchType = "Album";
            RateAlbumSongForm rateAlbumForm = new RateAlbumSongForm(searchType);
            rateAlbumForm.ShowDialog();
            this.Close();
        }

        private void rateSongButton_Click(object sender, EventArgs e)
        {
            searchType = "Song";
            RateAlbumSongForm rateSongForm = new RateAlbumSongForm(searchType);
            rateSongForm.ShowDialog();
            this.Close();
        }
    }
}
