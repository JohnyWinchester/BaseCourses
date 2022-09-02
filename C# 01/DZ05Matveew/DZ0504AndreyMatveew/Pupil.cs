using System;
using System.Collections.Generic;
using System.Text;

namespace DZ0504AndreyMatveew
{
    //Класс содержит имена и оценки учеников
    class Pupil : IComparable
    {
        public string PupilName { get; }
        public int PupilScore { get; }

        public Pupil(string name, int score)
        {
            PupilName = name;
            PupilScore = score;
        }

        //Реализовал интерфейс Icomparable для сортировки учеников
        public int CompareTo(object obj)
        {
            Pupil pup = obj as Pupil;
            if (pup.PupilScore > this.PupilScore) return 1;
            else if (pup.PupilScore < this.PupilScore) return -1;
            return 0;
        }
    }

}
