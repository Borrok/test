using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Special_ScenariosNameSpace;
using ScenarioNameSpace;



namespace GameNameSpace
{
    public class Game
    {
        /*
        Random rnd = new Random();

        private int charSTR = (new Random()).Next(1, 10);
        private int charDEX = (new Random()).Next(1, 10);
        private int charINT = (new Random()).Next(1, 10);
        private int charCHA = (new Random()).Next(1, 10);
        */

        //screen variables
        private int windowWidth;
        private int windowHeight;
        private int normalTextBorder;
        private int centeredTextBorder;
        private int textDelay;
        private bool enableDelay;

        //story variables
        private String userName;
        private bool borrok_saved; //currently unused

        //at the beginning one object of the class game will be created
        //every object of a subclass of scenario will have that game object as a param in their constructor so the methods can access
        public Game(int _windowWidth, int _windowHeight, int _normalTextBorder, int _centeredTextBorder, int _textDelay, bool _enableDelay)
        {
            borrok_saved = false;
            windowWidth = _windowWidth;
            windowHeight = _windowHeight;
            normalTextBorder = _normalTextBorder;
            centeredTextBorder = _centeredTextBorder;
            textDelay = _textDelay;
            enableDelay = _enableDelay;
        }

        //get set (a la c#)
        public bool BorrokSaved
        {
            get
            {
                return borrok_saved;
            }
            set
            {
                borrok_saved = value;
            }
        }

        public String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public int WindowHeight
        {
            get
            {
                return windowHeight;
            }
        }

        public int WindowWidth
        {
            get
            {
                return windowWidth;
            }
        }

        public int NormalTextBorder
        {
            get
            {
                return normalTextBorder;
            }
        }

        public int CenteredTextBorder
        {
            get
            {
                return centeredTextBorder;
            }
        }

        public int TextDelay
        {
            get
            {
                return textDelay;
            }
        }

        public bool DelayAvtivated
        {
            get
            {
                return enableDelay;
            }
        }

    }
}
