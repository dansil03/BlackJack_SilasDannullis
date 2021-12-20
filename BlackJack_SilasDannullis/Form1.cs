using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_SilasDannullis
{
    public partial class AantalSpelers : Form
    {
        Table table = new Table();
        public int Location = 370;
        public int DealerLocation = 135; 
        public List<Label> labels = new List<Label>();
        public int i = 2; 
        
        public AantalSpelers()
        {
            InitializeComponent();
            ShowBeginCards();
        }

        private void ShowBeginCards()
        {
            table.BeginCards();
            for (int i = 0; i < table.players[0].Hand.Count; i++)
            {
                var label = new Label();
                Location = Location + 20; 
                label.Location = new Point(433, Location);
                label.AutoSize = true; 
                label.Text = table.players[0].Hand[i].HeleKaart;
                this.Controls.Add(label);  
                Punten.Text = table.players[0].Value.ToString(); 
            }

            table.DealerBegin();
            var DealerKaarten = new Label();
            DealerKaarten.Location = new Point(433, DealerLocation);
            DealerKaarten.AutoSize = true;
            DealerKaarten.Text = table.dealer.Hand[0].HeleKaart;
            this.Controls.Add(DealerKaarten);
            DealerPunten.Text = table.dealer.Value.ToString(); 
        }        
        public bool DrawClicked = false;
        private void Draw_Click(object sender, EventArgs e)
        {
            table.AddCard();
            var label = new Label();
            Location = Location + 20;
            label.Location = new Point(433, Location);
            label.AutoSize = true;
            label.Text = table.players[0].Hand[i].HeleKaart;
            i = i + 1; 
            this.Controls.Add(label);
            Punten.Text = table.players[0].Value.ToString();
            ControlCards();    
        }
        public void TeVeel()
        {
            table.players.RemoveAt(0);
            table.DealerAdd();
            for (int i = 1; i < table.dealer.Hand.Count; i++)
            {
                var label = new Label();
                DealerLocation = DealerLocation + 20;
                label.Location = new Point(433, DealerLocation);
                label.AutoSize = true;
                label.Text = table.dealer.Hand[i].HeleKaart;
                this.Controls.Add(label);
                DealerPunten.Text = table.dealer.Value.ToString();
            }
            Resultaat();
        }
        public void ControlCards()
        {
            if (table.players[0].Value > 21)
            {
                TeVeel();
            }
            else if (table.players[0].Value == 21)
            {
                TeVeel();
            }            
        }
        public void Resultaat()
        {
            table.Gewonnen();
            if (table.Winn == true)
            {
                ResultaatLabel.Text = "U hebt gewonnon!"; 
            }
            else if(table.Winn == false)
            {
                ResultaatLabel.Text = "U hebt verloren"; 
            }
            else if(table.Push == true)
            {
                ResultaatLabel.Text = "Push!";
            }
        }

        private void Stand_Click(object sender, EventArgs e)
        {
            TeVeel();
        }
        
        
        public void Kaarten_Click(object sender, EventArgs e)
        {
            
        }
        public void ShowCards()
        {

        }

        private void AantalSpelers_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        public void InputAantalSpelers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
