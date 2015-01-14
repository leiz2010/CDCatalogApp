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
    public partial class SongDetialForm : Form
    {
        string songDetial;
        Song song;

        private string SongDetial
        {
            get {return this.songDetial;}
            set { this.songDetial = value; }
        }

        private Song Song
        {
            get { return this.song; }
            set { this.song = value; }
        }
        public SongDetialForm()
        {
            InitializeComponent();
        }

        public SongDetialForm(string songDetail)
        {
            InitializeComponent();
            songDetailLabel.Text = songDetail;
        }

    }
}
