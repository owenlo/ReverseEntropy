using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy.Engine
{
    public static class QueryFactory
    {
        public static Answer Instantiate(Question question)
        {
            switch (question)
            {
                case Question.EarthEntropyReversal:
                    return new Answer();
                case Question.LifeMeaning:
                    return new Answer();
                case Question.SumOfOneandOne:
                    return new Answer();
                default:
                    return null;
            }
        }

        public enum Question
        {
            LifeMeaning,
            EarthEntropyReversal,
            SumOfOneandOne
        }
    }
}
