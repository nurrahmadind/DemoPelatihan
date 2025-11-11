using UnityEngine;

public class TrianglePutar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject .transform.Rotate (0,0,50*Time.deltaTime); //untuk memutar objek
    }
}
