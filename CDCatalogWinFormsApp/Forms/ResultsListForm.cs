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
    public partial class ResultsListForm : Form
    {
        string selectedResult;
        public string SelectedResult
        {
            get { return this.selectedResult; }
            set { this.selectedResult = value; }
        }

        public ListBox ResultsListBox
        {
            get { return this.resultsListBox; }
            set { this.resultsListBox = value; }
        }

        public ResultsListForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedResult = resultsListBox.SelectedItem.ToString();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
