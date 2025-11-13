using UnityEngine;


    //deklarasi variable interaksi12 dengan tipe data class Interaksi12
    //ini digunakan untuk script ini bisa berkomunikasi dengan script Interaksi12
public class BolaTabrak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Interaksi12 interaksi12;

    public int nyawa;
    void Start()
    {
       nyawa= 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Square"))
        {
            Debug.Log("Bola menabrak Square");
            interaksi12.nyawa--; //mengurangi nyawa 
            KurangNyawa();
        }
        
    }
    public void KurangNyawa()
    {
        interaksi12.teksNyawa.text = "Nyawa:" + interaksi12.nyawa.ToString();
    }}
