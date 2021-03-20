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
            set { _title = value; title_label.Text = value; }         
        }
        


        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; history_picture.Image = value; }
        }



        #endregion

       
        private void HistoryItem_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void HistoryItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void HistoryItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
