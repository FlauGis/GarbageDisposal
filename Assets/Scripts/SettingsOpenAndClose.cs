using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsOpenAndClose : MonoBehaviour
{
    [SerializeField] private Image OpenSettings;
    [SerializeField] private Image Sound;
    [SerializeField] private Image CloseSettings;

    public void Open()
    {
        OpenSettings.enabled = false;
        Sound.enabled = true;
        CloseSettings.enabled = true;
    }
    public void Close()
    {
        Sound.enabled = false;
        CloseSettings.enabled = false;
        OpenSettings.enabled = true;
    }
}
