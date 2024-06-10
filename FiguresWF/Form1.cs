using System;
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
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: //квадрат
                    fig = new square((double)size1_numericUpDown.Value);
                    break;
                case 3: //трапеция
                    fig = new trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value,
    (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value, (double)size3_numericUpDown.Value);
                    break;

            }
            protocol_listBox.Items.Add(fig.ToString() + ": S=" + fig.Square());
        }

        private void figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    label2.Text = "Длина";
                    label3.Text = "Ширина";
                    label3.Visible = true;
                    size2_numericUpDown.Visible = true;
                    label5.Visible = false;
                    label4.Visible = false;
                    size3_numericUpDown.Visible = false;
                    size4_numericUpDown.Visible = false;
                    break;

                case 1: //окружность
                    fig = new Circle((double)size1_numericUpDown.Value);
                    label2.Text = "Радиус";
                    label3.Visible = false;
                    size2_numericUpDown.Visible = false;
                    label5.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    size5_numericUpDown.Visible = false;
                    size3_numericUpDown.Visible = false;
                    size4_numericUpDown.Visible = false;
                    break;

                case 2:
                    fig = new square((double)size1_numericUpDown.Value);
                    label2.Text = "Длина";
                    label3.Visible = false;
                    size2_numericUpDown.Visible = false;
                    label5.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    size5_numericUpDown.Visible = false;
                    size3_numericUpDown.Visible = false;
                    size4_numericUpDown.Visible = false;
                    break;
                case 3:
                    fig = new trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value,
                        (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value, (double)size3_numericUpDown.Value);
                    label2.Text = "Длина";
                    label3.Text = "Ширина";
                    label3.Visible = true;
                    size2_numericUpDown.Visible = true;
                    label5.Visible = true;
                    label4.Visible = true;
                    label6.Visible = true;
                    size5_numericUpDown.Visible = true;
                    size3_numericUpDown.Visible = true;
                    size4_numericUpDown.Visible = true;
                    break;

            }
        }

        private void perimetr_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;
                case 1: //окружность
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: //квадрат
                    fig = new square((double)size1_numericUpDown.Value);
                    break;
                case 3: //трапеция
                    fig = new trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value,
    (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value, (double)size3_numericUpDown.Value);
                    break; 
            }
            protocol_listBox.Items.Add(fig.ToString() + ": P=" + fig.Perimetr);
        }
    }
}
