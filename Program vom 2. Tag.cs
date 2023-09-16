// See https://aka.ms/new-console-template for more information
//                        Aufgabe 1
/*
int x = 5;
int y = 7;

if (x == y)
{
    Console.WriteLine(x + " und " + y + " sind gleich"); 
}
else
{
    Console.WriteLine(x + " und " + y + " sind nicht gleich");
}
*/

//                        Aufgabe 2
/*
        Console.Write("Bitte geben Sie eine Zahl ein: ");
        int zahl = int.Parse(Console.ReadLine());

        if (zahl % 2 == 0)
        {
            Console.WriteLine($"{zahl} ist eine gerade Zahl.");
        }
        else
        {
            Console.WriteLine($"{zahl} ist eine ungerade Zahl.");
        }
*/

//                         Aufgabe 3
/*
Console.Write("Bitte geben Sie eine Zahl ein: ");
int zahl = int.Parse(Console.ReadLine());

if (zahl < 0) {
    Console.WriteLine(zahl + " ist negativ ");
}
else {
    Console.WriteLine(zahl + " ist positiv ");
}
*/

//                          Aufgabe 4
/*
Console.Write("Bitte geben Sie ein Jahr ein: ");
int jahr = int.Parse(Console.ReadLine());

if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
{
    Console.WriteLine($"{jahr} ist ein Schaltjahr.");
}
else
{
    Console.WriteLine($"{jahr} ist kein Schaltjahr.");
}
*/

//                          Aufgabe 5

/*
Console.Write("Bitte geben Sie die ERSTE Zahl ein: ");
int eins = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die ZWEITE Zahl ein: ");
int zwei = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die DRITTE Zahl ein: ");
int drei = int.Parse(Console.ReadLine());

if (eins > zwei && eins > drei) {
    Console.WriteLine("Die erste Zahl ist die grösste Zahl");
}

if (zwei > eins && zwei > drei)
{
    Console.WriteLine("Die zweite Zahl ist die grösste Zahl");
}

if (drei > zwei && drei > eins)
{
    Console.WriteLine("Die dritte Zahl ist die grösste Zahl");
}
*/

//                          Aufgabe 6
/*
Console.Write("Bitte geben Sie den x Wert ein: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die y Wert ein: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Der Punkt " + "P(" + x + "|" + y + ") liegt im ersten Quadranten.");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Der Punkt " + "P(" + x + "|" + y + ") liegt im zweiten Quadranten.");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Der Punkt " + "P(" + x + "|" + y + ") liegt im dritten Quadranten.");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Der Punkt " + "P(" + x + "|" + y + ") liegt im vierten Quadranten.");
}
*/

//                          Aufgabe 7
/*
Console.Write("Bitte geben Sie den ersten Winkel ein: ");
int erste = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie den zweiten Winkel ein: ");
int zweite = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie den dritten Winkel ein: ");
int dritte = int.Parse(Console.ReadLine());

if (erste == zweite && zweite == dritte)
{
    Console.WriteLine("Dreieck ist gleichseitig");
}

else if (erste == zweite || erste == dritte || zweite == dritte)
{
    Console.WriteLine("Dreieck ist gleichschenklig");
}

else if (erste != zweite || erste != dritte || zweite != dritte)
{
    Console.WriteLine("Dreieck ist ungleichseitig");
}
*/

//                      Aufgabe 8 Chat GPT
/*
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menüführung:");
            Console.WriteLine("1 steht für Kreis");
            Console.WriteLine("2 steht für Rechteck");
            Console.WriteLine("3 steht für Dreieck");
            Console.WriteLine("4 zum Beenden");

            Console.Write("Menüwahl: ");
            int auswahl = int.Parse(Console.ReadLine());

            if (auswahl == 1)
            {
                BerechneKreisfläche();
            }
            else if (auswahl == 2)
            {
                BerechneRechteckfläche();
            }
            else if (auswahl == 3)
            {
                BerechneDreieckfläche();
            }
            else if (auswahl == 4)
            {
                Console.WriteLine("Programm wird beendet.");
                return;
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie erneut.");
            }
        }
    }

    static void BerechneKreisfläche()
    {
        Console.Write("Input Radius: ");
        double radius = double.Parse(Console.ReadLine());

        double fläche = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Flächeninhalt ist {fläche:F5}");
    }

    static void BerechneRechteckfläche()
    {
        Console.Write("Input Länge: ");
        double länge = double.Parse(Console.ReadLine());
        Console.Write("Input Breite: ");
        double breite = double.Parse(Console.ReadLine());

        double fläche = länge * breite;
        Console.WriteLine($"Flächeninhalt ist {fläche:F5}");
    }

    static void BerechneDreieckfläche()
    {
        Console.Write("Input Grundseite: ");
        double grundseite = double.Parse(Console.ReadLine());
        Console.Write("Input Höhe: ");
        double höhe = double.Parse(Console.ReadLine());

        double fläche = 0.5 * grundseite * höhe;
        Console.WriteLine($"Flächeninhalt ist {fläche:F5}");
    }
}
*/

//                                  Aufgabe 9

Console.WriteLine("Menüführung");
Console.WriteLine("1 Addition");
Console.WriteLine("2 Subtraktion");
Console.WriteLine("3 Multiplikation");
Console.WriteLine("4 Division");
Console.WriteLine("5 Abbruch");

Console.WriteLine("Menüauswahl");
int menü = int.Parse(Console.ReadLine());

if (menü == 1)
{
    Addition();
}
else if (menü == 2)
{
    Subtraktion();
}
else if (menü == 3)
{
    Multiplikation();
}
else if (menü == 4)
{
    Division();
}
else if (menü == 5)
{
    Abbruch();
}
else
{
    Console.WriteLine("Kein gültiger Eingabe bitte versuchen Sie es erneut");
    return;
}


static void Addition()
{
    Console.WriteLine("Erste Zahl");
    int zahlEins = int.Parse(Console.ReadLine());

    Console.WriteLine("Zweite Zahl");
    int zahlZwei = int.Parse(Console.ReadLine());

    int ergebnis = zahlEins + zahlZwei;

    Console.WriteLine("Das Ergebnis beträgt " + ergebnis);
}

static void Subtraktion()
{
    Console.WriteLine("Erste Zahl");
    int zahlEins = int.Parse(Console.ReadLine());

    Console.WriteLine("Zweite Zahl");
    int zahlZwei = int.Parse(Console.ReadLine());

    int ergebnis = zahlEins - zahlZwei;

    Console.WriteLine("Das Ergebnis beträgt " + ergebnis);
}

static void Multiplikation()
{
    Console.WriteLine("Erste Zahl");
    int zahlEins = int.Parse(Console.ReadLine());

    Console.WriteLine("Zweite Zahl");
    int zahlZwei = int.Parse(Console.ReadLine());

    int ergebnis = zahlEins * zahlZwei;

    Console.WriteLine("Das Ergebnis beträgt " + ergebnis);
}

static void Division()
{
    Console.WriteLine("Erste Zahl");
    int zahlEins = int.Parse(Console.ReadLine());

    Console.WriteLine("Zweite Zahl");
    int zahlZwei = int.Parse(Console.ReadLine());

    int ergebnis = zahlEins / zahlZwei;

    Console.WriteLine("Das Ergebnis beträgt " + ergebnis);
}

static void Abbruch()
{
    return;
}








//                                  BAHOSUN KODLAR







/* int x, y;
x = 5;
y = 7;
    if(x == y) {
    Console.WriteLine(x + " und " + y + " sind gleich.");
}
    else
{
    Console.WriteLine(x + " und " + y + " sind nicht gleich.");
}


Console.Write("Bitte geben Sie die Zahl ein: ");
int zahl = int.Parse(Console.ReadLine());
if (zahl % 2 == 0 )
{
    Console.WriteLine(zahl + " ist eine gerade Zahl.");
}
else
{
    Console.WriteLine(zahl + " ist eine ungerade Zahl.");
}


Console.Write("Bitte geben Sie die Zahl ein: ");
int zahl = int.Parse(Console.ReadLine());
if (zahl > 0)
{
    Console.WriteLine(zahl + " ist positiv.");
}
else
{
    Console.WriteLine(zahl + " ist negativ.");
}


Console.Write("Bitte geben Sie die erste Zahl ein: ");
int eins = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die zweite Zahl ein: ");
int zwei = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die dritte Zahl ein: ");
int drei = int.Parse(Console.ReadLine());

if (eins > zwei && eins > drei)
{
    Console.WriteLine("Die erste Zahl ist die grösste Zahl.");
}
else if (zwei > drei && zwei > eins)
{
    Console.WriteLine("Die zweite Zahl ist die grösste Zahl.");
}
else (drei > zwei && drei > eins) {
    Console.WriteLine("Die dritte Zahl ist die grösste Zahl.");
}
*/
/*
Console.Write("Bitte geben Sie die x Wert ein: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Bitte geben Sie die y Wert ein: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Der Punkt liegt im ersten Quadranten.");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Der Punkt liegt im zweiten Quadranten.");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Der Punkt liegt im dritten Quadranten.");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Der Punkt liegt im vierten Quadranten.");
}
*/