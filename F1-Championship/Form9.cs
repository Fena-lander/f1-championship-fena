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
    public partial class Form9 : Form
    {
        private List<Championship> championshipNameSelect;
        private Label championshipLabel;


        public Form9(List<Championship> championshipNameSelect)
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
                foreach (Pilot pilot in champ.Pilots)
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
            listView1.Columns.Add("Posição", 50);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newChampionship = new Form4();
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newChampionship = new Form2();
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();

        }
    }
}
