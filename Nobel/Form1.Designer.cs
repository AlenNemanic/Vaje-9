namespace Nobel
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
            this.datagridview_rezultati = new System.Windows.Forms.DataGridView();
            this.datagrid_leto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_podrocje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_do_leta = new System.Windows.Forms.Label();
            this.label_od_leta = new System.Windows.Forms.Label();
            this.label_podrocje = new System.Windows.Forms.Label();
            this.do_leta_textbox = new System.Windows.Forms.TextBox();
            this.od_leta_textbox = new System.Windows.Forms.TextBox();
            this.podrocja = new System.Windows.Forms.CheckedListBox();
            this.Gumb_poisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview_rezultati
            // 
            this.datagridview_rezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_rezultati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_leto,
            this.datagrid_podrocje,
            this.datagrid_ime});
            this.datagridview_rezultati.Location = new System.Drawing.Point(345, 12);
            this.datagridview_rezultati.Name = "datagridview_rezultati";
            this.datagridview_rezultati.Size = new System.Drawing.Size(399, 270);
            this.datagridview_rezultati.TabIndex = 16;
            // 
            // datagrid_leto
            // 
            this.datagrid_leto.HeaderText = "Leto";
            this.datagrid_leto.Name = "datagrid_leto";
            this.datagrid_leto.Width = 70;
            // 
            // datagrid_podrocje
            // 
            this.datagrid_podrocje.HeaderText = "Področje";
            this.datagrid_podrocje.Name = "datagrid_podrocje";
            // 
            // datagrid_ime
            // 
            this.datagrid_ime.HeaderText = "Ime";
            this.datagrid_ime.Name = "datagrid_ime";
            this.datagrid_ime.Width = 170;
            // 
            // label_do_leta
            // 
            this.label_do_leta.AutoSize = true;
            this.label_do_leta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_do_leta.Location = new System.Drawing.Point(122, 164);
            this.label_do_leta.Name = "label_do_leta";
            this.label_do_leta.Size = new System.Drawing.Size(80, 25);
            this.label_do_leta.TabIndex = 15;
            this.label_do_leta.Text = "Do leta";
            // 
            // label_od_leta
            // 
            this.label_od_leta.AutoSize = true;
            this.label_od_leta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_od_leta.Location = new System.Drawing.Point(7, 164);
            this.label_od_leta.Name = "label_od_leta";
            this.label_od_leta.Size = new System.Drawing.Size(82, 25);
            this.label_od_leta.TabIndex = 14;
            this.label_od_leta.Text = "Od leta";
            // 
            // label_podrocje
            // 
            this.label_podrocje.AutoSize = true;
            this.label_podrocje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_podrocje.Location = new System.Drawing.Point(7, 6);
            this.label_podrocje.Name = "label_podrocje";
            this.label_podrocje.Size = new System.Drawing.Size(154, 25);
            this.label_podrocje.TabIndex = 13;
            this.label_podrocje.Text = "Izberi področje";
            // 
            // do_leta_textbox
            // 
            this.do_leta_textbox.Location = new System.Drawing.Point(127, 195);
            this.do_leta_textbox.Name = "do_leta_textbox";
            this.do_leta_textbox.Size = new System.Drawing.Size(75, 20);
            this.do_leta_textbox.TabIndex = 12;
            // 
            // od_leta_textbox
            // 
            this.od_leta_textbox.Location = new System.Drawing.Point(12, 195);
            this.od_leta_textbox.Name = "od_leta_textbox";
            this.od_leta_textbox.Size = new System.Drawing.Size(77, 20);
            this.od_leta_textbox.TabIndex = 11;
            // 
            // podrocja
            // 
            this.podrocja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podrocja.FormattingEnabled = true;
            this.podrocja.Items.AddRange(new object[] {
            "Chemistry",
            "Economics",
            "Literature",
            "Medicine",
            "Peace",
            "Physics"});
            this.podrocja.Location = new System.Drawing.Point(12, 34);
            this.podrocja.Name = "podrocja";
            this.podrocja.Size = new System.Drawing.Size(191, 112);
            this.podrocja.TabIndex = 10;
            // 
            // Gumb_poisci
            // 
            this.Gumb_poisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gumb_poisci.Location = new System.Drawing.Point(209, 59);
            this.Gumb_poisci.Name = "Gumb_poisci";
            this.Gumb_poisci.Size = new System.Drawing.Size(130, 50);
            this.Gumb_poisci.TabIndex = 9;
            this.Gumb_poisci.Text = "Poišči";
            this.Gumb_poisci.UseVisualStyleBackColor = true;
            this.Gumb_poisci.Click += new System.EventHandler(this.Gumb_poisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 289);
            this.Controls.Add(this.datagridview_rezultati);
            this.Controls.Add(this.label_do_leta);
            this.Controls.Add(this.label_od_leta);
            this.Controls.Add(this.label_podrocje);
            this.Controls.Add(this.do_leta_textbox);
            this.Controls.Add(this.od_leta_textbox);
            this.Controls.Add(this.podrocja);
            this.Controls.Add(this.Gumb_poisci);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_rezultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview_rezultati;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_leto;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_podrocje;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_ime;
        private System.Windows.Forms.Label label_do_leta;
        private System.Windows.Forms.Label label_od_leta;
        private System.Windows.Forms.Label label_podrocje;
        private System.Windows.Forms.TextBox do_leta_textbox;
        private System.Windows.Forms.TextBox od_leta_textbox;
        private System.Windows.Forms.CheckedListBox podrocja;
        private System.Windows.Forms.Button Gumb_poisci;
    }
}

