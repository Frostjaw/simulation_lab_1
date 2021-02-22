
namespace simulation_lab_1.Forms
{
    partial class EventGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.questionTextBoxLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(207, 221);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 22);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(89, 112);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(100, 25);
            this.answerButton.TabIndex = 7;
            this.answerButton.Text = "Получить ответ";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.AnswerButton_click);
            // 
            // questionTextBoxLabel
            // 
            this.questionTextBoxLabel.AutoSize = true;
            this.questionTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBoxLabel.Location = new System.Drawing.Point(75, 18);
            this.questionTextBoxLabel.Name = "questionTextBoxLabel";
            this.questionTextBoxLabel.Size = new System.Drawing.Size(133, 20);
            this.questionTextBoxLabel.TabIndex = 6;
            this.questionTextBoxLabel.Text = "Введите вопрос";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(17, 56);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(250, 50);
            this.questionTextBox.TabIndex = 5;
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.Color.Green;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerTextBox.Location = new System.Drawing.Point(75, 150);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(130, 60);
            this.answerTextBox.TabIndex = 2;
            this.answerTextBox.Text = "ДА";
            this.answerTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerTextBox.Hide();
            // 
            // EventGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.questionTextBoxLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerTextBox);
            this.Name = "EventGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация события из группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label questionTextBoxLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label answerTextBox;
    }
}