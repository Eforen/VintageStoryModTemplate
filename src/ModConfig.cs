using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTemplate.src
{
    class ModConfig
    {
        public static ModConfig instance {get; set;} = new ModConfig();

        // Stone Axes
        [NonSerialized]
        private float _SettingWithDefaultValueAndMinimumValue = 0.8f;
        public float SettingWithDefaultValueAndMinimumValue { 
            get { return _SettingWithDefaultValueAndMinimumValue; } 
            set { _SettingWithDefaultValueAndMinimumValue = value >= 0 ? value : 0; }
        }
        
        public float SettingWithDefaultValue { get; set; } = 0.8f;


        /// <summary>
        /// Are we debugging? 
        /// This will set to true when compiled with the DEBUG symbol in compiler.
        /// This will be defaulted to false when compiled in release mode
        /// </summary>
#if (DEBUG)
        public bool DebugMode { get; set; } = true;
#else
        public bool DebugMode { get; set; } = false;
#endif
    }
}
