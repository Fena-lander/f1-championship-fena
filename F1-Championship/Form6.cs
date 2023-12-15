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
    public partial class Form6 : Form
    {
        private List<Championship> championshipNameSelect;

        public Form6(List<Championship> championshipNameSelect)
        {
            this.championshipNameSelect = championshipNameSelect;
            List<Pilot> allPilots = championshipNameSelect.SelectMany(championship => championship.Pilots).ToList();

            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allPilots;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void carNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void addPilot_Click(object sender, EventArgs e)
        {

        }

        private void finishChampionship_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newChampionship = new Form5(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }
    }
}
