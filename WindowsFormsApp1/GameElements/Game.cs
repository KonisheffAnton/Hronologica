using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HronologicaForms.GameElements;
using WindowsFormsApp1;

namespace HronologicaForms
{
    public class Game
    {

        public Random rnd { get; set; } = new Random();
        public List<Card> stackQ { get; set; } = new List<Card>();
        public List<Player> playerList { get; set; } = new List<Player>();
        public List<Card> table { get; set; } = new List<Card>();
        public int Сursor { get; set; } = 0;
        public Card StarterCard { get; set; }
        public int cardId { get; set; } = 0;
        public int turn { get; set; } = 0;
        public int PlayerCount { get; set; } = 2;

        public Card GamePickCard()
        {
            int cardId;
            Card CurrentCard = new Card();
            if (this.stackQ.Count > 0)
            {
                cardId = rnd.Next(0, stackQ.Count - 1);
                CurrentCard = this.stackQ[cardId];
                this.stackQ.Remove(this.stackQ[cardId]);
            }
            return CurrentCard; 
        }
        
    }
}
