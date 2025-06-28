using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadImage : MonoBehaviour
{
    public Image imageComponent;

    private void Start()
    {
        LoadImage();
    }

    private void OnDestroy()
    {
        SaveImage();
    }
    private void SaveImage()
    {
        PlayerPrefs.SetInt("ImageComponentEnabled", imageComponent.enabled ? 1 : 0);
        PlayerPrefs.Save();
    }
    private void LoadImage()
    {
        imageComponent.enabled = PlayerPrefs.GetInt("ImageComponentEnabled") == 1;
    }
}
