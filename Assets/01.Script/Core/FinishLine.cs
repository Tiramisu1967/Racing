﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class FinishLine : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        Debug.Log(tag);

        if (collider.gameObject.CompareTag("Player"))
        {
            if (GameInstance.instance.Stage != 3 )
            {
                if (100 - (int)GameInstance.instance.RacingTime > 0)
                {
                    GameInstance.instance.Score += 100 - (int)GameInstance.instance.RacingTime;
                }
                    GameInstance.instance.Score += 500;

                GameInstance.instance.StageTime[GameInstance.instance.Stage -1] = GameInstance.instance.RacingTime;
                GameInstance.instance.Stage += 1;
                ShopManager shopManager = GetComponent<ShopManager>();
                shopManager.Shop();
                SceneManager.LoadScene($"Stage{GameInstance.instance.Stage}");
            }
        }
        else
        {
            GameInstance.instance.RacingTime = 0f;
            SceneManager.LoadScene($"Stage{GameInstance.instance.Stage}");
        }
    }
}
