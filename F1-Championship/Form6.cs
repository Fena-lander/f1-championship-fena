using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Championship
{
    public partial class Form6 : Form
    {
        private List<Championship> championshipNameSelect;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            carNumber.MaxLength = 10;
        }

        private void addPilot_Click(object sender, EventArgs e)
        {
            if (carNumber.Text == "")
            {
                MessageBox.Show("Número do carro deve ser preenchido");
                return;
            }

            string name = pilotName.Text;
            int pilotCarNumber = int.Parse(carNumber.Text);
            int points = 0;

            List<Pilot> allPilots = championshipNameSelect.SelectMany(championship => championship.Pilots).ToList();
            Pilot newPilot = new Pilot { Name = name, CarNumber = pilotCarNumber, Points = points };

            if (name == "")
            {
                MessageBox.Show("Nome do piloto deve ser preenchido");
                return;
            }
            else
            {
                foreach (var pilot in allPilots)
                {
                    if (pilot.CarNumber == pilotCarNumber)
                    {
                        MessageBox.Show("Esse número de carro já existe");
                        carNumber.Text = string.Empty;
                        return;
                    }
                }

                allPilots.Add(newPilot);
            }

            foreach (Championship championship in championshipNameSelect)
            {
                championship.Pilots = allPilots;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allPilots;

            string updatedJson = JsonConvert.SerializeObject(championshipNameSelect, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);

            pilotName.Text = string.Empty;
            carNumber.Text = string.Empty;
        }

        private void finishChampionship_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newChampionship = new Form5(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }

        private void clearPilotsParameter_Click(object sender, EventArgs e)
        {
            pilotName.Text = string.Empty;
            carNumber.Text = string.Empty;
        }
    }
}
