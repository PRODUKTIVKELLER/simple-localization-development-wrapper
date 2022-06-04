using Produktivkeller.SimpleLocalization.Unity;
using UnityEngine;

public class LanguageSwitcher : MonoBehaviour
{
    public void SwitchToEnglish()
    {
        LocalizationService.Instance.ChangeLanguage(Language.EN);
    }

    public void SwitchToChinese()
    {
        LocalizationService.Instance.ChangeLanguage(Language.CHN);
    }

    public void SwitchToGerman()
    {
        LocalizationService.Instance.ChangeLanguage(Language.DE);
    }
}