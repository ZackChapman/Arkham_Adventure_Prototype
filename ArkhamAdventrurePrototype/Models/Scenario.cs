using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArkhamAdventrurePrototype.Models
{
    public class Scenario
    {
        //public void string ScenarioText()
        //{
        //    typeof(HttpContent).
        //}

        //public ActionResult Index(string id)
        //{
        //    return 

        //}

        public string Scenario1 =

                "You awaken in a small clearing in a forest, groggy, and without memory of how you got here." +
                "Immediately in front of you the trees seem to grow less dense, to your right you catch a " +
                "glimpse of a deer only fifty feet away, to the left you spy a path through the trees close by, " +
                "behind you a murder of crows is flies in the air." +
                "[Option 1 Forward] [Option 2 Left] [Option 3 Right] [Option 4 Behind]";
            //Forward link to number 2, Left link to number 187, Right link to number 315, Behind link to number 302 


        public string Scenario2 =

            "After walking for a few minutes through the trees they become more and more sparse until suddenly" +
            " you stop at a cliff edge. You are on top of some unknown mountain several hundred feet up. In " +
            "front of you there seems to be a path you can take to get down. To the right smoke rises in the air " +
            "over the tree line quite far away. Towards the left there is a path along the cliff edge leading away." +
            " Behind you lies a clearing in the trees. " +
            "[Option 1 Forward] [Option 2 Left] [Option 3 Right] [Option 4 Behind]";
            //Forward link to number 3 Left link to number 316 Right left to number 212 Behind link to number 275 
        

        public string Scenario187 =
       
                "You arrive at a path in the forest that leads to your left and right. The end of the path in neither " +
                "direction can be seen. " +
                "[Option 1 X] [Option 2 Left] [Option 3 Right] [Option 4 Go Back]";
                //Left link to number 192 Right Link to number 188 Go back Link to number 1
        

        public string Scenario315 =
    
                "Slowly you creep your way towards the deer hoping maybe for the chance to pet it and perhaps a nuzzle if " +
                "you’re lucky. You make it about thirty feet away from the deer before it runs away. You make your way back " +
                "to the clearing, and when you look back in the direction the deer is back in the same spot." +
                "[Option 1 Continue] [Option 2 X] [Option 3 X] [Option 4 X]";
            //Continue return to number 275
    

        public string Scenario302 =

                "You follow the murder through the trees, hoping to arrive at some form of other life, when to your dismay you " +
                "arrive at the gates for a small graveyard surrounded by a metal fence that is covered in rust. The gate looks like " +
                "it could be easily opened and entered. " +
                "[Option 1 Go Inside] [Option 2 Go Back] [Option 3 X] [Option 4 X]";
            //Go Inside link to number 303 Go Back Link to Number 275
   

        public string Scenario275 =

            "Immediately in front of you the trees seem to grow less dense. To your right you catch a glimpse of a deer only fifty feet" +
            " away. To the left you spy a path through the trees close by. Behind you is a murder of crows aloft in the air." +
            "[Option 1 Forward] [Option 2 Left] [Option 3 Right] [Option 4 Behind] ";
            //Forward link to number 2, Left link to number 187, Right link to number 315, Behind link to number 302 

    }
}
