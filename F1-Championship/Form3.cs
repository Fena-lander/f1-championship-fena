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
using Newtonsoft.Json;

namespace F1_Championship
{
    public partial class Form3 : Form
    {
        private List<Championship> championshipList;
        public Championship lastChampionship;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

        public Form3()
        {
            InitializeComponent();
            string json = File.ReadAllText(filePath);
            championshipList = JsonConvert.DeserializeObject<List<Championship>>(json);
            lastChampionship = championshipList.Last();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pilotName.Text = string.Empty;
            carNumber.Text = string.Empty;
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 backMenu = new Form1();
            backMenu.FormClosed += (s, args) => this.Close();
            backMenu.Show();
        }

        private void addPilot_Click(object sender, EventArgs e)
        {
            string name = pilotName.Text;
            int pilotCarNumber = int.Parse(carNumber.Text);

            foreach(var pilot in lastChampionship.Pilots)
            {
                if(pilot.CarNumber == pilotCarNumber)
                {
                    MessageBox.Show("Esse número de carro já existe");
                    pilotName.Text = string.Empty;
                    carNumber.Text = string.Empty;
                    return;
                }
            }

            lastChampionship.Pilots.Add(new Pilot { Name = name, CarNumber = pilotCarNumber });

            string updatedJson = JsonConvert.SerializeObject(championshipList, Formatting.Indented);

            File.WriteAllText(filePath, updatedJson);
            pilotName.Text = string.Empty;
            carNumber.Text = string.Empty;
        }

        private void finishChampionship_Click(object sender, EventArgs e)
        {

        }

        private void carNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void carNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            carNumber.MaxLength = 10;
        }
    }
}
