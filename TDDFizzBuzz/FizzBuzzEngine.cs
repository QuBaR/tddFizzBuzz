using System;
using System.Collections.Generic;
using System.Text;

namespace TDDFizzBuzz
{
    public class FizzBuzzEngine
    {
        public int Value { get; set; }
        
        // Adds one to Value
        public void Step()
        {
            Value++;
        }

        // Controlls if Value is divesable by 3, 5 or both and return Message
        public string GetFizzBuzzString()
        {
            var message = string.Empty;
            
            if (Value % 5 == 0) 
                message = "Buzz";

            if (Value % 3 == 0) 
                message = "Fizz";

            if (Value % 15 == 0) 
                message = "FizzBuzz";

            if (message == "") 
                message = Value.ToString();

            return message;
        }
    }
}
