using System.Collections;
using UnityEngine;

public class spawncircle : MonoBehaviour
{
    public GameObject objectCircle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    // StartCoroutine(spawnCircle());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
        Instantiate(objectCircle, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);
        }
    }
    IEnumerator spawnCircle()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(objectCircle, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);
        }
    }
}
