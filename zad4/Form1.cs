namespace zad4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int[] bubbleSort(int[] tab)
        {
            int temp = 0;
            bool czyZamiana = false;
            do
            {
                czyZamiana = false;
                for (int i = 1; i < tab.Length; i++)
                {
                    if (tab[i - 1] > tab[i])
                    {
                        czyZamiana = true;
                        temp = tab[i];
                        tab[i-1] = tab[i + 1];
                        tab[i] = temp;
                    }
                }

            }
            while (czyZamiana);
            return tab;

        }
       
        public int[] convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for(int i = 0; i < liczbyS.Length;i++)
            {
                liczby[i] = int.Parse(liczbyS[i]); 
            }
            return liczby;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int[] tab1 = { 7, 2, 3, 4, 5 };
            int[] newTab = bubbleSort(tab1);
            int[] liczbyS = { 1, 2, 3, 4, 5 };
        }

        private void tblinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblBubblesort_Click(object sender, EventArgs e)
        {
            string napis = tblinput.Text;
            int[] wynik = convert(napis);
            bubbleSort(wynik);
            lblWynik.Text = wynik.ToString();
        }

        private void tblwynik_Click(object sender, EventArgs e)
        {

        }
    }
}
