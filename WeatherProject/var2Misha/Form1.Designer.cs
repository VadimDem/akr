namespace WeatherProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TempLabel = new Label();
            WeatherLabel = new Label();
            HumidityLabel = new Label();
            PressureLabel = new Label();
            label9 = new Label();
            RecLabel = new Label();
            label5 = new Label();
            Icon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(529, 27);
            textBox.TabIndex = 0;
            textBox.Text = "Санкт-Петербург";
            // 
            // button
            // 
            button.BackColor = SystemColors.ControlLight;
            button.Location = new Point(12, 68);
            button.Name = "button";
            button.Size = new Size(529, 47);
            button.TabIndex = 1;
            button.Text = "Узнать прогноз";
            button.UseVisualStyleBackColor = false;
            button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Температура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Давление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Влажность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "Осадки";
            // 
            // TempLabel
            // 
            TempLabel.AutoSize = true;
            TempLabel.Location = new Point(122, 131);
            TempLabel.Name = "TempLabel";
            TempLabel.Size = new Size(16, 20);
            TempLabel.TabIndex = 6;
            TempLabel.Text = "?";
            // 
            // WeatherLabel
            // 
            WeatherLabel.AutoSize = true;
            WeatherLabel.Location = new Point(77, 234);
            WeatherLabel.Name = "WeatherLabel";
            WeatherLabel.Size = new Size(16, 20);
            WeatherLabel.TabIndex = 7;
            WeatherLabel.Text = "?";
            // 
            // HumidityLabel
            // 
            HumidityLabel.AutoSize = true;
            HumidityLabel.Location = new Point(102, 202);
            HumidityLabel.Name = "HumidityLabel";
            HumidityLabel.Size = new Size(16, 20);
            HumidityLabel.TabIndex = 8;
            HumidityLabel.Text = "?";
            // 
            // PressureLabel
            // 
            PressureLabel.AutoSize = true;
            PressureLabel.Location = new Point(96, 165);
            PressureLabel.Name = "PressureLabel";
            PressureLabel.Size = new Size(16, 20);
            PressureLabel.TabIndex = 9;
            PressureLabel.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 266);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 10;
            label9.Text = "Рекомендации";
            // 
            // RecLabel
            // 
            RecLabel.AutoSize = true;
            RecLabel.Location = new Point(130, 266);
            RecLabel.Name = "RecLabel";
            RecLabel.Size = new Size(16, 20);
            RecLabel.TabIndex = 11;
            RecLabel.Text = "?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 12);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 12;
            label5.Text = "Назавание города";
            // 
            // Icon
            // 
            Icon.Location = new Point(299, 165);
            Icon.Name = "Icon";
            Icon.Size = new Size(59, 50);
            Icon.TabIndex = 13;
            Icon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(Icon);
            Controls.Add(label5);
            Controls.Add(RecLabel);
            Controls.Add(label9);
            Controls.Add(PressureLabel);
            Controls.Add(HumidityLabel);
            Controls.Add(WeatherLabel);
            Controls.Add(TempLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Погода";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label TempLabel;
        private Label WeatherLabel;
        private Label HumidityLabel;
        private Label PressureLabel;
        private Label label9;
        private Label RecLabel;
        private Label label5;
        private PictureBox Icon;
    }
}
