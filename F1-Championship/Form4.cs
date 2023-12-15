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
    public partial class Form4 : Form
    {
        private List<Championship> championshipList;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

        public Form4()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                ReadChampionships();
            }

            GenerateGrade();
        }

        private void ReadChampionships() 
        {
            string json = File.ReadAllText(filePath);
            championshipList = JsonConvert.DeserializeObject<List<Championship>>(json);

            // Mudar string para [3] quando adicionar as corridas dos campeonatos e tirar commit do GenerateGrade()
            string[] item = new string[2];
            foreach(Championship champ in championshipList)
            {
                item[0] = champ.ChampionshipName;
                item[1] = champ.Pilots.Count.ToString();

                listView1.Items.Add(new ListViewItem(item));
            }

        }

        private void GenerateGrade()
        {
            listView1.Columns.Add("Campeonato", 200);
            listView1.Columns.Add("Pilotos", 50);
            listView1.Columns.Add("Corridas", 50);
            listView1.View = View.Details;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newChampionship = new Form1();
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }

        private void deleteChampionship_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.Selected)
                {
                    string championshipNameToDelete = item.SubItems[0].Text;
                    var championshipsToDelete = championshipList.Where(c => c.ChampionshipName == championshipNameToDelete).ToList();

                    foreach (var championship in championshipsToDelete)
                    {
                        championshipList.Remove(championship);
                    }

                    string updatedJson = JsonConvert.SerializeObject(championshipList, Formatting.Indented);
                    File.WriteAllText(filePath, updatedJson);

                    listView1.Items.Remove(item);
                }
            }
        }

        private void selectChampionship_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    string championshipNameSelect = item.SubItems[0].Text;
                    var championshipsSelected = championshipList.Where(c => c.ChampionshipName == championshipNameSelect).ToList();

                    this.Hide();
                    Form5 newChampionship = new Form5(championshipsSelected);
                    newChampionship.FormClosed += (s, args) => this.Close();
                    newChampionship.Show();
                }
            }
        }
    }
}
