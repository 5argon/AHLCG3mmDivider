using UnityEngine;
using UnityEngine.Localization;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class PlayerCornerSpec : ScriptableObject
    {
        [SerializeField] internal Color playerCornerColor;

        [SerializeField] internal LocalizedString playerCornerText;
    }
}