using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skapiec_APP
{
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
        }


        #region Properties

        private string _title;
        private Image _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value.Distinct().ToString(); title_label.Text = value; }         
        }
        


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; history_picture.Image = value; }
        }



        #endregion

        private void title_label_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void title_label_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void title_label_MouseClick(object sender, MouseEventArgs e)
        {
            RunSearch runSearch = new RunSearch();
            runSearch.search_text = title_label.Text;
            SqliteDataAccess.SaveRun(runSearch);
            System.Windows.Forms.Application.Restart();
        }
    }
}
