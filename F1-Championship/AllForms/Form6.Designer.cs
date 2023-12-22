namespace F1_Championship
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pilotName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carNumber = new System.Windows.Forms.TextBox();
            this.addPilot = new System.Windows.Forms.Button();
            this.finishChampionship = new System.Windows.Forms.Button();
            this.clearPilotsParameter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Piloto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pilotName
            // 
            this.pilotName.Location = new System.Drawing.Point(110, 75);
            this.pilotName.Name = "pilotName";
            this.pilotName.Size = new System.Drawing.Size(177, 20);
            this.pilotName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número do Carro";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // carNumber
            // 
            this.carNumber.Location = new System.Drawing.Point(110, 123);
            this.carNumber.Name = "carNumber";
            this.carNumber.Size = new System.Drawing.Size(177, 20);
            this.carNumber.TabIndex = 2;
            this.carNumber.TextChanged += new System.EventHandler(this.carNumber_TextChanged);
            this.carNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carNumber_KeyPress);
            // 
            // addPilot
            // 
            this.addPilot.Location = new System.Drawing.Point(18, 179);
            this.addPilot.Name = "addPilot";
            this.addPilot.Size = new System.Drawing.Size(75, 23);
            this.addPilot.TabIndex = 3;
            this.addPilot.Text = "Adicionar";
            this.addPilot.UseVisualStyleBackColor = true;
            this.addPilot.Click += new System.EventHandler(this.addPilot_Click);
            // 
            // finishChampionship
            // 
            this.finishChampionship.Location = new System.Drawing.Point(18, 221);
            this.finishChampionship.Name = "finishChampionship";
            this.finishChampionship.Size = new System.Drawing.Size(269, 46);
            this.finishChampionship.TabIndex = 5;
            this.finishChampionship.Text = "Voltar no Campeonato";
            this.finishChampionship.UseVisualStyleBackColor = true;
            this.finishChampionship.Click += new System.EventHandler(this.finishChampionship_Click);
            // 
            // clearPilotsParameter
            // 
            this.clearPilotsParameter.Location = new System.Drawing.Point(212, 179);
            this.clearPilotsParameter.Name = "clearPilotsParameter";
            this.clearPilotsParameter.Size = new System.Drawing.Size(75, 23);
            this.clearPilotsParameter.TabIndex = 7;
            this.clearPilotsParameter.Text = "Cancelar";
            this.clearPilotsParameter.UseVisualStyleBackColor = true;
            this.clearPilotsParameter.Click += new System.EventHandler(this.clearPilotsParameter_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 316);
            this.Controls.Add(this.clearPilotsParameter);
            this.Controls.Add(this.finishChampionship);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPilot);
            this.Controls.Add(this.pilotName);
            this.Controls.Add(this.carNumber);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pilotName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carNumber;
        private System.Windows.Forms.Button addPilot;
        private System.Windows.Forms.Button finishChampionship;
        private System.Windows.Forms.Button clearPilotsParameter;
    }
}