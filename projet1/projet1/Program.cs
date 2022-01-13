using System;

namespace projet1
{
    using System;

    namespace Projet_1_Shell
    {
        class Program
        {
            string[,] tableau = new string[10, 7];
            static void Main(string[] args)
            {

                Program program = new Program();
                program.startTheMachine();

            }

            private void afficherMenu()
            {
                string choix;
                do
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1 - Ajouter un animal");
                    Console.WriteLine("2 - Liste de tous les animaux en pension");
                    Console.WriteLine("3 - Liste de tous les propriétaires");
                    Console.WriteLine("4 - Nombre total d'animaux en pension");
                    Console.WriteLine("5 - Poids total de tous les animaux en pension");
                    Console.WriteLine("6 - Liste des animaux de couleur : rouge, bleu ou violet");
                    Console.WriteLine("7 - Retirer un animal de la liste");
                    Console.WriteLine("8 - Quitter");

                    choix = Console.ReadLine();
                    selectChoice(choix);
                } while (choix != "8");
            }
            private void startTheMachine()
            {
                afficherMenu();
            }

            private void selectChoice(string choice)
            {

                switch (choice)
                {

                    case "1":
                        ajouterUnAnimal();
                        break;
                    case "2":
                        voirListeAnimauxPension();
                        break;
                    case "3":
                        voirListePropriétaire();
                        break;
                    case "4":
                        voirNombreTotalAnimaux();
                        break;
                    case "5":
                        voirPoidsTotalAnimaux();
                        break;
                    case "6":
                        extraireAnimauxSelonCouleurs();
                        break;
                    case "7":
                        retirerUnAnimalDeListe();
                        break;
                    default:afficherMessageErreur();break;

                }

            }
            
            private void quitter()
            {
                Environment.Exit(0);
            }
                    
            private void afficherMessageErreur()
            {
                    Console.WriteLine("Le choix n'est pas valide");
                
            }

            private void ajouterUnAnimal()
            {
                Console.WriteLine("Veuillez saisir le type de l'animal:");
                string typeAnimal = Console.ReadLine();
                Console.WriteLine("Veuillez saisir le nom de l'animal:");
                string nomAnimal = Console.ReadLine();
                Console.WriteLine("Veuillez saisir l'âge de l'animal:");
                string ageAnimal = Console.ReadLine();
                Console.WriteLine("Veuillez saisir le poids de l'animal:");
                string poidsAnimal = Console.ReadLine();
                Console.WriteLine("Veuillez saisir la couleur de l'animal :");
                string couleurAnimal = Console.ReadLine();


                if(couleurAnimal != "rouge" &&  couleurAnimal != "bleu" && couleurAnimal != "violet")
                {
                    afficherMessageErreur();


                }
                while(couleurAnimal != "rouge" && couleurAnimal != "bleu" && couleurAnimal != "violet")
                {
                    Console.WriteLine("Veuillez saisir la couleur de l'animal rouge ou bleu ou violet :");
                    couleurAnimal = Console.ReadLine();
                }
                Console.WriteLine("Veuillez saisir le nom du propriétaire de l'animal :");
                string nomproprioAnimal = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (tableau[i, 0] == null)
                    {
                        tableau[i, 0] = Convert.ToString(i);
                        tableau[i, 1] = typeAnimal;
                        tableau[i, 2] = nomAnimal;
                        tableau[i, 3] = ageAnimal;
                        tableau[i, 4] = poidsAnimal;
                        tableau[i, 5] = couleurAnimal;
                        tableau[i, 6] = nomproprioAnimal;
                        break;
                    }
                }



            }
            // fonction qui affiche la liste des naimaux

            private void voirListeAnimauxPension()
            {
                Console.WriteLine("--------------------------------------------------------------------");
               
                Console.WriteLine ("ID |  TYPE ANIMAL  |  NOM  | AGE | POIDS | COULEUR | PROPRIÉTAIRE ");
                
                Console.WriteLine("--------------------------------------------------------------------");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(tableau[i, 0] + "    " + tableau[i, 1] + "\t" + tableau[i, 2] + "   " + tableau[i, 3] + "   " + tableau[i, 4] + "\t " + tableau[i, 5] + "\t\t " + tableau[i, 6]);
                }
            }
            // affiche la liste  des propietaires
            private void voirListePropriétaire()
            {
                Console.WriteLine("PROPRIÉTAIRE");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(tableau[i, 6]);
                }
            }

            private void voirNombreTotalAnimaux()
            {
                Console.WriteLine("NOMBRE ANIMAUX");
                int totalAnimaux = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (tableau[i, 0] != null)
                    {
                        totalAnimaux++;
                    }

                }
                Console.WriteLine(totalAnimaux);





            }


            private void voirPoidsTotalAnimaux()
            {


                Console.WriteLine("POIDS TOTAL");
                int poidsTotal = 0;
                int poidstemporaire = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (tableau[i, 4] != null)
                    {
                        poidstemporaire = Convert.ToInt32(tableau[i, 4]);
                        poidsTotal = poidstemporaire + poidsTotal;
                    }

                }
                Console.WriteLine(poidsTotal);
            }

           
            private void extraireAnimauxSelonCouleurs()
            {
                Console.WriteLine("Veuillez saisir la couleur de recherche");
                string couleurAnimal = Console.ReadLine();
                if (couleurAnimal != "rouge" && couleurAnimal != "bleu" && couleurAnimal != "violet")
                {
                    afficherMessageErreur();


                }
                while (couleurAnimal != "rouge" && couleurAnimal != "bleu" && couleurAnimal != "violet")
                {
                    Console.WriteLine("Veuillez saisir la couleur de l'animal rouge ou bleu ou violet :");
                    couleurAnimal = Console.ReadLine();
                }
                Console.WriteLine("--------------------------------------------------------------------");

                Console.WriteLine("ID |  TYPE ANIMAL  |  NOM  | COULEUR |");

                Console.WriteLine("--------------------------------------------------------------------");

                for (int i = 0; i < 10; i++)
                {
                    if (tableau[i,5]!= null && tableau[i, 5] == couleurAnimal)
                    {
                        Console.WriteLine(tableau[i, 0]+" "+ tableau[i, 1]+" "+ tableau[i, 2]+" " + tableau[i, 5]);
                        
                    }
                }
               
            }
            
            


            private void retirerUnAnimalDeListe()
            {

                Console.WriteLine("Veuillez saisir le ID de l'animal:");
                string ID = Console.ReadLine();
                
                for (int i = 0; i < 10; i++)
                {
                    if (tableau[i,0]==ID)
                    {
                        tableau[i, 0] = null;
                        tableau[i, 1] = null;
                        tableau[i, 2] = null;
                        tableau[i, 3] = null;
                        tableau[i, 4] = null;
                        tableau[i, 5] = null;
                        tableau[i, 6] = null;

                    }
                }

            }
            
        }
    }
}
