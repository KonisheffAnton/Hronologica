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
using static Program;
using HronologicaForms.GameElements;

namespace HronologicaForms
{
    public partial class MainMenue : Form
    {
        
        public int PlayerCount { get; set; } = 2;
        public Form Form1;
        public MainMenue()
        {
            InitializeComponent();
            MethodHandler.EventHandler = new MethodHandler.MyEvent(PlayerCountMain);
            MethodHandler.FormShow = new MethodHandler.voidDelegator(FormShow);
        }
        int PlayerCountMain()
        {
            return Convert.ToInt32(PlayersBox.SelectedItem);
        }
        void FormShow()
        {
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1 != null) { MethodHandler.FormClose(); }
            this.PlayerCount = Convert.ToInt32(PlayersBox.SelectedItem);
            Form1 = new Form1();
            Form1.Show();
            this.Visible = false;

        }

        private void MainMenue_Load(object sender, EventArgs e)
        {
            PlayersBox.SelectedItem = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
