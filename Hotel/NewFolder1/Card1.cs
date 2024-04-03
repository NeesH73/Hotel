using System;
using System.Windows.Forms;

namespace Hotel.NewFolder1
{
    public partial class Card1 : Form
    {
        public Card1()
        {
            InitializeComponent();
        }

        private void btnnazad_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
            this.Hide();
        }
    }
}
