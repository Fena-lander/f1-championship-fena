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
using System.Xml.Linq;

namespace F1_Championship
{
    public partial class Form7 : Form
    {
        private List<Championship> championshipNameSelect;

        private Pilot pilotSelect;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

        public Form7(List<Championship> championshipNameSelect, Pilot pilotSelect)
        {
            this.championshipNameSelect = championshipNameSelect;
            this.pilotSelect = pilotSelect;


            InitializeComponent();

            DisplayPilotInfot();

            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            List<Pilot> selectedPilot = new List<Pilot> { pilotSelect };

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = selectedPilot;
        }


        private void DisplayPilotInfot()
        {
            pilotNameEdit.Text = pilotSelect.Name;
            carNumberEdit.Text = pilotSelect.CarNumber.ToString();
            pointsEdit.Text = pilotSelect.Points.ToString();
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
            carNumberEdit.MaxLength = 10;
        }

        private void addPilot_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearPilotsParameter_Click(object sender, EventArgs e)
        {

        }

        private void backToChampionship_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newChampionship = new Form5(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }

        private void saveEditPilot_Click(object sender, EventArgs e)
        {
            List<Pilot> allPilots = championshipNameSelect.SelectMany(championship => championship.Pilots).ToList();

            if (carNumberEdit.Text == "")
            {
                MessageBox.Show("Número do carro deve ser preenchido");
                carNumberEdit.Text = pilotSelect.CarNumber.ToString();
                return;
            }
            if(pointsEdit.Text == "")
            {
                MessageBox.Show("Número do carro deve ser preenchido");
                pointsEdit.Text = pilotSelect.Points.ToString();
                return;
            }
            if (pilotNameEdit.Text == "")
            {
                MessageBox.Show("Nome do piloto deve ser preenchido");
                pilotNameEdit.Text = pilotSelect.Name;
                return;
            }
            else
            {
                foreach (var pilot in allPilots)
                {
                    if (pilot.CarNumber == int.Parse(carNumberEdit.Text))
                    {
                        if(pilotSelect.CarNumber == int.Parse(carNumberEdit.Text))
                        {
                            pilotSelect.Name = pilotNameEdit.Text;
                            pilotSelect.CarNumber = int.Parse(carNumberEdit.Text);
                            pilotSelect.Points = int.Parse(pointsEdit.Text);

                            string updatedJson = JsonConvert.SerializeObject(championshipNameSelect, Formatting.Indented);
                            File.WriteAllText(filePath, updatedJson);
                            LoadDataGridView();
                            return;
                        }
                        MessageBox.Show("Esse número de carro já existe");
                        carNumberEdit.Text = string.Empty;
                        return;
                    }
                }

                pilotSelect.Name = pilotNameEdit.Text;
                pilotSelect.CarNumber = int.Parse(carNumberEdit.Text);
                pilotSelect.Points = int.Parse(pointsEdit.Text);

                string updateJson = JsonConvert.SerializeObject(championshipNameSelect, Formatting.Indented);
                File.WriteAllText(filePath, updateJson);
                LoadDataGridView();
                return;
            }
        }
    }
}
