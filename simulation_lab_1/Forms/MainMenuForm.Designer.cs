
namespace simulation_lab_1
{
    partial class MainMenuForm
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
            this.singleEventButton = new System.Windows.Forms.Button();
            this.eventGroupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singleEventButton
            // 
            this.singleEventButton.Location = new System.Drawing.Point(279, 151);
            this.singleEventButton.Name = "singleEventButton";
            this.singleEventButton.Size = new System.Drawing.Size(200, 50);
            this.singleEventButton.TabIndex = 0;
            this.singleEventButton.Text = "Генерация одного события";
            this.singleEventButton.UseVisualStyleBackColor = true;
            this.singleEventButton.Click += new System.EventHandler(this.SingleEventButtonClick);
            // 
            // eventGroupButton
            // 
            this.eventGroupButton.Location = new System.Drawing.Point(279, 267);
            this.eventGroupButton.Name = "eventGroupButton";
            this.eventGroupButton.Size = new System.Drawing.Size(200, 50);
            this.eventGroupButton.TabIndex = 1;
            this.eventGroupButton.Text = "Генерация события из группы";
            this.eventGroupButton.UseVisualStyleBackColor = true;
            this.eventGroupButton.Click += new System.EventHandler(this.eventGroupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Генерация случайных событий";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventGroupButton);
            this.Controls.Add(this.singleEventButton);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singleEventButton;
        private System.Windows.Forms.Button eventGroupButton;
        private System.Windows.Forms.Label label1;
    }
}

