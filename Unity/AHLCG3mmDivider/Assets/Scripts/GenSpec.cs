using UnityEngine;
using UnityEngine.Localization;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class GenSpec : ScriptableObject
    {
        [SerializeField] internal LocalizedString mainText;

        [Space]
        [SerializeField] internal bool playerCornerDisplay;

        [SerializeField] internal PlayerCornerSpec playerCornerSpec;

        [Space]
        [SerializeField] internal bool setDisplay;

        [SerializeField] internal SetSpec setSpec;
        [SerializeField] internal bool lowerVerticalStrip;

        [Space]
        [SerializeField] internal bool iconDisplay;

        [SerializeField] internal Sprite iconDisplayIcon;

        [Space]
        [SerializeField] internal bool classIconDisplay;

        [SerializeField] internal CardClass firstClass;
        [SerializeField] internal CardClass secondClass;
        [SerializeField] internal CardClass thirdClass;
    }

    internal enum CardClass
    {
        NoClass,
        Guardian,
        Seeker,
        Rogue,
        Mystic,
        Survivor
    }
}