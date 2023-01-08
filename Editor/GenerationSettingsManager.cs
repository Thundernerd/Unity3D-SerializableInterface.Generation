using UnityEditor.SettingsManagement;

namespace TNRD.SerializableInterface.Generation
{
    internal static class GenerationSettingsManager
    {
        private static Settings settings;

        private static UserSetting<string> classPrefixSetting = new UserSetting<string>(Settings, "classPrefix", "S");

        private static UserSetting<string> filenameSuffixSetting =
            new UserSetting<string>(Settings, "filenameSuffix", ".g");

        public static Settings Settings
        {
            get
            {
                if (settings == null)
                    settings = new Settings("net.tnrd.serializableinterface.generation");

                return settings;
            }
        }

        public static UserSetting<string> ClassPrefixSetting => classPrefixSetting;

        public static UserSetting<string> FilenameSuffixSetting => filenameSuffixSetting;
    }
}
