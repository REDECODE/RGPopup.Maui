﻿namespace RGPopup.Maui
{
    public class Config
    {
        public const string InitializationDescriptionUrl = "https://github.com/rotorgames/Rg.Plugins.Popup/wiki/Getting-started#initialization";
        public const string MigrationV1_0_xToV1_1_xUrl = "https://github.com/rotorgames/Rg.Plugins.Popup/wiki/Migration-from-v1.0.x-to-v1.1.x";

        public static Config Instance { get; } = new Config();

        public bool FixKeyboardOverlap { get; set; } = true;
        
        public Action? BackPressHandler { get; set; }
    }
}
