using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : BaseItme
{
    public int Coin;
    public override void Pick()
    {
        base.Pick();
        Debug.Log(GameInstance.instance.Coin);
        GameInstance.instance.Coin += Coin;
        Debug.Log(GameInstance.instance.Coin);
    }
}
