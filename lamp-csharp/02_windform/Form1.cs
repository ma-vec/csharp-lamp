using System.Windows.Forms;

namespace _02_windform
{
    public partial class Form1 : Form
    {
        private Lampadina lampadina;

        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
            lampadina.Posizione = pictureBoxON.Top;  // Inizializza la posizione in base a come è inserita in form
            lampadina.Stato = false;  // Inizializza lo stato della lampadina
            UpdateLamp();
        }

        /* La funzione Accendi/Spegni cambia bool stato
         * poi è chiamata update che agisce sul form in base allo stato assunto dalla bool e aggiorna di conseguenza
         * L'unica funzione che agisce direttamente sul form è update, le altre su variabili (stato, posizione)
         */

        private void UpdateLamp() //Richiamata a ogni modifica cambia lo stato in base a attributo e posizione
        {
            if (lampadina.Stato)
            {
                pictureBoxON.Visible = true;
                pictureBoxOFF.Visible = false;
            }
            else
            {
                pictureBoxON.Visible = false;
                pictureBoxOFF.Visible = true;
            }

            pictureBoxOFF.Top = lampadina.Posizione;
            pictureBoxON.Top = lampadina.Posizione;
        }

        private void accendi_Click(object sender, EventArgs e)
        {
            lampadina.Accendi();
            UpdateLamp();
        }

        private void spegni_Click(object sender, EventArgs e)
        {
            lampadina.Spegni();
            UpdateLamp();
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (lampadina.Posizione > 0)
            {
                lampadina.Alza();
                UpdateLamp();
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (pictureBoxOFF.Height+10 <= this.ClientSize.Height)
            {
                lampadina.Abbassa();
                UpdateLamp();
            }
        }


    }


    public class Lampadina
    {
        private bool stato;
        private int posizione;

        public bool Stato
        {
            get { return stato; }
            set { stato = value; }
        }

        public int Posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }

        public void Accendi()
        {
            Stato = true;
        }

        public void Spegni()
        {
            Stato = false;
        }

        public void Alza()
        {
            Posizione -= 10;
        }

        public void Abbassa()
        {
            Posizione += 10;
        }
    }
}

