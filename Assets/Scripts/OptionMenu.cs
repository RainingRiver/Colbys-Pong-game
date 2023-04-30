using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private Text volumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float volume)
    {
        volumeTextUI.text = volume.ToString("0.0");
    }

    /// <summary>
    /// this lets you save the volume level
    /// </summary>
    public void SaveVolumeButton()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }

    /// <summary>
    /// this loads the volume level
    /// </summary>
    void LoadValues()
    {
        float volumeVlaue = PlayerPrefs.GetFloat("VolumeValue");
        volumeSlider.value = volumeVlaue;
        AudioListener.volume = volumeVlaue;
    }
}
