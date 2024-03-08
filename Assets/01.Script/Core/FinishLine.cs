using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(tag);

        if (CompareTag("Player"))
        {
            if (GameInstance.instance.Stage != 3 )
            {
                SceneManager.LoadScene($"Stage{GameInstance.instance.Stage + 1}");
            }
        }
    }
}
