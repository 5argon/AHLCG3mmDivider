using System;
using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    [Serializable]
    internal class IconRef
    {
        [SerializeField] internal GameObject go;
        [SerializeField] internal Image image;

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.iconDisplay);
            if (gs.setDisplay && gs.iconDisplayIcon != null)
            {
                image.gameObject.SetActive(true);
                image.sprite = gs.iconDisplayIcon;
            }
            else
            {
                image.gameObject.SetActive(false);
            }
        }
    }
}