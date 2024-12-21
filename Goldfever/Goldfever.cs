using MSCLoader;
using UnityEngine;
using System;
using System.IO;

namespace Goldfever
{
    public class Goldfever : Mod
    {
        #region Mod Properties
        public override string ID { get { return "Goldfever"; } }// Your (unique) mod ID 
        public override string Name { get { return "The Goldfever"; } } // Your mod name
        public override string Author { get { return "OxER10"; } }// Name of the Author (your name)
        public override string Version { get { return "1.0"; } } // Version
        public override string Description { get { return "This mod is inspired by Kummeli Kultakuume movie. In memory of Heikki silvennoinen"; } } // Short description of your mod
        #endregion

        private GameObject goldfeverHint1;
        private GameObject goldfeverHint2;
        private GameObject goldfeverHint3;
        private GameObject goldfeverHint4;
        private GameObject goldfeverMap;

        private readonly string saveFileName= "goldfeverSaveData.txt";
        private readonly string assetBundleFileName = "goldfeverSaveData.unity3d";

        public override void ModSetup()
        {
            SetupFunction(Setup.OnNewGame, Mod_OnNewGame);
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
            SetupFunction(Setup.OnSave, Mod_OnSave);
            SetupFunction(Setup.Update, Mod_Update);
        }

        private void Mod_OnNewGame()
        {
            // Called once, when creating a new game. This is useful for deleting old mod saves
        }
        private void Mod_OnLoad()
        {
            // Called once, when mod is loading after game is fully loaded
        }

        private void Mod_OnSave()
        {
            // Called once, when save and quit
            // Serialize your save file here.
        }
        private void Mod_Update()
        {
            // Update is called once per frame
        }
    }
}
