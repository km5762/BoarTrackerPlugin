using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker;
using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;

namespace BoarTrackerPlugin
{
    internal class BoarTracker
    {
        private BoarDisplay display;

        public BoarTracker(BoarDisplay display)
        {
            this.display = display;
        }

        internal void GameStart()
        {
            this.display.resetCounter();
            this.display.Show();
        }

        internal void InMenu()
        {
            this.display.Hide();
        }

        internal void PlayerPlayToGraveyard(Card card)
        {
            if (card.Name == "Elwynn Boar")
            {
                this.display.incrementCounter();
            }
        }
        
        internal void Dispose()
        {
            this.display.Close();
        }
    }
}
