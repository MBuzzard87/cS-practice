using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Temperature
    {




        


        public string checkTemp(string input)
        {
            int temp;

            bool success = Int32.TryParse(input, out temp);

            return !success ? "Not a valid temperature" :
                temp <= 15 ? "it is too cold here, it is " + input + " outside" :
                temp >= 16 && temp <= 28 ? "it is ok" : "it is hot here";

        }








    }
}
