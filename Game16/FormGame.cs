using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game16
{
    public partial class FormGame15 : Form
    {

        Game game;

        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button8_Click(object sender, EventArgs e)

        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //utton(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
            if (game.checkFinish()) MessageBox.Show("Вы победили!");
            //button(position).Text = position.ToString();
            //MessageBox.Show(position.ToString());
        }

        //Receve location
        private Button button (int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }

        }

        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {
            game.start();

            //Shuffle numbers
            for (int j = 0; j < 1000; j++)
                game.Shuffle();

            refresh();
        }

        private void refresh()
        {
            int len = 16;
            for (int position = 0; position < len ; position++)
            {
                button(position).Text = game.get_number(position).ToString();
                button(position).Visible = ((game.get_number(position)) > 0);
            }
                
        }

        private void FormGame15_Load(object sender, EventArgs e)
        {
            start_game();
        }
    }
}
