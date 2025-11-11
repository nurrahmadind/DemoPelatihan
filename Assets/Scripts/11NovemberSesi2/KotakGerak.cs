using UnityEngine;

public class KotakGerak : MonoBehaviour
{
    public float moveSpeed = 3.0f;

    public bool isMoveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0); //untuk memmindahkan objek ke kanan
        }
        else
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0); //untuk memmindahkan objek ke kiri
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kotak tabrakan");
        if (isMoveRight)
        {
            isMoveRight = false;
            
        }
        else
        {
            isMoveRight = true;
        }
    }
}