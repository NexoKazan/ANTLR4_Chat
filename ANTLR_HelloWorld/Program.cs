﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4;
using Antlr4.Runtime;

namespace ANTLR_HelloWorld
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string input = "";
                StringBuilder text = new StringBuilder();
                Console.WriteLine("Input the chat.");

                // to type the EOF character and end the input: use CTRL+D, then press <enter>
                while ((input = Console.ReadLine()) != "\u0004")
                {
                    text.AppendLine(input);
                }               
                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                SpeakLexer speakLexer = new SpeakLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
                SpeakParser speakParser = new SpeakParser(commonTokenStream);

                SpeakParser.ChatContext chatContext = speakParser.chat();
                SpeakVisitor visitor = new SpeakVisitor();
                visitor.Visit(chatContext);

                foreach (var line in visitor.Lines)
                {
                    Console.WriteLine("{0} has said {1}", line.Person, line.Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
  
}

