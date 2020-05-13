using System.Collections.Generic;

namespace TestWebApp.BLL
{
    /// <summary>
    /// Originally written by Marco Costa on 5/1
    /// </summary>
    public class MarcoFib
    {
        public List<long> fibSequence = new List<long>();
        private const int MAX_N = 50;

        public MarcoFib(int num)
        {
            SetFibSequence(num);
        }

        public void SetFibSequence(int num)
        {
            if (num >= 1)
            {
                fibSequence.Add(1);
            }
            else
            {
                fibSequence.Add(0);
            }
            if (num >= 2)
            {
                fibSequence.Add(2);
            }

            if (num >= 3)
            {
                for (int i = 2; (i < num && i < MAX_N); i++)
                {
                    fibSequence.Add(fibSequence[i - 1] + fibSequence[i - 2]);
                }
            }
        }

    }
}