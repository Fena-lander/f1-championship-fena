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
    public partial class Form8 : Form
    {

        private List<Championship> championshipNameSelect;
        private Pilot selectedPilot;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Championship.json");

        public Form8(List<Championship> championshipNameSelect)
        {
            this.championshipNameSelect = championshipNameSelect;

            InitializeComponent();

            if (dataGridView1.Rows.Count > 0)
            {
                selectedPilot = (Pilot)dataGridView1.Rows[0].DataBoundItem;
            }

            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
             List<Pilot> allPilots = championshipNameSelect.SelectMany(championship => championship.Pilots).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allPilots;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                selectedPilot = (Pilot)dataGridView1.Rows[0].DataBoundItem;
            }
        }

        private int GetPointsForPosition(int position)
        {
            if (position > 10 || position < 1)
            {
                return 0;
            }
            Dictionary<int, int> pointsTable = new Dictionary<int, int>
        {
            { 1, 25 },
            { 2, 18 },
            { 3, 15 },
            { 4, 12 },
            { 5, 10 },
            { 6, 8 },
            { 7, 6 },
            { 8, 4 },
            { 9, 2 },
            { 10, 1 }
        };
            return pointsTable[position];
        }

        private void backToChampionship_Click(object sender, EventArgs e)
        {

        }

        private void saveEditPilot_Click(object sender, EventArgs e)
        {

        }

        private void savePositionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            savePositionText.MaxLength = 2;
        }

        private void savePosition_Click(object sender, EventArgs e)
        {
            int position = int.Parse(savePositionText.Text);

            int points = GetPointsForPosition(position);

            selectedPilot.Points += points;

            LoadDataGridView();

            savePositionText.Text = string.Empty;

            string updateJson = JsonConvert.SerializeObject(championshipNameSelect, Formatting.Indented);
            File.WriteAllText(filePath, updateJson);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            selectedPilot = (Pilot)dataGridView1.Rows[e.RowIndex].DataBoundItem;
        }

        private void backToChampionship_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newChampionship = new Form5(championshipNameSelect);
            newChampionship.FormClosed += (s, args) => this.Close();
            newChampionship.Show();
        }
    }
}
