namespace Prodavnica
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGlavni = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchNaslov = new System.Windows.Forms.Button();
            this.btnSearchZanr = new System.Windows.Forms.Button();
            this.txtSrchNaslov = new System.Windows.Forms.TextBox();
            this.txtSrchZanr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lbcPopust = new System.Windows.Forms.Label();
            this.lbPopust = new System.Windows.Forms.Label();
            this.lbcNaziv = new System.Windows.Forms.Label();
            this.lbcCena = new System.Windows.Forms.Label();
            this.lbcZanr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lbBrArt = new System.Windows.Forms.Label();
            this.listArtikal = new System.Windows.Forms.ListBox();
            this.listZanr = new System.Windows.Forms.ListBox();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovZanr = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNovZanr = new System.Windows.Forms.TextBox();
            this.btnUkloniNaslov = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNaslovi = new System.Windows.Forms.ComboBox();
            this.btnNovNaslov = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcPopust = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcCena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.tabStat = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.grpRacuni = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateDatumDo = new System.Windows.Forms.DateTimePicker();
            this.dateDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOdjava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUkupna = new System.Windows.Forms.Label();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listRacun = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabGlavni.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabStat.SuspendLayout();
            this.grpRacuni.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabGlavni);
            this.tabControl1.Controls.Add(this.tabAdmin);
            this.tabControl1.Controls.Add(this.tabStat);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 499);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabGlavni
            // 
            this.tabGlavni.Controls.Add(this.label21);
            this.tabGlavni.Controls.Add(this.label20);
            this.tabGlavni.Controls.Add(this.label4);
            this.tabGlavni.Controls.Add(this.btnSearchNaslov);
            this.tabGlavni.Controls.Add(this.btnSearchZanr);
            this.tabGlavni.Controls.Add(this.txtSrchNaslov);
            this.tabGlavni.Controls.Add(this.txtSrchZanr);
            this.tabGlavni.Controls.Add(this.label18);
            this.tabGlavni.Controls.Add(this.btnMinus);
            this.tabGlavni.Controls.Add(this.lbcPopust);
            this.tabGlavni.Controls.Add(this.lbPopust);
            this.tabGlavni.Controls.Add(this.lbcNaziv);
            this.tabGlavni.Controls.Add(this.lbcCena);
            this.tabGlavni.Controls.Add(this.lbcZanr);
            this.tabGlavni.Controls.Add(this.label9);
            this.tabGlavni.Controls.Add(this.label7);
            this.tabGlavni.Controls.Add(this.label8);
            this.tabGlavni.Controls.Add(this.label6);
            this.tabGlavni.Controls.Add(this.btnAdd);
            this.tabGlavni.Controls.Add(this.btnPlus);
            this.tabGlavni.Controls.Add(this.lbBrArt);
            this.tabGlavni.Controls.Add(this.listArtikal);
            this.tabGlavni.Controls.Add(this.listZanr);
            this.tabGlavni.Location = new System.Drawing.Point(4, 25);
            this.tabGlavni.Margin = new System.Windows.Forms.Padding(4);
            this.tabGlavni.Name = "tabGlavni";
            this.tabGlavni.Padding = new System.Windows.Forms.Padding(4);
            this.tabGlavni.Size = new System.Drawing.Size(673, 470);
            this.tabGlavni.TabIndex = 0;
            this.tabGlavni.Text = "Glavni";
            this.tabGlavni.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 16);
            this.label21.TabIndex = 21;
            this.label21.Text = "Pretraga zanrova";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(213, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Pretraga naslova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "<-F1    F2->";
            // 
            // btnSearchNaslov
            // 
            this.btnSearchNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNaslov.Location = new System.Drawing.Point(349, 68);
            this.btnSearchNaslov.Name = "btnSearchNaslov";
            this.btnSearchNaslov.Size = new System.Drawing.Size(61, 22);
            this.btnSearchNaslov.TabIndex = 18;
            this.btnSearchNaslov.Text = "Pretraga";
            this.btnSearchNaslov.UseVisualStyleBackColor = true;
            this.btnSearchNaslov.Click += new System.EventHandler(this.btnSearchNaslov_Click);
            // 
            // btnSearchZanr
            // 
            this.btnSearchZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchZanr.Location = new System.Drawing.Point(142, 70);
            this.btnSearchZanr.Name = "btnSearchZanr";
            this.btnSearchZanr.Size = new System.Drawing.Size(61, 22);
            this.btnSearchZanr.TabIndex = 17;
            this.btnSearchZanr.Text = "Pretraga";
            this.btnSearchZanr.UseVisualStyleBackColor = true;
            this.btnSearchZanr.Click += new System.EventHandler(this.btnSearchZanr_Click);
            // 
            // txtSrchNaslov
            // 
            this.txtSrchNaslov.Location = new System.Drawing.Point(216, 68);
            this.txtSrchNaslov.Name = "txtSrchNaslov";
            this.txtSrchNaslov.Size = new System.Drawing.Size(127, 22);
            this.txtSrchNaslov.TabIndex = 16;
            this.txtSrchNaslov.TextChanged += new System.EventHandler(this.txtSrchNaslov_TextChanged);
            // 
            // txtSrchZanr
            // 
            this.txtSrchZanr.Location = new System.Drawing.Point(9, 70);
            this.txtSrchZanr.Name = "txtSrchZanr";
            this.txtSrchZanr.Size = new System.Drawing.Size(127, 22);
            this.txtSrchZanr.TabIndex = 15;
            this.txtSrchZanr.TextChanged += new System.EventHandler(this.txtSrchZanr_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(438, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "Broj artikala";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(489, 412);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(43, 40);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lbcPopust
            // 
            this.lbcPopust.AutoSize = true;
            this.lbcPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcPopust.Location = new System.Drawing.Point(523, 291);
            this.lbcPopust.Name = "lbcPopust";
            this.lbcPopust.Size = new System.Drawing.Size(17, 16);
            this.lbcPopust.TabIndex = 12;
            this.lbcPopust.Text = "...";
            // 
            // lbPopust
            // 
            this.lbPopust.AutoSize = true;
            this.lbPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPopust.Location = new System.Drawing.Point(439, 291);
            this.lbPopust.Name = "lbPopust";
            this.lbPopust.Size = new System.Drawing.Size(70, 16);
            this.lbPopust.TabIndex = 11;
            this.lbPopust.Text = "Popust(%)";
            // 
            // lbcNaziv
            // 
            this.lbcNaziv.AutoSize = true;
            this.lbcNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcNaziv.Location = new System.Drawing.Point(523, 204);
            this.lbcNaziv.Name = "lbcNaziv";
            this.lbcNaziv.Size = new System.Drawing.Size(17, 16);
            this.lbcNaziv.TabIndex = 10;
            this.lbcNaziv.Text = "...";
            // 
            // lbcCena
            // 
            this.lbcCena.AutoSize = true;
            this.lbcCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcCena.Location = new System.Drawing.Point(523, 249);
            this.lbcCena.Name = "lbcCena";
            this.lbcCena.Size = new System.Drawing.Size(17, 16);
            this.lbcCena.TabIndex = 9;
            this.lbcCena.Text = "...";
            // 
            // lbcZanr
            // 
            this.lbcZanr.AutoSize = true;
            this.lbcZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcZanr.Location = new System.Drawing.Point(523, 159);
            this.lbcZanr.Name = "lbcZanr";
            this.lbcZanr.Size = new System.Drawing.Size(17, 16);
            this.lbcZanr.TabIndex = 8;
            this.lbcZanr.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cena(RSD)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Naslov";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(439, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zanr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pregled proizvoda:";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(542, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj na racun";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(440, 412);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(43, 40);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lbBrArt
            // 
            this.lbBrArt.AutoSize = true;
            this.lbBrArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrArt.ForeColor = System.Drawing.Color.DarkRed;
            this.lbBrArt.Location = new System.Drawing.Point(548, 386);
            this.lbBrArt.Name = "lbBrArt";
            this.lbBrArt.Size = new System.Drawing.Size(27, 20);
            this.lbBrArt.TabIndex = 4;
            this.lbBrArt.Text = "x1";
            // 
            // listArtikal
            // 
            this.listArtikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listArtikal.FormattingEnabled = true;
            this.listArtikal.ItemHeight = 16;
            this.listArtikal.Location = new System.Drawing.Point(216, 96);
            this.listArtikal.Name = "listArtikal";
            this.listArtikal.Size = new System.Drawing.Size(194, 356);
            this.listArtikal.TabIndex = 3;
            this.listArtikal.SelectedIndexChanged += new System.EventHandler(this.listArtikal_SelectedIndexChanged);
            // 
            // listZanr
            // 
            this.listZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listZanr.FormattingEnabled = true;
            this.listZanr.ItemHeight = 16;
            this.listZanr.Location = new System.Drawing.Point(9, 96);
            this.listZanr.Name = "listZanr";
            this.listZanr.Size = new System.Drawing.Size(194, 356);
            this.listZanr.TabIndex = 2;
            this.listZanr.SelectedIndexChanged += new System.EventHandler(this.listZanr_SelectedIndexChanged);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.label5);
            this.tabAdmin.Controls.Add(this.btnNovZanr);
            this.tabAdmin.Controls.Add(this.label14);
            this.tabAdmin.Controls.Add(this.txtNovZanr);
            this.tabAdmin.Controls.Add(this.btnUkloniNaslov);
            this.tabAdmin.Controls.Add(this.label13);
            this.tabAdmin.Controls.Add(this.cmbNaslovi);
            this.tabAdmin.Controls.Add(this.btnNovNaslov);
            this.tabAdmin.Controls.Add(this.label12);
            this.tabAdmin.Controls.Add(this.txtcPopust);
            this.tabAdmin.Controls.Add(this.label11);
            this.tabAdmin.Controls.Add(this.txtcCena);
            this.tabAdmin.Controls.Add(this.label10);
            this.tabAdmin.Controls.Add(this.txtcNaslov);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Controls.Add(this.cmbZanr);
            this.tabAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdmin.Size = new System.Drawing.Size(673, 470);
            this.tabAdmin.TabIndex = 1;
            this.tabAdmin.Text = "Administracija";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "<-F1    F2->";
            // 
            // btnNovZanr
            // 
            this.btnNovZanr.Location = new System.Drawing.Point(291, 307);
            this.btnNovZanr.Name = "btnNovZanr";
            this.btnNovZanr.Size = new System.Drawing.Size(181, 30);
            this.btnNovZanr.TabIndex = 19;
            this.btnNovZanr.Text = "Dodaj zanr";
            this.btnNovZanr.UseVisualStyleBackColor = true;
            this.btnNovZanr.Click += new System.EventHandler(this.btnNovZanr_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Nov zanr";
            // 
            // txtNovZanr
            // 
            this.txtNovZanr.Location = new System.Drawing.Point(291, 254);
            this.txtNovZanr.Name = "txtNovZanr";
            this.txtNovZanr.Size = new System.Drawing.Size(181, 22);
            this.txtNovZanr.TabIndex = 17;
            this.txtNovZanr.TextChanged += new System.EventHandler(this.txtNovZanr_TextChanged);
            // 
            // btnUkloniNaslov
            // 
            this.btnUkloniNaslov.Location = new System.Drawing.Point(291, 130);
            this.btnUkloniNaslov.Name = "btnUkloniNaslov";
            this.btnUkloniNaslov.Size = new System.Drawing.Size(181, 30);
            this.btnUkloniNaslov.TabIndex = 16;
            this.btnUkloniNaslov.Text = "Ukloni postojeci naslov";
            this.btnUkloniNaslov.UseVisualStyleBackColor = true;
            this.btnUkloniNaslov.Click += new System.EventHandler(this.btnUkloniNaslov_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Postojeci naslovi";
            // 
            // cmbNaslovi
            // 
            this.cmbNaslovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaslovi.FormattingEnabled = true;
            this.cmbNaslovi.Location = new System.Drawing.Point(291, 62);
            this.cmbNaslovi.Name = "cmbNaslovi";
            this.cmbNaslovi.Size = new System.Drawing.Size(181, 24);
            this.cmbNaslovi.TabIndex = 14;
            this.cmbNaslovi.SelectedIndexChanged += new System.EventHandler(this.cmbNaslovi_SelectedIndexChanged);
            // 
            // btnNovNaslov
            // 
            this.btnNovNaslov.Location = new System.Drawing.Point(40, 307);
            this.btnNovNaslov.Name = "btnNovNaslov";
            this.btnNovNaslov.Size = new System.Drawing.Size(181, 30);
            this.btnNovNaslov.TabIndex = 13;
            this.btnNovNaslov.Text = "Dodaj nov naslov";
            this.btnNovNaslov.UseVisualStyleBackColor = true;
            this.btnNovNaslov.Click += new System.EventHandler(this.btnNovNaslov_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Popust";
            // 
            // txtcPopust
            // 
            this.txtcPopust.Location = new System.Drawing.Point(40, 254);
            this.txtcPopust.Name = "txtcPopust";
            this.txtcPopust.Size = new System.Drawing.Size(181, 22);
            this.txtcPopust.TabIndex = 6;
            this.txtcPopust.TextChanged += new System.EventHandler(this.txtcPopust_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Cena(RSD)";
            // 
            // txtcCena
            // 
            this.txtcCena.Location = new System.Drawing.Point(40, 196);
            this.txtcCena.Name = "txtcCena";
            this.txtcCena.Size = new System.Drawing.Size(181, 22);
            this.txtcCena.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Naslov";
            // 
            // txtcNaslov
            // 
            this.txtcNaslov.Location = new System.Drawing.Point(40, 138);
            this.txtcNaslov.Name = "txtcNaslov";
            this.txtcNaslov.Size = new System.Drawing.Size(181, 22);
            this.txtcNaslov.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zanr";
            // 
            // cmbZanr
            // 
            this.cmbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(40, 62);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(181, 24);
            this.cmbZanr.TabIndex = 0;
            this.cmbZanr.SelectedIndexChanged += new System.EventHandler(this.cmbZanr_SelectedIndexChanged);
            // 
            // tabStat
            // 
            this.tabStat.Controls.Add(this.label19);
            this.tabStat.Controls.Add(this.grpRacuni);
            this.tabStat.Controls.Add(this.label17);
            this.tabStat.Controls.Add(this.label16);
            this.tabStat.Controls.Add(this.label15);
            this.tabStat.Controls.Add(this.dateDatumDo);
            this.tabStat.Controls.Add(this.dateDatumOd);
            this.tabStat.Location = new System.Drawing.Point(4, 25);
            this.tabStat.Name = "tabStat";
            this.tabStat.Padding = new System.Windows.Forms.Padding(3);
            this.tabStat.Size = new System.Drawing.Size(673, 470);
            this.tabStat.TabIndex = 2;
            this.tabStat.Text = "Statistika";
            this.tabStat.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "<-F1    F2->";
            // 
            // grpRacuni
            // 
            this.grpRacuni.Controls.Add(this.panel1);
            this.grpRacuni.Location = new System.Drawing.Point(6, 196);
            this.grpRacuni.Name = "grpRacuni";
            this.grpRacuni.Size = new System.Drawing.Size(661, 268);
            this.grpRacuni.TabIndex = 5;
            this.grpRacuni.TabStop = false;
            this.grpRacuni.Text = "Postojeci racuni:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 241);
            this.panel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(517, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Prikaz racuna za odabrani vremenski period, odaberite datume da bi racuni bili vi" +
    "dljivi.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Datum od";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Datum do";
            // 
            // dateDatumDo
            // 
            this.dateDatumDo.Location = new System.Drawing.Point(27, 134);
            this.dateDatumDo.Name = "dateDatumDo";
            this.dateDatumDo.Size = new System.Drawing.Size(238, 22);
            this.dateDatumDo.TabIndex = 1;
            this.dateDatumDo.ValueChanged += new System.EventHandler(this.dateDatumDo_ValueChanged);
            // 
            // dateDatumOd
            // 
            this.dateDatumOd.Location = new System.Drawing.Point(27, 79);
            this.dateDatumOd.Name = "dateDatumOd";
            this.dateDatumOd.Size = new System.Drawing.Size(238, 22);
            this.dateDatumOd.TabIndex = 0;
            this.dateDatumOd.ValueChanged += new System.EventHandler(this.dateDatumOd_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(857, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(764, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(16, 521);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(183, 40);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lbUkupna);
            this.groupBox1.Controls.Add(this.btnIzdaj);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listRacun);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(704, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 484);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled racuna";
            // 
            // lbUkupna
            // 
            this.lbUkupna.AutoSize = true;
            this.lbUkupna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUkupna.ForeColor = System.Drawing.Color.DarkRed;
            this.lbUkupna.Location = new System.Drawing.Point(6, 420);
            this.lbUkupna.Name = "lbUkupna";
            this.lbUkupna.Size = new System.Drawing.Size(62, 24);
            this.lbUkupna.TabIndex = 11;
            this.lbUkupna.Text = "0RSD";
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.Location = new System.Drawing.Point(6, 448);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(100, 30);
            this.btnIzdaj.TabIndex = 12;
            this.btnIzdaj.Text = "Izdaj racun";
            this.btnIzdaj.UseVisualStyleBackColor = true;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ukloni sa racuna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listRacun
            // 
            this.listRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRacun.FormattingEnabled = true;
            this.listRacun.HorizontalScrollbar = true;
            this.listRacun.ItemHeight = 16;
            this.listRacun.Location = new System.Drawing.Point(6, 42);
            this.listRacun.Name = "listRacun";
            this.listRacun.Size = new System.Drawing.Size(237, 372);
            this.listRacun.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(205, 521);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Osvezi (F5)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearchZanr;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavnica";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabGlavni.ResumeLayout(false);
            this.tabGlavni.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            this.tabStat.ResumeLayout(false);
            this.tabStat.PerformLayout();
            this.grpRacuni.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGlavni;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabStat;
        private System.Windows.Forms.ListBox listArtikal;
        private System.Windows.Forms.ListBox listZanr;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lbBrArt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbcNaziv;
        private System.Windows.Forms.Label lbcCena;
        private System.Windows.Forms.Label lbcZanr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listRacun;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.Label lbUkupna;
        private System.Windows.Forms.Label lbPopust;
        private System.Windows.Forms.Label lbcPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcNaslov;
        private System.Windows.Forms.Button btnUkloniNaslov;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNaslovi;
        private System.Windows.Forms.Button btnNovNaslov;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcPopust;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcCena;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNovZanr;
        private System.Windows.Forms.Button btnNovZanr;
        private System.Windows.Forms.DateTimePicker dateDatumDo;
        private System.Windows.Forms.DateTimePicker dateDatumOd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpRacuni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearchNaslov;
        private System.Windows.Forms.Button btnSearchZanr;
        private System.Windows.Forms.TextBox txtSrchNaslov;
        private System.Windows.Forms.TextBox txtSrchZanr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRefresh;
    }
}

