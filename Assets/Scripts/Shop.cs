using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
 

    [SerializeField] private Canvas Menu;
    [SerializeField] private Canvas Settings;

    [SerializeField] private Image Hand1;
    [SerializeField] private Image Hand1image;
    [SerializeField] private TMP_Text Hand1Text;
    [SerializeField] private Image Hand1image1;
    [SerializeField] private Image Hand1image2;
    [SerializeField] private TMP_Text Hand1Text1;
    [SerializeField] private TMP_Text Hand1Text2;
    [SerializeField] private Image Hand2;
    [SerializeField] private Image Hand2image;
    [SerializeField] private TMP_Text Hand2Text;
    [SerializeField] private Image Hand2image1;
    [SerializeField] private Image Hand2image2;
    [SerializeField] private TMP_Text Hand2Text1;
    [SerializeField] private TMP_Text Hand2Text2;
    [SerializeField] private Image Hand3;
    [SerializeField] private Image Hand3image;
    [SerializeField] private TMP_Text Hand3Text;
    [SerializeField] private Image Hand3image1;
    [SerializeField] private Image Hand3image2;
    [SerializeField] private TMP_Text Hand3Text1;
    [SerializeField] private TMP_Text Hand3Text2;
    [SerializeField] private Image Hand4;
    [SerializeField] private Image Hand4image;
    [SerializeField] private TMP_Text Hand4Text;
    [SerializeField] private Image Hand4image1;
    [SerializeField] private Image Hand4image2;
    [SerializeField] private TMP_Text Hand4Text1;
    [SerializeField] private TMP_Text Hand4Text2;
    [SerializeField] private Image HandMax;
    [SerializeField] private TMP_Text HandMaxText;



    [SerializeField] private TMP_Text Money;
    [SerializeField] private TMP_Text MoneyShop;
    [SerializeField] private Image X0;
    [SerializeField] private Image X2;
    [SerializeField] private TMP_Text X2Text;
    [SerializeField] private Image X2image1;
    [SerializeField] private Image X2image2;
    [SerializeField] private TMP_Text X2image3;
    [SerializeField] private TMP_Text X2image4;
    [SerializeField] private Image X3;
    [SerializeField] private TMP_Text X3Text;
    [SerializeField] private Image X3image1;
    [SerializeField] private Image X3image2;
    [SerializeField] private TMP_Text X3image3;
    [SerializeField] private TMP_Text X3image4;
    [SerializeField] private Image X5;
    [SerializeField] private TMP_Text X5Text;
    [SerializeField] private Image X5image1;
    [SerializeField] private Image X5image2;
    [SerializeField] private TMP_Text X5image3;
    [SerializeField] private TMP_Text X5image4;
    [SerializeField] private Image X10;
    [SerializeField] private TMP_Text X10Text;
    [SerializeField] private Image X10image1;
    [SerializeField] private Image X10image2;
    [SerializeField] private TMP_Text X10image3;
    [SerializeField] private TMP_Text X10image4;
    [SerializeField] private Image XMAX;
    [SerializeField] private TMP_Text XMAXText;


    [SerializeField] private Image Skins1;
    [SerializeField] private TMP_Text Skins1Text;
    [SerializeField] private Image Skins1PuttOn;
    [SerializeField] private TMP_Text Skins1PuttOneText;
    [SerializeField] private Image Skins1Takeoff;
    [SerializeField] private TMP_Text Skins1TakeOffText;

    [SerializeField] private Image Skins2;
    [SerializeField] private TMP_Text Skins2Text;
    [SerializeField] private Image Skins2PuttOn;
    [SerializeField] private TMP_Text Skins2PuttOneText;
    [SerializeField] private Image Skins2Takeoff;
    [SerializeField] private TMP_Text Skins2TakeOffText;

    [SerializeField] private Image Skins3;
    [SerializeField] private TMP_Text Skins3Text;
    [SerializeField] private Image Skins3PuttOn;
    [SerializeField] private TMP_Text Skins3PuttOneText;
    [SerializeField] private Image Skins3Takeoff;
    [SerializeField] private TMP_Text Skins3TakeOffText;

    [SerializeField] private Image Skins4;
    [SerializeField] private TMP_Text Skins4Text;
    [SerializeField] private Image Skins4PuttOn;
    [SerializeField] private TMP_Text Skins4PuttOneText;
    [SerializeField] private Image Skins4Takeoff;
    [SerializeField] private TMP_Text Skins4TakeOffText;

    [SerializeField] private Image SpawnBattonSkin;
    [SerializeField] private Image SpawnBattonSkin1;
    [SerializeField] private Image SpawnBattonSkin2;
    [SerializeField] private Image SpawnBattonSkin3;
    [SerializeField] private Image SpawnBattonSkin4;
    private int count = 10000;

    void Start()
    {
        LoadValue();
        Money.text = $"{count}";
        MoneyShop.text = $"{count}";
    }

    void OnDestroy()
    {
        SaveValue(count);
    }

    private void SaveValue(int value)
    {
        PlayerPrefs.SetInt("MyValue", value);
        PlayerPrefs.Save();
    }

    private void LoadValue()
    {
        if (PlayerPrefs.HasKey("MyValue"))
        {
            count = PlayerPrefs.GetInt("MyValue");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        
        if (X2.enabled == false && X0.enabled == false && X3.enabled == true)
        {
            count += 2;
        }
        else if (X3.enabled == false && X2.enabled == false && X5.enabled == true )
        {
            count += 3;
        }
        else if (X5.enabled == false && X3.enabled == false && X10.enabled == true)
        {
            count += 5;
        }
        else if (X10.enabled == false && X5.enabled == false && XMAX.enabled == true)
        {
            count += 10;
        }
        else
        {
            count++;
        }

        Money.text = $"{count}";
        MoneyShop.text = $"{count}";
    }

    public void BuyHend1()
    {
        if (count >= 300)
        {

            count -= 300;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Hand1.enabled = true;
            EnableAutoClicker1();
            Hand1image.enabled = false ;
            Hand1image1.enabled = false;
            Hand1Text.enabled = false ;
            Hand1image2.enabled = false;
            Hand1Text1.enabled = false;
            Hand1Text2.enabled = false;

            Hand2image.enabled = true;
            Hand2image1.enabled = true;
            Hand2Text.enabled = true;
            Hand2image2.enabled = true;
            Hand2Text1.enabled = true;
            Hand2Text2.enabled = true;

            Hand3image.enabled = false;
            Hand3image1.enabled = false;
            Hand3Text.enabled = false;
            Hand3image2.enabled = false;
            Hand3Text1.enabled = false;
            Hand3Text2.enabled = false;

            Hand4image.enabled = false;
            Hand4image1.enabled = false;
            Hand4Text.enabled = false;
            Hand4image2.enabled = false;
            Hand4Text1.enabled = false;
            Hand4Text2.enabled = false;

            HandMax.enabled = false ;
            HandMaxText.enabled = false;

            Settings.enabled = false;
            Menu.enabled = true;

        }

    }
    public void BuyHend2()
    {
        if (count >= 1000)
        {

            count -= 1000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Hand1image.enabled = false;
            Hand1image1.enabled = false;
            Hand1Text.enabled = false;
            Hand1image2.enabled = false;
            Hand1Text1.enabled = false;
            Hand1Text2.enabled = false;

            Hand2.enabled = true;
            EnableAutoClicker2();
            Hand2image.enabled = false;
            Hand2image1.enabled = false;
            Hand2Text.enabled = false;
            Hand2image2.enabled = false;
            Hand2Text1.enabled = false;
            Hand2Text2.enabled = false;

            Hand3image.enabled = true;
            Hand3image1.enabled = true;
            Hand3Text.enabled = true;
            Hand3image2.enabled = true;
            Hand3Text1.enabled = true;
            Hand3Text2.enabled = true;

            Hand4image.enabled = false;
            Hand4image1.enabled = false;
            Hand4Text.enabled = false;
            Hand4image2.enabled = false;
            Hand4Text1.enabled = false;
            Hand4Text2.enabled = false;

            HandMax.enabled = false;
            HandMaxText.enabled = false;

            Settings.enabled = false;
            Menu.enabled = true;
        }

    }
    public void BuyHend3()
    {
        if (count >= 2500)
        {

            count -= 2500;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Hand1image.enabled = false;
            Hand1image1.enabled = false;
            Hand1Text.enabled = false;
            Hand1image2.enabled = false;
            Hand1Text1.enabled = false;
            Hand1Text2.enabled = false;

            Hand2image.enabled = false;
            Hand2image1.enabled = false;
            Hand2Text.enabled = false;
            Hand2image2.enabled = false;
            Hand2Text1.enabled = false;
            Hand2Text2.enabled = false;

            Hand3.enabled = true;
            EnableAutoClicker3();
            Hand3image.enabled = false;
            Hand3image1.enabled = false;
            Hand3Text.enabled = false;
            Hand3image2.enabled = false;
            Hand3Text1.enabled = false;
            Hand3Text2.enabled = false;

            Hand4image.enabled = true;
            Hand4image1.enabled = true;
            Hand4Text.enabled = true;
            Hand4image2.enabled = true;
            Hand4Text1.enabled = true;
            Hand4Text2.enabled = true;

            HandMax.enabled = false;
            HandMaxText.enabled = false;

            Settings.enabled = false;
            Menu.enabled = true;


        }

    }
    public void BuyHend4()
    {
        if (count >= 5000)
        {

            count -= 5000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Hand1image.enabled = false;
            Hand1image1.enabled = false;
            Hand1Text.enabled = false;
            Hand1image2.enabled = false;
            Hand1Text1.enabled = false;
            Hand1Text2.enabled = false;

            Hand2image.enabled = false;
            Hand2image1.enabled = false;
            Hand2Text.enabled = false;
            Hand2image2.enabled = false;
            Hand2Text1.enabled = false;
            Hand2Text2.enabled = false;

            Hand3image.enabled = false;
            Hand3image1.enabled = false;
            Hand3Text.enabled = false;
            Hand3image2.enabled = false;
            Hand3Text1.enabled = false;
            Hand3Text2.enabled = false;

            EnableAutoClicker4();
            Hand4.enabled = true;
            Hand4image.enabled = false;
            Hand4image1.enabled = false;
            Hand4Text.enabled = false;
            Hand4image2.enabled = false;
            Hand4Text1.enabled = false;
            Hand4Text2.enabled = false;

            HandMax.enabled = true;
            HandMaxText.enabled = true;

            Settings.enabled = false;
            Menu.enabled = true;
        }

    }
    private void EnableAutoClicker1()
    {
        if (Hand1 != null)
        {
            autoCliker autoClicker = Hand1.GetComponent<autoCliker>();
            if (autoClicker != null)
            {
                autoClicker.enabled = true;
            }
            MoveToPoint moveToPoint = Hand1.GetComponent<MoveToPoint>();
            if (autoClicker != null)
            {
                moveToPoint.enabled = true;
            }
        }
    }
    private void EnableAutoClicker2()
    {
        if (Hand2 != null)
        {
            autoCliker autoClicker = Hand2.GetComponent<autoCliker>();
            if (autoClicker != null)
            {
                autoClicker.enabled = true;
            }
            MoveToPoint moveToPoint = Hand2.GetComponent<MoveToPoint>();
            if (autoClicker != null)
            {
                moveToPoint.enabled = true;
            }
        }
    }
    private void EnableAutoClicker3()
    {
        if (Hand3 != null)
        {
            autoCliker autoClicker = Hand3.GetComponent<autoCliker>();
            if (autoClicker != null)
            {
                autoClicker.enabled = true;
            }
            MoveToPoint moveToPoint = Hand3.GetComponent<MoveToPoint>();
            if (autoClicker != null)
            {
                moveToPoint.enabled = true;
            }
        }
    }
    private void EnableAutoClicker4()
    {
        if (Hand4 != null)
        {
            autoCliker autoClicker = Hand4.GetComponent<autoCliker>();
            if (autoClicker != null)
            {
                autoClicker.enabled = true;
            }
            MoveToPoint moveToPoint = Hand4.GetComponent<MoveToPoint>();
            if (autoClicker != null)
            {
                moveToPoint.enabled = true;
            }
        }
    }

    public void Buy2X()
    {
        if (count >= 100)
        {

            count -= 100;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";
            
            X0.enabled = false;
            X2.enabled = false;
            X2Text.enabled = false;
            X2image1.enabled = false;
            X2image2.enabled = false;
            X2image3.enabled = false;
            X2image4.enabled = false;
            X3.enabled = true;
            X3Text.enabled = true;
            X3image1.enabled = true;
            X3image2.enabled = true;
            X3image3.enabled = true;
            X3image4.enabled = true;
            X5.enabled = false;
            X5image1.enabled = false;
            X5image2.enabled = false;
            X5image3.enabled = false;
            X5image4.enabled = false;
            X5Text.enabled = false;
            X10.enabled = false;
            X10Text.enabled = false;
            X10image1.enabled = false;
            X10image2.enabled = false;
            X10image3.enabled = false;
            X10image4.enabled = false;

        }

    }
    public void Buy3X()
    {
        if (count >= 500)
        {

            count -= 500;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            X2.enabled = false;
            X2Text.enabled = false;
            X2image1.enabled = false;
            X2image2.enabled = false;
            X2image3.enabled = false;
            X2image4.enabled = false;
            X3.enabled = false;
            X3Text.enabled = false;
            X3image1.enabled = false;
            X3image2.enabled = false;
            X3image3.enabled = false;
            X3image4.enabled = false;
            X5.enabled = true;
            X5image1.enabled = true;
            X5image2.enabled = true;
            X5image3.enabled = true;
            X5image4.enabled = true;
            X5image4.enabled = true;
            X5Text.enabled = true;
            X10.enabled = false;
            X10Text.enabled = false;
            X10image1.enabled = false;
            X10image2.enabled = false;
            X10image3.enabled = false;
            X10image4.enabled = false;
        }

    }
    public void Buy5X()
    {
        if (count >= 3000)
        {

            count -= 3000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            X2.enabled = false;
            X2Text.enabled = false;
            X2image1.enabled = false;
            X2image2.enabled = false;
            X2image3.enabled = false;
            X2image4.enabled = false;
            X3.enabled = false;
            X3Text.enabled = false;
            X3image1.enabled = false;
            X3image2.enabled = false;
            X3image3.enabled = false;
            X3image4.enabled = false;
            X5.enabled = false;
            X5image1.enabled = false;
            X5image2.enabled = false;
            X5image3.enabled = false;
            X5image4.enabled = false;
            X5Text.enabled = false;
            X10.enabled = true;
            X10Text.enabled = true;
            X10image1.enabled = true;
            X10image2.enabled = true;
            X10image3.enabled = true;
            X10image4.enabled = true;
        }

    }
    public void Buy10X()
    {
        if (count >= 10000)
        {

            count -= 10000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            X2.enabled = false;
            X2Text.enabled = false;
            X2image1.enabled = false;
            X2image2.enabled = false;
            X2image3.enabled = false;
            X2image4.enabled = false;
            X3.enabled = false;
            X3Text.enabled = false;
            X3image1.enabled = false;
            X3image2.enabled = false;
            X3image3.enabled = false;
            X3image4.enabled = false;
            X5.enabled = false;
            X5image1.enabled = false;
            X5image2.enabled = false;
            X5image3.enabled = false;
            X5image4.enabled = false;
            X5Text.enabled = false;
            X10.enabled = false;
            X10Text.enabled = false;
            X10image1.enabled = false;
            X10image2.enabled = false;
            X10image3.enabled = false;
            X10image4.enabled = false;
            XMAX.enabled = true; 
            XMAXText.enabled = true;
        }

    }

    public void BuySkin1()
    {
        if (count >= 250)
        {

            count -= 250;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Skins1.enabled = false;
            Skins1Text.enabled = false;
            Skins1PuttOn.enabled = true;
            Skins1PuttOneText.enabled = true;
        }

    }

    public void BuySkin2()
    {
        if (count >= 1500)
        {

            count -= 1500;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Skins2.enabled = false;
            Skins2Text.enabled = false;
            Skins2PuttOn.enabled = true;
            Skins2PuttOneText.enabled = true;
        }

    }

    public void BuySkin3()
    {
        if (count >= 5000)
        {

            count -= 5000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Skins3.enabled = false;
            Skins3Text.enabled = false;
            Skins3PuttOn.enabled = true;
            Skins3PuttOneText.enabled = true;
        }

    }

    public void BuySkin4()
    {
        if (count >= 10000)
        {

            count -= 10000;
            Money.text = $"{count}";
            MoneyShop.text = $"{count}";

            Skins4.enabled = false;
            Skins4Text.enabled = false;
            Skins4PuttOn.enabled = true;
            Skins4PuttOneText.enabled = true;
        }

    }

    public void PuttOnSkins1()
    {
        Skins1PuttOn.enabled = false;
        Skins1PuttOneText.enabled = false;
        Skins1Takeoff.enabled = true;
        Skins1TakeOffText.enabled = true;

        SpawnBattonSkin.enabled = false;
        SpawnBattonSkin1.enabled = true;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled= true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;       
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void TareOffSkins1()
    {
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;

        SpawnBattonSkin.enabled = true;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void PuttOnSkins2()
    {
        Skins2PuttOn.enabled = false;
        Skins2PuttOneText.enabled = false;
        Skins2Takeoff.enabled = true;
        Skins2TakeOffText.enabled = true;

        SpawnBattonSkin.enabled = false;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = true;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void TareOffSkins2()
    {
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;

        SpawnBattonSkin.enabled = true;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void PuttOnSkins3()
    {
        Skins3PuttOn.enabled = false;
        Skins3PuttOneText.enabled = false;
        Skins3Takeoff.enabled = true;
        Skins3TakeOffText.enabled = true;

        SpawnBattonSkin.enabled = false;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = true;
        SpawnBattonSkin4.enabled = false;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;
        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void TareOffSkins3()
    {
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;

        SpawnBattonSkin.enabled = true;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;
        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
    }
    public void PuttOnSkins4()
    {
        Skins4PuttOn.enabled = false;
        Skins4PuttOneText.enabled = false;
        Skins4Takeoff.enabled = true;
        Skins4TakeOffText.enabled = true;

        SpawnBattonSkin.enabled = false;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = true;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;
        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
    }
    public void TareOffSkins4()
    {
        Skins4Takeoff.enabled = false;
        Skins4TakeOffText.enabled = false;
        Skins4PuttOn.enabled = true;
        Skins4PuttOneText.enabled = true;

        SpawnBattonSkin.enabled = true;
        SpawnBattonSkin1.enabled = false;
        SpawnBattonSkin2.enabled = false;
        SpawnBattonSkin3.enabled = false;
        SpawnBattonSkin4.enabled = false;

        Skins2PuttOn.enabled = true;
        Skins2PuttOneText.enabled = true;
        Skins3PuttOn.enabled = true;
        Skins3PuttOneText.enabled = true;
        Skins1PuttOn.enabled = true;
        Skins1PuttOneText.enabled = true;
        Skins2Takeoff.enabled = false;
        Skins2TakeOffText.enabled = false;
        Skins3Takeoff.enabled = false;
        Skins3TakeOffText.enabled = false;
        Skins1Takeoff.enabled = false;
        Skins1TakeOffText.enabled = false;
    }

}
