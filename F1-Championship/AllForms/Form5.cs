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
    public partial class Form5 : Form
    {
        private List<Championship> championshipNameSelect;
        private Label championshipLabel;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

        public Form5(List<Championship> championshipNameSelect)
        {
            this.championshipNameSelect = championshipNameSelect;

            InitializeComponent();

            championshipLabel = new Label();
            championshipLabel.Text = championshipNameSelect.FirstOrDefault()?.ChampionshipName;
            championshipLabel.Location = new Point(10, 10);
            championshipLabel.Font = new Font("Arial", 20, FontStyle.Bold);
            championshipLabel.AutoSize = true;
            this.Controls.Add(championshipLabel);

            OrderPilotsByPoints();

            GenerateGrade();
            ReadChampionships();
        }

        private void OrderPilotsByPoints()
        {
            foreach (Championship champ in championshipNameSelect)
            {
                champ.Pilots = champ.Pilots.OrderByDescending(p => p.Points).ToList();
            }
        }

        private void ReadChampionships()
        {
            string[] item = new string[4];
            var position = 1;
            foreach (Championship champ in championshipNameSelect)
            {
                foreach(Pilot pilot in champ.Pilots)
                {
                    item[0] = position.ToString();
                    item[1] = pilot.CarNumber.ToString();
                    item[2] = pilot.Name.ToString();
                    item[3] = pilot.Points.ToString();

                    listView1.Items.Add(new ListViewItem(item));
                    position++;
                }

            }

        }

        private void GenerateGrade()
        {
            listView1.Columns.Add("Posição",50);
            listView1.Columns.Add("Carro", 50);
            listView1.Columns.Add("Piloto", 140);
            listView1.Columns.Add("Pontos", 60);
            listView1.View = View.Details;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void championshipTitle_Click(object sender, EventArgs e)
        {

        }

        private void backListChampionship_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newChampionship = new Form4();
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();

        }

        private void addPilot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 newChampionship = new Form6(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }

        private void deletePilotOnChampionship_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    string pilotNameToDelete = item.SubItems[1].Text;

                    Championship championshipContainingPilot = championshipNameSelect.FirstOrDefault();
                    Pilot pilotToRemove = championshipContainingPilot.Pilots.FirstOrDefault(pilot => pilot.Name == pilotNameToDelete);

                    championshipContainingPilot.Pilots.Remove(pilotToRemove);

                    listView1.Items.Remove(item);

                    string json = JsonConvert.SerializeObject(championshipNameSelect, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                }
            }
        }

        private void editPilot_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    string pilotNameToEdit = item.SubItems[1].Text;

                    Championship championshipContainingPilot = championshipNameSelect.FirstOrDefault();
                    Pilot pilotToEdit = championshipContainingPilot.Pilots.FirstOrDefault(pilot => pilot.Name == pilotNameToEdit);

                    this.Hide();
                    Form7 newChampionship = new Form7(championshipNameSelect, pilotToEdit);
                    newChampionship.FormClosed += (s, args) => this.Close();
                    newChampionship.Show();
                }
            }
        }

        private void createRace_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 newChampionship = new Form8(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }
    }
}
