using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    [Serializable]
    internal class StripRef
    {
        [SerializeField] internal GameObject go;
        [SerializeField] internal Image imageColor;
        [SerializeField] internal GameObject secondaryImageGo;
        [SerializeField] internal Image secondaryImageColor;
        [SerializeField] internal TMP_Text text;

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.setDisplay);
            if (gs.setDisplay)
            {
                secondaryImageGo.SetActive(gs.setSpec.enableSecondarySetStrip);
                if (gs.setSpec.enableSecondarySetStrip)
                {
                    secondaryImageColor.color = gs.setSpec.secondarySetStripColor;
                }

                imageColor.color = gs.setSpec.setStripColor;
                text.text = gs.setSpec.setStripText.IsEmpty
                    ? string.Empty
                    : gs.setSpec.setStripText.GetLocalizedString();
            }
        }
    }
}