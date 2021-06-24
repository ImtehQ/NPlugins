using NPlugins.Base;
using NPluginTest.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NPluginTest
{
    public class Program
    {

        private static List<Plugin> pluginsList = new List<Plugin>();

        //Simulating Editor interactions
        public static void Main(string[] args)
        {
            Console.WriteLine("Pointers Test");

            //-----------------------------------------------------------------------------------------------------------------

            pluginsList.Add(new BasicWaterPlugin());                                    //List of plugins
            UpdateCycle updateCycle = new UpdateCycle();                                //Unity instance of the update loop
            updateCycle.Start();                                                        // Start call always
            updateCycle.GetWaterLevelPTR = pluginsList.Last<Plugin>().GetWaterLevel;    //Overwrite base with plugin
            updateCycle.Update();                                                       //Run a single frame

            //-----------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }

    }
}
