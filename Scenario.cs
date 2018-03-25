using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Format;
using GameNameSpace;

//All screens are objects of the Scenario class

namespace ScenarioNameSpace
{
    public abstract class Scenario
    {
        //attributes
        //each class that implements this class will have additional attributes depending on the objects to interact with
        private String location;
        private String text;
        private Scenario[] exits = { };
        private Game boundGame;

        //formatter
        private Form formatter;

        //constructor
        public Scenario(Game _game, String _location, String _text)
        {
            location = _location;
            text = _text;
            boundGame = _game;

            formatter = new Form(_game.NormalTextBorder, _game.CenteredTextBorder, _game.TextDelay, _game.DelayAvtivated);
        }

        //get-methods
        public String GetLocation()
        {
            return location;
        }

        public String GetText()
        {
            return text;
        }

        public Scenario[] GetExits()
        {
            return exits;
        }

        public Game GetGame()
        {

            return boundGame;

        }

        public Form GetFormatter()
        {
            return formatter;
        }

        //set-methods
        public void SetExits(params Scenario[] _exits)
        {
            exits = _exits;
        }

        //clears the console and readjusts window size
        public void ResetWindow()
        {
            Console.Clear();
            Console.SetWindowSize(GetGame().WindowWidth, GetGame().WindowHeight);
        }

        //output-methods
        //Standard display method for a scenario
        //TODO: Check private and public
        public void Display()
        {
            ResetWindow();

            //show the current location
            if (!(formatter.IsEmpty(location)))
                Console.WriteLine("Location: " + location);

            //wait 1.0 secs
            //TWEAK: Change the time waited after printing the Location header
            System.Threading.Thread.Sleep(0);
            formatter.Paragraphs(2);

            //print text
            formatter.Show(text);

            Prompt();

            HandleUserInput();
        }

        //simple prompt; same for every regular scenario
        private void Prompt()
        {
            Console.SetCursorPosition(boundGame.NormalTextBorder, boundGame.WindowHeight - 5);
            Console.Write("What are you going to do?> ");
        }

        //handles the user input after the prompt
        //every scenario handles inputs individually and differently
        //so it will be overwritten
        public abstract void HandleUserInput();

    }
}
