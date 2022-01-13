using System;

namespace Projet_2_Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        private void Start()
        {
            Afficher();
        }

        private void Afficher()
        {
            string choix;
            do
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Veuillez choisir le jeu à jouer:");
                Console.WriteLine("1- Roche/papier/ciseau   2- La devinette   3- Quitter");
                Console.WriteLine("----------------------------------------------------");
                choix = Console.ReadLine();
                selectChoix(choix);
            } while (choix != "3");
            
        }
        private void selectChoix (string choix)
        {
            switch (choix)
            {
                case "1":
                    JouerARochePapierCiseau();
                    break;
                case "2":
                    JouerADevinette();
                    break;
                default:AfficherChoixInvalide();break;
            }

        }
        private void AfficherChoixInvalide()
        {
            Console.WriteLine("Veuillez effectuer un choix valide:");
        }
        
        private void JouerARochePapierCiseau()
        {            
            Console.WriteLine("Bienvenu dans le jeu roche/papier/ciseau");
            Console.WriteLine("----------------------------------------");
            GetComputerChoice();
        }

        private bool IsAnotherGame()
        {
            Console.WriteLine("Voulez-vous refaire une partie (O/N)?");
            string choiceGame = Console.ReadLine();
            while (choiceGame != ("O") && choiceGame != ("o") && choiceGame != ("N") && choiceGame != ("n"))
            {
                Console.WriteLine("Voulez-vous refaire une partie (O/N)?");
                choiceGame = Console.ReadLine();
            }
            switch (choiceGame.ToUpper())
            {
                case "O":
                    JouerARochePapierCiseau();
                    break;
                case "N":
                    Afficher();
                    break;
            }
            //return false;
        }


        private string GetUserChoice(string choixUser)
        {
            Console.WriteLine("J'ai déjà choisi mon élément! A votre tour de choisir l'élément:");
            choixUser = Console.ReadLine();
            if (choixUser != "roche" && choixUser != "papier" && choixUser != "ciseau")
            {
                Console.WriteLine(" votre choix est invalide, veuillez le saisir à nouveau");

            }

           // ValidateWinner("", "");
            return choixUser;
        }

        
        private void ValidateWinner(string userChoice, string cpuChoice)
        {
           string userChoice = GetUserChoice();

            string cpuChoice = GetComputerChoice();

            if(cpuChoice == userChoice)
            {
                Console.WriteLine("Partie nulle! Nous avons choisi le même élément !");
            }
            if(cpuChoice == "roche")
            {

                switch (userChoice)
                {
                    case "ciseau":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " Je gagne la partie");
                        break;
                    case "papier":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " vous avez gagné la partie !");
                        break;

                }
            }
            if(cpuChoice == "papier")
            {
                switch (userChoice)
                {
                    case "roche":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " Je gagne la partie");
                        break;
                    case "ciseau":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " vous avez gagné la partie !");
                        break;

                }

            }
            if(cpuChoice == "ciseau")
            {
                switch (userChoice)
                {
                    case "papier":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " Je gagne la partie");
                        break;
                    case "roche":
                        Console.WriteLine("votre choix est " + userChoice + " et mon choix est " + cpuChoice + " vous avez gagné la partie !");
                        break;

                }
            }IsAnotherGame();


        }

        private string GetComputerChoice()
        {
            Random rnd = new Random();
            string[] elementRPC = { "roche", "papier", "ciseau" };
            int position = rnd.Next(3);

            //string choixUser = GetUserChoice("");
            return elementRPC[position];
           
            
        }

        private void JouerADevinette()
        {

        }

        private void AfficherResultatGame(bool isFound, string fruitToFind)
        {

        }

        private bool IsFruitPlayerGood(string fruitPlayer, string fruitToFind)
        {
            return false;
        }

        private string GetFruitWithout3Letters(string fruit)
        {
            return null;
        }

        private int[] GetThreeRandomNumber(string fruit)
        {
            return null;
        }

        private string GetFruit()
        {
            string[] fruits = { "banane", "poire", "pomme", "cerise", "mangue", "figue", "tangerine", "fraise", "framboise", "bleuet" };
            return null;
        }
    }
}
