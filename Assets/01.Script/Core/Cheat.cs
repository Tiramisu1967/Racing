using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class Cheat : MonoBehaviour
{
    public GameObject Booster;
    public GameObject MaxBooster;
    public GameObject SmallCoin;
    public GameObject Coin;
    public GameObject BigCoin;
    public GameObject Shop;
    public void BoosterItme()
    {
        Spawn(Booster);
    }

    public void MaxBoosterItem()
    {
        Spawn(MaxBooster);

    }

    public void SmallCoinItem()
    {
        Spawn(SmallCoin);
    }

    public void CoinItem()
    {
        Spawn(Coin);
    }

    public void BigCoinItem()
    {
        Spawn(BigCoin);
    }

    public void ShopItem()
    {
        Spawn(Shop);
    }

    public void Spawn(GameObject Item)
    {
        Instantiate(Item, GameInstance.instance.PlayerPoint.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
