namespace KONTROL
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        void buttonObjectsChoice_Click(object sender, EventArgs e)
        {
            if (buttonObjectsChoice.Text != null)
            {
                // Вызываем метод формы и передаем ему выбранный элемент списка
                string selectItem = buttonObjectsChoice.Text;
                ObjectsForm cof = new();
                cof.SetText(selectItem);
                cof.ShowDialog();
            }
        }

        private void buttonSettingsChoice_Click(object sender, EventArgs e)
        {

        }

        private void ChoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
