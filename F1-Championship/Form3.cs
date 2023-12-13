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
        private Championship championship;

        public Form3()
        {
            InitializeComponent();
            championship = new Championship();
            championship.Pilots = new List<Pilot>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            string filePath = @"C:\Users\fe-ga\source\Championships.json";

            try
            {
                string name = pilotName.Text;
                int pilotCarNumber = int.Parse(carNumber.Text);

                // Le o arquivo inteiro então disserializa ele
                string existingCarNumber = File.ReadAllText(filePath);
                dynamic jsonData = JsonConvert.DeserializeObject(existingCarNumber);

                if (jsonData.Pilots != null)
                {
                    foreach (var pilot in jsonData.Pilots)
                    {
                        if (pilot.CarNumber == pilotCarNumber)
                        {
                            MessageBox.Show("Esse número de carro já existe");
                            pilotName.Text = string.Empty;
                            carNumber.Text = string.Empty;
                            return;
                        }
                    }
                }

                if (championship.Pilots != null)
                {
                    championship.Pilots = new List<Pilot>();
                }

                championship.Pilots.Add(new Pilot { Name = name, CarNumber = pilotCarNumber });

                pilotName.Text = string.Empty;
                carNumber.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);

                Championship existingChampionship = JsonConvert.DeserializeObject<Championship>(existingJson);

                existingChampionship.Pilots.AddRange(championship.Pilots);

                string updatedJson = existingChampionship.JsonSerialize(existingChampionship);
                File.WriteAllText(filePath, updatedJson);
            }
        }

        private void finishChampionship_Click(object sender, EventArgs e)
        {

        }
    }
}
