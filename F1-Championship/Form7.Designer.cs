namespace F1_Championship
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editeCarNumber = new System.Windows.Forms.Label();
            this.carNumberEdit = new System.Windows.Forms.TextBox();
            this.pilotNameEdit = new System.Windows.Forms.TextBox();
            this.editPilotName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pointsEdit = new System.Windows.Forms.TextBox();
            this.editPilotPoints = new System.Windows.Forms.Label();
            this.backToChampionship = new System.Windows.Forms.Button();
            this.saveEditPilot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editeCarNumber
            // 
            this.editeCarNumber.AutoSize = true;
            this.editeCarNumber.Location = new System.Drawing.Point(31, 84);
            this.editeCarNumber.Name = "editeCarNumber";
            this.editeCarNumber.Size = new System.Drawing.Size(87, 13);
            this.editeCarNumber.TabIndex = 1;
            this.editeCarNumber.Text = "Número do Carro";
            this.editeCarNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // carNumberEdit
            // 
            this.carNumberEdit.Location = new System.Drawing.Point(126, 81);
            this.carNumberEdit.Name = "carNumberEdit";
            this.carNumberEdit.Size = new System.Drawing.Size(177, 20);
            this.carNumberEdit.TabIndex = 2;
            this.carNumberEdit.TextChanged += new System.EventHandler(this.carNumber_TextChanged);
            this.carNumberEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumber_KeyPress);
            // 
            // pilotNameEdit
            // 
            this.pilotNameEdit.Location = new System.Drawing.Point(126, 33);
            this.pilotNameEdit.Name = "pilotNameEdit";
            this.pilotNameEdit.Size = new System.Drawing.Size(177, 20);
            this.pilotNameEdit.TabIndex = 2;
            // 
            // editPilotName
            // 
            this.editPilotName.AutoSize = true;
            this.editPilotName.Location = new System.Drawing.Point(31, 36);
            this.editPilotName.Name = "editPilotName";
            this.editPilotName.Size = new System.Drawing.Size(79, 13);
            this.editPilotName.TabIndex = 1;
            this.editPilotName.Text = "Nome do Piloto";
            this.editPilotName.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pointsEdit
            // 
            this.pointsEdit.Location = new System.Drawing.Point(126, 128);
            this.pointsEdit.Name = "pointsEdit";
            this.pointsEdit.Size = new System.Drawing.Size(177, 20);
            this.pointsEdit.TabIndex = 2;
            this.pointsEdit.TextChanged += new System.EventHandler(this.carNumber_TextChanged);
            this.pointsEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumber_KeyPress);
            // 
            // editPilotPoints
            // 
            this.editPilotPoints.AutoSize = true;
            this.editPilotPoints.Location = new System.Drawing.Point(31, 131);
            this.editPilotPoints.Name = "editPilotPoints";
            this.editPilotPoints.Size = new System.Drawing.Size(84, 13);
            this.editPilotPoints.TabIndex = 1;
            this.editPilotPoints.Text = "Pontos do Piloto";
            this.editPilotPoints.Click += new System.EventHandler(this.label1_Click);
            // 
            // backToChampionship
            // 
            this.backToChampionship.Location = new System.Drawing.Point(35, 241);
            this.backToChampionship.Name = "backToChampionship";
            this.backToChampionship.Size = new System.Drawing.Size(268, 46);
            this.backToChampionship.TabIndex = 4;
            this.backToChampionship.Text = "Voltar ao Campeonato";
            this.backToChampionship.UseVisualStyleBackColor = true;
            this.backToChampionship.Click += new System.EventHandler(this.backToChampionship_Click);
            // 
            // saveEditPilot
            // 
            this.saveEditPilot.Location = new System.Drawing.Point(35, 174);
            this.saveEditPilot.Name = "saveEditPilot";
            this.saveEditPilot.Size = new System.Drawing.Size(268, 46);
            this.saveEditPilot.TabIndex = 5;
            this.saveEditPilot.Text = "Salvar";
            this.saveEditPilot.UseVisualStyleBackColor = true;
            this.saveEditPilot.Click += new System.EventHandler(this.saveEditPilot_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 315);
            this.Controls.Add(this.saveEditPilot);
            this.Controls.Add(this.backToChampionship);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editPilotPoints);
            this.Controls.Add(this.editeCarNumber);
            this.Controls.Add(this.pointsEdit);
            this.Controls.Add(this.carNumberEdit);
            this.Controls.Add(this.editPilotName);
            this.Controls.Add(this.pilotNameEdit);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editeCarNumber;
        private System.Windows.Forms.TextBox carNumberEdit;
        private System.Windows.Forms.TextBox pilotNameEdit;
        private System.Windows.Forms.Label editPilotName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pointsEdit;
        private System.Windows.Forms.Label editPilotPoints;
        private System.Windows.Forms.Button backToChampionship;
        private System.Windows.Forms.Button saveEditPilot;
    }
}