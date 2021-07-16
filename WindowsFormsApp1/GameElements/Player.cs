using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HronologicaForms.GameElements;
using WindowsFormsApp1;
namespace HronologicaForms
{
   public class Player
    {
        public readonly int id;

        public List<Card> hand { get; set; } = new List<Card>();



        public Player(List<Card> stackQ, int innerid, Random rnd)
        {
            this.id = innerid;
            for (int i = 0; i < 6; i++)
            {
                this.PickCard(stackQ, rnd);
            }
        }

        public void PickCard(List<Card> stackQ, Random rnd)
        {
            int cardId;
            if (stackQ.Count > 0)
            {
                cardId = rnd.Next(0, stackQ.Count - 1);
                this.hand.Add(stackQ[cardId]);
                stackQ.Remove(stackQ[cardId]);
            }
        }
    }
}
