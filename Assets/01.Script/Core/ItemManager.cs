using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemList;
    public GameObject[] SpawnPoint;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ItemSpawn());
    }

    IEnumerator ItemSpawn()
    {
        
        int Max = ItemList.Length;
        int SpawnItem = Random.Range(0, Max);
        Max = SpawnPoint.Length;
        int ItemPoint = Random.Range(0, Max);

        Instantiate(ItemList[SpawnItem], SpawnPoint[ItemPoint].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2f);
    }
}
