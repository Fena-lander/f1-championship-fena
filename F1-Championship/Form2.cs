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
        public Form2()
        {
            InitializeComponent();
        }

        private void startChampionship_Click(object sender, EventArgs e)
        {
            var championship = new Championship();
            championship.ChampionshipName = championshipName.Text;

            string filePath = @"C:\Users\fe-ga\Documents\GitHub\f1-championship-fena\Championships.json";

            if(!File.Exists(filePath))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(@"C:\Users\fe-ga\Documents\GitHub\f1-championship-fena\Championships.json"))
                    {
                        sw.WriteLine(championship.JsonSerialize(championship));
                    }
                }
                catch
                {

                }

            }
            else
            {
                string jsonContent = File.ReadAllText(filePath);
                dynamic jsonData = JsonConvert.DeserializeObject(jsonContent);
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
