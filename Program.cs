using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Info;


// TEST laurent LOE LOE//
namespace GestionRH
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe e = new Employe("Martin", "Jean", "Paris", 35, "Technicien", 2500.0);
            Console.WriteLine(e.getInfo());
            e.affectation("Technicien Senior");
            e.augmentation(500);
            Console.WriteLine(e.getInfo());


            using (Employe ee = new Employe("O", "L", "F", 50, "Atos", 5000.0))
            {
                Console.WriteLine(ee.getInfo());
            }

        }
    }
}
