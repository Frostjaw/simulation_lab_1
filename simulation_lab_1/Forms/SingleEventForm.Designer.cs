
namespace simulation_lab_1
{
    partial class SingleEventForm
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
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBoxLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(22, 64);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(250, 50);
            this.questionTextBox.TabIndex = 0;
            // 
            // questionTextBoxLabel
            // 
            this.questionTextBoxLabel.AutoSize = true;
            this.questionTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextBoxLabel.Location = new System.Drawing.Point(80, 26);
            this.questionTextBoxLabel.Name = "questionTextBoxLabel";
            this.questionTextBoxLabel.Size = new System.Drawing.Size(133, 20);
            this.questionTextBoxLabel.TabIndex = 1;
            this.questionTextBoxLabel.Text = "Введите вопрос";
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.Color.Green;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerTextBox.Location = new System.Drawing.Point(84, 159);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(120, 50);
            this.answerTextBox.TabIndex = 2;
            this.answerTextBox.Text = "ДА";
            this.answerTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerTextBox.Hide();
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(94, 120);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(100, 25);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Получить ответ";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.AnswerButton_click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(212, 229);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 22);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SingleEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBoxLabel);
            this.Controls.Add(this.questionTextBox);
            this.Name = "SingleEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация одного события";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label questionTextBoxLabel;
        private System.Windows.Forms.Label answerTextBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button backButton;
    }
}