namespace Proiect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbCasete = new System.Windows.Forms.ListBox();
            this.btnPopulareLbCasete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficSituatieInchirieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.btnInregistrareInchiriere = new System.Windows.Forms.Button();
            this.tbInchirieri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCosInchirieri = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.afisareBazaDeDateClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCasete
            // 
            this.lbCasete.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbCasete.FormattingEnabled = true;
            this.lbCasete.ItemHeight = 16;
            this.lbCasete.Location = new System.Drawing.Point(439, 74);
            this.lbCasete.Name = "lbCasete";
            this.lbCasete.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCasete.Size = new System.Drawing.Size(559, 404);
            this.lbCasete.TabIndex = 1;
            this.lbCasete.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbCasete_DrawItem);
            this.lbCasete.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbCasete_MeasureItem);
            this.lbCasete.SelectedIndexChanged += new System.EventHandler(this.lbCasete_SelectedIndexChanged);
            // 
            // btnPopulareLbCasete
            // 
            this.btnPopulareLbCasete.Location = new System.Drawing.Point(611, 28);
            this.btnPopulareLbCasete.Name = "btnPopulareLbCasete";
            this.btnPopulareLbCasete.Size = new System.Drawing.Size(205, 40);
            this.btnPopulareLbCasete.TabIndex = 2;
            this.btnPopulareLbCasete.Text = "Afisare lista casete";
            this.btnPopulareLbCasete.UseVisualStyleBackColor = true;
            this.btnPopulareLbCasete.Click += new System.EventHandler(this.btnPopulareLbCasete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.ajutorToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1563, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurareToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.afisareGraficSituatieInchirieriToolStripMenuItem,
            this.afisareToolStripMenuItem,
            this.afisareBazaDeDateClientiToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.fILEToolStripMenuItem.Text = "Options";
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.restaurareToolStripMenuItem.Text = "Afisare lista casete";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem1});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.salvareToolStripMenuItem.Text = "FILE";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // afisareGraficSituatieInchirieriToolStripMenuItem
            // 
            this.afisareGraficSituatieInchirieriToolStripMenuItem.Name = "afisareGraficSituatieInchirieriToolStripMenuItem";
            this.afisareGraficSituatieInchirieriToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.afisareGraficSituatieInchirieriToolStripMenuItem.Text = "Afisare grafic situatie inchirieri";
            this.afisareGraficSituatieInchirieriToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficSituatieInchirieriToolStripMenuItem_Click);
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.afisareToolStripMenuItem.Text = "Afisare inchirieri \"Binding\"";
            this.afisareToolStripMenuItem.Click += new System.EventHandler(this.afisareToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Formular inchiriere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume si prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numar de telefon";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(231, 133);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(135, 22);
            this.tbNume.TabIndex = 8;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(231, 179);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(135, 22);
            this.tbAdresa.TabIndex = 9;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(231, 218);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(135, 22);
            this.tbTelefon.TabIndex = 10;
            this.tbTelefon.TextChanged += new System.EventHandler(this.tbTelefon_TextChanged);
            // 
            // btnInregistrareInchiriere
            // 
            this.btnInregistrareInchiriere.Location = new System.Drawing.Point(45, 433);
            this.btnInregistrareInchiriere.Name = "btnInregistrareInchiriere";
            this.btnInregistrareInchiriere.Size = new System.Drawing.Size(321, 45);
            this.btnInregistrareInchiriere.TabIndex = 11;
            this.btnInregistrareInchiriere.Text = "Inchiriaza";
            this.btnInregistrareInchiriere.UseVisualStyleBackColor = true;
            this.btnInregistrareInchiriere.Click += new System.EventHandler(this.btnInregistrareInchiriere_Click);
            // 
            // tbInchirieri
            // 
            this.tbInchirieri.Location = new System.Drawing.Point(1074, 74);
            this.tbInchirieri.Multiline = true;
            this.tbInchirieri.Name = "tbInchirieri";
            this.tbInchirieri.ReadOnly = true;
            this.tbInchirieri.Size = new System.Drawing.Size(477, 404);
            this.tbInchirieri.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(1229, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lista inchirieri\r\n";
            // 
            // tbCosInchirieri
            // 
            this.tbCosInchirieri.Location = new System.Drawing.Point(45, 275);
            this.tbCosInchirieri.Multiline = true;
            this.tbCosInchirieri.Name = "tbCosInchirieri";
            this.tbCosInchirieri.ReadOnly = true;
            this.tbCosInchirieri.Size = new System.Drawing.Size(321, 129);
            this.tbCosInchirieri.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // afisareBazaDeDateClientiToolStripMenuItem
            // 
            this.afisareBazaDeDateClientiToolStripMenuItem.Name = "afisareBazaDeDateClientiToolStripMenuItem";
            this.afisareBazaDeDateClientiToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.afisareBazaDeDateClientiToolStripMenuItem.Text = "Afisare baza de date Clienti";
            this.afisareBazaDeDateClientiToolStripMenuItem.Click += new System.EventHandler(this.afisareBazaDeDateClientiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 624);
            this.Controls.Add(this.tbCosInchirieri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInchirieri);
            this.Controls.Add(this.btnInregistrareInchiriere);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPopulareLbCasete);
            this.Controls.Add(this.lbCasete);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inchiriere casete video";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbCasete;
        private System.Windows.Forms.Button btnPopulareLbCasete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Button btnInregistrareInchiriere;
        private System.Windows.Forms.TextBox tbInchirieri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCosInchirieri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficSituatieInchirieriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareBazaDeDateClientiToolStripMenuItem;
    }
}

