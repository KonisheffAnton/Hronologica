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
using HronologicaForms.GameElements;
using HronologicaForms;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {
        Game NewGame = new Game();

        public Form1(Form2 form2)
        {
            InitializeComponent();
            
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
                Controls["Card" + i.ToString()].Text = "";
            }
            for (int i = 0; i < innerHand[NewGame.turn].hand.Count; i++)
            {
                Controls["Card" + i.ToString()].Text = innerHand[NewGame.turn].hand[i].innerText;
            }
            label2.Text = "";
            label2.Text += "Карт в колоде " + Convert.ToString(NewGame.stackQ.Count);
        }

        void CheckCardInHand(int Сursor)
        {

            label1.Text = "Событие " + NewGame.playerList[NewGame.turn].hand[Сursor].innerText +
                " произошло раньше события " + NewGame.StarterCard.innerText + " ?";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Заполнение карт
            for (int i = 0; i < 70; i++)
            {
                NewGame.stackQ.Add(new Card{id = i, innerText = Convert.ToString(i + 1) });
            }
            //Инициализация игроков
            for (int i = 0; i < NewGame.PlayerCount; i++)
            {
                var Player = new Player(NewGame.stackQ, i, NewGame.rnd);
                NewGame.playerList.Add(Player);
            }
            //Дабавление начальной карты
            NewGame.cardId = NewGame.rnd.Next(0, NewGame.stackQ.Count-1);
            NewGame.table.Add(NewGame.stackQ[NewGame.cardId]);
            NewGame.StarterCard = NewGame.stackQ[NewGame.cardId];
            NewGame.stackQ.Remove(NewGame.stackQ[NewGame.cardId]);

            
            FullTable(NewGame.playerList, NewGame.table);
            label1.Text = "Событие "+ NewGame.playerList[NewGame.turn].hand[NewGame.Сursor].innerText;
            label3.Text = "Игрок "+Convert.ToString(NewGame.turn + 1);
        }


        private void Earlier_Click(object sender, EventArgs e)
        {
            if (NewGame.playerList[NewGame.turn].hand[NewGame.Сursor].id < NewGame.StarterCard.id)
            {
                NewGame.table.Insert(0, NewGame.playerList[NewGame.turn].hand[NewGame.Сursor]);
                NewGame.playerList[NewGame.turn].hand.RemoveAt(NewGame.Сursor);
        


            }
            else {
                NewGame.playerList[NewGame.turn].hand.RemoveAt(NewGame.Сursor);
                NewGame.playerList[NewGame.turn].PickCard(NewGame.stackQ, NewGame.rnd);
                

            }
            if (NewGame.turn < NewGame.playerList.Count-1) { NewGame.turn++; } else { NewGame.turn = 0; };
            FullTable(NewGame.playerList, NewGame.table);
            NewGame.Сursor = 0;
            label3.Text = "Игрок " + Convert.ToString(NewGame.turn + 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = NewGame.playerList[NewGame.turn].id + " количесвто карт "+ NewGame.playerList[NewGame.turn].hand.Count;//table[i].innerText + Environment.NewLine;
            for (int i = 0; i < NewGame.playerList[NewGame.turn].hand.Count; i++)
            {
                textBox2.Text += " nomer sobitiya "+ NewGame.playerList[NewGame.turn].hand[i].id+" текст " + NewGame.playerList[NewGame.turn].hand[i].innerText+ " ";
            }

            textBox2.Text += " nomer sobitiya на столе " +Environment.NewLine;

            for (int i = 0; i < NewGame.table.Count; i++)
            {
                textBox2.Text += "Igrok lubit pisi nomer sobitiya na stole" + NewGame.table[i].id + " текст na stole" + NewGame.table[i].innerText + " ";
            }
            textBox2.Text +=Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Card0.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 0; }
            CheckCardInHand(NewGame.Сursor);
        }

        private void Later_Click(object sender, EventArgs e)
        {
            if (NewGame.playerList[NewGame.turn].hand[NewGame.Сursor].id >= NewGame.StarterCard.id)
            {
                NewGame.table.Insert(NewGame.table.Count, NewGame.playerList[NewGame.turn].hand[NewGame.Сursor]);
                NewGame.playerList[NewGame.turn].hand.RemoveAt(NewGame.Сursor);


            }
            else
            {
                NewGame.playerList[NewGame.turn].hand.RemoveAt(NewGame.Сursor);
                NewGame.playerList[NewGame.turn].PickCard(NewGame.stackQ, NewGame.rnd);

            }
            if (NewGame.turn < NewGame.playerList.Count - 1) { NewGame.turn++; } else { NewGame.turn = 0; };
            FullTable(NewGame.playerList, NewGame.table);
            NewGame.Сursor = 0;
            label3.Text = "Игрок " + Convert.ToString(NewGame.turn + 1);
        
    }

        private void Card1_Click_1(object sender, EventArgs e)
        {
            if (Card1.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 1; }
            CheckCardInHand(NewGame.Сursor);
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (Card2.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 2; }
            CheckCardInHand(NewGame.Сursor);
        }

        private void Card3_Click_1(object sender, EventArgs e)
        {
            if (Card3.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 3; }
            CheckCardInHand(NewGame.Сursor);
        }

        private void Card4_Click_1(object sender, EventArgs e)
        {
            if (Card4.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 4; }
            CheckCardInHand(NewGame.Сursor);
        }

        private void Card5_Click_1(object sender, EventArgs e)
        {
            if (Card5.Text == "") { NewGame.Сursor = 0; } else { NewGame.Сursor = 5; }
            CheckCardInHand(NewGame.Сursor);
        }
    }
}
