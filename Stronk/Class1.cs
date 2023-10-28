using System;
using TLDLoader;
namespace Stronk
{
    public class Stronk : Mod
    {

        public override string ID
        {
            get
            {
                return "Stronk";
            }
        }


        public override string Name
        {
            get
            {
                return "Stronk";
            }
        }


        public override string Author
        {
            get
            {
                return "Zach.O";
            }
        }


        public override string Version
        {
            get
            {
                return "0.0.0";
            }
        }


        public override void OnLoad()
        {
        }

        public override void Update()
        {
            mainscript.M.player.maxWeight = 2147483647f;
            mainscript.M.player.maxPickupForce = 2147483647f;
        }
       


    }
}