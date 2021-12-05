using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace E7.AhLcgMiniDivider
{
    [Serializable]
    internal class ClassIconRef
    {
        [SerializeField] internal GameObject go;
        [SerializeField] internal Image classIcon1;
        [SerializeField] internal Image classIcon2;
        [SerializeField] internal Image classIcon3;

        [SerializeField] internal Sprite guardian;
        [SerializeField] internal Sprite seeker;
        [SerializeField] internal Sprite rogue;
        [SerializeField] internal Sprite mystic;
        [SerializeField] internal Sprite survivor;

        internal void ApplySpec(GenSpec genSpec)
        {
            var gs = genSpec;
            go.SetActive(gs.classIconDisplay);
            if (gs.classIconDisplay)
            {
                classIcon1.gameObject.SetActive(gs.firstClass != CardClass.NoClass);
                classIcon2.gameObject.SetActive(gs.secondClass != CardClass.NoClass);
                classIcon3.gameObject.SetActive(gs.thirdClass != CardClass.NoClass);

                classIcon1.sprite = GetSprite(gs.firstClass);
                classIcon2.sprite = GetSprite(gs.secondClass);
                classIcon3.sprite = GetSprite(gs.thirdClass);
            }
        }

        private Sprite GetSprite(CardClass c)
        {
            return c switch
            {
                CardClass.NoClass => default,
                CardClass.Guardian => guardian,
                CardClass.Seeker => seeker,
                CardClass.Rogue => rogue,
                CardClass.Mystic => mystic,
                CardClass.Survivor => survivor,
                _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
            };
        }
    }
}