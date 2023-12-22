namespace F1_Championship
{
    partial class Form2
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
            this.championshipName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startChampionship = new System.Windows.Forms.Button();
            this.cancelStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // championshipName
            // 
            this.championshipName.Location = new System.Drawing.Point(86, 88);
            this.championshipName.Name = "championshipName";
            this.championshipName.Size = new System.Drawing.Size(310, 20);
            this.championshipName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Campeonato";
            // 
            // startChampionship
            // 
            this.startChampionship.Location = new System.Drawing.Point(86, 137);
            this.startChampionship.Name = "startChampionship";
            this.startChampionship.Size = new System.Drawing.Size(107, 37);
            this.startChampionship.TabIndex = 3;
            this.startChampionship.Text = "Iniciar";
            this.startChampionship.UseVisualStyleBackColor = true;
            this.startChampionship.Click += new System.EventHandler(this.startChampionship_Click);
            // 
            // cancelStart
            // 
            this.cancelStart.Location = new System.Drawing.Point(289, 137);
            this.cancelStart.Name = "cancelStart";
            this.cancelStart.Size = new System.Drawing.Size(107, 37);
            this.cancelStart.TabIndex = 4;
            this.cancelStart.Text = "Cancelar";
            this.cancelStart.UseVisualStyleBackColor = true;
            this.cancelStart.Click += new System.EventHandler(this.cancelStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 202);
            this.Controls.Add(this.cancelStart);
            this.Controls.Add(this.startChampionship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.championshipName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox championshipName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startChampionship;
        private System.Windows.Forms.Button cancelStart;
    }
}