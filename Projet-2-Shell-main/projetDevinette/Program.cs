using System;
using System.Collections.Generic;
using System.Linq;

namespace projetDevinette
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.startPlay();
        }
        
        private void afficherMenu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Veuillez choisir le jeu à jouer");
            Console.WriteLine("1- Roche/papier/ciseau   2- La devinette   3- Quitter");
            Console.WriteLine("----------------------------------------------------------");
        }

        private void startPlay()
        {
            string inputNumber = null;
            selectChoice(inputNumber);
        }

        private void selectChoice(string choice)
        {
            do
            {
                afficherMenu();
                choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        jouerRochePapierCiseau();
                        break;

                    case "2":
                        jouerDevinette();
                        break;

                    case "3":
                        break;

                    default:
                        afficherMessageErreur();
                        break;
                }

            }
            while (choice != "3");
        }

        private void afficherMessageErreur()
        {
            Console.WriteLine();
            Console.WriteLine("Veuillez effectuer un choix valide:");
        }

        private void jouerRochePapierCiseau()
        {
            Console.WriteLine();
            Console.WriteLine("Bienvenue dans le jeu roche/papier/ciseau");
            Console.WriteLine("----------------------------------------------------------");

            var random = new Random();
            var list = new List<string> { "roche", "papier", "ciseau" };
            int index = random.Next(0,3);
            string machineChioce = list[index];

            Console.WriteLine();
            Console.WriteLine("J'ai déjà choisis mon élément! À votre tour de choisir l'élément: (éléments=roche,papier ou ciseau)");
            string userChoice = Console.ReadLine();

            while (userChoice != "roche" & userChoice != "papier" & userChoice != "ciseau")
            {
                Console.WriteLine();
                Console.WriteLine("Votre choix est invalide, veuillez le saisir à nouveau:");
                Console.WriteLine("J'ai déjà choisis mon élément! À votre tour de choisir l'élément: (éléments=roche, papier ou ciseau)");
                userChoice = Console.ReadLine();
            }

            int machineWin;
            switch (machineChioce)
            {
                case "roche":
                    if (userChoice == "roche")
                    {
                        machineWin = 2;
                        jugeChoice(machineChioce, userChoice, machineWin);

                    }
                    else if(userChoice == "papier")
                    {
                        machineWin = 0;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    else
                    {
                        machineWin = 1;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    break;

                case "papier":
                    if (userChoice == "roche")
                    {
                        machineWin = 1;
                        jugeChoice(machineChioce, userChoice, machineWin);

                    }
                    else if (userChoice == "papier")
                    {
                        machineWin = 2;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    else
                    {
                        machineWin = 0;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    break;

                default:
                    if (userChoice == "roche")
                    {
                        machineWin = 0;
                        jugeChoice(machineChioce, userChoice, machineWin);

                    }
                    else if (userChoice == "papier")
                    {
                        machineWin = 1;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    else
                    {
                        machineWin = 2;
                        jugeChoice(machineChioce, userChoice, machineWin);
                    }
                    break;
            }

            Console.WriteLine(  ); 
            Console.WriteLine("Voulez-vous refaire une partie (O/N) ?");
            string repond = Console.ReadLine();

            while (repond != "o" & repond != "O" & repond != "n" & repond != "N")
            {
                Console.WriteLine();
                Console.WriteLine("Voulez-vous refaire une partie (O/N) ?");
                repond = Console.ReadLine();
            }

            if(repond=="o"|| repond == "O")
            {
                jouerRochePapierCiseau();
            }
 
        }

        private void jugeChoice(string myChoice, string yourChoice,int a)
        {
            if (a == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Partie nulle! Nous avons choisis le même élément!");
            }
            else if(a == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Votre choix est {0} et mon choix est {1}. Je gagne la partie!", yourChoice, myChoice);
            }
            else if (a == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Votre choix est {0} et mon choix est {1}. Vous gagnez la partie!", yourChoice, myChoice);
            }
        }

        private void jouerDevinette()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Bienvenue dans le devinette");
            Console.WriteLine("----------------------------------------------------------");

            var randomfruit = new Random();
            var listDevinette = new List<string> { "banane", "poire", "pomme", "cerise", "mangue", "figue", "tangerine", "fraise", "framboise", "bleuet" };
            int index = randomfruit.Next(0, listDevinette.Count);
            string machineChioce = listDevinette[index];

            bool rightChoice = false;
            Array wordstring= afficher3Letters(machineChioce);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.Write("FRUIT A TROUVER: ");
                for (int j = 0; j < wordstring.Length; j++ )
                {
                    Console.Write( wordstring.GetValue(j));
                }
                Console.WriteLine();

                string userInput = Console.ReadLine();

                if (userInput == machineChioce)
                {
                    rightChoice = true;
                    break;
                }

            }

            if (rightChoice == true)
            {
                Console.WriteLine();
                Console.WriteLine("Bravo! Vos avez trouvé le mot!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Le mot était : {0} ", machineChioce);
            }
        }


        private Array afficher3Letters(string word)
        {
            int[] list3Letter = new int[3];
            var letterList = Enumerable.Range(0, word.Length).ToList();//let the word to a list of letter
            
            var r = new Random();
            int num = letterList.Count;
            list3Letter[0] = r.Next(0, num);
            List<int> list2 = new List<int>();
            // int[] list2 = new int[0];
            for (int i = 0; i < num; i++)
            {
                if (letterList[i] != list3Letter[0])
                {
                    list2.Add(letterList[i]);
                }
            }
            
            num--;


            list3Letter[1] = r.Next(0, num);
            List<int> list3 = new List<int>();
            for (int i = 0; i < num; i++)
            {
                if (list2[i] != list3Letter[1])
                {
                    list3.Add(letterList[i]);
                }
            }
            
            num--;


            list3Letter[2] = r.Next(0, num);
            List<int> list4 = new List<int>();
            for (int i = 0; i < num; i++)
            {
                if (list3[i] != list3Letter[2])
                {
                    list4.Add(letterList[i]);
                }
            }

            num--;

           
            var char_array = word.ToCharArray();
            int k = 0;
            for (int j = 0; j < letterList.Count; j++)
            {
                if (k >= num)
                {
                    break;
                }
                else if (list4[k] == letterList[j])
                {
                    char_array[j] = '_';
                    k++;
                }

            }
            return char_array;



        }

    }

}
