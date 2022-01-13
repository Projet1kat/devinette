using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {   

        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Start();
      
        }
        private void Start()
        {
            string choix;

            do
            {
                Menu();
                choix = Console.ReadLine();
                FaireUnchoix(choix);
            } while (choix != "4");
        }


        private void Menu()

        {
            Console.WriteLine("Veuillez choisir un jeu");
            Console.WriteLine("1 - Bingo");
            Console.WriteLine("2 - Simili black jack");
            Console.WriteLine("3 - Simili pendu");
        }

        private void FaireUnchoix(string choix)
        {
            switch (choix)
            {
                case "1":
                    Bingo();
                    break;
                case "2":
                    SimiliBlackJack();
                    break;
                case "3":
                    SimiliPendu();
                    break;
                case "4":
                    Quitter();
                    break;
                default:
                    choixinvalide();
                    break;
            }
        }

        private void choixinvalide()
        {
            Console.WriteLine("Veuillez effectuer un choix valide");
        }

        private void Quitter()
        {
            Environment.Exit(0);
        }

        private void SimiliPendu()
        {
            throw new NotImplementedException();
        }

        private void SimiliBlackJack()
        {
            throw new NotImplementedException();
        }

        private void Bingo()
        {
            throw new NotImplementedException();
        }
    }


}