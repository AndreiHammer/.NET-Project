namespace Proiect
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
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.btnAfiseazaClientiDB = new System.Windows.Forms.Button();
            this.btnStergeClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(133, 69);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersWidth = 51;
            this.dgvClienti.RowTemplate.Height = 24;
            this.dgvClienti.Size = new System.Drawing.Size(535, 313);
            this.dgvClienti.TabIndex = 0;
            this.dgvClienti.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClienti_RowHeaderMouseClick);
            // 
            // btnAfiseazaClientiDB
            // 
            this.btnAfiseazaClientiDB.Location = new System.Drawing.Point(133, 25);
            this.btnAfiseazaClientiDB.Name = "btnAfiseazaClientiDB";
            this.btnAfiseazaClientiDB.Size = new System.Drawing.Size(204, 38);
            this.btnAfiseazaClientiDB.TabIndex = 1;
            this.btnAfiseazaClientiDB.Text = "Afiseaza baza de date clienti";
            this.btnAfiseazaClientiDB.UseVisualStyleBackColor = true;
            this.btnAfiseazaClientiDB.Click += new System.EventHandler(this.btnAfiseazaClientiDB_Click);
            // 
            // btnStergeClient
            // 
            this.btnStergeClient.Location = new System.Drawing.Point(445, 26);
            this.btnStergeClient.Name = "btnStergeClient";
            this.btnStergeClient.Size = new System.Drawing.Size(223, 37);
            this.btnStergeClient.TabIndex = 2;
            this.btnStergeClient.Text = "Sterge inregistrare";
            this.btnStergeClient.UseVisualStyleBackColor = true;
            this.btnStergeClient.Click += new System.EventHandler(this.btnStergeClient_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergeClient);
            this.Controls.Add(this.btnAfiseazaClientiDB);
            this.Controls.Add(this.dgvClienti);
            this.Name = "Form4";
            this.Text = "Baza de date Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Button btnAfiseazaClientiDB;
        private System.Windows.Forms.Button btnStergeClient;
    }
}