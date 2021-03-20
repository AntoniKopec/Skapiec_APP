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
        private string _title2;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; title_label.Text = value; }         
        }
        [Category("Custom Props")]
        public string Title2
        {
            get { return _title2; }
            set { _title2 = value; title_btn_hist.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; history_picture.Image = value; }
        }



        #endregion

        private void title_btn_hist_Click(object sender, EventArgs e)
        {
            History history = new History();
            Home home = new Home();
            home.Show();
           
        }
    }
}
