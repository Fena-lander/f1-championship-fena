namespace F1_Championship
{
    partial class Form5
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.backListChampionship = new System.Windows.Forms.Button();
            this.addPilot = new System.Windows.Forms.Button();
            this.deletePilotOnChampionship = new System.Windows.Forms.Button();
            this.editPilot = new System.Windows.Forms.Button();
            this.createRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // backListChampionship
            // 
            this.backListChampionship.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backListChampionship.Location = new System.Drawing.Point(12, 405);
            this.backListChampionship.Name = "backListChampionship";
            this.backListChampionship.Size = new System.Drawing.Size(214, 33);
            this.backListChampionship.TabIndex = 2;
            this.backListChampionship.Text = "↩   Voltar\r\n";
            this.backListChampionship.UseVisualStyleBackColor = true;
            this.backListChampionship.Click += new System.EventHandler(this.backListChampionship_Click);
            // 
            // addPilot
            // 
            this.addPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPilot.Location = new System.Drawing.Point(12, 352);
            this.addPilot.Name = "addPilot";
            this.addPilot.Size = new System.Drawing.Size(97, 47);
            this.addPilot.TabIndex = 3;
            this.addPilot.Text = "Adicionar Piloto";
            this.addPilot.UseVisualStyleBackColor = true;
            this.addPilot.Click += new System.EventHandler(this.addPilot_Click);
            // 
            // deletePilotOnChampionship
            // 
            this.deletePilotOnChampionship.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePilotOnChampionship.Location = new System.Drawing.Point(129, 352);
            this.deletePilotOnChampionship.Name = "deletePilotOnChampionship";
            this.deletePilotOnChampionship.Size = new System.Drawing.Size(97, 47);
            this.deletePilotOnChampionship.TabIndex = 3;
            this.deletePilotOnChampionship.Text = "Excluir Piloto";
            this.deletePilotOnChampionship.UseVisualStyleBackColor = true;
            this.deletePilotOnChampionship.Click += new System.EventHandler(this.deletePilotOnChampionship_Click);
            // 
            // editPilot
            // 
            this.editPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPilot.Location = new System.Drawing.Point(13, 299);
            this.editPilot.Name = "editPilot";
            this.editPilot.Size = new System.Drawing.Size(96, 47);
            this.editPilot.TabIndex = 4;
            this.editPilot.Text = "Editar Piloto";
            this.editPilot.UseVisualStyleBackColor = true;
            this.editPilot.Click += new System.EventHandler(this.editPilot_Click);
            // 
            // createRace
            // 
            this.createRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRace.Location = new System.Drawing.Point(130, 299);
            this.createRace.Name = "createRace";
            this.createRace.Size = new System.Drawing.Size(96, 47);
            this.createRace.TabIndex = 5;
            this.createRace.Text = "Criar Corrida";
            this.createRace.UseVisualStyleBackColor = true;
            this.createRace.Click += new System.EventHandler(this.createRace_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 457);
            this.Controls.Add(this.createRace);
            this.Controls.Add(this.editPilot);
            this.Controls.Add(this.deletePilotOnChampionship);
            this.Controls.Add(this.addPilot);
            this.Controls.Add(this.backListChampionship);
            this.Controls.Add(this.listView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backListChampionship;
        private System.Windows.Forms.Button addPilot;
        private System.Windows.Forms.Button deletePilotOnChampionship;
        private System.Windows.Forms.Button editPilot;
        private System.Windows.Forms.Button createRace;
    }
}