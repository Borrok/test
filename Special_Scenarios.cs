using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScenarioNameSpace;
using GameNameSpace;
using ASCIIText;

//irregular scenarios with special properties
namespace Special_ScenariosNameSpace
{
    //used for the very first screen
    public class MainScreen : Scenario
    {
        //TWEAK: Change mainscreen message
        public MainScreen(Game _game) : base(_game, "",
                            "Hello, my name is Lionel and this is the first consolebased textadventure-game I have ever done. " +
                            "Since I didn't know too much about programming in C# when I started this I thought it would be a " +
                            "nice and creative exercise to just get into it better. I hope that you will enjoy the outcome of " +
                            "this little project and find yourself enteratined at one point or another. However, if you feel " +
                            "ready for the TIME OF YOUR LIFE go ahead and enter the magical world created by my imagination!")
        {

        }

        //titlescreen should be displayed differently than a regular Scenario
        new public void Display()
        {
            ResetWindow();

            /*
            Logo, text and prompt to start game should be centered on the screen
            Pattern: 
                - show TALogo
                - 2 paragraphs
                - developerMessage
                - 2 paragraphs
                - prompt
            -> total height: 5 + 2 + Height(developerMessage) + 2 + 1 = 10 + Height(developerMessage)
            */


            //position the consolecursor vertically
            Console.SetCursorPosition(Console.CursorLeft, (Console.WindowHeight - (10 + (GetFormatter().GetStringHeight(GetText(), GetGame().NormalTextBorder)))) / 2);

            //output
            ASCII.TALogo();
            GetFormatter().Paragraphs(2);

            GetFormatter().Show(GetText());

            GetFormatter().Paragraphs(2);
            Prompt();

            //wait for userInput
            HandleUserInput();
        }

        //new unique prompt for the mainscreen
        private void Prompt()
        {
            GetFormatter().Show("Press any key to start the adventure!");
            Console.SetCursorPosition(GetGame().NormalTextBorder + "Press any key to start the adventure!".Length + 1, Console.CursorTop - 1);
        }
        //implement the abstract method AwaitUserInput
        override public void HandleUserInput()
        {
            Console.ReadKey();

            //consecutive screen to the main screen is a NameEntryScreen
            //thus typecast is necessary, otherwise Scenario.Display() will be used
            //see Scenario.SetExits(-->params Scenario[]<-- _exits)
            ((NameEntryScreen)(GetExits()[0])).Display();
        }
    }

    //used for screens that describe certain events like finding objects or object desciptions
    //used inside scenarios
    public class CenteredScreen : Scenario
    {
        public CenteredScreen(Game _game, String _location, String _text) : base(_game, _location, _text)
        { }

        new public void Display()
        {
            ResetWindow();
            Console.WriteLine(GetLocation());

            GetFormatter().ShowCentered(GetText());

            //just put the blinking cursor somewhere it doesnt look too bad
            Console.SetCursorPosition(GetGame().WindowWidth / 2 - 1, Console.CursorTop);

            Console.ReadKey();

        }

        //after a keypress return to screen who called that screen (see display method of that screen)
        override public void HandleUserInput()
        {
            Console.ReadKey();
        }
    }

    //Name entry
    public class NameEntryScreen : Scenario
    {
        private int nameTries = 0;

        public NameEntryScreen(Game _game) : base(_game, "", "Wait! Before your little journey begins you need to tell me your name first!")
        {

        }

        new public void Display()
        {
            ResetWindow();

            ///if the user refuses to enter a valid name
            if (nameTries == 3)
            {
                GetGame().UserName = "Bob";

                CenteredScreen notFunny = new CenteredScreen(GetGame(), "", "Fuck you! Your name is now Bob...");
                notFunny.Display();

                System.Threading.Thread.Sleep(5000);

                //show start logo
                ResetWindow();
                ASCII.StartLogo();

                GetExits()[0].Display();
            }
            else
            {
                //when the user has already made an invalid input
                if (nameTries > 0)
                {
                    Console.WriteLine("Please enter a valid name (max. 20 letters)");
                }

                Console.SetCursorPosition((GetGame().WindowWidth - (GetText().Length)) / 2, (GetGame().WindowHeight) / 2 - 1);

                //max length of username is 20
                GetFormatter().ShowCentered(GetText());
                GetFormatter().Paragraphs(1);

                //print nameinput space
                Console.SetCursorPosition((GetGame().WindowWidth - 24) / 2, Console.CursorTop);
                Console.Write(">                      <"); //">                      <" length is 24

                //move cursor back into the space
                Console.SetCursorPosition(Console.CursorLeft - 22, Console.CursorTop);


                HandleUserInput();
            }
        }

        public override void HandleUserInput()
        {
            String input = Console.ReadLine();

            //if input string is short enough
            if (input.Length < 21)
            {
                //if string is empty
                if (GetFormatter().IsEmpty(input))
                {
                    nameTries++;
                    Display();
                }
                //string is legitimate
                else
                {
                    GetGame().UserName = Trim(input);

                    ResetWindow();
                    ASCII.StartLogo();

                    GetExits()[0].Display();
                }
            }
            else
            {
                nameTries++;
                Display();
            }
        }

        //trims spaces in front and at the end of a string
        public String Trim(String _str)
        {
            String str = _str;

            if (!(GetFormatter().IsEmpty(str)))
            {
                //trim spaces in front
                while (str.ElementAt(0).Equals(' '))
                {
                    str = str.Substring(1, str.Length - 1);
                }

                //trim spaces in front
                while (str.ElementAt(str.Length - 1).Equals(' '))
                {
                    str = str.Substring(0, str.Length - 2);
                }
            }

            return str;
        }
    }
}
