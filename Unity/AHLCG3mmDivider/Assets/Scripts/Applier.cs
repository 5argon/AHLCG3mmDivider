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

        [Space]
        [SerializeField] private IconRef icon1;

        [SerializeField] private IconRef icon2;

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
                playerCornerText1.text = gs.playerCornerSpec.playerCornerText;
                playerCornerText2.text = gs.playerCornerSpec.playerCornerText;
            }

            strip1.ApplySpec(gs);
            strip2.ApplySpec(gs);

            icon1.ApplySpec(gs);
            icon2.ApplySpec(gs);

            mainText1.text = gs.mainText;
            mainText2.text = gs.mainText;
        }
    }
}