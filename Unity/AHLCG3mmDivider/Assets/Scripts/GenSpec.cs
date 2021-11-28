using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class GenSpec : ScriptableObject
    {
        [SerializeField] internal string mainText;

        [Space]
        [SerializeField] internal bool playerCornerDisplay;

        [SerializeField] internal PlayerCornerSpec playerCornerSpec;

        [Space]
        [SerializeField] internal bool setDisplay;

        [SerializeField] internal SetSpec setSpec;

        [Space]
        [SerializeField] internal bool iconDisplay;

        [SerializeField] internal Sprite iconDisplayIcon;
    }
}