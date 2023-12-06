
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


            var wec1 = new wezel2(3);
            var wec2 = new wezel2(1);
            var wec3 = new wezel2(5);
            var wec4 = new wezel2(6);
            var wec5 = new wezel2(4);
            var wec6 = new wezel2(2);
            var wec7 = new wezel2(7);
            odwiedzane.Clear();
            napis2 = "";
            A(w2);
            MessageBox.Show(napis2);

        }
        private void button2_Click(object sender, EventArgs e)
        {

            var d = new DrzewoBinarne(5);
            d.Add2(5);
            d.Add2(3);
            d.Add2(2);
            d.Add2(4);
            d.Add2(4);
         


            var w = d.ZnajdzNajmnieszy(d.korzen);
            while(w != null)
            {
                w = d.Nastepnik(w);


            }
            MessageBox.Show(napis3);
        }
        String napis = "";
        String napis2 = "";
        String napis3 = "";

        void A(wezel w)
        {
            A(w);
            napis2 += " " + w.wartosc.ToString();
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
        void A3(wezel3 w)
        {
            napis3 += " " + w.wartosc.ToString();
            if (w.leweDziecko != null)
                A3(w.leweDziecko);

            if (w.praweDziecko != null)
                A3(w.praweDziecko);
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
    // BFS ALGORYTM
    class wezel3
    {
        public wezel3 rodzic;
        public wezel3 prawe_dziecko;
        public wezel3 lewe_dziecko;
        public int wartosc;
        public wezel3 korzen;
        public wezel3 leweDziecko;
        public wezel3 praweDziecko;

        public wezel3(int liczba)
        {
            this.wartosc = liczba;
        }

        public void Add_dziecka(int liczba)
        {
            var dziecko = new wezel3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartosc)
            {
                this.leweDziecko = dziecko;
            }
            else
            {
                this.praweDziecko = dziecko;
            }
            throw new NotImplementedException();
        }

        class DrzewoBinarne
        {
            public wezel3 korzen;
            public int liczbaWezlow = 0;
            public wezel3 leweDziecko;
            private int v;

            public DrzewoBinarne(int v)
            {
                this.v = v;
            }

            
            public wezel3 Znajdz(int liczba)
            {
                var w = this.korzen;
                while (true)
                {
                    if (liczba == w.wartosc)
                    {
                        return w;
                    }
                    if (liczba < w.wartosc)
                    {
                        if (w.lewe_dziecko == null)
                        {
                            return null;
                        }
                        else
                        {
                            w = w.leweDziecko;
                        }
                    }
                    else if (liczba > w.wartosc)
                    {
                        if (w.prawe_dziecko == null)
                        {
                            return null;
                        }
                        else
                        {
                            w = w.praweDziecko;
                        }
                    }
                }
            }
        }
        public wezel3 ZnajdzRodzica(int liczba)
            {
                var w = this.korzen;
                while (true)
                {
                    if (liczba < w.wartosc)
                    {
                        if (w.lewe_dziecko != null)
                        {
                            w = w.leweDziecko;
                        }
                        else
                        {
                            return w;
                        }
                    }
                    else if (liczba > w.wartosc)
                    {
                        if (w.prawe_dziecko != null)
                        {
                            w = w.praweDziecko;
                        }
                        else
                        {
                            return w;
                        }
                    }
                }
            }
        void Add2(int liczba)
        {
            var rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add_dziecka(liczba);
        }
        public wezel3 ZnajdzNajmnieszy(wezel3 w)
            {
                for (; w.leweDziecko != null; w = w.leweDziecko) ;
                return w;
            }
            public wezel3 ZnajdzNajwieksa(wezel3 w)
            {
                for (; w.praweDziecko != null; w = w.praweDziecko) ;
                return w;
            }
            public wezel3 Nastepnik(wezel3 w)
            {
                if (w.praweDziecko != null)
                {
                    return this.ZnajdzNajmnieszy(w.praweDziecko);
                }
                while (w.rodzic != null)
                {
                    if (w.rodzic.leweDziecko == w)
                    {
                        return w.rodzic;
                    }
                    w = w.rodzic;
                }
                return null;
            }
           
    }
}


