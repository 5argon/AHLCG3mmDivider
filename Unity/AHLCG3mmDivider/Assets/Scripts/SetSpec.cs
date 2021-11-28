using UnityEngine;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class SetSpec : ScriptableObject
    {
        [SerializeField] internal Color setStripColor;
        [SerializeField] internal string setStripText;
    }
}