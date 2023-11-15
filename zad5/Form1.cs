
namespace zad5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            var w1 = new wezel(5);
            var w2 = new wezel(3);
            var w3 = new wezel(1);
            var w4 = new wezel(2);
            var w5 = new wezel(5);
            var w6 = new wezel(2);
            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            A(w1);
            MessageBox.Show(napis);
        }
        string napis = "";
        
        void A(wezel w)
        {
            A(w);
            napis += " " + w.wartosc.ToString();
            for (int i = 0; i < w.dzieci.Count; i++)
            {
                {
                    A(w.dzieci[i]);
                }
            }
        }
    }
    class wezel
    {
        public int wartosc;
        public List<wezel> dzieci = new List<wezel>();
        public wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}


