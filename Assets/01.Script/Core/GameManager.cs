using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cheat();
    }

    public void lose()
    {
        SceneManager.LoadScene($"Stage{GameInstance.instance.Stage}");
    }

    public void Cheat()
    {
        if (!GameInstance.instance.isStop)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {

            }
            if (Input.GetKeyDown(KeyCode.F2))
            {

            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                SceneManager.LoadScene($"Stage{GameInstance.instance.Stage}");
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                if(GameInstance.instance.Stage != 3)
            {
                SceneManager.LoadScene($"Stage{GameInstance.instance.Stage}");
            }
            }
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            if (GameInstance.instance.isStop)
            {
                Time.timeScale = 1f;
                GameInstance.instance.isStop = false;
            } 
            else
            {
                Time.timeScale = 0f;
                GameInstance.instance.isStop = true;
            }
        }

    }
}
