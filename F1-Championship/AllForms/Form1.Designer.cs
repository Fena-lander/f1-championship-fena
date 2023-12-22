namespace F1_Championship
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.newChampionship = new System.Windows.Forms.Button();
            this.changeChampionship = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newChampionship
            // 
            this.newChampionship.Location = new System.Drawing.Point(12, 61);
            this.newChampionship.Name = "newChampionship";
            this.newChampionship.Size = new System.Drawing.Size(123, 87);
            this.newChampionship.TabIndex = 0;
            this.newChampionship.Text = "Novo Campeonato";
            this.newChampionship.UseVisualStyleBackColor = true;
            this.newChampionship.Click += new System.EventHandler(this.newChampionship_Click);
            // 
            // changeChampionship
            // 
            this.changeChampionship.Location = new System.Drawing.Point(162, 61);
            this.changeChampionship.Name = "changeChampionship";
            this.changeChampionship.Size = new System.Drawing.Size(123, 87);
            this.changeChampionship.TabIndex = 1;
            this.changeChampionship.Text = "Acompanhar Campeonato";
            this.changeChampionship.UseVisualStyleBackColor = true;
            this.changeChampionship.Click += new System.EventHandler(this.changeChampionship_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 201);
            this.Controls.Add(this.changeChampionship);
            this.Controls.Add(this.newChampionship);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newChampionship;
        private System.Windows.Forms.Button changeChampionship;
    }
}

