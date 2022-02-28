using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    public class BracketsOpenClose
    {
        /*Sprawdzanie, czy nawiasy są zrównoważone
         * 
         * Poprawne rozmieszczenie nawiasów
        { ()({ }) { }    <>       (((())))

        niepoprawne
        ><
        () } (( )
            */

        public static void Main2(string[] args)
        {
            Console.WriteLine("Podaj string: ");
            string expression = Console.ReadLine();
            Console.WriteLine(Solution(expression));
        }

        public static bool Solution(string input)
        {
            Stack<char> brackets = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {'(', ')' },
                {'[', ']' },
                {'{', '}' },
                {'<', '>' },
            };
            try
            {
                foreach (var mark in input)
                {
                    //check if mark is open brackets
                    if (bracketPairs.Keys.Contains(mark))
                        brackets.Push(mark); //to stock
                    //is closed brakets
                    else if (bracketPairs.Values.Contains(mark))
                    {
                        //is pair from last to stock brackets
                        if (mark == bracketPairs[brackets.First()])
                        {
                            //move from stock
                            brackets.Pop();
                        }
                        else
                            return false;
                    }
                    else
                        continue;
                }
            }
            catch
            {
                return false;
            }
            //check if all brackets are closed
            return brackets.Count() == 0 ? true : false;
        }
    }
}
