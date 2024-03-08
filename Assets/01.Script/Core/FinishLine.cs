using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);

        if (collision.collider.CompareTag("Player"))
        {
            if (GameInstance.instance.Stage != 3 )
            {
                SceneManager.LoadScene($"Stage{GameInstance.instance.Stage + 1}");
            }
        }
    }
}
