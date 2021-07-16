using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {

        Random rnd = new Random();
        public List<Card> stackQ = new List<Card>();
        public List<Player> playerList = new List<Player>();
        public List<Card> table = new List<Card>();
        public new int Cursor = 0;
        public Card StarterCard;
        public int cardId = 0;
        public int turn = 0;
        public int PlayerCount = 4;
        public Form1(Form2 form2)
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void FullTable(List<Player> innerHand, List<Card> table)
        {
            textBox1.Clear();
            for (int i = 0; i < table.Count; i++)
            {
                textBox1.Text += "Событие "+table[i].innerText + Environment.NewLine;
            }
            for (int i = 0; i < 6; i++)
            {
                Controls["button" + i.ToString()].Text = "";
            }
            for (int i = 0; i < innerHand[turn].hand.Count; i++)
            {
                Controls["button" + i.ToString()].Text = innerHand[turn].hand[i].innerText;
            }
            label2.Text = "";
            label2.Text += "Карт в колоде " + Convert.ToString(stackQ.Count);
        }

        void CheckCardInHand(int Cursor)
        {

            label1.Text = "Событие " + playerList[turn].hand[Cursor].innerText +
                " произошло раньше события " + StarterCard.innerText + " ?";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполнение карт
            for (int i = 0; i < 70; i++)
            {
                stackQ.Add(new Card{id = i, innerText = Convert.ToString(i + 1) });
            }
            //Инициализация игроков
            for (int i = 0; i < PlayerCount; i++)
            {
                var Player = new Player(stackQ, rnd);
                Player.id = i;
                playerList.Add(Player);
            }
            //Dobavlenie nachalnoy carty
            cardId = rnd.Next(0, stackQ.Count-1);
            table.Add(stackQ[cardId]);
            StarterCard = stackQ[cardId];
            stackQ.Remove(stackQ[cardId]);

            
            FullTable(playerList, table);
            label1.Text = "Событие "+ playerList[turn].hand[Cursor].innerText;
            label3.Text = "Игрок "+Convert.ToString(turn + 1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerList[turn].hand[Cursor].id < StarterCard.id)
            {
                table.Insert(0, playerList[turn].hand[Cursor]);
                playerList[turn].hand.RemoveAt(Cursor);
        


            }
            else { 
                playerList[turn].hand.RemoveAt(Cursor);
                playerList[turn].PickCard(stackQ, rnd);
                

            }
            if (turn < playerList.Count-1) { turn++; } else { turn = 0; };
            FullTable(playerList, table);
            Cursor = 0;
            label3.Text = "Игрок " + Convert.ToString(turn + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = playerList[turn].id + " количесвто карт "+playerList[turn].hand.Count;//table[i].innerText + Environment.NewLine;
            for (int i = 0; i < playerList[turn].hand.Count; i++)
            {
                textBox2.Text += " nomer sobitiya "+ playerList[turn].hand[i].id+" текст " + playerList[turn].hand[i].innerText+ " ";
            }

            textBox2.Text += " nomer sobitiya на столе " +Environment.NewLine;

            for (int i = 0; i < table.Count; i++)
            {
                textBox2.Text += " nomer sobitiya na stole" + table[i].id + " текст na stole" + table[i].innerText + " ";
            }
            textBox2.Text +=Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button0.Text == "") { Cursor = 0; } else { Cursor = 0; }
            CheckCardInHand(Cursor);
        }

        private void button234_Click(object sender, EventArgs e)
        {
            if (playerList[turn].hand[Cursor].id >= StarterCard.id)
            {
                table.Insert(table.Count, playerList[turn].hand[Cursor]);
                playerList[turn].hand.RemoveAt(Cursor);


            }
            else
            {
                playerList[turn].hand.RemoveAt(Cursor);
                playerList[turn].PickCard(stackQ, rnd);

            }
            if (turn < playerList.Count - 1) { turn++; } else { turn = 0; };
            FullTable(playerList, table);
            Cursor = 0;
            label3.Text = "Игрок " + Convert.ToString(turn + 1);
        
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "") { Cursor = 0; } else { Cursor = 1; }
            CheckCardInHand(Cursor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "") { Cursor = 0; } else { Cursor = 2; }
            CheckCardInHand(Cursor);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "") { Cursor = 0; } else { Cursor = 3; }
            CheckCardInHand(Cursor);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (button4.Text == "") { Cursor = 0; } else { Cursor = 4; }
            CheckCardInHand(Cursor);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (button5.Text == "") { Cursor = 0; } else { Cursor = 5; }
            CheckCardInHand(Cursor);
        }
    }
}
