using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class ListeDeMots
    {
        private string text;
        private int length;
        private Arraylist mots = new Arraylist();
        public ListeDeMots()
        {
          
        }

        public string Text { get => text; set => text = value; }
        public int Length { get => length; set => length = value; }
        internal Arraylist Mots { get => mots; set => mots = value; }
    }
}
