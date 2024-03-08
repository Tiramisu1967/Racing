using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BaseItme : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            Pick();
            Destroy(this.gameObject);
        } else if (CompareTag("Item"))
        {
            Destroy(this.gameObject);
        }
    }

    public virtual void Pick()
    {
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }
}
