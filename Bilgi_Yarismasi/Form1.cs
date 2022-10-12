namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruAdet = 10, soruNo = 0, dogru = 0, yanlis = 0;
        char cevap = default;
        char[] keys = { 'B', 'C', 'A', 'D', 'C', 'D', 'A', 'B', 'C', 'A' };
        Color btnOffColor = ColorTranslator.FromHtml("#c0c0ff");
        //Color btnOffColor = Color.FromArgb(192, 192, 255); // veya direkt a�a��daki gibi nesneyi ba�lar�z

        private void ButtonKapat(Button a)
        {
            a.Enabled = false;
            a.BackColor = btnOffColor;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatAppearance.BorderSize = 0;
        }
        private void ButtonAc(Button a)
        {
            a.Enabled = true;
            a.BackColor = DefaultBackColor;
            a.FlatStyle = FlatStyle.Standard;
            a.FlatAppearance.BorderSize = 1;
        }
        private void CevapAnahari()
        {
            bool sonuc = cevap == keys[soruNo - 1] ? true : false;

            dogru += sonuc ? 1 : 0;
            yanlis += !sonuc ? 1 : 0;

            trueGif.Enabled = sonuc ? true : false;
            falseGif.Enabled = sonuc ? false : true;
            trueGif.Visible = sonuc ? true : false;
            falseGif.Visible = sonuc ? false : true;

            lblTrue.Text = dogru.ToString();
            lblFalse.Text = yanlis.ToString();

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trueGif.Enabled = false;
            falseGif.Enabled = false;
            trueGif.Visible = false;
            falseGif.Visible = false;

            ButtonKapat(btnA);
            ButtonKapat(btnB);
            ButtonKapat(btnC);
            ButtonKapat(btnD);

        }
        private void btnA_Click(object sender, EventArgs e)
        {
            cevap = 'A';
            CevapAnahari();
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            cevap = 'B';
            CevapAnahari();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            cevap = 'C';
            CevapAnahari();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            cevap = 'D';
            CevapAnahari();
        }

        private void btnSonra_Click(object sender, EventArgs e)
        {
            trueGif.Visible = false;
            falseGif.Visible = false;

            soruNo++;

            if (soruNo > soruAdet)
            {
                btnSonra.Text = "";
                // btnSonra.BackColor = Color.White; // veya direkt tan�ml� renkler de alabilir

                ButtonKapat(btnA);
                ButtonKapat(btnB);
                ButtonKapat(btnC);
                ButtonKapat(btnD);
                ButtonKapat(btnSonra);
            }
            else
            {
                ButtonAc(btnA);
                ButtonAc(btnB);
                ButtonAc(btnC);
                ButtonAc(btnD);

                btnSonra.Text = soruNo == keys.Length ? "Bitir" : "Sonraki";
            }

            lblSoruNo.Text = soruNo > soruAdet || soruNo == 0 ? "" : (soruNo).ToString();

            richTextBox1.Text = soruNo switch
            {
                1 => "Osmanl� Devleti ka� y�l�nda kurulmu�tur?",
                2 => "T�rkiye�de Erozyonla m�cadele amac�yla kurulan vakf�n k�sa ad� nedir?",
                3 => "Gece g�nd�z e�itli�i (ekinoks) bir y�lda ka� kez ger�ekle�ir?",
                4 => "Mimar Sinan'�n Ustal�k D�nemi eseri say�lan Edirne'deki eserinin ad� nedir?",
                5 => "T�rkiye�nin uluslararas� otomatik telefon kod numaras� ka�t�r?",
                6 => "Tarihte T�rk ad�yla kurulan ilk devlet hangisidir?",
                7 => "Alt�n Palmiye �d�lleri hangi �ehrimizde verilmektedir?",
                8 => "Amerika k�tas�n� 2�ye ay�ran �nemli su ge�idinin ad� nedir?",
                9 => "D�nyan�n ilk haritas�n� �izen �nl� T�rk denizcisi kimdir?",
                10 => "Osmanl� Devleti'nde ilk n�fus say�m� hangi padi�ah zaman�nda yap�lm��t�r?",
                _ => "\n\n\n\t          YARI�MA B�TT�.\n\t             Te�ekk�rler..."
            };

            btnA.TextAlign = ContentAlignment.MiddleLeft;
            btnA.Text = soruNo switch
            {
                1 => "A) 1071",
                2 => "A) KAMA",
                3 => "A) 2",
                4 => "A) S�leymaniye",
                5 => "A) 545",
                6 => "A) Uygur",
                7 => "A) Antalya",
                8 => "A) S�vey�",
                9 => "A) Oru� Reis",
                10 => "A) II. Mahmut",
                _ => ""
            };

            btnB.TextAlign = ContentAlignment.MiddleLeft;
            btnB.Text = soruNo switch
            {
                1 => "B) 1299",
                2 => "B) NASA",
                3 => "B) 3",
                4 => "B) Fatih",
                5 => "B) 80",
                6 => "B) Asur",
                7 => "B) �stanbul",
                8 => "B) Panama",
                9 => "B) Turgut Reis",
                10 => "B) IV. Murat",
                _ => ""
            };

            btnC.TextAlign = ContentAlignment.MiddleLeft;
            btnC.Text = soruNo switch
            {
                1 => "C) 1453",
                2 => "C) TEMA",
                3 => "C) 4",
                4 => "C) K�z Kulesi",
                5 => "C) 90",
                6 => "C) Babil",
                7 => "C) Ankara",
                8 => "C) Cebelitar�k",
                9 => "C) Piri Reis",
                10 => "C) Y�ld�r�m Bayezid",
                _ => ""
            };

            btnD.TextAlign = ContentAlignment.MiddleLeft;
            btnD.Text = soruNo switch
            {
                1 => "D) 1789",
                2 => "D) �EMA",
                3 => "D) 5",
                4 => "D) Selimiye",
                5 => "D) 99",
                6 => "D) G�kt�rk",
                7 => "D) �zmir",
                8 => "D) Bering",
                9 => "D) Reisi Cumhur",
                10 => "D) Fatih",
                _ => ""
            };

        }
    }
}