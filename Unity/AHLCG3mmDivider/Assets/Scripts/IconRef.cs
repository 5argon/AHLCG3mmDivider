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

        static Color blackColor = new Color(0.2078431f, 0.1803922f, 0.1215686f);

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.iconDisplay);
            if (gs.iconDisplay && gs.iconDisplayIcon != null)
            {
                image.gameObject.SetActive(true);
                image.sprite = gs.iconDisplayIcon;
                if (gs.iconPreserveColor)
                {
                    image.color = Color.white;
                }
                else
                {
                    image.color = blackColor;
                }
            }
            else
            {
                image.gameObject.SetActive(false);
            }
        }
    }
}