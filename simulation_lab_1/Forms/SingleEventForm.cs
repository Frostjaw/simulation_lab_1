using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_lab_1
{
    public partial class SingleEventForm : Form
    {
        private const double PROBABILITY = 0.5;
        private const string YES_STRING = "ДА";
        private const string NO_STRING = "НЕТ";

        private readonly Random _rng;
        private readonly Form _callingForm;

        public SingleEventForm(Form callingForm)
        {
            _rng = new Random();
            _callingForm = callingForm;

            InitializeComponent();
        }

        private void AnswerButton_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(questionTextBox.Text))
            {
                MessageBox.Show("Введите вопрос");

                return;
            }

            var a = _rng.NextDouble();

            if (a < PROBABILITY)
            {
                answerTextBox.BackColor = Color.Green;
                answerTextBox.Text = YES_STRING;
                answerTextBox.Show();

                return;
            }

            answerTextBox.BackColor = Color.Red;
            answerTextBox.Text = NO_STRING;
            answerTextBox.Show();

            return;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            _callingForm.Show();
        }

    }
}
