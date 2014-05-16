using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entropy.Engine
{
    public class Answer
    {
        public Answer()
        {
        }        

        public string GetAnswer()
        {
            return computeEntropyReversal();
        }

        /// <summary>
        /// Computes answer for reversal of entropy. 
        /// TODO: Input all entities and compute answer.
        /// </summary>
        /// <returns></returns>
        private string computeEntropyReversal()
        {
            return "INSUFFICIENT DATA FOR MEANINGFUL ANSWER";
        }



    }
}
