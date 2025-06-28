using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Specialized;

public class SaveLoadTMP : MonoBehaviour
{
    public TMP_Text textComponent;

    private void Start()
    {
        LoadTPM();
    }

    private void OnDestroy()
    {
        SaveTPM();
    }

    private void SaveTPM()
    {
        PlayerPrefs.SetInt("TextComponentEnabled", textComponent.enabled ? 1 : 0);
        PlayerPrefs.Save();

        
    }

    private void LoadTPM()
    {
            textComponent.enabled = PlayerPrefs.GetInt("TextComponentEnabled") == 1;
    }

}
