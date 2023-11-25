namespace BotWhatsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WhatsAppSendMessage sendMessage = new WhatsAppSendMessage();
            sendMessage.SendMessage("teste", "PauloCesar");
        }
    }
}