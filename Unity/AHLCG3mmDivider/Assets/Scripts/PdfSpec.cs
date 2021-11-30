using UnityEngine;

namespace E7.AhLcgMiniDivider
{
    [CreateAssetMenu]
    internal class PdfSpec : ScriptableObject
    {
        [SerializeField] internal string pdfName;

        [SerializeField] internal GenSpec[] genSpecs;
    }
}