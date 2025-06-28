using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveCanvasState : MonoBehaviour
{
    private void Start()
    {
        LoadState();
    }

    private void OnDestroy()
    {
        SaveState();
    }

    private void SaveState()
    {
        foreach (Transform child in transform)
        {
            var imageComponent = child.GetComponent<Image>();
            if (imageComponent != null)
            {
                string imageKey = "ImageEnabled_" + child.name;
                PlayerPrefs.SetInt(imageKey, imageComponent.enabled ? 1 : 0);
            }

            var textComponent = child.GetComponent<TextMeshProUGUI>();
            if (textComponent != null)
            {
                string textKey = "TextEnabled_" + child.name;
                PlayerPrefs.SetInt(textKey, textComponent.enabled ? 1 : 0);
            }
        }

        PlayerPrefs.Save();
    }

    private void LoadState()
    {
        foreach (Transform child in transform)
        {
            var imageComponent = child.GetComponent<Image>();
            if (imageComponent != null)
            {
                string imageKey = "ImageEnabled_" + child.name;
                if (PlayerPrefs.HasKey(imageKey))
                {
                    bool isEnabled = PlayerPrefs.GetInt(imageKey) == 1;
                    imageComponent.enabled = isEnabled;
                }
            }

            var textComponent = child.GetComponent<TextMeshProUGUI>();
            if (textComponent != null)
            {
                string textKey = "TextEnabled_" + child.name;
                if (PlayerPrefs.HasKey(textKey))
                {
                    bool isEnabled = PlayerPrefs.GetInt(textKey) == 1;
                    textComponent.enabled = isEnabled;
                }
            }
        }
    }
}
