﻿using System;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;
                case 1: //окружность
                    break;
            }
            protocol_listBox.Items.Add(fig.ToString() + ": S=" + fig.Square());
        }
    }
}
