using System.Data.Common;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DinoPlayer : MonoBehaviour
{
    public TMP_Text nilai;
    public int score;
    public bool diLantai;
    public float forceMultiplier = 6.0f; //variabel untuk perhitungan daya lompaat
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Left Clicked");
            Lompat();
        }
    }
    public void tambahScore()
    {
        score += 1;
        nilai.text = "nilai:" + score.ToString();//utk update score
    }
    public void Lompat()
    {
        if (diLantai) //(dilantai) dino hanya bisa di klik kalau dia berada di lantai kalau trus dilantai dan di udara bisa di klik
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Lagi lompat");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))//cari atau buat tagnya di unitynya
        {
            diLantai = true;
            tambahScore();
            Debug.Log("di Lantai");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = false;
            Debug.Log("di Udara");
        }
    }
    

}
