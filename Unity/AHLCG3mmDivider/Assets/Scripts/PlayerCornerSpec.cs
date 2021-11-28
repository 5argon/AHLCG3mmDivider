using UnityEngine;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class PlayerCornerSpec : ScriptableObject
    {
        [SerializeField] internal Color playerCornerColor;

        [SerializeField] internal string playerCornerText;
    }
}