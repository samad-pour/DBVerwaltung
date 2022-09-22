using System.Drawing;
using System.Data.OleDb;
using System.Xml.Linq;

namespace DBVerwaltung
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private List<int> pnummer = new List<int>();

        public Form1()
        {
            InitializeComponent();

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Users\\samad.pour\\source\\repos\\DB\\firma.accdb";
            cmd.Connection = con;
        }

        private void BtnAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen();
        }

        private void AlleSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen";
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            TxtName.Text = "";
            TxtVorname.Text = "";
            TxtPersonalnummer.Text = "";
            TxtGehalt.Text = "";
            TxtGeburtstag.Text = "";
        }

        private void Ausgabe()
        {
            DateTime geburtstag;

            reader = cmd.ExecuteReader();
            LstDisplay.Items.Clear();
            pnummer.Clear();

            while (reader.Read())
            {
                geburtstag = Convert.ToDateTime(reader["geburtstag"]);

                LstDisplay.Items.Add(reader["name"] + " # " +
                    reader["vorname"] + " # " +
                    reader["personalnummer"] + " # " +
                    reader["gehalt"] + " # " +
                    geburtstag.ToShortDateString());
                pnummer.Add((int)reader["personalnummer"]);
            }
            reader.Close();
        }

        private void BtnEinfuegen_Click(object sender, EventArgs e)
        {
            int anzahl;

            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO personen (name, vorname," +
                    " personalnummer, gehalt, geburtstag) VALUES ('" +
                    TxtName.Text + "', '" + TxtVorname.Text + "', " +
                    TxtPersonalnummer.Text + ", " + TxtGehalt.Text.
                    Replace(',', '.') + ", '" + TxtGeburtstag.Text + "')";
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte mindestens einen Namen, eine " +
                    "eindeutige Personalnummer und ein gültiges " +
                    "Geburtsdatum eintragen");
            }

            con.Close();
            AlleSehen();
        }

        private void LstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime geburtstag;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen WHERE " +
                "personalnummer = " + pnummer[LstDisplay.SelectedIndex];

                reader = cmd.ExecuteReader();
                reader.Read();

                TxtName.Text = "" + reader["name"];
                TxtVorname.Text = "" + reader["vorname"];
                TxtPersonalnummer.Text = "" + reader["personalnummer"];
                TxtGehalt.Text = "" + reader["gehalt"];
                geburtstag = Convert.ToDateTime(reader["geburtstag"]);
                TxtGeburtstag.Text = geburtstag.ToShortDateString();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void Btnaendern_Click(object sender, EventArgs e)
        {
            if (TxtPersonalnummer.Text == "")
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            try
            {
                con.Open();
                cmd.CommandText = "UPDATE personen SET name = '" +
                    TxtName.Text + "', vorname = '" + TxtVorname.Text +
                    "', personalnummer = " + TxtPersonalnummer.Text +
                    ", gehalt = " + TxtGehalt.Text.Replace(',', '.') +
                    ", geburtstag = '" + TxtGeburtstag.Text + "' WHERE " +
                    "personalnummer = " + pnummer[LstDisplay.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte einen Datensatz auswählen und " +
                    "mindestens einen Namen, eine eindeutige Personal" +
                    "nummer und ein gültiges Geburtsdatum eintragen");
            }

            con.Close();
            AlleSehen();
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            if (TxtPersonalnummer.Text == "")
            {
                MessageBox.Show("Bitte einen Datensatz auswählen");
                return;
            }

            if (MessageBox.Show("Wollen Sie den ausgewählten " +
                    "Datensatz wirklich löschen?", "Löschen",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM personen WHERE " +
                    "personalnummer = " + pnummer[LstDisplay.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            AlleSehen();
        }

        private void BtnNameSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM personen WHERE " +
                "name LIKE '%" + TxtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}