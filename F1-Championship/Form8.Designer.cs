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
            this.label1 = new System.Windows.Forms.Label();
            this.savePositionText = new System.Windows.Forms.TextBox();
            this.finishRace = new System.Windows.Forms.Button();
            this.cancelRace = new System.Windows.Forms.Button();
            this.pilotName = new System.Windows.Forms.Label();
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
            this.savePosition.Location = new System.Drawing.Point(34, 129);
            this.savePosition.Name = "savePosition";
            this.savePosition.Size = new System.Drawing.Size(266, 46);
            this.savePosition.TabIndex = 6;
            this.savePosition.Text = "Salvar Posição";
            this.savePosition.UseVisualStyleBackColor = true;
            this.savePosition.Click += new System.EventHandler(this.savePosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Colocação";
            // 
            // savePositionText
            // 
            this.savePositionText.Location = new System.Drawing.Point(95, 86);
            this.savePositionText.Name = "savePositionText";
            this.savePositionText.Size = new System.Drawing.Size(204, 20);
            this.savePositionText.TabIndex = 9;
            this.savePositionText.TextChanged += new System.EventHandler(this.saveEditPilot_Click);
            this.savePositionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.savePositionText_KeyPress);
            // 
            // finishRace
            // 
            this.finishRace.Location = new System.Drawing.Point(34, 233);
            this.finishRace.Name = "finishRace";
            this.finishRace.Size = new System.Drawing.Size(267, 46);
            this.finishRace.TabIndex = 10;
            this.finishRace.Text = "Finalizar Corrida";
            this.finishRace.UseVisualStyleBackColor = true;
            this.finishRace.Click += new System.EventHandler(this.finishRace_Click);
            // 
            // cancelRace
            // 
            this.cancelRace.Location = new System.Drawing.Point(34, 181);
            this.cancelRace.Name = "cancelRace";
            this.cancelRace.Size = new System.Drawing.Size(266, 46);
            this.cancelRace.TabIndex = 11;
            this.cancelRace.Text = "Cancelar Corrida";
            this.cancelRace.UseVisualStyleBackColor = true;
            this.cancelRace.Click += new System.EventHandler(this.cancelRace_Click);
            // 
            // pilotName
            // 
            this.pilotName.AutoSize = true;
            this.pilotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotName.Location = new System.Drawing.Point(29, 28);
            this.pilotName.Name = "pilotName";
            this.pilotName.Size = new System.Drawing.Size(203, 25);
            this.pilotName.TabIndex = 12;
            this.pilotName.Text = "Selecione um Piloto";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 317);
            this.Controls.Add(this.pilotName);
            this.Controls.Add(this.cancelRace);
            this.Controls.Add(this.finishRace);
            this.Controls.Add(this.savePositionText);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savePositionText;
        private System.Windows.Forms.Button finishRace;
        private System.Windows.Forms.Button cancelRace;
        private System.Windows.Forms.Label pilotName;
    }
}