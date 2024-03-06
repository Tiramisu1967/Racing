using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    public static GameInstance instance;
    public bool isStop;
    public int Stage = 1;
    public float RacingTime;
    public int Coin;

    private void Awake()
    {
        if (instance == null)  // �� �ϳ��� �����ϰԲ�
        {
            instance = this;  // ��ü ������ instance�� �ڱ� �ڽ��� �־���
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}