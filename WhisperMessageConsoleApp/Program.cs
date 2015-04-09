﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhisperMessage.Test;
using WhisperMessage;

namespace WhisperMessageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWhisperString whisperStr = new WhisperString();
                Console.WriteLine("Enter a message: ");
                var message = Console.ReadLine();
                var result = whisperStr.ManipulateMessage(message);
                Console.WriteLine("Entered message: {0} \n Manipulated message: {1}", message, result);
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
