using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
   

   public struct Card
    {
        public int id { get; set; }
        public string innerText { get; set; }
       
    }
   public class Player
    {
        public int id { get; set; }

        public List<Card> hand { get; set; } = new List<Card>();
        public Player(List<Card> stackQ, Random rnd)
        {
           for (int i = 0; i<6; i++)
            {
                this.PickCard(stackQ,rnd);
            }
        }

        public void PickCard(List<Card> stackQ, Random rnd)
        {
            int cardId;
            if (stackQ.Count > 0)
            {
                cardId = rnd.Next(0, stackQ.Count-1);
                this.hand.Add(stackQ[cardId]);
                stackQ.Remove(stackQ[cardId]);
            }
        }

         

          }
    }


    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

                 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    
}

