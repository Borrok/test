using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    public class Form
    {
        private int normalTextBorder;
        private int centeredTextBorder;
        private int textDelay;
        private bool delayEnable;

        public Form(int _normalTextBorder, int _centeredTextBorder, int _textDelay, bool _delayEnable)
        {
            normalTextBorder = _normalTextBorder;
            centeredTextBorder = _centeredTextBorder;
            textDelay = _textDelay;
            delayEnable = _delayEnable;
        }

        //some formatting methods
        //creates beautiful Stringoutput iwth building up text
        public void Show(String _string)
        {
            //we want a border on each side; (WindowWidth - (borderWidth*2)) spaces left for a String in ONE line
            int borderWidth = normalTextBorder;

            //time to wait between printing single symbols in ms
            bool delayText = delayEnable;
            int delay = textDelay;

            String argS = _string;

            //as long as the string is longer than theres space in one line
            while (argS.Length > Console.WindowWidth - 2 * borderWidth)
            {
                //hint for the -1: indices begin with 0!
                int toplimit = Console.WindowWidth - (2 * borderWidth) - 1;

                //look at the (Console.WindowWidth - (2 * borderWidth) +1)th symbol (e.g. WindowWidth: 120, borderWidth:10; 120-(20)+1 = 101th symbol) 
                //and see if its in the middle of a word; 
                //decrease the toplimit until theres a " " on the right side of string[toplimit]
                while (!(argS.ElementAt(toplimit + 1).Equals(' ')))
                {
                    toplimit--;

                    //if a word in the string is longer than 100 and cannot be displayed properly
                    if (toplimit < 0)
                    {
                        Console.WriteLine("WORD IN ARGUMENT STRING IS TOO LARGE (Longer than " + (Console.WindowWidth - borderWidth * 2) + " symbols)\nConsole will exit on next buttn press.\n@Format.Show()");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                }
                Console.SetCursorPosition(borderWidth, Console.CursorTop);

                //first max toplimit+1 symbols
                //substring-parameters: 1. starting position (included), 2. length!!!!
                String substring = argS.Substring(0, toplimit + 1);

                if (delayText)
                {
                    ShowSlow(substring, delay);
                }
                else
                {
                    Console.WriteLine(substring);
                }

                //cut the unnecessary space-character (toplimit + 2)
                argS = argS.Substring(toplimit + 2);
            }

            Console.SetCursorPosition(borderWidth, Console.CursorTop);
            if (delayText)
            {
                ShowSlow(argS, delay);
            }
            else
            {
                Console.WriteLine(argS);
            }
        }

        //used in Show
        //creates delayed Stringoutput
        //works like a slow Console.WriteLine()
        public void ShowSlow(String _text, int _delay)
        {
            foreach (char symbol in _text)
            {
                Console.Write(symbol);
                System.Threading.Thread.Sleep(_delay);
            }

            Console.WriteLine();
        }

        //shows text centered in the middle of the screen
        public void ShowCentered(String _string)
        {
            //centered screen often display a smaller quantity of text, so bigger borders would look more appealing
            //we want a border on each side; (WindowWidth - (borderWidth*2)) spaces left for a String in ONE line
            int borderWidth = centeredTextBorder;

            //time to wait between printing single symbols in ms
            bool delayText = delayEnable;
            int delay = textDelay;

            String argS = _string;
            int totalStringHeight = GetStringHeight(argS, borderWidth);

            //vertical position
            Console.SetCursorPosition(0, (Console.WindowHeight - totalStringHeight) / 2);

            //as long as the string is longer than theres space in one line
            while (argS.Length > Console.WindowWidth - 2 * borderWidth)
            {
                //hint for the -1: indices begin with 0!
                int toplimit = Console.WindowWidth - (2 * borderWidth) - 1;

                //look at the (Console.WindowWidth - (2 * borderWidth) +1)th symbol (e.g. WindowWidth: 120, borderWidth:10; 120-(20)+1 = 101th symbol) 
                //and see if its in the middle of a word; 
                //decrease the toplimit until theres a " " on the right side of string[toplimit]
                while (!(argS.ElementAt(toplimit + 1).Equals(' ')))
                {
                    toplimit--;

                    //if a word in the string is longer than 100 and cannot be displayed properly
                    if (toplimit < 0)
                    {
                        Console.WriteLine("WORD IN ARGUMENT STRING IS TOO LARGE (Longer than " + (Console.WindowWidth - borderWidth * 2) + " symbols)\nConsole will exit on next buttn press.\n@Format.ShowCentered()");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                }
                //first max toplimit+1 symbols
                //substring-parameters: 1. starting position (included), 2. length!!!!
                String substring = argS.Substring(0, toplimit + 1);

                //horizontal position depending on the individual substring
                Console.SetCursorPosition((Console.WindowWidth - substring.Length) / 2, Console.CursorTop);

                if (delayText)
                {
                    ShowSlow(substring, delay);
                }
                else
                {
                    Console.WriteLine(substring);
                }

                //cut the unnecessary space-character (toplimit + 2)
                argS = argS.Substring(toplimit + 2);
            }

            Console.SetCursorPosition((Console.WindowWidth - argS.Length) / 2, Console.CursorTop);
            if (delayText)
            {
                ShowSlow(argS, delay);
            }
            else
            {
                Console.WriteLine(argS);
            }
        }

        //simply prints x amounts of paragraphs
        public void Paragraphs(int x)
        {
            String pgs = "";
            for (int i = 0; i < x; i++)
            {
                pgs += "\n";
            }
            Console.Write(pgs);
        }

        //checks height of given String on output depending on window dimensions and borderwidth
        public int GetStringHeight(String _text, int _bordrWidth)
        {
            //Spaces in one line: (WindowWidth - 2 * _borderWidth)
            String argS = _text;
            int height = 1;

            while (argS.Length > Console.WindowWidth - 2 * _bordrWidth)
            {
                int toplimit = Console.WindowWidth - 2 * _bordrWidth - 1;

                //look at the ((WindowWidth - 2 * _borderWidth) +1)th symbol and see if its in the middle 
                //of a word; decrease the toplimit until theres a " " on the right side of string@toplimit

                while (!(argS.ElementAt(toplimit + 1).Equals(' ')))
                {
                    toplimit--;

                    //if a word in the string is longer than 100 and cannot be displayed properly
                    if (toplimit < 0)
                    {
                        //TODO: edit error message
                        Console.WriteLine("WORD IN ARGUMENT STRING IS TOO LARGE (Longer than 100 symbols)\nConsole will exit on next buttn press.\n@Format.GetStringHeight()");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                }
                //everytime we cut the given string in piece 'x' and piece 'rest' in Format.Show() we write 'x' 
                //in one line and repeat the process for 'rest' in the next line. 
                //so everytime we cut we increment height by 1
                height++;

                //cut the unnecessary space-character (toplimit + 2)
                argS = argS.Substring(toplimit + 2);
            }

            //just for debugging
            //Console.WriteLine("The height of String:");
            //Show(_text);
            //Console.WriteLine("is " + height);

            //returnstatement
            return height;
        }

        //checks if a string only contains spaces
        public bool IsEmpty(String _str)
        {
            foreach (char x in _str)
            {
                if (!(x.Equals(' ')))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
