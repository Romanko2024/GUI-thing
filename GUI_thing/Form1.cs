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
            this.BackColor = this.BackColor == Color.Gray ? Color.Yellow : Color.Gray;
        }
        private void ShowHelloWorld()
        {
            MessageBox.Show("Hello, World!");
        }

        //��� ������ ����� �����
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
            MessageBox.Show("� ���������������,\n� ����� ���� �� ��������!");

            if (checkTransparency.Checked) actTransparency();
            if (checkBackgroundColor.Checked) actBackgroundColor();
            if (checkMessage.Checked) actMessage();
        }
    }
}