using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public bool diLantai;
    public float forceMultiplier = 3.0f; //variabel untuk perhitungan daya lompaat
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lompat()
    {
        if (diLantai)
        {
        Rigidbody2D rb = GetComponent <Rigidbody2D> ();
        rb.AddForce (transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log ("Lagi lompat");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai=true;
            Debug.Log ("di Lantai");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai=false;
            Debug.Log ("di Udara");
        }
    }

}
