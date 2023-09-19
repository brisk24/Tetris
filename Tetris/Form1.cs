﻿using System;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.Step(0, 1);
        }
    }
}
