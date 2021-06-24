using MissingUnityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPluginTest
{
    public class UpdateCycle
    {
        private float waterLevel = -2;

        /// <summary>
        /// Overwriteable option for the plugin
        /// </summary>
        public Func<Vector3, float> GetWaterLevelPTR = null;

        /// <summary>
        /// Default start of unity
        /// </summary>
        public void Start()
        {
            GetWaterLevelPTR = GetWaterLevel; //Set the default Method to get the water level;
        }

        /// <summary>
        /// Default Update of unity
        /// </summary>
        public void Update()
        {
            Vector3 pos = new Vector3(0, 10, 0);

            Console.WriteLine(GetWaterLevelPTR(pos));  //<- using pos we ask the water level method ptr
        }


        /// <summary>
        /// Default GetWaterLevel without plugins
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public float GetWaterLevel(Vector3 pos)
        {
            return waterLevel;
        }
    }
}
