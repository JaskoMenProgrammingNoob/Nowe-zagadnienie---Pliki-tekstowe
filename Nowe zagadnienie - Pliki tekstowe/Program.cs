using System.Diagnostics;
using System.IO;
using System;
class Dane
{
    FileStream Fin , Fout;
    string imie_nazwisko, imie_nazwisko1;

    public void czytaj_dane()
    {
        Console.Write("Podaj Imię oraz Nazwisko: ");
        imie_nazwisko = Console.ReadLine();
        
        
    }
    public void zapisz_dane_do_pliku()
    {
        Fout = new FileStream("dane.txt", FileMode.Create);
        StreamWriter zapis = new StreamWriter(Fout);
        zapis.WriteLine(imie_nazwisko);
        zapis.Close();
        Fout.Close();
    }
    public void czytaj_dane_z_pliku()
    {
       Console.WriteLine("Wprowadzam dane");
        Fin = new FileStream("dane.txt", FileMode.Open);
        StreamReader odczyt = new StreamReader(Fin);
        while ((imie_nazwisko1 = odczyt.ReadLine()) != null)
        {
            Console.WriteLine(imie_nazwisko1);
        }
        odczyt.Close();
        Fin.Close();
    }
    
    static void Main(string[] args)
    {
        Dane dane = new Dane();
        dane.czytaj_dane();
        dane.zapisz_dane_do_pliku();
        dane.czytaj_dane_z_pliku();
        Console.Read();


    }
}