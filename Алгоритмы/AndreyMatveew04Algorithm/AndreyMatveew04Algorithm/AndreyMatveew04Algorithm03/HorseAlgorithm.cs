using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndreyMatveew04Algorithm03
{
    class HorseAlgorithm
    {
        private int[][] board;
        public int[][] Board
        {
            get { return board; }
            private set { board = value; }
        }
        public HorseAlgorithm(int lenghtX,int lenghtY)
        {
            Board = new int[lenghtX][];
            for(int i = 0;i < lenghtX;i++)
            {
                Board[i] = new int[lenghtY];
                for (int j = 0;j < lenghtY;j++)
                {
                    Board[i][j] = 0;
                }
            }
        }
        public void SearchSolution(int n,(int x,int y) coordinates)
        {
            if( n == Board.Length * Board[0].Length)
            {
                Board[coordinates.x][coordinates.y] = n;
                Print();
                return;
            }
            if (Board[coordinates.x][coordinates.y] == 0) Board[coordinates.x][coordinates.y] = n;
            Print();

            var nextCoordinates = NextStep(coordinates);
            SearchSolution(n + 1, nextCoordinates);
            return;
        }
        public (int,int) NextStep((int x, int y) coordinates)
        {
            var possibleSteps = PossibleSteps(coordinates);
             var minStepCoordinates = possibleSteps[0];
            int maxSteps = 9;

            for (int i = 0;i < possibleSteps.Count;i++)
            {
                var coordinateSteps = PossibleSteps(possibleSteps[i]);
                if (coordinateSteps.Count < maxSteps)
                {
                    maxSteps = coordinateSteps.Count;
                    minStepCoordinates = possibleSteps[i];
                }
            }
            return minStepCoordinates;
        }
        public List<(int,int)> PossibleSteps((int x, int y) coordinates)
        {
            List <(int, int)> possibleSteps= new List<(int, int)>();

            var conditionsXY = new int[8]
            {
                coordinates.x - 2,//0
                coordinates.x + 1,//1
                coordinates.x + 2,//2
                coordinates.x - 1,//3
                coordinates.y - 1,//4
                coordinates.y + 1,//5
                coordinates.y + 2,//6
                coordinates.y - 2 //7
            };

            if (CheckCoordinates(conditionsXY[0], conditionsXY[4]))
                possibleSteps.Add((conditionsXY[0], conditionsXY[4]));

            if (CheckCoordinates(conditionsXY[0], conditionsXY[5]))
                possibleSteps.Add((conditionsXY[0], conditionsXY[5]));

            if (CheckCoordinates(conditionsXY[3], conditionsXY[6]))
                possibleSteps.Add((conditionsXY[3], conditionsXY[6]));

            if (CheckCoordinates(conditionsXY[1], conditionsXY[6]))
                possibleSteps.Add((conditionsXY[1], conditionsXY[6]));

            if (CheckCoordinates(conditionsXY[2], conditionsXY[5]))
                possibleSteps.Add((conditionsXY[2], conditionsXY[5]));

            if (CheckCoordinates(conditionsXY[2], conditionsXY[4]))
                possibleSteps.Add((conditionsXY[2], conditionsXY[4]));

            if (CheckCoordinates(conditionsXY[3], conditionsXY[7]))
                possibleSteps.Add((conditionsXY[3], conditionsXY[7]));

            if (CheckCoordinates(conditionsXY[1], conditionsXY[7]))
                possibleSteps.Add((conditionsXY[1], conditionsXY[7]));

            return possibleSteps;
        }
        public bool CheckCoordinates(int x,int y)
        {
            bool coordinateBounds = x >= 0 && y >= 0 && x < Board.Length && y < Board.Length;
            if (coordinateBounds && Board[x][y] == 0) return true;

            return false;
        }
        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < Board.Length; i++)
            {
                for (int j = 0; j < Board[i].Length; j++)
                    Console.Write(Board[i][j] + " |");
                Console.WriteLine();
            }
        }
    }
}
