namespace F1_Championship
{
    partial class Form4
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
            this.backToMenu = new System.Windows.Forms.Button();
            this.selectChampionship = new System.Windows.Forms.Button();
            this.deleteChampionship = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 288);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // backToMenu
            // 
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenu.Location = new System.Drawing.Point(12, 22);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(110, 33);
            this.backToMenu.TabIndex = 1;
            this.backToMenu.Text = "↩   Voltar";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // selectChampionship
            // 
            this.selectChampionship.Location = new System.Drawing.Point(12, 390);
            this.selectChampionship.Name = "selectChampionship";
            this.selectChampionship.Size = new System.Drawing.Size(96, 33);
            this.selectChampionship.TabIndex = 1;
            this.selectChampionship.Text = "Selecionar";
            this.selectChampionship.UseVisualStyleBackColor = true;
            this.selectChampionship.Click += new System.EventHandler(this.selectChampionship_Click);
            // 
            // deleteChampionship
            // 
            this.deleteChampionship.Location = new System.Drawing.Point(216, 390);
            this.deleteChampionship.Name = "deleteChampionship";
            this.deleteChampionship.Size = new System.Drawing.Size(96, 33);
            this.deleteChampionship.TabIndex = 1;
            this.deleteChampionship.Text = "Excluir";
            this.deleteChampionship.UseVisualStyleBackColor = true;
            this.deleteChampionship.Click += new System.EventHandler(this.deleteChampionship_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 447);
            this.Controls.Add(this.deleteChampionship);
            this.Controls.Add(this.selectChampionship);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Button selectChampionship;
        private System.Windows.Forms.Button deleteChampionship;
    }
}