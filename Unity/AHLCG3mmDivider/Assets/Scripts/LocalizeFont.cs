using System;
using TMPro;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

[Serializable]
public class LocalizedFont : LocalizedAsset<TMP_FontAsset> {}

[Serializable]
public class UnityEventFont : UnityEvent<TMP_FontAsset> {}

public class LocalizeFont : LocalizedAssetEvent<TMP_FontAsset, LocalizedFont, UnityEventFont>
{
}
