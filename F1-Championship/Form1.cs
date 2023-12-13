using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Championship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChampionshipName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void namePilotText_TextChanged(object sender, EventArgs e)
        {

        }

        private void newChampionship_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newChampionship = new Form2();
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }
    }
}
