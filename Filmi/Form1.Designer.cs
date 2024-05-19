namespace Filmi
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
            this.Gumb_poisci = new System.Windows.Forms.Button();
            this.od_leta_textbox = new System.Windows.Forms.TextBox();
            this.do_leta_textbox = new System.Windows.Forms.TextBox();
            this.label_od_leta = new System.Windows.Forms.Label();
            this.label_do_leta = new System.Windows.Forms.Label();
            this.datagridview_rezultati = new System.Windows.Forms.DataGridView();
            this.datagrid_naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_leto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_reziser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ocena = new System.Windows.Forms.Label();
            this.comboBox_ocena = new System.Windows.Forms.ComboBox();
            this.ocena_textbox = new System.Windows.Forms.TextBox();
            this.label_ime = new System.Windows.Forms.Label();
            this.ime_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // Gumb_poisci
            // 
            this.Gumb_poisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gumb_poisci.Location = new System.Drawing.Point(90, 217);
            this.Gumb_poisci.Name = "Gumb_poisci";
            this.Gumb_poisci.Size = new System.Drawing.Size(130, 50);
            this.Gumb_poisci.TabIndex = 0;
            this.Gumb_poisci.Text = "Poišči";
            this.Gumb_poisci.UseVisualStyleBackColor = true;
            this.Gumb_poisci.Click += new System.EventHandler(this.Gumb_poisci_Click);
            // 
            // od_leta_textbox
            // 
            this.od_leta_textbox.Location = new System.Drawing.Point(82, 104);
            this.od_leta_textbox.Name = "od_leta_textbox";
            this.od_leta_textbox.Size = new System.Drawing.Size(77, 20);
            this.od_leta_textbox.TabIndex = 3;
            // 
            // do_leta_textbox
            // 
            this.do_leta_textbox.Location = new System.Drawing.Point(197, 104);
            this.do_leta_textbox.Name = "do_leta_textbox";
            this.do_leta_textbox.Size = new System.Drawing.Size(75, 20);
            this.do_leta_textbox.TabIndex = 4;
            // 
            // label_od_leta
            // 
            this.label_od_leta.AutoSize = true;
            this.label_od_leta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_od_leta.Location = new System.Drawing.Point(77, 73);
            this.label_od_leta.Name = "label_od_leta";
            this.label_od_leta.Size = new System.Drawing.Size(82, 25);
            this.label_od_leta.TabIndex = 6;
            this.label_od_leta.Text = "Od leta";
            // 
            // label_do_leta
            // 
            this.label_do_leta.AutoSize = true;
            this.label_do_leta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_do_leta.Location = new System.Drawing.Point(192, 73);
            this.label_do_leta.Name = "label_do_leta";
            this.label_do_leta.Size = new System.Drawing.Size(80, 25);
            this.label_do_leta.TabIndex = 7;
            this.label_do_leta.Text = "Do leta";
            // 
            // datagridview_rezultati
            // 
            this.datagridview_rezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_rezultati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_naslov,
            this.datagrid_leto,
            this.datagrid_reziser,
            this.datagrid_ocena});
            this.datagridview_rezultati.Location = new System.Drawing.Point(382, 18);
            this.datagridview_rezultati.Name = "datagridview_rezultati";
            this.datagridview_rezultati.Size = new System.Drawing.Size(480, 270);
            this.datagridview_rezultati.TabIndex = 8;
            // 
            // datagrid_naslov
            // 
            this.datagrid_naslov.HeaderText = "Naslov";
            this.datagrid_naslov.Name = "datagrid_naslov";
            this.datagrid_naslov.Width = 200;
            // 
            // datagrid_leto
            // 
            this.datagrid_leto.HeaderText = "Leto";
            this.datagrid_leto.Name = "datagrid_leto";
            this.datagrid_leto.Width = 50;
            // 
            // datagrid_reziser
            // 
            this.datagrid_reziser.HeaderText = "Režiser";
            this.datagrid_reziser.Name = "datagrid_reziser";
            this.datagrid_reziser.Width = 120;
            // 
            // datagrid_ocena
            // 
            this.datagrid_ocena.HeaderText = "Ocena";
            this.datagrid_ocena.Name = "datagrid_ocena";
            this.datagrid_ocena.Width = 50;
            // 
            // label_ocena
            // 
            this.label_ocena.AutoSize = true;
            this.label_ocena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ocena.Location = new System.Drawing.Point(12, 159);
            this.label_ocena.Name = "label_ocena";
            this.label_ocena.Size = new System.Drawing.Size(76, 25);
            this.label_ocena.TabIndex = 9;
            this.label_ocena.Text = "Ocena";
            // 
            // comboBox_ocena
            // 
            this.comboBox_ocena.FormattingEnabled = true;
            this.comboBox_ocena.Items.AddRange(new object[] {
            ">",
            ">=",
            "=",
            "<=",
            "<"});
            this.comboBox_ocena.Location = new System.Drawing.Point(94, 165);
            this.comboBox_ocena.Name = "comboBox_ocena";
            this.comboBox_ocena.Size = new System.Drawing.Size(60, 21);
            this.comboBox_ocena.TabIndex = 10;
            // 
            // ocena_textbox
            // 
            this.ocena_textbox.Location = new System.Drawing.Point(160, 166);
            this.ocena_textbox.Name = "ocena_textbox";
            this.ocena_textbox.Size = new System.Drawing.Size(75, 20);
            this.ocena_textbox.TabIndex = 11;
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ime.Location = new System.Drawing.Point(12, 12);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(142, 25);
            this.label_ime.TabIndex = 13;
            this.label_ime.Text = "Ime režiserja:";
            // 
            // ime_textbox
            // 
            this.ime_textbox.Location = new System.Drawing.Point(160, 18);
            this.ime_textbox.Name = "ime_textbox";
            this.ime_textbox.Size = new System.Drawing.Size(202, 20);
            this.ime_textbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 307);
            this.Controls.Add(this.label_ime);
            this.Controls.Add(this.ime_textbox);
            this.Controls.Add(this.ocena_textbox);
            this.Controls.Add(this.comboBox_ocena);
            this.Controls.Add(this.label_ocena);
            this.Controls.Add(this.datagridview_rezultati);
            this.Controls.Add(this.label_do_leta);
            this.Controls.Add(this.label_od_leta);
            this.Controls.Add(this.do_leta_textbox);
            this.Controls.Add(this.od_leta_textbox);
            this.Controls.Add(this.Gumb_poisci);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gumb_poisci;
        private System.Windows.Forms.TextBox od_leta_textbox;
        private System.Windows.Forms.TextBox do_leta_textbox;
        private System.Windows.Forms.Label label_od_leta;
        private System.Windows.Forms.Label label_do_leta;
        private System.Windows.Forms.DataGridView datagridview_rezultati;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_leto;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_reziser;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_ocena;
        private System.Windows.Forms.Label label_ocena;
        private System.Windows.Forms.ComboBox comboBox_ocena;
        private System.Windows.Forms.TextBox ocena_textbox;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.TextBox ime_textbox;
    }
}

