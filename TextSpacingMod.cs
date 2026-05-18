using BepInEx;
using HarmonyLib;
using TMPro;
using UnityEngine;

[BepInPlugin("com.yourname.textspacingmod", "Text Spacing Mod", "1.0.0")]
public class TextSpacingMod : BaseUnityPlugin
{
    void Awake()
    {
        Harmony harmony = new Harmony("com.yourname.textspacingmod");
        harmony.PatchAll();
        Logger.LogInfo("Text Spacing Mod Loaded");
    }

    [HarmonyPatch(typeof(TextMeshProUGUI), "Awake")]
    public class TextMeshProSpacingPatch
    {
        static void Postfix(TextMeshProUGUI __instance)
        {
            // Set line spacing between each text line (default 1.0f)
            __instance.lineSpacing = 1.2f;

            // enable word wrapping to ensure text wraps properly when it exceeds the width of the container
            __instance.enableWordWrapping = true;

            // Set default font size (optional)
            //__instance.fontSize = 24;
        }
    }
}