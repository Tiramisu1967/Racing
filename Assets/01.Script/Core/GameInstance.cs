using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    public static GameInstance instance;
    public bool isStop;
    public int Score;
    public int Stage = 1;
    public float RacingTime;
    public float[] StageTime;
    public int Coin;
    public bool isFreeShop;
    public bool isclear;
    public Canvas CheatShop;
    [HideInInspector] public GameObject PlayerPoint;
    #region Wheel
    public bool isDesertWheel;
    public bool isMountainWheel;
    public bool isDownTownWheel;
    #endregion


    private void Awake()
    {
        if (instance == null)  // 단 하나만 존재하게끔
        {
            instance = this;  // 객체 생성시 instance에 자기 자신을 넣어줌
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        RacingTime += Time.deltaTime;
    }
}