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

        string link_search;
        #region Properties

        private string _title;
        private string _price;
        private Image _icon;

        //-----------------
        private string _btn;

        [Category("Custom Props")]
        public string Button
        {
            get { return _btn; }
            set { _btn = value; link_search = value; }
        }

        //------------------

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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{link_search}");
            MessageBox.Show("COS DZIALA");
        }
    }
}
