namespace F1_Championship
{
    partial class Form8
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
            this.savePosition = new System.Windows.Forms.Button();
            this.backToChampionship = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.savePositionText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // savePosition
            // 
            this.savePosition.Location = new System.Drawing.Point(33, 171);
            this.savePosition.Name = "savePosition";
            this.savePosition.Size = new System.Drawing.Size(268, 46);
            this.savePosition.TabIndex = 6;
            this.savePosition.Text = "Salvar Posição";
            this.savePosition.UseVisualStyleBackColor = true;
            this.savePosition.Click += new System.EventHandler(this.savePosition_Click);
            // 
            // backToChampionship
            // 
            this.backToChampionship.Location = new System.Drawing.Point(33, 236);
            this.backToChampionship.Name = "backToChampionship";
            this.backToChampionship.Size = new System.Drawing.Size(268, 46);
            this.backToChampionship.TabIndex = 7;
            this.backToChampionship.Text = "Voltar ao Campeonato";
            this.backToChampionship.UseVisualStyleBackColor = true;
            this.backToChampionship.Click += new System.EventHandler(this.backToChampionship_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colocação";
            // 
            // savePositionText
            // 
            this.savePositionText.Location = new System.Drawing.Point(95, 90);
            this.savePositionText.Name = "savePositionText";
            this.savePositionText.Size = new System.Drawing.Size(206, 20);
            this.savePositionText.TabIndex = 9;
            this.savePositionText.TextChanged += new System.EventHandler(this.saveEditPilot_Click);
            this.savePositionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.savePositionText_KeyPress);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 317);
            this.Controls.Add(this.savePositionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToChampionship);
            this.Controls.Add(this.savePosition);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button savePosition;
        private System.Windows.Forms.Button backToChampionship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savePositionText;
    }
}