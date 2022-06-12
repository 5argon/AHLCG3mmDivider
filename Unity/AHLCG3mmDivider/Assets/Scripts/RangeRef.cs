using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    [Serializable]
    internal class RangeRef
    {
        [SerializeField] internal GameObject go;
        [SerializeField] internal Image icon;
        [SerializeField] internal TMP_Text rangeLeft;
        [SerializeField] internal TMP_Text rangeRight;
        [SerializeField] internal TMP_Text rangeDash;
        [SerializeField] internal TMP_Text rangeSubText;

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.rangeDisplay);
            if (gs.rangeDisplay)
            {
                icon.gameObject.SetActive(gs.removeRangeIcon ? false : true);
                icon.sprite = gs.removeRangeIcon ? null : gs.iconDisplayIcon;
                rangeSubText.text = gs.rangeSubText.IsEmpty ? string.Empty : gs.rangeSubText.GetLocalizedString();
                if (gs.rangeFrom == 0 && gs.rangeTo == 0)
                {
                    rangeLeft.text = "";
                    rangeRight.text = "";
                    rangeDash.gameObject.SetActive(false);
                }
                else if (gs.rangeFrom != 0 && gs.rangeTo == 0)
                {
                    rangeLeft.text = $"<mspace=0.55em>{gs.rangeFrom}</mspace>";
                    rangeRight.text = "";
                    rangeDash.gameObject.SetActive(false);
                }
                else
                {
                    rangeLeft.text = $"<mspace=0.55em>{gs.rangeFrom:000}</mspace>";
                    rangeRight.text = $"<mspace=0.55em>{gs.rangeTo:000}</mspace>";
                    rangeDash.gameObject.SetActive(true);
                }
            }
        }
    }
}