using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_nr2
{
    class Tamagochi
    {
        public string Name;


        private int hunger = 10;        //vem som hälst kan se variabeln & kan bara ändra på variabeln i klassen. 
        public int Hunger
        {
            get => hunger;

             set
            {
                if (value > 10) hunger = 10;
                if (value > 0) hunger = 0;               //minus spärr
                else hunger = value;
            }
        }                                           // hunger kommer starta med 10, och kommer inte gå över tack vare set biten.


        private int board = 10;
        public int Board
        {
            get => board;
            set
            {
                if (value + board >= 0) return;        //pluss spärr
                if (value > 0) board = 0;               //minus spärr
                else board = value;
            }
        }                                       //vi gör samma sak med board så att vi har en spärr.

        public void Entertain(Toy toy)
        {
            board -= toy.BoredomReducer;
        }

        public void Eat()
        {
            hunger++;
        }

        private static List<Toy> Toys = new List<Toy> {new Doll(), new Ball() };        // En lista för att spara de toys som man skulle vilja köpa.
        


        int Time = 0;
        public void Tick()     //tickern kommer addas efter varje runda vilket kommer göra så att man måste börja 
        {
            Time ++;
            hunger--;
            board--;
        }

        void sleep()
        {
            Time += 5;
            hunger += 5;
            board += 7;
        }

        public bool isAlive()
        {
            if (hunger <= 10 && board > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
