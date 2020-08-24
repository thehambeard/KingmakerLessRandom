using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingmaker.RuleSystem;
using Kingmaker.RuleSystem.Rules;
using ModMaker;
using ModMaker.Utility;
using UnityModManagerNet;
using GL = UnityEngine.GUILayout;

namespace KingmakerLessRandom.Menu
{
    class Settings : IModEventHandler, IMenuTopPage
    {
        public int Priority => 100;

        public string Name => "Settings";

        public void HandleModDisable()
        {
            
        }

        public void HandleModEnable()
        {
            
        }

        public void OnGUI(UnityModManager.ModEntry modEntry)
        {
            using (new GUISubScope("Settings", "Box"))
            {
                if (GL.Button("TEST", GL.ExpandWidth(false)))
                {
                    Main.Mod.Debug("TEST");
                    for(int i = 0; i < 20; i++)
                    {
                        Main.Mod.Debug(RulebookEvent.Dice.D4);
                        //Main.Mod.Debug(Bucket.BucketWrapper.D4.Result());
                    }
                }
            }
        }
    }
}
