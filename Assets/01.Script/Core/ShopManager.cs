using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class ShopManager : MonoBehaviour
{
    public Canvas ShopCanvas;
    public void ShopExit()
    {
        ShopCanvas.gameObject.SetActive(false);
    }
    public void Shop()
    {
        ShopCanvas.gameObject.SetActive(true);
    }
}
