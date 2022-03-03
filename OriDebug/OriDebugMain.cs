using BepInEx;

namespace OriDebug
{
    [BepInPlugin("com.sharpice.oridebug", "OriDebug", "1.0.0")]
    [BepInProcess("oriDE.exe")]
    public class OriDebugMain : BaseUnityPlugin
    {
        private void Awake()
        {
            CheatsHandler.DebugAlwaysEnabled = true;
        }
    }
}
