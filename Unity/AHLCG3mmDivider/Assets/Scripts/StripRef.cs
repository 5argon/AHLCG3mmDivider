using System;
using System.Runtime.InteropServices.ComTypes;
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
        [SerializeField] internal TMP_Text text;

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.setDisplay);
            if (gs.setDisplay)
            {
                imageColor.color = gs.setSpec.setStripColor;
                text.text = gs.setSpec.setStripText.IsEmpty
                    ? string.Empty
                    : gs.setSpec.setStripText.GetLocalizedString();
            }
        }
    }
}