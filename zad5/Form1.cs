
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

            var w1 = new wezel2(3);
            var w2.2 = new wezel2(1);
            var w2.3 = new wezel2(5);
            var w2.4 = new wezel2(6);
            var w2.5 = new wezel2(4);
            var w2.6 = new wezel2(2);
            var w2.7 = new wezel2(7);

            A(w2);


        }
        string napis = "";
        string napis2 = "";

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
        List<wezel2> odwiedzane = new(); 
        void A2(wezel2 w)
        {
            odwiedzane.Add(w);
            napis += " " + w.wartosc.ToString();
            for (int i = 0; i < w.sasiedzi.Count; i++)
            {
               
                if (!odwiedzane.Contains(w.sasiedzi[i]))
                A2(w.sasiedzi[i]);
            }
            // foreach(var sasiad in w.sasiedzi)
            // {
            // A(sasiedzi)
            // } 
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
    class wezel2
    {
        public int wartosc;
        public List<wezel2> sasiedzi = new List<wezel2>();
        public wezel2(int liczba)
        {
            this.wartosc = liczba;
        }
        public bool Add(wezel2 s)
        {
            if(this == s)
            {
                return false;
            }
            bool wynik = false;
            if(!this.sasiedzi.Contains(s))
            {
                this.sasiedzi.Add(s);
                wynik = true;
            }
            if(!s.sasiedzi.Contains(this))
            {
                s.sasiedzi.Add(this);
                wynik = true;
            }
            return wynik;
        }
    }
}


