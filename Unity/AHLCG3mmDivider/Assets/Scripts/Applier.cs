using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    internal class Applier : MonoBehaviour
    {
        [SerializeField] private GenSpec genSpec;

        [Space]
        [SerializeField] private GameObject playerCornerObject;

        [SerializeField] private Image playerCornerColor;
        [SerializeField] private TMP_Text playerCornerText1;
        [SerializeField] private TMP_Text playerCornerText2;

        [Space]
        [SerializeField] private TMP_Text mainText1;

        [SerializeField] private TMP_Text mainText2;

        [Space]
        [SerializeField] private StripRef strip1;

        [SerializeField] private StripRef strip2;

        [SerializeField] private StripRef strip3;

        [Space]
        [SerializeField] private IconRef icon1;

        [SerializeField] private IconRef icon2;

        [Space]
        [SerializeField] private ClassIconRef classIconRef1;

        [SerializeField] private ClassIconRef classIconRef2;

        [Space]
        [SerializeField] private RangeRef rangeRef1;

        [SerializeField] private RangeRef rangeRef2;

        [ContextMenu("Gen")]
        internal void Gen()
        {
            Gen(genSpec);
        }

        internal void Gen(GenSpec gs)
        {
            playerCornerObject.SetActive(gs.playerCornerDisplay);
            if (gs.playerCornerDisplay)
            {
                playerCornerColor.color = gs.playerCornerSpec.playerCornerColor;
                playerCornerText1.text = gs.playerCornerSpec.playerCornerText.IsEmpty
                    ? string.Empty
                    : gs.playerCornerSpec.playerCornerText.GetLocalizedString();
                playerCornerText2.text = gs.playerCornerSpec.playerCornerText.IsEmpty
                    ? string.Empty
                    : gs.playerCornerSpec.playerCornerText.GetLocalizedString();
            }

            strip1.ApplySpec(gs);
            if (!gs.lowerVerticalStrip)
            {
                strip2.ApplySpec(gs);
                strip3.go.SetActive(false);
            }
            else
            {
                strip3.ApplySpec(gs);
                strip2.go.SetActive(false);
            }

            icon1.ApplySpec(gs);
            icon2.ApplySpec(gs);

            rangeRef1.ApplySpec(gs);
            rangeRef2.ApplySpec(gs);

            classIconRef1.ApplySpec(gs);
            classIconRef2.ApplySpec(gs);

            if (!mainText1.gameObject.activeInHierarchy)
            {
                mainText1.gameObject.SetActive(true);
            }
            if(!mainText2.gameObject.activeInHierarchy)
            {
                mainText2.gameObject.SetActive(true);
            }
            mainText1.text = gs.mainText.IsEmpty ? string.Empty : gs.mainText.GetLocalizedString();
            mainText2.text = gs.mainText.IsEmpty ? string.Empty : gs.mainText.GetLocalizedString();
        }
    }
}