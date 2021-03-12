using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skapiec_APP
{
    public partial class History : Form
    {
        List<PeroductsModel> products = new List<PeroductsModel>();
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void history_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
