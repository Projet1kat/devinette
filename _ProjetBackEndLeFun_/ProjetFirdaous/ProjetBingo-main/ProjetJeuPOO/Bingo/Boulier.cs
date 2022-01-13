using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier

    {
        //private List<BingoBall>  liste = new List<BingoBall>();

        // public void add(BingoBall element)
        //{
        //  liste.Add(element);
        // }

        //public BingoBall getRanbomBall()   //Random methode 

        //te créer un random
        //extraire une boule de bingo au hazard
        //Random doit être dynamique
        // Random rand = new Random();
        //    BingoBall out = liste.Remove(rand.Next(this.liste.Count));
        //    return out;
        //}

        //public int getSize()
        //{
        //    return 0;
        //}

        //public bool isEmpty()
        //{
        //   return false;
        //}

        //public void restartBoulier()
        //{
        //   //il faut vider le boulier
        //}
        public void add(BingoBall element)
        {
            throw new NotImplementedException();
        }

        public BingoBall getRanbomBall()
        {
            throw new NotImplementedException();
        }

        public int getSize()
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public void restartBoulier()
        {
            throw new NotImplementedException();
        }
    }
}
