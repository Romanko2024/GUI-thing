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
            //
        }
        private void ShowHelloWorld()
        {
            MessageBox.Show("Hello, World!");
        }
    }
}