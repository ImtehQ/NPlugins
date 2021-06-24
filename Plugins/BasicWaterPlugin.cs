using MissingUnityTypes;
using NPlugins.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPluginTest.Plugins
{
    public class BasicWaterPlugin : Plugin
    {
        private float WaterLevel { get; set; }

        /// <summary>
        /// Not needed for every plugin, but can be added, just remember to call Initialize()
        /// </summary>
        public BasicWaterPlugin()
        {
            Initialize();
        }

        /// <summary>
        /// Make sure data is set correctly, in not in the constructor can be called manualy
        /// </summary>
        public override void Initialize()
        {
            WaterLevel = 50;
        }

        /// <summary>
        /// Overwrite the default plugin behavior
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public override float GetWaterLevel(Vector3 pos)
        {
            return WaterLevel;
        }
    }
}
