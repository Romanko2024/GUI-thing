namespace GUI_thing
{
    public partial class Form1 : Form
    {
        //делегати дій кнопок
        private Action actTransparency;
        private Action actBackgroundColor;
        private Action actMessage;
        public Form1()
        {
            InitializeComponent();
            //ініціалізуємо делегати
            actTransparency = ChangeTransparency;
            actBackgroundColor = ChangeBackgroundColor;
            actMessage = ShowHelloWorld;
            
        }
        private void ChangeTransparency()
        {
            //0.0 - прозоре. якщо 1.0 то приводимо до 0.5, якщо ны то до 1.0
            this.Opacity = this.Opacity == 1.0 ? 0.5 : 1.0;
        }
        private void ChangeBackgroundColor()
        {
            this.BackColor = this.BackColor == Color.Gray ? Color.Yellow : Color.Gray;
        }
        private void ShowHelloWorld()
        {
            MessageBox.Show("Hello, World!");
        }

        //для кнопок оброб подый
        private void buttonTransparency_Click(object sender, EventArgs e)
        {
            actTransparency();
        }

        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            actBackgroundColor();
        }

        private void buttonHelloWorld_Click(object sender, EventArgs e)
        {
            actMessage();
        }
        private void buttonTHEBUTTON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");

            if (checkTransparency.Checked) actTransparency();
            if (checkBackgroundColor.Checked) actBackgroundColor();
            if (checkMessage.Checked) actMessage(); //в Form1.cs [Design] зробити цы кнопки і чекбокси
        }
    }
}