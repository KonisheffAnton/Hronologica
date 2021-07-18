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
using static Program;

namespace WindowsFormsApp1
{



    public partial class Form1 : Form
    {
        Game NewGame = new Game();
        StringBuilder sb = new StringBuilder("");
        public MainMenue MainMenue { get; }
       
        
        public Form1()
        {
            InitializeComponent();
            MethodHandler.FormClose = new MethodHandler.voidDelegator(FormClose);
            
    }

        public Form1(MainMenue mainMenue)
        {
            MainMenue = mainMenue;
        }

        void FormClose()
        {
            this.Close();
        }

        void FullTable(List<Player> innerHand, List<Card> table)
        {
            textBox1.Clear();
            
            for (int i = 0; i < table.Count; i++)
            {
                sb.Clear();
                textBox1.Text += sb.Append($"Событие {table[i].innerText}") + Environment.NewLine;
                sb.Clear();
            }
            
            for (int i = 0; i < 6; i++)
            {

                Controls["Card" + i.ToString()].Text = Convert.ToString(sb);
                sb.Clear();
            }

            for (int i = 0; i < innerHand[NewGame.turn].hand.Count; i++)
            {
                Controls["Card" + i.ToString()].Text = Convert.ToString(sb.Append(innerHand[NewGame.turn].hand[i].innerText));
                sb.Clear();
            }
            CheckCardInHand(NewGame.Сursor);
            label2.Text = Convert.ToString(sb.Append("Карт в колоде " + Convert.ToString(NewGame.stackQ.Count)));
            sb.Clear();
            //label1.Text = Convert.ToString(sb.Append($"Событие {NewGame.playerList[NewGame.turn].hand[NewGame.Сursor].innerText}"));
            sb.Clear();
            label3.Text = Convert.ToString(sb.Append($"Игрок {NewGame.turn + 1}"));
            sb.Clear();
        }

        void CheckCardInHand(int Сursor)
        {
            
            label1.Text = ("Событие " + NewGame.playerList[NewGame.turn].hand[Сursor].innerText +
                " произошло раньше события " + NewGame.StarterCard.innerText + " ?");
           

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
                var Player = new Player(i);
                NewGame.playerList.Add(Player);

                //Раздача начальных карт
                for (int j = 0; j<6; j++)
                {
                    NewGame.playerList[i].PickCard(NewGame.GamePickCard());
                }
            }

            


            //Дабавление начальной карты
            
            NewGame.table.Add(NewGame.GamePickCard());
            NewGame.StarterCard = NewGame.table[0];
            

            
           FullTable(NewGame.playerList, NewGame.table);
            
        }


        private void Earlier_Click(object sender, EventArgs e)
        {
            if (NewGame.playerList[NewGame.turn].hand[NewGame.Сursor].id < NewGame.StarterCard.id)
            {
                NewGame.table.Insert(0, NewGame.playerList[NewGame.turn].hand[NewGame.Сursor]);
                NewGame.playerList[NewGame.turn].DumpCard(NewGame.Сursor);
               
                if (NewGame.playerList[NewGame.turn].hand.Count == 0)
                {
                    MessageBox.Show($"Игрок {NewGame.turn+1} выйграл!");
                    MethodHandler.FormShow();
                }


            }
            else {
                NewGame.playerList[NewGame.turn].DumpCard(NewGame.Сursor);
                NewGame.playerList[NewGame.turn].PickCard(NewGame.GamePickCard());



            }
            if (NewGame.turn == NewGame.playerList.Count-1) { NewGame.turn=0; } else { NewGame.turn++; };
            NewGame.Сursor = 0;
            FullTable(NewGame.playerList, NewGame.table);
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = ($"turn {NewGame.turn} игрок {NewGame.playerList[0].id} игрок {NewGame.playerList[1].id} количесвто карт {NewGame.playerList[NewGame.turn].hand.Count}") + Environment.NewLine+ ($"turn {NewGame.turn} {NewGame.playerList[0].id} количесвто карт {NewGame.playerList[NewGame.turn].hand.Count}" + Environment.NewLine);
            for (int i = 0; i < NewGame.playerList[0].hand.Count; i++)
            {
                textBox2.Text += " nomer sobitiya "+ NewGame.playerList[0].hand[i].id+" текст " + NewGame.playerList[NewGame.turn].hand[i].innerText+ " ";
            }
            textBox2.Text += Environment.NewLine;
            for (int i = 0; i < NewGame.playerList[1].hand.Count; i++)
            {
                textBox2.Text += " nomer sobitiya " + NewGame.playerList[NewGame.turn].hand[i].id + " текст " + NewGame.playerList[NewGame.turn].hand[i].innerText + " ";
            }
            textBox2.Text +=Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MethodHandler.FormShow();
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
                NewGame.playerList[NewGame.turn].DumpCard(NewGame.Сursor);
                if (NewGame.playerList[NewGame.turn].hand.Count == 0)
                {
                    MessageBox.Show($"Игрок {NewGame.turn+1} выйграл!");
                    MethodHandler.FormShow();
                }

            }
            else
            {
                NewGame.playerList[NewGame.turn].DumpCard(NewGame.Сursor);
                NewGame.playerList[NewGame.turn].PickCard(NewGame.GamePickCard());

            }
            if (NewGame.turn == NewGame.playerList.Count - 1) { NewGame.turn = 0; } else { NewGame.turn++; };
            NewGame.Сursor = 0;
            FullTable(NewGame.playerList, NewGame.table);
            
          
        
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
