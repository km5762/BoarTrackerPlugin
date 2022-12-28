using System;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;


namespace BoarTrackerPlugin
{
    public class BoarPlugin : IPlugin
    {
        BoarTracker bt;

        public string Author
        {
            get { return "km5762"; }
        }

        public string ButtonText
        {
            get { return "Settings"; }
        }

        public string Description
        {
            get { return "A simple plugin to track and display the number of your Elwynn Boars that have died."; }
        }

        public MenuItem MenuItem
        {
            get { return null; }
        }

        public string Name
        {
            get { return "Boar Tracker"; }
        }

        public void OnButtonPress()
        {
        }

        public void OnLoad()
        {
            BoarDisplay display = new BoarDisplay();
            bt = new BoarTracker(display);

            GameEvents.OnGameStart.Add(bt.GameStart);
            GameEvents.OnInMenu.Add(bt.InMenu);
            GameEvents.OnPlayerPlayToGraveyard.Add(bt.PlayerPlayToGraveyard);
        }

        public void OnUnload()
        {
            if (bt != null)
            {
                bt.Dispose();
            }
        }

        public void OnUpdate()
        {
        }

        public Version Version
        {
            get { return new Version(0, 1, 1); }
        }   
    }
}
