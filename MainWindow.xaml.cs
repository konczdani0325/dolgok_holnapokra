using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GLS_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       List<AutoAdatok> autok = new List<AutoAdatok>();
        public MainWindow()
        {
            
            StreamReader sr = new StreamReader("GLS.txt");
            while (!sr.EndOfStream)
            {
                autok.Add(new AutoAdatok(sr.ReadLine()));
            }
            sr.Close();
           
            InitializeComponent();
            adat_gird.ItemsSource = autok;
            adat_gird.Items.Refresh();
        }

        private void fel_Click(object sender, RoutedEventArgs e)
        {
            bool ok=false;
            try
            {
                DateOnly d = DateOnly.Parse(datumx.Text);
                ok = true;
            }
            catch (Exception w)
            {
                ok = false;
                
            }
            if (ok==true&&datumx.Text!=""&&nevx.Text!="" &&csomagx.Text!=""&&fogyx.Text!=""&&kmx.Text!=""&& 0 < int.Parse(csomagx.Text) && 0 < int.Parse(fogyx.Text) && 0 < int.Parse(kmx.Text))
            {
               
                    string uj = $"{datumx.Text};{nevx.Text};{csomagx.Text};{fogyx.Text};{kmx.Text}";
                    autok.Add(new AutoAdatok(uj));
                    adat_gird.Items.Refresh();           
            }
            else
            {
                MessageBox.Show("Hibás vagy hiányzó adatok!");
            }

        }

        private void mod_Click(object sender, RoutedEventArgs e)
        {
            bool ok = false;
            try
            {
                DateOnly d = DateOnly.Parse(datumx.Text);
                ok = true;
            }
            catch (Exception w)
            {
                ok = false;

            }
            if (ok == true && datumx.Text != "" && nevx.Text != "" && csomagx.Text != "" && fogyx.Text != "" && kmx.Text != "" && 0 < int.Parse(csomagx.Text) && 0 < int.Parse(fogyx.Text) && 0 < int.Parse(kmx.Text))
            {
                string modositando = $"{datumx.Text};{nevx.Text};{csomagx.Text};{fogyx.Text};{kmx.Text}";
                int i = adat_gird.SelectedIndex;
                if (i < 0)
                {
                    i = 0;
                }
             

                adat_gird.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Hibás vagy hiányzó adatok!");
            }
        }

        private void ment_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("gls.txt");
            for (int i = 0; i < autok.Count; i++)
            {
                sw.WriteLine($"{autok[i].datum};{autok[i].nev};{autok[i].csomag_szam};{autok[i].napi_fogyasztas};{autok[i].napi_km}");
            }
            sw.Close();
            MessageBox.Show("Sikeres Mentés!");
        }

        private void adat_gird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int i=adat_gird.SelectedIndex;
            if (i<0)
            {
                i = 0;
            }
            datumx.Text = $"{autok[i].datum}";
            nevx.Text = $"{autok[i].nev}";
            csomagx.Text = $"{autok[i].csomag_szam}";
            fogyx.Text = $"{autok[i].napi_fogyasztas}";
            kmx.Text = $"{autok[i].napi_km}";
            
        }
    }
}