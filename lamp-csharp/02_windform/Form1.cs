namespace _02_windform
{
    public partial class Form1 : Form
    {
        // Dichiarazione della costante deltaY a livello di classe
        private const int deltaY = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void accendi_Click(object sender, EventArgs e)
        {
            pictureBoxON.Visible = true;
            pictureBoxOFF.Visible = false;
        }

        private void spegni_Click(object sender, EventArgs e)
        {
            pictureBoxON.Visible = false;
            pictureBoxOFF.Visible = true;
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void up_Click(object sender, EventArgs e)
        {
            // Calcolo della nuova coordinata Y
            int newY = pictureBoxOFF.Location.Y - deltaY;
            if (newY >= 0)
            {
                // Sposta entrambe le PictureBox verso l'alto
                pictureBoxOFF.Location = new Point(pictureBoxOFF.Location.X, newY);
                pictureBoxON.Location = new Point(pictureBoxON.Location.X, newY);
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            // Calcolo della nuova coordinata Y
            int newY = pictureBoxOFF.Location.Y + deltaY;
            if (newY + pictureBoxOFF.Height <= this.ClientSize.Height)
            {
                // Sposta entrambe le PictureBox verso l'alto
                pictureBoxOFF.Location = new Point(pictureBoxOFF.Location.X, newY);
                pictureBoxON.Location = new Point(pictureBoxON.Location.X, newY);
            }
        }
    }
}
