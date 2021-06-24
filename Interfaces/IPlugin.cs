using MissingUnityTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPlugins.Interfaces
{
    interface IPlugin
    {
        void Initialize();

        float GetWaterLevel(Vector3 pos);
    }
}
