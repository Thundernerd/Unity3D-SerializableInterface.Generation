using UnityEngine;

namespace TNRD.SerializableInterface.Generation
{
    public class GeneratorSettingsAsset : ScriptableObject
    {
        [SerializeField] private string classPrefix = "S";
        [SerializeField] private string filenameSuffix = ".g";

        public string ClassPrefix
        {
            get => classPrefix;
            set => classPrefix = value;
        }

        public string FilenameSuffix
        {
            get => filenameSuffix;
            set => filenameSuffix = value;
        }
    }
}
