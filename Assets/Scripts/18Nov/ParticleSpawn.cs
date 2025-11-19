using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    public GameObject objectEffect;// Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(objectEffect, mouseWorldPosition, Quaternion.identity);
        }
    }
}
