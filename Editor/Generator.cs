using System;
using System.Collections.Generic;
using System.Linq;
using TNRD.SerializableInterface.Generators;
using UnityEditor;
using UnityEngine;

namespace TNRD.SerializableInterface.Generation
{
    internal class Generator
    {
        [InitializeOnLoadMethod]
        private static void Init()
        {
            List<MonoScript> monoScripts = AssetDatabase.FindAssets("t:monoscript")
                .Select(x => AssetDatabase.GUIDToAssetPath(x))
                .Select(x => AssetDatabase.LoadAssetAtPath<MonoScript>(x))
                .ToList();

            bool hasGenerated = false;

            for (int i = 0; i < monoScripts.Count; i++)
            {
                MonoScript monoScript = monoScripts[i];
                IEnumerable<SerializableInterfaceGenerator> generators = SerializableInterfaceGenerator.Create(
                    monoScript.text,
                    AssetDatabase.GetAssetPath(monoScript),
                    GeneratorSettings.ClassPrefix,
                    GeneratorSettings.FilenameSuffix);

                foreach (SerializableInterfaceGenerator generator in generators)
                {
                    hasGenerated |= generator.Generate(out Exception exception);

                    if (exception != null)
                        Debug.LogException(exception);
                }
            }

            if (hasGenerated)
            {
                AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
            }
        }
    }
}
