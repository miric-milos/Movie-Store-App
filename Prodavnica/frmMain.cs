using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Prodavnica
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSrchZanr;
            Thread t = new Thread(Administracija);
            t.Start(); t.Join(); txtSrchZanr.Focus();
            string q = "select distinct nazivzanr from zanrovi order by nazivzanr asc";
            try
            {
                DBManager.Connection.Open();
                var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
                while (reader.Read())
                {
                    listZanr.Items.Add(reader["NazivZanr"]);
                }
                DBManager.Connection.Close();
            }
            catch { DBManager.Connection.Close(); }
            finally { DBManager.Connection.Close(); }
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnIzdaj.Focus();
            var ukupna = float.Parse(new String(lbUkupna.Text.Where(Char.IsDigit).ToArray()));
            var popust = float.Parse(lbcPopust.Text);
            int cenaSaPopustom = (int)Math.Round(float.Parse(lbcCena.Text) * (1 - (popust / 100)));

            var cena = float.Parse(new String(lbBrArt.Text.Where(Char.IsDigit).ToArray())) * cenaSaPopustom;
            ukupna += cena; lbUkupna.Text = ukupna.ToString() + "RSD";
            listRacun.Items.Add(lbBrArt.Text + " " + lbcNaziv.Text + "  -  " + cena.ToString());
        }

        static int brArtikala = 1;

        private void listZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listArtikal.Items.Clear(); btnAdd.Enabled = false;
                lbBrArt.Text = "x1";

                string q = "select naziv from artikal" +
                    " where id_artikal in" +
                    "(select id_artikal from grupe where id_zanr in" +
                    "(select id_zanr from zanrovi where nazivzanr= '" + listZanr.SelectedItem.ToString() + "')) ";
                try
                {
                    DBManager.Connection.Open();
                    var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
                    while (reader.Read())
                    {
                        listArtikal.Items.Add(reader["Naziv"]);
                    }
                    DBManager.Connection.Close();
                }
                finally { DBManager.Connection.Close(); }
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void listArtikal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
            brArtikala = 1; lbBrArt.Text = "x" + brArtikala;
            try
            {
                string q = "select cena, popust from artikal where naziv = '" + listArtikal.SelectedItem.ToString() + "'";
                try
                {
                    DBManager.Connection.Open();
                    var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
                    while (reader.Read())
                    {
                        lbcCena.Text = reader["cena"].ToString();
                        lbcPopust.Text = reader["popust"].ToString();
                        btnAdd.Enabled = true;
                    }

                    DBManager.Connection.Close();
                }
                finally { DBManager.Connection.Close(); }
                lbcNaziv.Text = listArtikal.SelectedItem.ToString(); lbcZanr.Text = listZanr.SelectedItem.ToString();
            }
            catch { }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            var ukupnaCena = int.Parse(new String(lbUkupna.Text.Where(Char.IsDigit).ToArray()));
            string q = "insert into racun(cena, datum, vreme) " +
                       "values(@ukupnaCena, @datum, @vreme)";

            var cmd = new OleDbCommand(q, DBManager.Connection);
            cmd.Parameters.AddWithValue("ukupnaCena", ukupnaCena);
            cmd.Parameters.AddWithValue("datum", DateTime.Now.ToShortDateString());
            cmd.Parameters.AddWithValue("vreme", DateTime.Now.ToShortTimeString());

            if (listRacun.Items.Count.Equals(0)) MessageBox.Show("Prazan racun");
            else
            {
                DBManager.RunQuery(q, cmd);
                MessageBox.Show("Stampam racun.");
            }

            listRacun.Items.Clear();
            this.Invoke(new delOsvezi(osveziFormu));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ukupna = int.Parse(new String(lbUkupna.Text.Where(Char.IsDigit).ToArray()));
                string[] brojevi = Regex.Split(listRacun.SelectedItem.ToString(), @"\D+");
                var cena = ukupna - int.Parse(brojevi[2]);
                lbUkupna.Text = cena + "RSD";

                listRacun.Items.Remove(listRacun.SelectedItem);
            }
            catch { MessageBox.Show("Prazan racun"); }
        }

        private void Administracija()
        {
            string q = "select distinct nazivzanr from zanrovi order by nazivzanr asc";
            try
            {
                DBManager.Connection.Open();
                var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
                while (reader.Read())
                {
                    cmbZanr.Items.Add(reader["nazivzanr"]);
                }
                DBManager.Connection.Close();
            }
            catch { DBManager.Connection.Close(); }
            finally { DBManager.Connection.Close(); }
        }

        private void btnNovNaslov_Click(object sender, EventArgs e)
        {
            string q = "insert into artikal(naziv, cena, popust) " +
                       "values(@naziv, @cena, @popust)";
            string q2 = "insert into grupe " +
                        "select id_zanr, id_artikal from zanrovi, artikal " +
                        "where zanrovi.nazivzanr = @zanr " +
                        "and artikal.naziv = @naslov";

            var cmd = new OleDbCommand(q, DBManager.Connection);
            cmd.Parameters.AddWithValue("naziv", txtcNaslov.Text);
            cmd.Parameters.AddWithValue("cena", int.Parse(txtcCena.Text));
            cmd.Parameters.AddWithValue("popust", int.Parse(txtcPopust.Text));

            var cmd2 = new OleDbCommand(q2, DBManager.Connection);
            cmd2.Parameters.AddWithValue("@zanr", cmbZanr.SelectedItem);
            cmd2.Parameters.AddWithValue("@naslov", txtcNaslov.Text);

            DBManager.RunQuery(q, cmd);
            DBManager.RunQuery(q2, cmd2);

            foreach (var txt in tabAdmin.Controls.OfType<TextBox>())
                if (txt.Name.StartsWith("txtc")) { txt.Clear(); txtcNaslov.Focus(); }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (brArtikala != 1)
                lbBrArt.Text = "x" + --brArtikala;
            else brArtikala = 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lbBrArt.Text = "x" + ++brArtikala;
        }

        private void btnUkloniNaslov_Click(object sender, EventArgs e)
        {
            if (cmbNaslovi.Text.Equals("")) MessageBox.Show("Prazno polje");
            else
            {
                string q = "delete from artikal where naziv = @naslov";
                var cmd = new OleDbCommand(q, DBManager.Connection);
                cmd.Parameters.AddWithValue("@naslov", cmbNaslovi.SelectedItem);

                DBManager.RunQuery(q, cmd);cmbNaslovi.Items.Remove(cmbNaslovi.SelectedItem);
            }
        }

        private void cmbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNaslovi.Items.Clear(); txtcNaslov.Focus();
            string q = "select distinct naziv from artikal" +
                    " where id_artikal in" +
                    "(select id_artikal from grupe where id_zanr in" +
                    "(select id_zanr from zanrovi where nazivzanr= '" + cmbZanr.SelectedItem + "')) ";
            DBManager.Connection.Open();
            var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
            while (reader.Read())
                cmbNaslovi.Items.Add(reader["naziv"]);
            DBManager.Connection.Close();
        }

        private void btnNovZanr_Click(object sender, EventArgs e)
        {
            if (txtNovZanr.Text.Equals("")) MessageBox.Show("Prazno polje.");
            else
            {
                string q = "insert into zanrovi(nazivzanr) " +
                    "values(@nazivZanra)";

                var cmd = new OleDbCommand(q, DBManager.Connection);
                cmd.Parameters.AddWithValue("nazivZanra", txtNovZanr.Text);
                DBManager.RunQuery(q, cmd);cmbZanr.Items.Add(txtNovZanr.Text);
                MessageBox.Show("Dodato"); txtNovZanr.Clear();
            }
        }

        private void dateDatumDo_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PrikaziRacune();
        }

        private void PrikaziRacune()
        {
            var Od = Convert.ToDateTime(dateDatumOd.Text);
            var Do = Convert.ToDateTime(dateDatumDo.Text);
            if (Od.Date < Do.Date)
            {
                string q = "select distinct * from racun " +
                            "where datum between " +
                            " #" + dateDatumOd.Value.ToShortDateString() + "# and " +
                            " #" + dateDatumDo.Value.ToShortDateString() + "#";
                int top = 20, i = 0;
                try
                {
                    DBManager.Connection.Open();
                    var reader = new OleDbCommand(q, DBManager.Connection).ExecuteReader();
                    while (reader.Read())
                    {
                        var lb = new Label(); lb.Name = "lb" + i++; lb.Left = 10; lb.Top = top; lb.AutoSize = true;

                        DateTime datum = Convert.ToDateTime(reader["datum"]);
                        lb.Text = reader["cena"] + "RSD  -  " +
                            datum.ToShortDateString() +
                            "  -  " + reader["vreme"];
                        panel1.Controls.Add(lb); top += 22;
                    }
                    DBManager.Connection.Close();
                }
                finally { DBManager.Connection.Close(); }
            }
        }

        private void dateDatumOd_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PrikaziRacune();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            switch (e.KeyCode)
            {
                case Keys.NumPad8:
                    btnPlus.PerformClick();
                    btnAdd.Focus();
                    break;
                case Keys.NumPad2:
                    btnMinus.PerformClick();
                    break;
                case Keys.F1:
                    if (i == 2 || i == 1)
                        tabControl1.SelectedIndex = --i;
                    break;
                case Keys.F2:
                    if (i == 0 || i == 1)
                        tabControl1.SelectedIndex = ++i;
                    break;
                case Keys.W:
                    listZanr.SelectedIndex = listZanr.Items.Count - 1;
                    break;
                case Keys.Delete:
                    button1.PerformClick();
                    break;
                case Keys.F5:
                    btnRefresh.PerformClick();
                    break;
                case Keys.Down:
                    if (txtcNaslov.Focused) txtcCena.Focus();
                    else txtcPopust.Focus();
                    break;
                case Keys.Up:
                    if (txtcPopust.Focused) txtcCena.Focus();
                    else txtcNaslov.Focus();
                    break;
            }
        }

        private delegate void SearchDelegate(ListBox ls, TextBox txt);

        private void SearchList(ListBox ls, TextBox txt)
        {
            var item = ls.Items;
            for (int i = 0; i < item.Count; i++)
                if (txtSrchZanr.Text.Equals(item[i].ToString()) ||
                    item[i].ToString().StartsWith(txt.Text))
                    ls.SelectedItem = item[i];
        }

        private void btnSearchZanr_Click(object sender, EventArgs e)
        {
            SearchDelegate search = new SearchDelegate(SearchList);
            search(listZanr, txtSrchZanr);
            txtSrchNaslov.Focus();
        }

        private void btnSearchNaslov_Click(object sender, EventArgs e)
        {
            SearchDelegate search = new SearchDelegate(SearchList);
            search(listArtikal, txtSrchNaslov);

        }

        private void txtSrchNaslov_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchNaslov;
        }

        private void txtSrchZanr_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearchZanr;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.ActiveControl = txtSrchZanr;
                    break;
                case 1:
                    this.ActiveControl = cmbZanr;
                    break;
            }
        }

        private delegate void delOsvezi();

        private void osveziFormu()
        {
            this.Invalidate();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    listArtikal.Items.Clear();
                    txtSrchNaslov.Clear();
                    txtSrchZanr.Clear();
                    txtSrchZanr.Focus();
                    foreach (var lb in tabGlavni.Controls.OfType<Label>())
                        if (lb.Name.StartsWith("lbc")) lb.Text = "...";
                    break;
                case 2:
                    dateDatumOd.Value = DateTime.Now;
                    dateDatumDo.Value = DateTime.Now;
                    break;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new delOsvezi(osveziFormu));
        }

        private void txtcPopust_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnNovNaslov;
        }

        private void cmbNaslovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUkloniNaslov.Focus();
        }

        private void txtNovZanr_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnNovZanr;
        }
    }
}
