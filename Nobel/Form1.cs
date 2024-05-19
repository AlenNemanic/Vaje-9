using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Nobel
{
    public partial class Form1: Form
    {
        private const string pov_niz = "Data source = nobelDB.db; Version = 3;";
        int od_leta, do_leta;
        string leto_meje, seznam_podrocji, pogoji;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_poisci_Click(object sender, EventArgs e)
        {
            // Pobrišemo prejšnje rezultate
            datagridview_rezultati.Rows.Clear();
            // Ustvarimo povezavo
            SQLiteConnection povezava = new SQLiteConnection(pov_niz);
            // Preverimo pogoje
            if (int.TryParse(od_leta_textbox.Text, out od_leta))
            {                
                if (int.TryParse(do_leta_textbox.Text, out do_leta))
                    leto_meje = $"yr >= {od_leta} AND yr <= {do_leta}";
                else leto_meje = $"yr >= {od_leta}";
            }
            else if (int.TryParse(do_leta_textbox.Text, out do_leta))
                leto_meje = $"yr <= {do_leta}";
            else
                leto_meje = "";
            if (podrocja.CheckedItems.Count > 0)
            {
                seznam_podrocji = "subject IN (";
                foreach (object podrocje in podrocja.CheckedItems)
                {
                    seznam_podrocji += $"'{podrocje}', ";
                }
                seznam_podrocji = seznam_podrocji.Substring(0, seznam_podrocji.Length - 2) + ")";
            }
            else seznam_podrocji = "";
            if (leto_meje.Length > 0 || seznam_podrocji.Length > 0)
            {
                pogoji = " WHERE ";
                if (leto_meje.Length > 0)
                {
                    if (seznam_podrocji.Length > 0)
                        pogoji += $"{leto_meje} AND {seznam_podrocji}";
                    else pogoji += leto_meje;
                }
                else pogoji += seznam_podrocji;
            }
            else pogoji = "";
            try
            {
                povezava.Open();
                SQLiteCommand ukaz = new SQLiteCommand("SELECT * FROM nobel" + pogoji, povezava);
                SQLiteDataReader rez = ukaz.ExecuteReader();
                // Prikažemo nove rezultate
                while (rez.Read())
                {
                    datagridview_rezultati.Rows.Add(rez[0], rez[1], rez[2]);
                }   
            }
            catch (Exception ex)
            {
                throw new Exception($"Napaka: {ex}");
            }
            finally
            {
                povezava.Close();
            }
        }
    }
}