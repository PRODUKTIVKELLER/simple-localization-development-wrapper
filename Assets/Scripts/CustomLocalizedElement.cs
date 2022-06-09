using Produktivkeller.SimpleLocalization.Unity;
using Produktivkeller.SimpleLocalization.Unity.Components;
using Produktivkeller.SimpleLocalization.Unity.Core;
using TMPro;
using UnityEngine;

public class CustomLocalizedElement : MonoBehaviour, ILocalized
{
    [SerializeField] private string key;

    private TextMeshProUGUI _text;
    
    public void OnLanguageHasChanged()
    {
        _text.text = LocalizationService.Instance.ResolveLocalizationKey(key);
    }
}