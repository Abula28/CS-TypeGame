namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string[] randomStrings =
            {
            "ქუჩა",
            "სკოლა",
            "უნივერსიტეტი",
            "მანქანა",
            "გიორგი",
            "პროგრამირება",
            "სდასუ",
            "ჩიხი",
            "კომპიუტერი",
            "ტელევიზორი",
            "მაცივარი",
            "სკამი",
            "მანქანა",
            "ველოსიპედი",
            "ჩანთა",
            "ხელი",
            "ტელეფონი",
            "ტაბლეტი",
            "ლეპტოპი",
            "იარაღი",
            "ნისლი",
            "მზე",
            "მთვარე",
            "ვარსკვლავი",
            "ფანჯარა",
            "გზა",
            "ტბა",
            "ხრამი",
            "ორმო",
            "მთა",
            "გორი",
            "ველი",
            "ბილიკი",
            "ციცინათელა",
            "ხე",
            "ტყე",
            "საქართველო",
            "ბალახი",
            "ყვავილი",
            "ძაღლი",
            "კატა",
            "ნიანგი",
            "კარტოფილი"
        };
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            label2.Text = randomStrings[rand.Next(0, randomStrings.Length)];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (textBox1.Text == label2.Text)
            {
                int randomText = random.Next(0, randomStrings.Length);
                label2.Text = randomStrings[randomText];
                score++;
                label3.Text = $"ქულა {score}";
                textBox1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}