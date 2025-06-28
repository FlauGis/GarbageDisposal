using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenyButton : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas settingsCanvas;
    [SerializeField] Canvas shopCanvas;

    public void OpenMeny()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenSettings()
    {
        mainMenuCanvas.enabled = false;
        settingsCanvas.enabled = true;
    }
    public void ExitSettings()
    {
        settingsCanvas.enabled = false;
        mainMenuCanvas.enabled = true;

    }
    public void OpenShop()
    {
        shopCanvas.enabled = true;
        mainMenuCanvas.enabled = false;
    }
    public void ExitShop()
    {
        shopCanvas.enabled = false;
        mainMenuCanvas.enabled = true;
    }
}
