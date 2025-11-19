using UnityEngine;

public class BolaTabrakWarna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision) //OnCllisonEnter2D adalah method yang akan dijalankan ketika ada collision
    //collision adalah parameter yang akan diisi oleh object yang menabrak
    //Collision2D adalah tipe data yang akan diisi oleh object yang menabrak
    //Collision2D adalah class yang berisi informasi tentang collision
    {
        if (collision.gameObject.CompareTag("Bola")) //mengecek apakah object yang menabrak adalah object dengan tag "Bola"
        {
            Debug.Log("Bola menabrak bola");
            SpriteRenderer _spriteRenderer; //SpriteRenderer adalah komponen yang digunakan untuk mengatur warna sprite
            //_spriteRenderer berfungsi untuk mengatur warna sprite
            //SpriteRenderer adalah class yang berisi informasi tentang sprite

            _spriteRenderer = GetComponent<SpriteRenderer>(); //mengambil komponen SpriteRenderer dari game object ini

            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));//membuat warna acak
            _spriteRenderer.color = warnaAcak; //mengubah warna sprite menjadi warna acak
        }
    }
}
