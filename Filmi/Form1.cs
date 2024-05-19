using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Filmi
{
    public partial class Form1: Form
    {
        private const string pov_niz = "Data source = filmi.sqlite; Version = 3;";
        int od_leta, do_leta, ocena;
        string ime_pogoj, leto_meje, ocena_pogoj, pogoji;

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
            if (ime_textbox.Text.Length > 0)
                ime_pogoj = $"reziser == '{ime_textbox.Text}'";
            else ime_pogoj = "";
            if (int.TryParse(od_leta_textbox.Text, out od_leta))
            {
                if (int.TryParse(do_leta_textbox.Text, out do_leta))
                    leto_meje = $"leto >= {od_leta} AND leto <= {do_leta}";
                else leto_meje = $"leto >= {od_leta}";
            }
            else if (int.TryParse(do_leta_textbox.Text, out do_leta))
                leto_meje = $"leto <= {do_leta}";
            else
                leto_meje = "";
            if (comboBox_ocena.Text.Length > 0 && ocena_textbox.Text.Length > 0 && int.TryParse(ocena_textbox.Text, out ocena))
                ocena_pogoj = $"ocena {comboBox_ocena.Text} {ocena}";
            else ocena_pogoj = "";
            if (ime_pogoj.Length > 0 || leto_meje.Length > 0 || ocena_pogoj.Length > 0)
            {
                pogoji = " WHERE ";
                if (ime_pogoj.Length > 0)
                {
                    if (leto_meje.Length > 0)
                    {
                        if (ocena_pogoj.Length > 0)
                            pogoji += $"{ime_pogoj} AND {leto_meje} AND {ocena_pogoj}";
                        else pogoji += $"{ime_pogoj} AND {leto_meje}";
                    }
                    else if (ocena_pogoj.Length > 0)
                        pogoji += $"{ime_pogoj} AND {ocena_pogoj}";
                    else pogoji += $"{ime_pogoj}";
                }
                else if (leto_meje.Length > 0)
                {
                    if (ocena_pogoj.Length > 0)
                        pogoji += $"{leto_meje} AND {ocena_pogoj}";
                    else pogoji += $"{leto_meje}";
                }
                else pogoji += $"{ocena_pogoj}";
            }
            else pogoji = "";
            try
            {
                povezava.Open();
                SQLiteCommand ukaz = new SQLiteCommand("SELECT * FROM filmi " + pogoji, povezava);
                SQLiteDataReader rez = ukaz.ExecuteReader();
                // Prikažemo nove rezultate
                while (rez.Read())
                {
                    datagridview_rezultati.Rows.Add(rez[1], rez[2], rez[3], rez[6]);
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