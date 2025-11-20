using UnityEngine;

public class KotakSpawn : MonoBehaviour
{

    public GameObject Kotak;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnSegitiga();
        }
    }

    public void SpawnSegitiga()
    {
       Instantiate (Kotak, transform.position, Quaternion.identity);
       Destroy(gameObject, 1f);
    }
}
