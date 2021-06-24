using MissingUnityTypes;
using NPlugins.Interfaces;
using System;

namespace NPlugins.Base
{
    public class Plugin : IPlugin
    {
        public virtual float GetWaterLevel(Vector3 pos)
        {
            throw new NotImplementedException();
        }

        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
