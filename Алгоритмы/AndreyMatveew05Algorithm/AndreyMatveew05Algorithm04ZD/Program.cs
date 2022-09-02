using System;
using MyStructures; 

namespace AndreyMatveew05Algorithm04ZD
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 05.
    //Задание 4.*Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PostFix("(3+4)+5*5*(3-2)"));
            Console.ReadLine();
        }

        public static string PostFix(string infix)
        {
            string postfix = "";
            int priority = 0;
            MyStack<char> operators = new();

            for(int i = 0;i < infix.Length;i++)
            {
                if (SymbolOrOperator(infix[i]) == 2 || SymbolOrOperator(infix[i]) == 3)
                {
                    if (operators.Count == 0) operators.Push(infix[i]);
                    else
                    {
                        if (SymbolOrOperator(operators.Peek()) == 2) priority = 1;
                        else priority = 0;

                        if (priority == 1)
                        {
                            postfix += operators.Pop();
                            i--;
                        }
                        else
                        {
                            if (SymbolOrOperator(infix[i]) == 3)
                            {
                                postfix += operators.Pop();
                                operators.Push(infix[i]);
                            }
                            else operators.Push(infix[i]);
                        }
                    }
                }
                else if (SymbolOrOperator(infix[i]) == 4)
                {
                    var result = Parenthesis(infix, ++i);
                    postfix += result.Item1;
                    i = result.Item2;
                }
                else postfix += infix[i];
            }

            foreach (var el in operators)
                postfix += el;

            return postfix;
        }

        public static int SymbolOrOperator(char symbol)
        {
            if (Char.IsNumber(symbol)) return 1;

            if (symbol == '/' || symbol == '*') return 2; 

            if (symbol == '+' || symbol =='-' ) return 3;

            if (symbol == '(') return 4;

            if (symbol == ')') return 5;

            return 0;
        }

        public static (string,int) Parenthesis(string infix, int start)
        {
            string newEquation = "";
            while(SymbolOrOperator(infix[start]) != 5)
            {
                newEquation += infix[start];
                start++;
            }

            return (PostFix(newEquation),start);
        }
    }
}
