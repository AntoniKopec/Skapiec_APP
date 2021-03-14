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
    public partial class HomeItem : UserControl
    {
        public HomeItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _price;
        private Image _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; home_title_label.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; price_label.Text = value; }
        }


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; home_picture.Image = value; }
        }


        #endregion
    }
}
