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
        public int id { get; set; }

        public List<Card> hand { get; set; } = new List<Card>();
        internal protected Player(int id)
        {
            this.id = id;
        }
        public void PickCard(Card NewCard)
        {
                this.hand.Add(NewCard);
            }

        public void DumpCard(int CurrentCursor)
        {
            this.hand.RemoveAt(CurrentCursor);

        }
    }
    
}
