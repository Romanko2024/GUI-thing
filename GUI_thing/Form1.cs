namespace GUI_thing
{
    public partial class Form1 : Form
    {
        //�������� �� ������
        private Action actTransparency;
        private Action actBackgroundColor;
        private Action actMessage;
        public Form1()
        {
            InitializeComponent();
            //���������� ��������
            actTransparency = ChangeTransparency;
            actBackgroundColor = ChangeBackgroundColor;
            actMessage = ShowHelloWorld;
            
        }
        private void ChangeTransparency()
        {
            //0.0 - �������. ���� 1.0 �� ��������� �� 0.5, ���� �� �� �� 1.0
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