namespace Kalkulator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonDzialanie(object? sender, EventArgs e)
        {
            
            var liczbaA = LiczbaA.Text;
            var liczbaB = LiczbaB.Text;

            if (liczbaA == null || string.IsNullOrWhiteSpace(liczbaA.ToString()))
            {
                BledyLabel.Text = "Podaj poprawną liczbe A!";
            }
            else if (liczbaA == null || string.IsNullOrWhiteSpace(liczbaA.ToString()))
            {
                BledyLabel.Text = "Podaj poprawną liczbe B!";
            }
            else if (PickerDzialania.SelectedItem == null || string.IsNullOrWhiteSpace(PickerDzialania.SelectedItem.ToString()))
            {
                BledyLabel.Text = "Wybierz dzialanie!";
            }
            else
            {
                var liczba1 = double.Parse(liczbaA);
                var liczba2 = double.Parse(liczbaB);

                if (PickerDzialania.SelectedIndex == 0)
                {
                    var dodawanie = Math.Round(liczba1 + liczba2,2);
                    WynikLabel.Text = "Wynik: " + liczba1 + " + " + liczba2 + " = " + dodawanie.ToString();
                }
                else if (PickerDzialania.SelectedIndex == 1)
                {
                    var odejmowanie = Math.Round(liczba1 - liczba2,2);
                    WynikLabel.Text = "Wynik: " + liczba1 + " - " + liczba2 + " = " + odejmowanie.ToString();
                }
                else if (PickerDzialania.SelectedIndex == 2)
                {
                    var mnozenie = Math.Round(liczba1 * liczba2,2);
                    WynikLabel.Text = "Wynik: "+liczba1+" * "+liczba2 +" = "+ mnozenie.ToString();
                }
                else if (PickerDzialania.SelectedIndex == 3)
                {
                    var dzielenie = Math.Round(liczba1 / liczba2, 2);
                    if (liczba2 == 0) { BledyLabel.Text = "Nie można dzielic przez 0!"; }
                    else
                    { WynikLabel.Text = "Wynik: " + liczba1 + " / " + liczba2 + " = " + dzielenie.ToString(); }
                }

            }


        }
    }
}

/*Nazwa funkcji:OnButtonDzialanie
 * Opis funkcji:Spawdza czy pola Liczba A i Liczba B są null lub puste i czy wybrano dzialanie 
 * po czym wykonuje wybrane dzialanie na wpisanych liczbach
 * parametry:object? sender, EventArgs e
 * zwracany typ: brak
 * autor:Szymon Wlaź
*/