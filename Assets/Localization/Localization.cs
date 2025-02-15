using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Localization : MonoBehaviour
{
    private bool _active = false;


    // Start is called before the first frame update
    void Start()
    {
        int ID = PlayerPrefs.GetInt("LocaleKey", 0);
        
        ChangeLocale(ID);
    }

    public void ChangeLocale(int localeID)
    {
        if (_active)
        {
            return;
        }
        StartCoroutine(SetLocale(localeID));
    }

    private IEnumerator SetLocale(int localeID)
    {
        _active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];
        PlayerPrefs.SetInt("LocaleKey", localeID);
        _active = false;

    }
}
