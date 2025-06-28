using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMeny : MonoBehaviour
{
    [SerializeField] private Image Home;
    [SerializeField] private Image Shop;
    [SerializeField] private Image Settings;
    [SerializeField] private Image OpenMenyy;
    [SerializeField] private Image CloseMenyy;

    public void Open()
    {
        OpenMenyy.enabled = false;
        Home.enabled = true;
        Shop.enabled = true;
        Settings.enabled = true;
        CloseMenyy.enabled = true; 
    }
    public void Close()
    {
        CloseMenyy.enabled = false;
        Home.enabled = false;
        Shop.enabled = false;
        Settings.enabled = false;
        OpenMenyy.enabled = true;
    }
}
