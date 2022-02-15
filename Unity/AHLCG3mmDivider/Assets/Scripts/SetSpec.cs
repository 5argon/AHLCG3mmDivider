using UnityEngine;
using UnityEngine.Localization;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class SetSpec : ScriptableObject
    {
        [SerializeField] internal Color setStripColor;
        [SerializeField] internal LocalizedString setStripText;
        [SerializeField] internal bool enableSecondarySetStrip;
        [SerializeField] internal Color secondarySetStripColor;
    }
}