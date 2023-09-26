using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        Board board;
        public Form1()
        {
            InitializeComponent();
            board = new Board(panelBoard);
            timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.Step(0, 1);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            board.Step(-1, 0);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            board.Step(1, 0);
        }

        private void buttonTurn_Click(object sender, EventArgs e)
        {
            board.Turn();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(Form1.ActiveForm == this)
              board.Step(0, 1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           switch(e.KeyCode)
            {          
                case Keys.Left: board.Step(-1, 0); break;
                case Keys.Right: board.Step(1, 0); break;
                case Keys.Down: board.Step(0, 1); break;
                case Keys.Up: board.Turn(); break;
                case Keys.Space: SetPause(); break;
            }
        }
        private void SetPause()
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                labelPause.Visible = true;
            } else
            {
                timer.Enabled = true;
                labelPause.Visible = false;
            }
        }
    }
}
