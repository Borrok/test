using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameNameSpace;
using Special_ScenariosNameSpace;
using Regular_ScenariosNamesSpace;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);

            //game format settings
            int windowWidth = 140; //max 240
            int windowHeight = 35; //max 63
            int normalTextBorder = 25; 
            int centeredTextBorder = 40;
            int textDisplayDelay = 5;
            bool enableDelay = false;

            //creating a gameobject containing all variables needed throughout the story
            Game currentGame = new Game(windowWidth, windowHeight, normalTextBorder, centeredTextBorder, textDisplayDelay, enableDelay);

            
            //creating scenarios           
            Scenario01 sc01 = new Scenario01(currentGame);  //01 Collapsing Dungeon Hallway
            Scenario00 sc00 = new Scenario00(currentGame);  //00 Cell
           
            NameEntryScreen nameScreen = new NameEntryScreen(currentGame);  //Namescreen           
            MainScreen titleScreen = new MainScreen(currentGame);           //MainScreen


             //setting the exits for each scenario
            sc00.SetExits(sc01);

            nameScreen.SetExits(sc00);
            titleScreen.SetExits(nameScreen);




            //Gamestart
            titleScreen.Display();

        }
    }
}

/*
"Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet."
*/
