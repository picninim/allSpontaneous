using HarmonyLib;
using UnityModManagerNet;

namespace allSpontaneous
{
    public static class Main
    {
        public static UnityModManager.ModEntry ModEntry;
        public static Harmony HarmonyInstance;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            ModEntry = modEntry;
            HarmonyInstance = new Harmony(modEntry.Info.Id);

            modEntry.OnToggle = OnToggle;
            modEntry.OnGUI = OnGUI;
            modEntry.OnSaveGUI = OnSaveGUI;

            ModEntry.Logger.Log("allSpontaneous loaded.");
            return true;
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            if (value)
            {
                HarmonyInstance.PatchAll();
                ModEntry.Logger.Log("Mod enabled.");
            }
            else
            {
                HarmonyInstance.UnpatchAll(HarmonyInstance.Id);
                ModEntry.Logger.Log("Mod disabled.");
            }
            return true;
        }

        private static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            // TODO: Interface de configuração por classe
        }

        private static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            // TODO: Salvar configurações
        }
    }
}
