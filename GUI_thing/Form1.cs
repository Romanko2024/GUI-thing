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
            private void ChangeTransparency()
            {
                //
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
}