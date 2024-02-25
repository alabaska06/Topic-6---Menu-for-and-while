using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5___Making_an_new_class
{
    public class Die
    {
        private int _roll;
        private Random _genorator;

        public Die() //this is your constructer, you can call this code from main
        { 
        _genorator = new Random();
        _roll = _genorator.Next(1, 7);
        }

        public int Roll
        {
            get { return _roll; }
        }

        public int RollDie()//get a new roll
        {
            _roll = _genorator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.Write("_______\r\n|      |\r\n|  o   |\r\n|______|\r\n");
            }
            else if (_roll == 2)
            {
                Console.Write("_______\r\n|  o   |\r\n|      |\r\n|____o_|\r\n");
            }
            else if (_roll == 3)
            { 
                Console.Write("_______\r\n| o    |\r\n|  o   |\r\n|____o_|\r\n");
            }
            else if (_roll == 4)
            {
                Console.Write("_______\r\n| o  o |\r\n|      |\r\n|_o__o_|\r\n");
            }
            else if (_roll == 5)
            {
                Console.Write("_______\r\n| o  o |\r\n|  o   |\r\n|_o__o_|\r\n");
            }
            else if (_roll == 6)
            {
                Console.Write("_______\r\n| o  o |\r\n| o  o |\r\n|_o__o_|\r\n");
            }
        }
        public override string ToString()//not needed
        {
            return _roll.ToString();
        }



    }
}
