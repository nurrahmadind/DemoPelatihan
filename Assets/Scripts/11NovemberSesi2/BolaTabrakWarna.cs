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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            Debug.Log("Bola menabrak bola");
            SpriteRenderer _spriteRenderer;

            _spriteRenderer = GetComponent<SpriteRenderer>(); //mengambil komponen SpriteRenderer dari game object ini

            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));//membuat warna acak
            _spriteRenderer.color = warnaAcak; //mengubah warna sprite menjadi warna acak
        }
    }
}
