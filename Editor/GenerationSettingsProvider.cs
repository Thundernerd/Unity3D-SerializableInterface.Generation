using UnityEditor;
using UnityEditor.SettingsManagement;

namespace TNRD.SerializableInterface.Generation
{
    internal static class GenerationSettingsProvider
    {
        [SettingsProvider]
        private static SettingsProvider CreateSettingsProvider()
        {
            return new SettingsProvider("Project/Serializable Interface", SettingsScope.Project)
            {
                guiHandler = OnGUI
            };
        }

        private static void OnGUI(string searchContext)
        {
            EditorGUILayout.Space();
            
            GenerationSettingsManager.ClassPrefixSetting.value = SettingsGUILayout.SettingsTextField(
                "Class Prefix",
                GenerationSettingsManager.ClassPrefixSetting,
                searchContext);

            GenerationSettingsManager.FilenameSuffixSetting.value = SettingsGUILayout.SettingsTextField(
                "Filename Suffix",
                GenerationSettingsManager.FilenameSuffixSetting,
                searchContext);
        }
    }
}
