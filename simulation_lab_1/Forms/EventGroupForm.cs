using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_lab_1.Forms
{
    public partial class EventGroupForm : Form
    {
        private const int N = 20;

        private readonly Random _rng;
        private readonly Form _callingForm;
        private List<double> _probabilitys = new List<double>()
        {
            0.02,
            0.02,
            0.03,
            0.03,
            0.03,
            0.05,
            0.07,
            0.07,
            0.08,
            0.08,
            0.1,
            0.08,
            0.07,
            0.07,
            0.05,
            0.05,
            0.03,
            0.03,
            0.02,
            0.02,
        };
        private List<string> _answers = new List<string>()
        {
            "Бесспорно",
            "Предрешено",
            "Никаких сомнений",
            "Определённо да",
            "Можешь быть уверен в этом",
            "Мне кажется — да",
            "Вероятнее всего",
            "Хорошие перспективы",
            "Знаки говорят — да",
            "Да",
            "Пока не ясно, попробуй снова",
            "Спроси позже",
            "Лучше не рассказывать",
            "Сейчас нельзя предсказать",
            "Сконцентрируйся и спроси опять",
            "Даже не думай",
            "Мой ответ — нет",
            "По моим данным — нет",
            "Перспективы не очень хорошие",
            "Весьма сомнительно",
        };
        private List<Color> _colors = new List<Color>()
        {
            Color.Green,
            Color.Green,
            Color.Green,
            Color.Green,
            Color.Green,
            Color.Blue,
            Color.Blue,
            Color.Blue,
            Color.Blue,
            Color.Blue,
            Color.Orange,
            Color.Orange,
            Color.Orange,
            Color.Orange,
            Color.Orange,
            Color.Red,
            Color.Red,
            Color.Red,
            Color.Red,
            Color.Red,
        };

        public EventGroupForm(Form callingForm)
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

            var aTemp = a;
            for (int i = 0; i < N; i++)
            {
                aTemp -= _probabilitys[i];
                if (aTemp <= 0)
                {
                    answerTextBox.BackColor = _colors[i];
                    answerTextBox.Text = _answers[i];
                    answerTextBox.Show();

                    return;
                }
            }
            
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            Close();
            _callingForm.Show();
        }
    }
}
