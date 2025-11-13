using System.Collections;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public bool sedangSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine (MunculkanObject());
    }

    IEnumerator MunculkanObject ()
    {
        while (sedangSpawn == true)
        {
            //Spawn Object
            Instantiate (SpawnObject);
            yield return new WaitForSeconds(5);
        }
    }
}
