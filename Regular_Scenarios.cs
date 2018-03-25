using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScenarioNameSpace;
using GameNameSpace;
using Special_ScenariosNameSpace;

namespace Regular_ScenariosNamesSpace
{
    //00 Cell
    class Scenario00 : Scenario
    {
        //scene related centered screens
        private CenteredScreen csDoor;

        //counts the nr of actions taken by the player
        private int nr_actions = 0;

        //descriptions of interactable items
        private String info_door;



        //location and displayed text
        public Scenario00(Game _game) : base(_game, "Dungeon Cell", "You slowly manage to open up your eyes. Fatigue and hunger have become your greatest enemies in this very cell you dont know how much time you have spent in. However, after a few minutes you manage to sit up crooked on your BED...which is as much ‚BED‘ as your sleep is actual sleep and  you feel like you have not even slept at all. You take a glance at your cell, while, in the background, the GUARDS continue their - almost intentionally you get the impression - loud conversation about how they are going to spend their evenings. Since you have spent a whole lot of time here in this sickeningly lousy place – it could be weeks but it could also be months – and you have lost track of time completely this is the only way to get information about the daytime...or anything about the outside world at all. Your cell is a surprisingly big one with a high ceiling you can move freely in and have some exercise in if you had the strength to do so. You can also fully stand up without problems and there also is a TOILET in here even if it is just a hole in the floor. It serves its purpose. The grey brick walls are wet and mossy and you have already learned better not to touch them if you wanna keep your last bit of hygiene. The scent of sweat and feces lies within the air and although you have become used to the mixture of smells you still feel disgusted and nauseous. You stand up from your BED. Your legs are weak but strong enough to support your scraggy body. Theres a rusty old iron bar DOOR hindering you from escaping.")
        {
            //inititalizing centered screens and item descriptions
            //doorscreen
            info_door = "The door is old and rusty. You are sure you could smash the lock easily with something solid. If you only had something like this and the guards would not be there...";
            csDoor = new CenteredScreen(_game, GetLocation(), info_door);
        }


        public override void HandleUserInput()
        {
            if (nr_actions < 3)
            {
                string input = Console.ReadLine();

                if (input.Contains("door") && input.Contains("go"))
                {
                    csDoor.Display();
                    nr_actions++;
                    Display();
                }
                else
                {
                    Display();
                }
            }
            else
            {
                GetExits()[0].Display();
            }
        }


    }

    //01 Collapsing Dungeon Hallway
    class Scenario01 : Scenario
    {
        public Scenario01(Game _game) : base(_game, "Collapsing Dungeon Hallway", "asdf sdf asdf asdf asdfasfsadfsdafsdafsadf sadfsdafasdf sdafsadfasdf sadfasdfasdfsadfasfasfasdfasfasdfasdf asdfasfd asdfasdf afsdfasdfasfdsdfasdfsdfsdfasf asfasdfasd fasdfsadfas fasfasdfsafas fasfsaf safsadfsadf asdfasd fasdf asdfasfdasdfas dfasdfasfsgdfgsdfgsd gsdgdsfgdsfgdfsgdsfgdfsg sdgsdfgdsf gsdfgsdf gdsf gsdfgdfsg sdfgdfsgdf sgsdfg sdf g sdfgsdfgsd fgsdfg sdf")
        { }

        public override void HandleUserInput()
        {
            Console.ReadKey();
        }
    }

}

/*
public class scenario00 : Scenario
    {
        public sc00(Game _game) : base(_game, "loc", "text")
        { }

        public override void HandleUserInput()
        {
            
        }
    }
*/
