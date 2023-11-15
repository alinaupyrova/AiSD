using System.Net.Http.Headers;
using System.Windows.Forms;

namespace cw3_zad1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            int[] tab = { 4,3,2,1};
            int[] newtab = fun(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                System.Console.WriteLine(tab[i]);
            }
        }
        int[] fun(int[] tab)
        {
            int temp = 0;
            int[] newTab = new int[tab.Length];
            bool czyZamiana = false;
            do
            {
                czyZamiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (temp > tab[i])
                    {
                        czyZamiana = true;
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                    }
                }

            }
            while (czyZamiana);
            return newTab;

        }
      
    }
}
