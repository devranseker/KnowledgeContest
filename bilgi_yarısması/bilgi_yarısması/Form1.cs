using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bilgi_yarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global alanında bazı degiskenler genel alan 
        int questionNumber = 0;
        int dogruSayisi = 0;
        int yanlisSayisi = 0;


        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            // sonraki butona her bastıgımda soru sayısı artsın ve Lbl'ye yazdıralım 
            questionNumber++;          //  questionNumber = questionNumber + 1; (ikiside aynı )
            LblSoruNo.Text = questionNumber.ToString();

        }
    }
}