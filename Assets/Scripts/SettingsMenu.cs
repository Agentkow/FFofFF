using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour 
{
    [SerializeField]
    Slider volumeSlider;
    [SerializeField]
    Toggle funModeToggle;


    void SaveSettings()
    {
        PlayerPrefs.SetFloat(GlobalConstants.VolumeSetting, volumeSlider.value);

        int funModeValue;
        if (funModeToggle.isOn)
        {
            funModeValue = 1;
        }
        else
        {
            funModeValue = 0;
        }
        PlayerPrefs.SetInt(GlobalConstants.FunModeSetting, funModeValue);
    }

    public void SaveButtonClicked()
    {
        SaveSettings();
    }

    void LoadSettings()
    {
        if (PlayerPrefs.HasKey(GlobalConstants.VolumeSetting))
            volumeSlider.value = PlayerPrefs.GetFloat(GlobalConstants.VolumeSetting);

        if (PlayerPrefs.HasKey(GlobalConstants.FunModeSetting))
            funModeToggle.isOn = PlayerPrefs.GetInt(GlobalConstants.FunModeSetting) > 0;
    }

    
}
