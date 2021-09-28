using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    class TicTocToe
    {
        public char[] CreatingBoard()
        {
            char[] array = new char[10];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = ' ';
            }
            return array;
        }

        public char Player()
        {
            Console.WriteLine("Enter the character either X or O");
            char user = Convert.ToChar(Console.ReadLine());
            return user;
        }

        public char ComputerReturnLetter(char user)
        {
            char computerReturn;
            if (user == 'X')
                computerReturn = 'O';
            else
            {
                computerReturn = 'X';
            }
            return computerReturn;
        }
    }
}