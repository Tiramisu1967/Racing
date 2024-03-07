using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class ShopManager : MonoBehaviour
{
    public int DesertWhellCoin;
    public int MountainWhellCoin;
    public int DownTownWhellCoin;
    public TextMeshProUGUI DesertText;
    public TextMeshProUGUI MountainText;
    public TextMeshProUGUI DownTownText;

    public Canvas ShopCanvas;

    public void Start()
    {
        Shop();
    }
    public void ShopExit()
    {
        ShopCanvas.gameObject.SetActive(false);
    }
    public void Shop()
    {
        DesertText.text = $"{DesertWhellCoin}";
        MountainText.text = $"{MountainWhellCoin}";
        DownTownText.text = $"{DownTownWhellCoin}";
        ShopCanvas.gameObject.SetActive(true);
    }

    public void Desert()
    {
        if(GameInstance.instance.Coin >= DesertWhellCoin && !GameInstance.instance.isDesertWheel)
        {
            GameInstance.instance.isDesertWheel = true;
        }
    }
    public void Mountain()
    {
        if (GameInstance.instance.Coin >= MountainWhellCoin && !GameInstance.instance.isMountainWheel)
        {
            GameInstance.instance.isMountainWheel = true;
        }
    }
    public void DownTown()
    {
        if (GameInstance.instance.Coin >= DownTownWhellCoin && !GameInstance.instance.isDownTownWheel)
        {
            GameInstance.instance.isDownTownWheel = true;
        }
    }


}
