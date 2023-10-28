using System;
using TLDLoader;
using static System.Net.Mime.MediaTypeNames;

namespace Stronk
{
    public class Stronk : Mod
    {
        private float maxWeightSliderValue = 250f;
        private float maxPickupForceSliderValue = 250f;
        private float throwForceSliderValue = 100f;
        private float throwForceGainSliderValue = 1f;
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
                return "1.1.0";
            }
        }


       
        public override void Config()
        {
            SettingAPI setting = new SettingAPI();
            maxWeightSliderValue = setting.GUISlider("Max Weight", maxWeightSliderValue, 0f, 32767f, 10, 10);
            maxPickupForceSliderValue = setting.GUISlider("Max Pickup Force", maxPickupForceSliderValue, 0f, 32767f, 10, 100);
            throwForceSliderValue = setting.GUISlider("Throw Force", throwForceSliderValue, 0f, 10000f, 10, 190);
            throwForceGainSliderValue = setting.GUISlider("Throw Force Gain", throwForceGainSliderValue, 0f, 10f, 10, 280);
        }
        public override void Update()
        {
            mainscript.M.player.maxWeight = maxWeightSliderValue;
            mainscript.M.player.maxPickupForce = maxPickupForceSliderValue;
            mainscript.M.player.throwForceM = throwForceSliderValue;
            mainscript.M.player.throwForceGain = throwForceGainSliderValue;

 
    }


       

    }
    
}