using System;
using System.Diagnostics.Eventing.Reader;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct; // pour que la réponse soit un nombre entier ou pas

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                try
                {
                    choix = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Erreur de saisie");
                }
                // traitement des choix
                if (choix != 0)
                {
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    switch (choix)
                    {
                        case 1:

                            // saisie de la réponse
                            Console.Write(val1 + " + " + val2 + " = ");
                            correct = false;
                            while(!correct)
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                    Console.WriteLine("veuillez saisir un nombre entier");
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                        break;
                        case 2:
                            // saisie de la réponse
                            Console.Write(val1 + " x " + val2 + " = ");
                            correct = false;
                            while (!correct)
                            try
                            {
                                    reponse = int.Parse(Console.ReadLine());
                                    correct = true;
                            }
                            catch
                            {
                                    Console.WriteLine("veuillez saisir un nombre entier");
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 * val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }

                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                        break;
                        default:
                        Console.WriteLine("Erreur de saisie");
                        break;
                     }

                }
            }
        }
    }
}