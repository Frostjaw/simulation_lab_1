using simulation_lab_1.Forms;
using System;
using System.Windows.Forms;

namespace simulation_lab_1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void SingleEventButtonClick(object sender, EventArgs e)
        {
            var singleEventForm = new SingleEventForm(this);
            singleEventForm.Show();
            Hide();
        }

        private void eventGroupButton_Click(object sender, EventArgs e)
        {
            var eventGroupForm = new EventGroupForm(this);
            eventGroupForm.Show();
            Hide();
        }
    }
}
