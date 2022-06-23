using System;

namespace OOP_lab6_incapsulare_Clase_Obiecte
{
    ////public class Dulap
    ////{

    ////    private int lungime, latime, inaltime;

    ////    static void Main(string[] args)
    ////    {
    ////        // Ex 1
    ////        //Un dulap are trei caracteristici: lungime, latime, inaltime.Dulapul va avea o
    ////        //metoda care va calcula volumul acestuia.
    ////        //Folositi o clasa care va modela un dulap.
    ////        // Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
    ////        // Cele trei campuri vor fi initializate cu ajutorul constructorului
    ////        // Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri
    ////        // Realiazti diagrama UML a clasei.
    ////        //Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
    ////        //afisati rezultatul

    ////        int lungime = int.Parse(Console.ReadLine());

    ////        int latime = int.Parse(Console.ReadLine());

    ////        int inaltime = int.Parse(Console.ReadLine());

    ////        Dulap(lungime, latime, inaltime);
    ////    }

    ////    public Dulap()
    ////    {
    ////        lungime = 1;

    ////        latime = 1;

    ////        inaltime = 1;
    ////    }

    ////    public Dulap(int lungime, int latime, int inaltime)
    ////    {
    ////        this.lungime = lungime;
    ////        this.latime = latime;
    ////        this.inaltime = inaltime;
    ////    }

    ////    public int Volum(int lungime, int latime, int inaltime)
    ////    {
    ////        return latime * lungime * inaltime;
    ////    }

    //} ex // ex1





//    Ex 2
//Scrieti un program care va modela un autoturism.Un autoturism va avea o marca
//(string), un numar de inmatriculare (string), precum si o capacitate
//cilindrica(int).
//Autoturismul va avea:
// Campurile corespunzatoare caracteristicilor autoturismului.
// Un constructor care va initializa campurile acestuia
// O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
//numarDeInmatriculare, capacitateCilindrica”.
// Realiazti diagrama UML a clasei.
//Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml
//pentru metodele publice.
//Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le metodele
//“Tipareste”




   //class Autoturism
   // {
   //     private readonly string marca;

   //     private readonly string numarImatriculare;

   //     private readonly int capacitateCilindrica;

   //     static void Main(string[] args)
   //     {

   //     }

   //    public Autoturism(string marca, string numarImatriculare, int capacitateCilindrica)
   //     {
   //         this.marca = marca;

   //         this.numarImatriculare = numarImatriculare;

   //         this.capacitateCilindrica = capacitateCilindrica;
   //     }



   //     public  void Tipareste()
   //     {
   //         Console.WriteLine($"Autoturism marca {this.marca} cu numarul de imatriculare {this.numarImatriculare}" + $"are capacitatea cilindrica de {this.capacitateCilindrica} centimetri cubi.");
   //     }
   // }
}

