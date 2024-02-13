using System;
using TMPro;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

[Serializable]
public class LocalizedStyleSheet : LocalizedAsset<TMP_StyleSheet> {}

[Serializable]
public class UnityEventStyleSheet : UnityEvent<TMP_StyleSheet> {}

public class LocalizeStyleSheet: LocalizedAssetEvent<TMP_StyleSheet, LocalizedStyleSheet, UnityEventStyleSheet>
{
}
