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
    public partial class Form2 : Form
    {
        private List<Championship> championshipList;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");


        public Form2()
        {
            InitializeComponent();
            championshipList = new List<Championship>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                championshipList = JsonConvert.DeserializeObject<List<Championship>>(json);
            }
        }

        private void startChampionship_Click(object sender, EventArgs e)
        {
            var championship = new Championship();
            championship.ChampionshipName = championshipName.Text;

            bool campeonatoExistente = championshipList.Any(c => c.ChampionshipName == championship.ChampionshipName);

            if (campeonatoExistente)
            {
                MessageBox.Show("Já existe um campeonato com o mesmo nome. Escolha um nome diferente.");
                return;
            }
            else
            {
                try
                {
                    championshipList.Add(championship);

                    string json = JsonConvert.SerializeObject(championshipList, Formatting.Indented);

                    File.WriteAllText(filePath, json);
                }
                catch
                {

                }
            }

            this.Hide();
            Form3 startChampionship = new Form3();
            startChampionship.FormClosed += (s, args) => this.Close();
            startChampionship.Show();
        }

        private void cancelStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 backMenu = new Form1();
            backMenu.FormClosed += (s, args) => this.Close();
            backMenu.Show();
        }
    }
}
