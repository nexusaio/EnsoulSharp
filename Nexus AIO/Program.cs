
using EnsoulSharp;
using EnsoulSharp.SDK;
using Nexus_AIO.Champions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexus_AIO
{
    
     class Program
    {
        static void Main(string[] args)
        {
            GameEvent.OnGameLoad += On_LoadGame;
        }
        private static void On_LoadGame()
        {

            if (ObjectManager.Player.CharacterName == ObjectManager.Player.CharacterName)
            {
                Morgana.OnLoad();
                Chat.PrintChat("NEXUS_AIO LOADED, GGWP!");
            }
        }
    }
}
